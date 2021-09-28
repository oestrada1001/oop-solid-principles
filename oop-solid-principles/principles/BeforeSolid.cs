using System;
using System.Collections.Generic;

namespace oop_solid_principles.principles
{
    public class BeforeSolid
    {
        List<Item> Items = new List<Item>();

        float Total = 0f;

        public BeforeSolid()
        {
        }

        public void createItem()
        {
            int ItemsNeeded = 5;

            do
            {
                Console.WriteLine("Item Name:");

                string ItemName = Console.ReadLine();

                if (ItemName == "exit" || ItemName == "done")
                {
                    ItemsNeeded = 0;
                } else
                {
                    Console.WriteLine("Item Price:");

                    float ItemPrice = Single.Parse(Console.ReadLine());

                    this.AddItem(new Item(ItemName, ItemPrice));
                }

            } while (this.Items.Count < ItemsNeeded);
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

    public class Item
    {
        public string Name = "";
        public float Price = 0;

        public Item(string name, float price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
