
namespace ALILA_POS
{
    partial class InventoryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnPurchasing = new System.Windows.Forms.Button();
            this.btnRequisition = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblInventoryTitle = new System.Windows.Forms.Label();
            this.lblInventorySubtitle = new System.Windows.Forms.Label();
            this.txtSearchInventory = new System.Windows.Forms.TextBox();
            this.btnSearchInventory = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.picPOSLogo = new System.Windows.Forms.PictureBox();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPOSLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnInventory);
            this.pnlSidebar.Controls.Add(this.btnPurchasing);
            this.pnlSidebar.Controls.Add(this.btnRequisition);
            this.pnlSidebar.Controls.Add(this.btnDelivery);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 561);
            this.pnlSidebar.TabIndex = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(25, 25);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(134, 32);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "ALILA POS";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(10, 100);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(180, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(10, 155);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(180, 45);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnPurchasing
            // 
            this.btnPurchasing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnPurchasing.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPurchasing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchasing.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnPurchasing.ForeColor = System.Drawing.Color.White;
            this.btnPurchasing.Location = new System.Drawing.Point(10, 210);
            this.btnPurchasing.Name = "btnPurchasing";
            this.btnPurchasing.Size = new System.Drawing.Size(180, 45);
            this.btnPurchasing.TabIndex = 3;
            this.btnPurchasing.Text = "Purchasing";
            this.btnPurchasing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchasing.UseVisualStyleBackColor = false;
            // 
            // btnRequisition
            // 
            this.btnRequisition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnRequisition.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRequisition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequisition.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnRequisition.ForeColor = System.Drawing.Color.White;
            this.btnRequisition.Location = new System.Drawing.Point(10, 265);
            this.btnRequisition.Name = "btnRequisition";
            this.btnRequisition.Size = new System.Drawing.Size(180, 45);
            this.btnRequisition.TabIndex = 4;
            this.btnRequisition.Text = "Requisition";
            this.btnRequisition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequisition.UseVisualStyleBackColor = false;
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDelivery.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Location = new System.Drawing.Point(10, 320);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(180, 45);
            this.btnDelivery.TabIndex = 5;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelivery.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlMain.Controls.Add(this.btnDeleteProduct);
            this.pnlMain.Controls.Add(this.lblInventoryTitle);
            this.pnlMain.Controls.Add(this.lblInventorySubtitle);
            this.pnlMain.Controls.Add(this.txtSearchInventory);
            this.pnlMain.Controls.Add(this.btnSearchInventory);
            this.pnlMain.Controls.Add(this.btnAddProduct);
            this.pnlMain.Controls.Add(this.btnEditProduct);
            this.pnlMain.Controls.Add(this.lblTotalProducts);
            this.pnlMain.Controls.Add(this.dgvInventory);
            this.pnlMain.Controls.Add(this.picPOSLogo);
            this.pnlMain.Location = new System.Drawing.Point(200, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 561);
            this.pnlMain.TabIndex = 0;
            // 
            // lblInventoryTitle
            // 
            this.lblInventoryTitle.AutoSize = true;
            this.lblInventoryTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblInventoryTitle.ForeColor = System.Drawing.Color.White;
            this.lblInventoryTitle.Location = new System.Drawing.Point(25, 25);
            this.lblInventoryTitle.Name = "lblInventoryTitle";
            this.lblInventoryTitle.Size = new System.Drawing.Size(333, 32);
            this.lblInventoryTitle.TabIndex = 0;
            this.lblInventoryTitle.Text = "INVENTORY MANAGEMENT";
            // 
            // lblInventorySubtitle
            // 
            this.lblInventorySubtitle.AutoSize = true;
            this.lblInventorySubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblInventorySubtitle.Location = new System.Drawing.Point(27, 60);
            this.lblInventorySubtitle.Name = "lblInventorySubtitle";
            this.lblInventorySubtitle.Size = new System.Drawing.Size(247, 15);
            this.lblInventorySubtitle.TabIndex = 1;
            this.lblInventorySubtitle.Text = "Manage and monitor your product inventory.";
            // 
            // txtSearchInventory
            // 
            this.txtSearchInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtSearchInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchInventory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchInventory.ForeColor = System.Drawing.Color.White;
            this.txtSearchInventory.Location = new System.Drawing.Point(25, 105);
            this.txtSearchInventory.Name = "txtSearchInventory";
            this.txtSearchInventory.Size = new System.Drawing.Size(300, 25);
            this.txtSearchInventory.TabIndex = 2;
            // 
            // btnSearchInventory
            // 
            this.btnSearchInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnSearchInventory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchInventory.ForeColor = System.Drawing.Color.White;
            this.btnSearchInventory.Location = new System.Drawing.Point(335, 105);
            this.btnSearchInventory.Name = "btnSearchInventory";
            this.btnSearchInventory.Size = new System.Drawing.Size(85, 30);
            this.btnSearchInventory.TabIndex = 3;
            this.btnSearchInventory.Text = "SEARCH";
            this.btnSearchInventory.UseVisualStyleBackColor = false;
            this.btnSearchInventory.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAddProduct.Location = new System.Drawing.Point(443, 103);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(115, 32);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "+ ADD PRODUCT";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnEditProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Location = new System.Drawing.Point(564, 102);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(114, 33);
            this.btnEditProduct.TabIndex = 5;
            this.btnEditProduct.Text = "EDIT PRODUCT";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click_1);
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.lblTotalProducts.Location = new System.Drawing.Point(25, 155);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(122, 15);
            this.lblTotalProducts.TabIndex = 6;
            this.lblTotalProducts.Text = "TOTAL PRODUCTS: 0";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.Location = new System.Drawing.Point(25, 185);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowTemplate.Height = 30;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(750, 350);
            this.dgvInventory.TabIndex = 7;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(686, 102);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(73, 33);
            this.btnDeleteProduct.TabIndex = 8;
            this.btnDeleteProduct.Text = "DELETE";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // picPOSLogo
            // 
            this.picPOSLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.picPOSLogo.Image = global::ALILA_POS.Properties.Resources.LoginLogo;
            this.picPOSLogo.Location = new System.Drawing.Point(510, 12);
            this.picPOSLogo.Name = "picPOSLogo";
            this.picPOSLogo.Size = new System.Drawing.Size(249, 104);
            this.picPOSLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPOSLogo.TabIndex = 9;
            this.picPOSLogo.TabStop = false;
            this.picPOSLogo.Click += new System.EventHandler(this.picPOSLogo_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(990, 560);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1006, 599);
            this.MinimumSize = new System.Drawing.Size(1006, 599);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALILA POS - Inventory";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPOSLogo)).EndInit();
            this.ResumeLayout(false);

        }

        // CONTROL DECLARATIONS
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;

        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnPurchasing;
        private System.Windows.Forms.Button btnRequisition;
        private System.Windows.Forms.Button btnDelivery;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblInventoryTitle;
        private System.Windows.Forms.Label lblInventorySubtitle;
        private System.Windows.Forms.TextBox txtSearchInventory;
        private System.Windows.Forms.Button btnSearchInventory;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.PictureBox picPOSLogo;
    }
}
