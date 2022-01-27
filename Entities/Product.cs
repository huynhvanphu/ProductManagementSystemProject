using System;
namespace Entities
{
    public class Product
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public DateTime ExpiryDate { set; get; }

        public string Manufacturer { set; get; }

        public int YearOfProduction { set; get; }

        public int Commodity { set; get; }

        public int Quantity { set; get; }
    }
}
