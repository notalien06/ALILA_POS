
namespace ALILA_POS
{
    partial class AddProductForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // FORM CONTROLS
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.Label lblReorderLevel;

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtStockQty;
        private System.Windows.Forms.TextBox txtReorderLevel;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();

            this.lblProductName = new System.Windows.Forms.Label();
            this.lblSku = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.lblReorderLevel = new System.Windows.Forms.Label();

            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtStockQty = new System.Windows.Forms.TextBox();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // FORM
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 470);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ForeColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text = "ALILA POS - Add Product";

            // TITLE
            this.lblTitle.Text = "Add New Product";
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Size = new System.Drawing.Size(500, 35);

            // LABELS
            ConfigureLabel(lblProductName, "Product Name", 30, 75);
            ConfigureLabel(lblSku, "SKU", 30, 130);
            ConfigureLabel(lblBarcode, "Barcode", 30, 185);
            ConfigureLabel(lblCategory, "Category ID", 30, 240);
            ConfigureLabel(lblPrice, "Price", 30, 295);
            ConfigureLabel(lblCost, "Cost", 285, 295);
            ConfigureLabel(lblStockQty, "Stock Quantity", 30, 350);
            ConfigureLabel(lblReorderLevel, "Reorder Level", 285, 350);

            // TEXTBOXES
            ConfigureTextBox(txtProductName, 30, 100, 490);
            ConfigureTextBox(txtSku, 30, 155, 490);
            ConfigureTextBox(txtBarcode, 30, 210, 490);
            // CATEGORY DROPDOWN
            this.cmbCategory.Location = new System.Drawing.Point(30, 265);
            this.cmbCategory.Size = new System.Drawing.Size(490, 25);
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            this.cmbCategory.ForeColor = System.Drawing.Color.White;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbCategory.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            ConfigureTextBox(txtPrice, 30, 320, 235);
            ConfigureTextBox(txtCost, 285, 320, 235);

            ConfigureTextBox(txtStockQty, 30, 375, 235);
            ConfigureTextBox(txtReorderLevel, 285, 375, 235);

            // SAVE BUTTON
            this.btnSave.Text = "Save Product";
            this.btnSave.Location = new System.Drawing.Point(285, 425);
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // CANCEL BUTTON
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(445, 425);
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;

            this.btnCancel.Click += (s, e) => this.Close();

            // ADD CONTROLS
            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblSku);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblStockQty);
            this.Controls.Add(this.lblReorderLevel);

            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtStockQty);
            this.Controls.Add(this.txtReorderLevel);

            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
        }

        // LABEL CONFIGURATION
        private void ConfigureLabel(
            System.Windows.Forms.Label label,
            string text,
            int x,
            int y)
        {
            label.Text = text;
            label.Location = new System.Drawing.Point(x, y);
            label.Size = new System.Drawing.Size(230, 20);
            label.ForeColor = System.Drawing.Color.Silver;
            label.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Regular);
        }

        // TEXTBOX CONFIGURATION
        private void ConfigureTextBox(
            System.Windows.Forms.TextBox textBox,
            int x,
            int y,
            int width)
        {
            textBox.Location = new System.Drawing.Point(x, y);
            textBox.Size = new System.Drawing.Size(width, 25);
            textBox.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            textBox.ForeColor = System.Drawing.Color.White;
            textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
        }

        #endregion
    }
}
