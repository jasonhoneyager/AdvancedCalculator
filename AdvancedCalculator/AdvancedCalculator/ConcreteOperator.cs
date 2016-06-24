using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class ConcreteOperator : Operator
    {
        public override ICalculate DetermineOperator(string equation)
        {
            char mathOP = DetermineMathOP(equation);
            switch (mathOP)
            {
                case '+':
                    return new Addition();
                case '-':
                    return new Subtraction();
                case '*':
                    return new Multiplication();
                case '/':
                    return new Division();
                case '^':
                    return new Exponentation();
                default:
                    throw new ApplicationException("Please enter a valid equation\r\n");
            }
        }

        private char DetermineMathOP(string equation)
        {
            char mathOP = '$';
            if (equation.Contains<char>('+'))
            {
                mathOP = '+';
            }
            else if (equation.Contains<char>('-'))
            {
                mathOP = '-';
            }
            else if (equation.Contains<char>('*'))
            {
                mathOP = '*';
            }
            else if (equation.Contains<char>('/'))
            {
                mathOP = '/';
            }
            else if (equation.Contains<char>('^'))
            {
                mathOP = '^';
            }
            return mathOP;
        }
    }
}
