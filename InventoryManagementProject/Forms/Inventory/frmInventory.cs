using InventoryManagementProject.Helpers;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementProject.Forms.Inventory
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        private async Task LoadInventoryGrid()
        {
            var helper = new FirebaseHelper();
            var products = await helper.GetAllProducts();

            var inventoryData = products.Select(p => new
            {
                p.SKU,
                p.ProductName,
                p.Category,
                p.Quantity,
                p.ReorderLevel,
                Status = p.Quantity == 0 ? "❌ Out of Stock"
                        : p.Quantity <= p.ReorderLevel ? "⚠️ Low Stock"
                        : "✅ Normal"
            }).ToList();

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = inventoryData;

            StyleInventoryGrid(); // optional
        }
        private void StyleInventoryGrid()
        {
            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                var status = row.Cells["Status"].Value?.ToString();

                if (status == "❌ Out of Stock")
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                else if (status == "⚠️ Low Stock")
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                else if (status == "✅ Normal")
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }
        private async void frmInventory_Load(object sender, EventArgs e)
        {
            await LoadInventoryGrid();
        }

        private async void btnAdjustStock_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow?.Cells["SKU"].Value != null)
            {
                string selectedSKU = dgvInventory.CurrentRow.Cells["SKU"].Value.ToString();

                var helper = new FirebaseHelper();
                var product = await helper.GetProductBySKU(selectedSKU);

                if (product != null)
                {
                    using (frmAdjustStock adjustForm = new frmAdjustStock(product))
                    {
                        if (adjustForm.ShowDialog() == DialogResult.OK)
                        {
                            await LoadInventoryGrid(); // refresh grid after update
                        }
                    }
                }
            }
        }
    }
}
