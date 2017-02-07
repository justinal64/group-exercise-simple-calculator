﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

                Regex r1 = new Regex(@"^(\d+)\s*([+-/%*])\s*(\d+)$");
                Regex r2 = new Regex(@"^[a-zA-Z]\s*=\s*\d*$");

                Match match1 = r2.Match(input);
                if(match1.Success)
                {
                    Console.WriteLine("Congratz that worked!!!!");
                }
                // Match the input and write results
                Match match = r1.Match(input);
               
                if (match.Success)
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
