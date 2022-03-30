using OTS_Supermarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Supermarket
{
    public class Cart
    {
        public List<Item> items;
        public int size;
        public double amount;
        public int broj;

        public Cart()
        {
            items = new List<Item>();
            size = 0;
            amount = 0;
            broj = 1;
        }

        public void AddOneToCart(Item item)
        {
            if(broj >= 10)
            {
                throw new Exception("Broj ajtema ne moze biti veci od 10");
            }
            if(size >= 10)
            {
                throw new Exception("Broj ajtema ne moze biti veci od 10");
            }
            items.Add(item);
            size++;
            amount += item.Price;
        }
    }
}
