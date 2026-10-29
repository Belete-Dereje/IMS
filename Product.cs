using System;
using System.Collections.Generic;
using System.Text;

namespace IMS
{
    public class Product
    {
        public string ProductCode { get; set; } = "";
        public string ProductName { get; set; } = "";
        public string Category { get; set; } = "";
        public string Unit { get; set; } = "";

        public decimal PurchaseCost { get; set; }
        public decimal SellingPrice { get; set; }

        public int Quantity { get; set; }
        public int MinimumStock { get; set; }
    }
}
