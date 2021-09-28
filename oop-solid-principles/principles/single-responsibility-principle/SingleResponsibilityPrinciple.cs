using System;
namespace oop_solid_principles.principles.singleresponsibilityprinciple
{
    public class SingleResponsibilityPrinciple
    {
        public SingleResponsibilityPrinciple()
        {
            CashRegister cashRegister = new();

            cashRegister.ProcessItems();
            cashRegister.Checkout();
        }
    }
}
