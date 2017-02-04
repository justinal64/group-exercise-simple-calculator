using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Operations
{
    public class SubtractNumber
    {
        public int SubtractStuff(int firstStuff, int secondStuff)
        {
            Console.WriteLine("The difference of your numbers is: {0}", (firstStuff - secondStuff));
            return firstStuff - secondStuff;
        }
    }
}
  
