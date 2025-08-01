using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using InventoryManagementProject.Models;

namespace InventoryManagementProject.Helpers
{
    internal class FirebaseHelper
    {
        private readonly FirebaseClient firebase = new FirebaseClient("https://oop-inventory-management-default-rtdb.asia-southeast1.firebasedatabase.app/");

        public async Task AddProduct(Product product)
        {
            await firebase.Child("Products").PostAsync(product);
        }

        public async Task<List<Product>> GetAllProducts()
        {
            var products = await firebase
                .Child("Products")
                .OnceAsync<Product>();

            return products.Select(p => p.Object).ToList();
        }

        public async Task UpdateProduct(string key, Product product)
        {
            await firebase.Child("Products").Child(key).PutAsync(product);
        }

        public async Task DeleteProduct(string key)
        {
            await firebase.Child("Products").Child(key).DeleteAsync();
        }
        public async Task<string> GetProductKeyBySKU(string sku)
        {
            var products = await firebase
                .Child("Products")
                .OnceAsync<Product>();

            var match = products.FirstOrDefault(p => p.Object.SKU == sku);
            return match?.Key;
        }

        public async Task DeleteProductBySKU(string sku)
        {
            var key = await GetProductKeyBySKU(sku);
            if (key != null)
            {
                await firebase.Child("Products").Child(key).DeleteAsync();
            }
        }
        public async Task UpdateProduct(Product product)
        {
            var toUpdate = (await firebase
                .Child("Products")
                .OnceAsync<Product>())
                .FirstOrDefault(p => p.Object.SKU == product.SKU);

            if (toUpdate != null)
            {
                await firebase
                    .Child("Products")
                    .Child(toUpdate.Key)
                    .PutAsync(product);
            }
        }
        public async Task<Product> GetProductBySKU(string sku)
        {
            var allProducts = await GetAllProducts();
            return allProducts.FirstOrDefault(p => p.SKU == sku);
        }
    }
}
