
namespace ALILA_POS
{
    partial class EditProductForm
    {
        private System.ComponentModel.IContainer components = null;

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
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtStockQty;
        private System.Windows.Forms.TextBox txtReorderLevel;

        private System.Windows.Forms.ComboBox cmbCategory;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtStockQty = new System.Windows.Forms.TextBox();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();

            this.cmbCategory = new System.Windows.Forms.ComboBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // FORM
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 470);
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "ALILA POS - Edit Product";

            // TITLE
            this.lblTitle.Text = "Edit Product";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.AutoSize = true;

            // PRODUCT NAME
            ConfigureLabel(lblProductName, "Product Name", 30, 75);
            ConfigureTextBox(txtProductName, 30, 100, 490);

            // SKU
            ConfigureLabel(lblSku, "SKU", 30, 130);
            ConfigureTextBox(txtSku, 30, 155, 490);

            // BARCODE
            ConfigureLabel(lblBarcode, "Barcode", 30, 185);
            ConfigureTextBox(txtBarcode, 30, 210, 490);

            // CATEGORY
            ConfigureLabel(lblCategory, "Category", 30, 240);

            this.cmbCategory.Location = new System.Drawing.Point(30, 265);
            this.cmbCategory.Size = new System.Drawing.Size(490, 25);
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            this.cmbCategory.ForeColor = System.Drawing.Color.White;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // PRICE
            ConfigureLabel(lblPrice, "Price", 30, 295);
            ConfigureTextBox(txtPrice, 30, 320, 235);

            // COST
            ConfigureLabel(lblCost, "Cost", 285, 295);
            ConfigureTextBox(txtCost, 285, 320, 235);

            // STOCK QUANTITY
            ConfigureLabel(lblStockQty, "Stock Quantity", 30, 350);
            ConfigureTextBox(txtStockQty, 30, 375, 235);

            // REORDER LEVEL
            ConfigureLabel(lblReorderLevel, "Reorder Level", 285, 350);
            ConfigureTextBox(txtReorderLevel, 285, 375, 235);

            // SAVE BUTTON
            this.btnSave.Text = "Save Changes";
            this.btnSave.Location = new System.Drawing.Point(285, 425);
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // CANCEL BUTTON
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(445, 425);
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // ADD CONTROLS
            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductName);

            this.Controls.Add(this.lblSku);
            this.Controls.Add(this.txtSku);

            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtBarcode);

            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);

            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);

            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCost);

            this.Controls.Add(this.lblStockQty);
            this.Controls.Add(this.txtStockQty);

            this.Controls.Add(this.lblReorderLevel);
            this.Controls.Add(this.txtReorderLevel);

            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            this.CancelButton = this.btnCancel;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ConfigureLabel(
            System.Windows.Forms.Label label,
            string text,
            int x,
            int y)
        {
            label.Text = text;
            label.Location = new System.Drawing.Point(x, y);
            label.AutoSize = true;
            label.ForeColor = System.Drawing.Color.White;
            label.Font = new System.Drawing.Font("Segoe UI", 9.75F);
        }

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
    }
}
