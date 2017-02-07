using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using SimpleCalculator.Constants;


namespace SimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while(true)
            {
                Console.WriteLine($"[{x}]>");
                // increment number of times using program
                x++;
                // user passed expression
                string input = Console.ReadLine();
                if (input.ToLower() == "quit" || input.ToLower() == "exit")
                {
                    break;
                }
                /*
                 Write regex command to test for, (x=3, x "checks for value", x+1,) 
                 Create new files for when these conditions are met."think of an operations type folder"
                 Call appropriate file based on user submission. 
                 Key value pair to store variables.
                 Convert to work with existing methods.            
                 */

                // Check for 1 + 1 or 1+1
                Regex r1 = new Regex(@"^(\d+)\s*([+-/%*])\s*(\d+)$");
                Match match = r1.Match(input);
                
                // Check for a single char
                Regex r2 = new Regex(@"^([a-zA-Z])$");
                Match match2 = r2.Match(input);
               
                // Check for x = 1
                Regex r3 = new Regex(@"^([a-zA-Z])\s*=\s*(\d*)$");
                Match match3 = r3.Match(input);
                // If x sucess = true
                if (match2.Success)
                {
                    char charEntered = Convert.ToChar(match2.Groups[1].Value);
                    Console.WriteLine($"charEntered={charEntered}");
                    Constants.Constants constant = new Constants.Constants();
                    constant.AddConstantstoDictionary();
                    constant.TestForValueInDictionary(charEntered);
                }
                // If x = 1 success = true
                else if (match3.Success)
                {
                    string charEntered = match3.Groups[1].Value;
                    string valEntered = match3.Groups[2].Value;
                    Console.WriteLine($"charEntered={charEntered} valEntered={valEntered}");
                }
                // If 1 + 1 or 1+1 success = true
                else if (match.Success)
                {
                    string firstValue = match.Groups[1].Value;
                    string operatorUsed = match.Groups[2].Value;
                    string secondValue = match.Groups[3].Value;
                    /*
                    Console.WriteLine("First value = {0}", firstValue);
                    Console.WriteLine("Operator =  {0}", operatorUsed);
                    Console.WriteLine("Second value =  {0}", secondValue);
                    */
                    EquationConverter conversion = new EquationConverter();
                    conversion.MathRouter(firstValue, operatorUsed, secondValue);
                }
                else
                {
                    Console.WriteLine("Please enter in the formatt of (1 + 1) or (1+1)");
                }
            }
        }
    }
}


