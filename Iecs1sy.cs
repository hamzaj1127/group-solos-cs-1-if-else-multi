using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Group_Project_C_solo
{
    internal class Iecs1sy
    {
        static void Main(string[] args)
        {
            int Count = 70;


            while (Count < 100)
            {
                Count+= 1;
                if (Count <= 75)
                    Console.WriteLine($"{Count} is less than 75");
                else
                    Console.WriteLine($"{Count} is greater than 75");

            }
           


        }
    }
}
