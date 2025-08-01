using InventoryManagementProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementProject.Forms.Home
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private async void frmHome_Load(object sender, EventArgs e)
        {
            await LoadDashboardStats();
        }
        private async Task LoadDashboardStats()
        {
            var helper = new FirebaseHelper();

            // Products count
            var products = await helper.GetAllProducts();
            lblProduct.Text = products.Count.ToString();

            // Transactions count
            var transactions = await helper.GetAllTransactions();
            lblTransactions.Text = transactions.Count.ToString();

            // Total sales
            var sales = transactions.Where(t => t.Type == "Sale").ToList();
            double totalSales = sales.Sum(s => s.TotalAmount);
            lblSales.Text = $"RM {totalSales:0.00}";
        }
    }
}
