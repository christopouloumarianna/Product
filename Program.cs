using System;

namespace Store1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product x1 = new Product(1, "Painting Picasso. Guernica", 100, 1000);
            Product x2 = new Product(2, "Painting Tsarouxis. Naftis A", 200, 2000);
            Product x3 = new Product(3, "Chair. Luis XV", 100, 1000);
            Product x4 = new Product(4, "Vase. Cubic", 500, 5000);
            var simple = new SimpleRetailStore();
            simple.Buy(x1); simple.Buy(x3); simple.Sell(x1);
            Console.WriteLine(simple.GetRevenue());
            var invStore = new InventoryRetailStore();
            invStore.Buy(x1); invStore.Buy(x3); invStore.Sell(x1);
            Console.WriteLine(invStore.GetRevenue());
            invStore.Sell(x2);
            invStore.GetInventory();
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PriceWhenBuy { get; set; }
        public double PriceWhenSell { get; set; }

        public Product(int id, string name, double priceWhenBuy, double priceWhenSell)
        {
            Id = id;
            Name = name;
            PriceWhenBuy = priceWhenBuy;
            PriceWhenSell = priceWhenSell;
        }

        public override string ToString()
        {
            return $" {Id} {Name} {PriceWhenBuy} {PriceWhenSell}";
        }

        public bool Equals(Product other)
        {
            return Id == other.Id && Name == other.Name;
        }
    }
}


