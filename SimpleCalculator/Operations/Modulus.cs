using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class ModuleNumber
    {
        public void AddStuff(int firstStuff, int secondStuff)
        {
            Console.WriteLine("The modulus of numbers: {0}", (firstStuff % secondStuff));
        }

    }
}

