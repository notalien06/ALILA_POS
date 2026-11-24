
using ALILA_POS.Domain;
using ALILA_POS.Services;
using System;
using System.Windows.Forms;
using static ALILA_POS.Services.InventoryService;

namespace ALILA_POS
{
    public partial class EditProductForm : Form
    {
        private InventoryService inventoryService;
        private CategoryService categoryService;
        private Product selectedProduct;

        public EditProductForm(Product product)
        {
            InitializeComponent();

            inventoryService = new InventoryService();
            categoryService = new CategoryService();
            selectedProduct = product;

            LoadCategories();
            LoadProductDetails();

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => this.Close();
        }

        private void LoadCategories()
        {
            var categories = categoryService.GetAllCategories();

            cmbCategory.DataSource = new BindingSource(categories, null);
            cmbCategory.DisplayMember = "Value";
            cmbCategory.ValueMember = "Key";
        }

        private void LoadProductDetails()
        {
            txtProductName.Text = selectedProduct.Name;
            txtSku.Text = selectedProduct.Sku;
            txtBarcode.Text = selectedProduct.Barcode;
            txtPrice.Text = selectedProduct.Price.ToString();
            txtCost.Text = selectedProduct.Cost.ToString();
            txtStockQty.Text = selectedProduct.StockQty.ToString();
            txtReorderLevel.Text = selectedProduct.ReorderLevel.ToString();

            cmbCategory.SelectedValue = selectedProduct.CategoryId;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter the product name.");
                txtProductName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSku.Text))
            {
                MessageBox.Show("Please enter the SKU.");
                txtSku.Focus();
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                cmbCategory.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid Price.");
                txtPrice.Focus();
                return;
            }

            if (!decimal.TryParse(txtCost.Text, out decimal cost) || cost < 0)
            {
                MessageBox.Show("Please enter a valid Cost.");
                txtCost.Focus();
                return;
            }

            if (!int.TryParse(txtStockQty.Text, out int stockQty) || stockQty < 0)
            {
                MessageBox.Show("Please enter a valid Stock Quantity.");
                txtStockQty.Focus();
                return;
            }

            if (!int.TryParse(txtReorderLevel.Text, out int reorderLevel) || reorderLevel < 0)
            {
                MessageBox.Show("Please enter a valid Reorder Level.");
                txtReorderLevel.Focus();
                return;
            }

            selectedProduct.Name = txtProductName.Text.Trim();
            selectedProduct.Sku = txtSku.Text.Trim();
            selectedProduct.Barcode = string.IsNullOrWhiteSpace(txtBarcode.Text)
                ? null
                : txtBarcode.Text.Trim();

            selectedProduct.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            selectedProduct.Price = price;
            selectedProduct.Cost = cost;
            selectedProduct.StockQty = stockQty;
            selectedProduct.ReorderLevel = reorderLevel;

            try
            {
                inventoryService.UpdateProduct(selectedProduct);

                MessageBox.Show(
                    "Product successfully updated!",
                    "ALILA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update product.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
