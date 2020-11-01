using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the Yield Keyword *****\n");
            Garage carLot = new Garage();
            // Get items using GetEnumerator().
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH",
                c.PetName, c.CurrentSpeed);
            }

            foreach (Car c in carLot.GetTheCars(true))
            {
                Console.WriteLine("{0} is going {1} MPH",
                c.PetName, c.CurrentSpeed);
            }
        }
    }
}
