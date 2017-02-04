using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Operations
{
    public class DivideNumber
    {
        public int DivideStuff(int firstStuff, int secondStuff)
        {
            Console.WriteLine("The quotient (maybe? Is that it?) of your numbers is: {0}", (firstStuff / secondStuff));
            return firstStuff / secondStuff;
        }
    }
}
