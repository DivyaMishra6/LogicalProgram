using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class SwapNumber
    {
        public static void DisplaySwapNumber()
        {
            int a , b;

            Console.WriteLine("Enter First Number");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter First Number");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap a=" + a + " b =" + b);

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("After swap a = " + a + " b = " + b);
        }
    }
}
