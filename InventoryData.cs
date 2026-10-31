using System;
using System.Collections.Generic;
using System.Text;

namespace IMS
{
    public static class InventoryData
    {
        // Stores all products
        public static List<Product> Products { get; }
            = new List<Product>();

        // Stores all stock receipt records
        public static List<StockTransaction> StockTransactions { get; }
            = new List<StockTransaction>();

        // Stores all suppliers
        public static List<Supplier> Suppliers { get; }
            = new List<Supplier>();

        // Stores all category names
        public static List<string> Categories { get; }
            = new List<string>();
    }
}
