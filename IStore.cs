using System;
using System.Collections.Generic;
using System.Text;

namespace Store1
{
    public interface IStore
    {
        void Buy(Product product);
        void Sell(Product product);
        double GetRevenue();

    }
    public class SimpleRetailStore : IStore
    {
        public double TotalBuyBalance { get; set; }
        public double TotalSellBalance { get; set; }
        public void Buy(Product product)
        {
            TotalBuyBalance += product.PriceWhenBuy;
        }
        public void Sell(Product product)
        {
            TotalSellBalance += product.PriceWhenSell;
        }
        public double GetRevenue()
        {
            return TotalSellBalance - TotalBuyBalance;
        }

        public SimpleRetailStore(double totalByeBalance, double totalSellBalance)
        {
            TotalBuyBalance = totalByeBalance;
            TotalSellBalance = totalSellBalance;
        }

        public SimpleRetailStore()
        {
        }
    }
    public class InventoryRetailStore : IStore
    {
        private List<Product> Inventory { get; set; }
        double TotalRevenue;
        private Product product;

        public InventoryRetailStore()
        {
            Inventory = new List<Product>();
        }
        public void Buy(Product product)
        {
            Inventory.Add(product);
            TotalRevenue -= product.PriceWhenBuy;
        }
        public void Sell(Product product)
        {
            Inventory.Remove(product);
            TotalRevenue -= product.PriceWhenSell;
        }
        public void GetInventory()
        {
            foreach (Product p in Inventory)
            {
                Console.WriteLine(p);
            }
        }
        public double GetRevenue()
        {


            return TotalRevenue;

        }


        public void Reset()
        {
            Inventory = new List<Product>();
        }
    }
}

