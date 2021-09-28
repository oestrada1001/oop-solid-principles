using System;

namespace oop_solid_principles.principles.singleresponsibilityprinciple
{
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
