using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Operations
{
    class ModulusizeNumber
    {
        public void ModulusizeStuff(int firstStuff, int secondStuff)
        {
            Console.WriteLine("The modulus (aka \"remainder\" for you laypeople) of your numbers is: {0}", (firstStuff % secondStuff));
        }
    }
}
