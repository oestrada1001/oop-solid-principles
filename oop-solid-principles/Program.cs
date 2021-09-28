using System;
using oop_solid_principles.principles;

namespace oop_solid_principles
{
    class Program
    {


        static void Main(string[] args)
        {
            BeforeSolid cashRegister = new BeforeSolid();

            cashRegister.createItem();
            cashRegister.CalculateTotal();
        }


    }

}