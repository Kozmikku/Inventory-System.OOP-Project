using Firebase.Database;
using Firebase.Database.Query;
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
using System.Xml.Linq;

namespace InventoryManagementProject.Forms.Inventory
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                SKU = Guid.NewGuid().ToString().Substring(0, 8), // simple SKU gen
                ProductName = txtProductName.Text,
                Category = cmbCategory.Text,
                Quantity = int.Parse(numQuantity.Text),
                CostPrice = double.Parse(txtCostPrice.Text),
                SellPrice = double.Parse(txtSellPrice.Text),
                Supplier = cmbSupplier.Text,
                Description = txtDescription.Text,
                ImageFile = txtImageFile.Text
            };

            var helper = new FirebaseHelper();
            await helper.AddProduct(product);
            MessageBox.Show("Product added!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Product Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = ofd.FileName;
                    string imageName = Guid.NewGuid().ToString() + Path.GetExtension(selectedFile);
                    string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                    Directory.CreateDirectory(imagesFolder);
                    string newFilePath = Path.Combine(imagesFolder, imageName);

                    File.Copy(selectedFile, newFilePath, true);

                    txtImageFile.Text = "Images/" + imageName; // relative path
                    picProduct.Image = Image.FromFile(newFilePath); // load for preview
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}