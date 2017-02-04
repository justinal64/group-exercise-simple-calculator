using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Operations
{
    public class ModulusizeNumber
    {
        public int ModulusizeStuff(int firstStuff, int secondStuff)
        {
            Console.WriteLine("The modulus (aka \"remainder\" for you laypeople) of your numbers is: {0}", (firstStuff % secondStuff));
            return firstStuff % secondStuff;
        }
    }
}
