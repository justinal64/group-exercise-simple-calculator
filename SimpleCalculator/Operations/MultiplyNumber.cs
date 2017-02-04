using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Operations
{
    public class MultiplyNumber
    {
        public int MultiplyStuff(int firstStuff, int secondStuff)
        {
            Console.WriteLine("The product of your numbers is: {0}", (firstStuff * secondStuff));
            return firstStuff * secondStuff;
        }
    }
}
