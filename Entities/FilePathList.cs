using System;
using System.IO;

namespace Entities
{
    public class FilePathList
    {
        public static string pathToProducts = Path.Combine(Environment.CurrentDirectory, "Data", "Products.json");

        public static string pathToCommodities = Path.Combine(Environment.CurrentDirectory, "Data", "Commodities.json");

        public static string pathToInventoryReceipts = Path.Combine(Environment.CurrentDirectory, "Data", "InventoryReceipts.json");

        public static string pathToSalesReceipts = Path.Combine(Environment.CurrentDirectory, "Data", "SalesReceipts.json");
    }
}
