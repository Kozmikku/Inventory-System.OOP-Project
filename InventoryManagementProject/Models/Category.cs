using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProject.Models
{
    public class Category
    {
            public static List<string> GetCategories()
            {
                return new List<string>
            {
                "Nike",
                "Adidas",
                "Puma",
                "New Balance",
                "Converse"
            };
            }
        
    }
}
