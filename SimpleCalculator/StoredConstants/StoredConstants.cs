using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.StoredConstants
{
    public class StoredConstants
    {
        Dictionary<char, int> constantDictionary = new Dictionary<char, int>();

        public void AddConstantsToDictionary()
        {
            constantDictionary.Add('a', 2);
            constantDictionary.Add('b', 1);
            constantDictionary.Add('c', 100);
        }

        public void AddConstantsToDictionary(char userKey, int userValue)
        {
            //constantDictionary.Add('d', 100);
            constantDictionary.Add(userKey, userValue);
        }

        public bool IsValueInDictionary(char inDictionary)
        {
            if (constantDictionary.ContainsKey(inDictionary))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddValueToDictionary()
        {

        }


    }
}
