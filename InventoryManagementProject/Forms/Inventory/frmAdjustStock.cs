using InventoryManagementProject.Helpers;
using InventoryManagementProject.Models;
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
    public partial class frmAdjustStock : Form
    {
        public frmAdjustStock()
        {
            InitializeComponent();
        }
        private Product _product;
        public frmAdjustStock(Product product)
        {
            InitializeComponent();
            _product = product;
            lblCurrentQty.Text = product.Quantity.ToString();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNewQty.Text, out int newQty))
            {
                _product.Quantity = newQty;
                var helper = new FirebaseHelper();
                await helper.UpdateProduct(_product);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
