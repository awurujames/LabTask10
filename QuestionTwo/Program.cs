using System;
using System.Collections.Generic;
namespace PropertyTest
{
    class Program
    {
        static void Main(string[] args)
        {
           House house1 = new House("Abuja",false,22, 0.50M);
           House house2 = new House("Kaduna",false,23, 0.15M);
           House house3 = new House("Edo",false,21, 0.55M);
           Bus bus1 = new Bus(25,34525, 6000M);
           Bus bus2 = new Bus(26,34345, 500M);
           Bus bus3 = new Bus(56,14575, 8000M);
            List<ITaxable> taxables = new List<ITaxable>(){house1, house2, house3, bus1, bus2, bus3};
            Console.WriteLine("\nTaxables Processed Polymorphically\n");
            foreach (ITaxable taxable in taxables)
            {
                Console.WriteLine(taxable.TaxValue());
            }
        }
    }
}





