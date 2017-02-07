using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Constants
{
    public class Constants
    {
        Dictionary<char, int> constantDictionary = new Dictionary<char, int>();

        public void AddConstantstoDictionary()
        {
            constantDictionary.Add('a', 2);
        }
    }
}
