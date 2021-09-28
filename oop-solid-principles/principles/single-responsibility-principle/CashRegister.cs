using System;

namespace oop_solid_principles.principles.singleresponsibilityprinciple
{
    public class CashRegister
    {
        Scanner scanner = new Scanner();
        Checkout checkout = new Checkout();

        public CashRegister()
        {
        }

        public void ProcessItems()
        {

            int ItemsNeeded = 3;

            do
            {
                this.checkout.AddItem(this.scanner.scanItem());

                
            } while (this.checkout.Items.Count < ItemsNeeded);
        }

        public void Checkout()
        {
            this.checkout.CalculateTotal();
        }

    }
}
