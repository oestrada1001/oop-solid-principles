using System;
namespace oop_solid_principles.principles.singleresponsibilityprinciple
{
    public class Scanner
    {
        public Scanner()
        {
        }

        public Item scanItem()
        {
            Console.WriteLine("Item Name:");

            string ItemName = Console.ReadLine();

            Console.WriteLine("Item Price:");

            float ItemPrice = Single.Parse(Console.ReadLine());

            return new Item(ItemName, ItemPrice);
        }
    }
}
