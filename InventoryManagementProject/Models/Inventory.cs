using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProject.Models
{
    internal class Inventory
    {
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string ActionType { get; set; } // "Add", "Deduct", "Manual"
        public int QuantityChanged { get; set; }
        public string Reason { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
