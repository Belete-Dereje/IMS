using System;
using System.Collections.Generic;
using System.Text;

namespace IMS
{
    public class StockTransaction
    {
        public string ProductCode { get; set; } = "";
        public string ProductName { get; set; } = "";
        public string SupplierCode { get; set; } = "";

        public string TransactionType { get; set; } = "";

        public int Quantity { get; set; }

        public string Notes { get; set; } = "";

        public DateTime TransactionDate { get; set; }
    }
}
