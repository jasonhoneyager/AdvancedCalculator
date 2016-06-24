using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Blackboard blackboard = new Blackboard();
            blackboard.RunProgram();
        }
    }
}
//Build an advanced calculator:
//    a.Take in at least two numbers and an operator (can be user input or passed in)
//    b.Calculate Addition, Subtraction, Multiplication, Division, Exponential
//    c.Display the result
//    d.Implement three design patterns
//    e.For an extra challenge, implement compound expressions, advanced operations 
//      (beyond the simple arithmetic binary operators), and dependency injection.
//    f.Use SOLID principles.