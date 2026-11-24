
using System;
using System.Windows.Forms;
using ALILA_POS.Services;

namespace ALILA_POS
{
    public static class InventoryTest
    {
        public static void Run()
        {
            try
            {
                var service = new InventoryService();
                var products = service.GetAllProducts();

                MessageBox.Show(
                    "Database query successful!\n\n" +
                    "Products found: " + products.Count,
                    "Inventory Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Inventory test failed:\n\n" + ex.Message,
                    "Inventory Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
