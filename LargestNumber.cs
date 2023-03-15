using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class LargestNumber
    {
        public static void FindLargest()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the Largest Number");

            Console.WriteLine("Input the 1st Number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 1st Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 1st Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine("The 1st number is the gretest among three");

                }
                else
                {
                    Console.WriteLine("The 3rd number is the gretest among three");
                }

            }
            else if(num2 > num3)
            {
                Console.WriteLine("The 2nd number is the gretest amang three");

            }
            else
            {
                Console.WriteLine("The 3rd number is the gretest among three");
            }
        }
    }
}
