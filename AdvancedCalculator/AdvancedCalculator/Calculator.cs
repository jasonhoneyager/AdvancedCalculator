using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Calculator
    {
        ICalculate _mathoperator;
        public Calculator(ICalculate mathoperator)
        {
            _mathoperator = mathoperator;
        }

        private string[] SeperateValues(string equation)
        {
            string[] newequation = _mathoperator.SeperateValues(equation);
            return newequation;
        }

        private double? Calculate(string[] newequation)
        {
            double? answer = _mathoperator.Calculate(newequation);
            return answer;
        }

        public double? RunCalculation(string equation)
        {
            string[] newequation = SeperateValues(equation);
            double? answer = Calculate(newequation);
            return answer;
        }
    }
}
