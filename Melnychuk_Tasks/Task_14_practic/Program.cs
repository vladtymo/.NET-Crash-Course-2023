using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
    
        public class Calculator
        {
            private Dictionary<string, Func<double, double, double>> operations;

            public Calculator()
            {
                operations = new Dictionary<string, Func<double, double, double>>();

                operations.Add("+",(a,b)=>a+b);
                operations.Add("-", (a, b) => a - b);
                operations.Add("*", (a, b) => a * b);
                operations.Add("/", (a, b) => a / b);

                operations.Add("sin", (a, b) => Math.Sin(a));
                operations.Add("cos", (a, b) => Math.Cos(a));
                operations.Add("tan", (a, b) => Math.Tan(a));
            }

            public double Calculate(string operation,double a, double b)
            {
                if (operations.ContainsKey(operation))
                {
                    return operations[operation](a, b);
                }
                else { throw new ArgumentException("Invalid operation: " + operation); }
            }
        }
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator();

            Console.WriteLine("Enter the first operand:");
            double operand1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter an opertion:");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter the second operand:");
            double operand2 = double.Parse(Console.ReadLine());

            double resualt = calculator.Calculate(operation, operand1, operand2);
            Console.WriteLine("Resualt {0}",resualt);
        }

    }
}