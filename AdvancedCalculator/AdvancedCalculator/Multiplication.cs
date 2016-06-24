﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Multiplication : ICalculate
    {
        public string[] SeperateValues(string equation)
        {
            string[] newequation = equation.Split('*');
            return newequation;
        }

        public double? Calculate(string[] newequation)
        {
            double value1 = Convert.ToInt32(newequation[0]);
            double value2 = Convert.ToInt32(newequation[1]);
            double answer = value1 * value2;
            return answer;
        }
    }
}
