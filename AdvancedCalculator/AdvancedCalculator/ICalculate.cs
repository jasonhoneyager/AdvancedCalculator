using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    interface ICalculate
    {

        string[] SeperateValues(string equation);

        double? Calculate(string[] newequation);
    }
}
