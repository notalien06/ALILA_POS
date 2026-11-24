using ALILA_POS.Data;
using ALILA_POS.Domain;
using ALILA_POS.Services;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static ALILA_POS.Services.InventoryService;

namespace ALILA_POS
{
    public partial class AddProductForm : Form
    {
        private InventoryService inventoryService;
        private CategoryService categoryService;

        public AddProductForm()
        {
            InitializeComponent();

            inventoryService = new InventoryService();
            categoryService = new CategoryService();

            LoadCategories();

            btnSave.Click += BtnSave_Click;
        }

        private void LoadCategories()
        {
            var categories = categoryService.GetAllCategories();

            cmbCategory.DataSource = new BindingSource(categories, null);
            cmbCategory.DisplayMember = "Value";
            cmbCategory.ValueMember = "Key";
            cmbCategory.SelectedIndex = -1;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // REQUIRED FIELDS
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter the product name.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtProductName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSku.Text))
            {
                MessageBox.Show("Please enter the SKU.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSku.Focus();
                return;
            }

            // CATEGORY ID
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                cmbCategory.Focus();
                return;
            }

            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);

            // PRICE
            if (!decimal.TryParse(txtPrice.Text, out decimal price)
                || price < 0)
            {
                MessageBox.Show("Please enter a valid Price.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrice.Focus();
                return;
            }

            // COST
            if (!decimal.TryParse(txtCost.Text, out decimal cost)
                || cost < 0)
            {
                MessageBox.Show("Please enter a valid Cost.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCost.Focus();
                return;
            }

            // STOCK QUANTITY
            if (!int.TryParse(txtStockQty.Text, out int stockQty)
                || stockQty < 0)
            {
                MessageBox.Show("Please enter a valid Stock Quantity.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStockQty.Focus();
                return;
            }

            // REORDER LEVEL
            if (!int.TryParse(txtReorderLevel.Text, out int reorderLevel)
                || reorderLevel < 0)
            {
                MessageBox.Show("Please enter a valid Reorder Level.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtReorderLevel.Focus();
                return;
            }

            // CREATE PRODUCT
            Product product = new Product
            {
                Name = txtProductName.Text.Trim(),
                Sku = txtSku.Text.Trim(),
                Barcode = string.IsNullOrWhiteSpace(txtBarcode.Text)
                    ? null
                    : txtBarcode.Text.Trim(),
                CategoryId = categoryId,
                Price = price,
                Cost = cost,
                StockQty = stockQty,
                ReorderLevel = reorderLevel,
                IsActive = true
            };

            // SAVE TO DATABASE
            try
            {
                int productId = inventoryService.AddProduct(product);

                MessageBox.Show(
                    "Product successfully added!\n\nProduct ID: " + productId,
                    "ALILA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save product.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // UPDATE PRODUCT
        public void Update(Product product)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                string query = @"
            UPDATE dbo.Products
            SET
                Sku = @Sku,
                Barcode = @Barcode,
                Name = @Name,
                CategoryId = @CategoryId,
                Price = @Price,
                Cost = @Cost,
                StockQty = @StockQty,
                ReorderLevel = @ReorderLevel
            WHERE ProductId = @ProductId;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                    cmd.Parameters.AddWithValue("@Sku", product.Sku);

                    cmd.Parameters.AddWithValue(
                        "@Barcode",
                        string.IsNullOrWhiteSpace(product.Barcode)
                            ? (object)DBNull.Value
                            : product.Barcode);

                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Cost", product.Cost);
                    cmd.Parameters.AddWithValue("@StockQty", product.StockQty);
                    cmd.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}