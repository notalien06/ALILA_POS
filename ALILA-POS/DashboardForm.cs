using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ALILA_POS.Services;

namespace ALILA_POS
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            LoadDashboardMetrics();
     
            btnInventory.Click += BtnInventory_Click;
        }


        public DashboardForm(string fullName, string roleName)
        {
            InitializeComponent();

            lblUserWelcome.Text = "Hello, " + fullName + "!";
            lblUserRole.Text = "Your role: " + roleName;

            LoadDashboardMetrics();
            btnInventory.Click += BtnInventory_Click;
        }

        private void LoadDashboardMetrics()
        {
            try
            {
                var service = new InventoryService();
                var metrics = service.GetInventoryMetrics();

                lblTotalProductsValue.Text =
                    metrics["TotalProducts"].ToString();

                lblLowStockValue.Text =
                    metrics["LowStockItems"].ToString();

                lblTotalStockUnitsValue.Text =
                    metrics["TotalStockUnits"].ToString();

                lblActiveProductsValue.Text =
                    metrics["ActiveProducts"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load dashboard metrics:\n\n" + ex.Message,
                    "Dashboard Metrics",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblInventoryCardDescription_Click(object sender, EventArgs e)
        {

        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.ShowDialog();
        }
    }
}