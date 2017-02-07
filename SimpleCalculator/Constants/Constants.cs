using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator.Constants;

namespace SimpleCalculator.Constants
{
    public class Constants
    {
        Dictionary<char, int> constantDictionary = new Dictionary<char, int>();
        
        // Dummy data for testing
        public void AddConstantstoDictionary()
        {
            constantDictionary.Add('a', 1);
            constantDictionary.Add('b', 2);
            constantDictionary.Add('c', 3);
            constantDictionary.Add('d', 4);
        }

        // Tests to see if a value in is in the dictionary
        public bool TestForValueInDictionary(char valuePassed)
        {
            bool containsChar = false;
            if (constantDictionary.ContainsKey(valuePassed))
            {
                containsChar = true;
            }
            Console.WriteLine($"containsChar = {containsChar}");
            return containsChar;
        }
    }
}
