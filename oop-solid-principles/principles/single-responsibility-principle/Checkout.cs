using System;
using System.Collections.Generic;

namespace oop_solid_principles.principles.singleresponsibilityprinciple
{
    public class Checkout
    {
        public List<Item> Items = new List<Item>();

        float Total = 0f;


        public Checkout()
        {
        }

        public void AddItem(Item item)
        {
            this.Items.Add(item);
        }

        public void CalculateTotal()
        {
            foreach (Item item in this.Items)
            {
                Console.WriteLine("Item: {0}, Price: {1}", item.Name, item.Price);
                this.Total += item.Price;
            }

            Console.WriteLine("Total Amount: {0:C}", this.Total);
        }
    }
}
