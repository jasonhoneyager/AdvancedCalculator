using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Blackboard
    {
        public Blackboard()
        {

        }

        private string ObtainEquationString()
        {
            Console.WriteLine("Input the equation you want calculated:\r\n");
            string equation = Console.ReadLine();
            return equation;
        }

        public void RunProgram()
        {
            string equation = ObtainEquationString();
            Operator domath = new ConcreteOperator();
            ICalculate mathoperator = domath.DetermineOperator(equation);
            Calculator calc = new Calculator(mathoperator);
            double? answer = calc.RunCalculation(equation);
            Console.WriteLine(answer);
            Console.ReadKey(true);
        }
    }
}
