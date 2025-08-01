using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProject.Models
{
    public class TransactionType
    {
        public static List<string> GetTypes()
        {
            return new List<string>
        {
            "All",         // For filtering purposes
            "Stock In",
            "Stock Out",
            "Adjustment"
        };
        }
    }
}
