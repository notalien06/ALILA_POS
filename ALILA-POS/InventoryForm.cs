
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ALILA_POS.Domain;
using ALILA_POS.Services;

namespace ALILA_POS
{
    public partial class InventoryForm : Form
    {
        private InventoryService inventoryService;
        private List<Product> products;

        public InventoryForm()
        {
            InitializeComponent();

            inventoryService = new InventoryService();
            products = new List<Product>();

            LoadProducts();

            btnDashboard.Click += BtnDashboard_Click;
            btnEditProduct.Click += BtnEditProduct_Click;
            btnDeleteProduct.Click += BtnDeleteProduct_Click;
        }

        private void LoadProducts()
        {
            try
            {
                products = inventoryService.GetAllProducts();

                dgvInventory.DataSource = null;
                dgvInventory.DataSource = products;

                ConfigureProductColumns();

                lblTotalProducts.Text =
                    "TOTAL PRODUCTS: " + products.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load inventory:\n\n" + ex.Message,
                    "Inventory Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigureProductColumns()
        {
            // Hide unnecessary columns
            if (dgvInventory.Columns["Image"] != null)
                dgvInventory.Columns["Image"].Visible = false;

            if (dgvInventory.Columns["ProductId"] != null)
                dgvInventory.Columns["ProductId"].Visible = false;

            // Column widths
            SetColumnWidth("Sku", 130);
            SetColumnWidth("Barcode", 150);
            SetColumnWidth("Name", 220);
            SetColumnWidth("CategoryId", 100);
            SetColumnWidth("Price", 100);
            SetColumnWidth("Cost", 100);
            SetColumnWidth("StockQty", 100);
            SetColumnWidth("ReorderLevel", 120);
            SetColumnWidth("IsActive", 100);

            // Header names
            if (dgvInventory.Columns["Name"] != null)
                dgvInventory.Columns["Name"].HeaderText = "PRODUCT NAME";

            if (dgvInventory.Columns["Sku"] != null)
                dgvInventory.Columns["Sku"].HeaderText = "SKU";

            if (dgvInventory.Columns["StockQty"] != null)
                dgvInventory.Columns["StockQty"].HeaderText = "STOCK";

            if (dgvInventory.Columns["ReorderLevel"] != null)
                dgvInventory.Columns["ReorderLevel"].HeaderText = "REORDER LEVEL";

            // Prevent manual resizing
            dgvInventory.AllowUserToResizeColumns = false;
            dgvInventory.AllowUserToResizeRows = false;
            dgvInventory.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInventory.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Normal cell colors
            dgvInventory.DefaultCellStyle.ForeColor = Color.Black;
            dgvInventory.DefaultCellStyle.BackColor = Color.White;
            dgvInventory.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvInventory.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(0, 120, 215);

            // Alternating row colors
            dgvInventory.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(235, 235, 235);

            dgvInventory.AlternatingRowsDefaultCellStyle.ForeColor =
                Color.Black;

            // Header colors
            dgvInventory.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(45, 45, 45);

            dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvInventory.EnableHeadersVisualStyles = false;
        }

        private void SetColumnWidth(string columnName, int width)
        {
            if (dgvInventory.Columns[columnName] != null)
                dgvInventory.Columns[columnName].Width = width;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchInventory.Text.Trim();

            List<Product> filteredProducts = products
                .Where(p =>
                    (p.Name != null &&
                     p.Name.IndexOf(
                         keyword,
                         StringComparison.OrdinalIgnoreCase) >= 0)
                    ||
                    (p.Sku != null &&
                     p.Sku.IndexOf(
                         keyword,
                         StringComparison.OrdinalIgnoreCase) >= 0)
                    ||
                    (p.Barcode != null &&
                     p.Barcode.IndexOf(
                         keyword,
                         StringComparison.OrdinalIgnoreCase) >= 0)
                )
                .ToList();

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = filteredProducts;

            ConfigureProductColumns();

            lblTotalProducts.Text =
                "TOTAL PRODUCTS: " + filteredProducts.Count;
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            using (AddProductForm addProductForm = new AddProductForm())
            {
                if (addProductForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a product to edit.",
                    "No Product Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Product selectedProduct =
                dgvInventory.CurrentRow.DataBoundItem as Product;

            if (selectedProduct == null)
                return;

            using (EditProductForm editForm =
                new EditProductForm(selectedProduct))
            {
                if (editForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProduct_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a product to delete.",
                    "No Product Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Product selectedProduct =
                dgvInventory.CurrentRow.DataBoundItem as Product;

            if (selectedProduct == null)
                return;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this product?\n\n" +
                "Product: " + selectedProduct.Name,
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    inventoryService.DeleteProduct(selectedProduct.ProductId);

                    MessageBox.Show(
                        "Product deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Unable to delete product:\n\n" + ex.Message,
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void picPOSLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
