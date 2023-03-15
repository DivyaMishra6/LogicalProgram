using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class EvenOrOdd
    {
        public static void Call()
        {
        int n;
        Console.WriteLine("Enter The Number");

           n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("It is Even Number");
            }
            else
            {
                Console.WriteLine("It is ODD Number");
            }
        }
    }
}
