using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Division : ICalculate
    {
        public string[] SeperateValues(string equation)
        {
            string[] newequation = equation.Split('/');
            return newequation;
        }

        public double? Calculate(string[] newequation)
        {
            double value1 = Convert.ToInt32(newequation[0]);
            double value2 = Convert.ToInt32(newequation[1]);
            if (value2 == 0)
            {
                Console.WriteLine("Cannot Divide by 0");
                return null;
            }
            else
            {
                double answer = value1 / value2;
                return answer;
            }
        }
    }
}
