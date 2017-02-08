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
            /* a side effect of using the .Add method is that it throws an error 
             if the key already exists, so we don't need a seperate method  
             checking if the key exist
             */
            try
            {
                constantDictionary.Add(userKey, userValue);
                Console.WriteLine($"{userKey} = {userValue} added to the dictionary!");
            }
            catch(Exception)
            {
                Console.WriteLine("Sorry that variable already exists");
            }
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

        public string GetValueFromDictionary(char key)
        {
            if(constantDictionary.ContainsKey(key))
            {
                //string value = constantDictionary[key];
                Console.WriteLine($"The Value of {key} is {constantDictionary[key]}");
            }
            else
            {
                Console.WriteLine("Sorry that value is not in the Dictionary");
            }
            return "Test";
        }


    }
}
