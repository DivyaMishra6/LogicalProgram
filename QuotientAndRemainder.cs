using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class QuotientAndRemainder
    {
        public static void FindQuotientAndRemainder()
        {
            int divident;
            int divisor;

            Console.WriteLine("Enter the divident");
            divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor");
            divisor = Convert.ToInt32(Console.ReadLine());

            int remainder = divident % divisor;
            int Quotient = divident / divisor;

            Console.WriteLine("The divident" + divident + "and divisor " + divisor) ;

            Console.WriteLine("The quotent is " + Quotient + "and The reminder is " + remainder);


        }
    }
}
