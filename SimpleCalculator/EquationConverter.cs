using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator.Operations;

namespace SimpleCalculator
{
    public class EquationConverter
    {

        public void ConvertString(string a, string op, string b)
        {
            int firstNumberInEquation = Convert.ToInt32(a);

            char operatorInEquation = Convert.ToChar(op);

            int secondNumberInEquation = Convert.ToInt32(b);

            MathRouter(firstNumberInEquation, operatorInEquation, secondNumberInEquation);
        }

        public int MathRouter(int firstInt, char operatorChar, int secondInt)
        {
            int result = 0;
            if (operatorChar == '+')
            {
                AddNumber addnumber = new AddNumber();
                result = addnumber.AddStuff(firstInt, secondInt);
            }
            else if (operatorChar == '-')
            {
                SubtractNumber subtractnumber = new SubtractNumber();
                result = subtractnumber.SubtractStuff(firstInt, secondInt);
            }
            else if (operatorChar == '*')
            {
                MultiplyNumber multiplynumber = new MultiplyNumber();
                result = multiplynumber.MultiplyStuff(firstInt, secondInt);

            }
            else if (operatorChar == '/')
            {
                DivideNumber dividenumber = new DivideNumber();
                result = dividenumber.DivideStuff(firstInt, secondInt);
            }
            else if (operatorChar == '%')
            {
                ModulusizeNumber modulusizeNumber = new ModulusizeNumber();
                result = modulusizeNumber.ModulusizeStuff(firstInt, secondInt);
            }

            return result;
        }
    }
}
