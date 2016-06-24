using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    abstract class Operator
    {
        public abstract ICalculate DetermineOperator(string equation);


    }
}
