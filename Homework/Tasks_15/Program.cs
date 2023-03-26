using System.Runtime.CompilerServices;

namespace Tasks_15
{
	class Calculator
	{
		private Dictionary<string, Func<double, double, double>> operations = new Dictionary<string, Func<double, double, double>>()
		{
		{ "+", (x, y) => x + y },
		{ "-", (x, y) => x - y },
		{ "*", (x, y) => x * y },
		{ "/", (x, y) => x / y },
		};
		private Dictionary<string, Func<double, double>> specialOperations = new Dictionary<string, Func< double, double>>()
		{
		{ "sin", (x) => Math.Sin(x) },
		{ "cos", (x) => Math.Cos(x) },
		{ "tan", (x) => Math.Tan(x) }
		};
		public double Operation(double x, double y, string op)
		{
			if (operations.ContainsKey(op))
			{
				return operations[op](x, y);
			}
			else
			{
				throw new ArgumentException("Invalid operation");
			}
		}
		public double Operation(double x, string op)
		{
			if (specialOperations.ContainsKey(op))
			{
				return specialOperations[op](x);
			}
			else
			{
				throw new ArgumentException("Invalid operation");
			}
		}

		public int Operation(int x, int y, Func<int, int, int> func) => func(x, y);
		public double Operation(double x, double y, Func<double, double, double> func) => func(x, y);
		public int Operation(int x, Func<int, int> func) => func(x);
		public double Operation(double x, Func<double, double> func) => func(x);
	}
	public class Program
	{
		static void Main(string[] args)
		{
			Calculator calculator = new Calculator();
			int sum = calculator.Operation(2, 2, (a, b) => a + b);
			int sub = calculator.Operation(2, 2, (a, b) => a - b);
			double multip = calculator.Operation(3.0, 2, (a, b) => a * b);
			double divide = calculator.Operation(3.0, 2, (a, b) => a / b);
			double sin = calculator.Operation(2, (x) => Math.Sin(x));
			double cos = calculator.Operation(2, (x)=> Math.Cos(x));
			double tan = calculator.Operation(2, (x) => Math.Tan(x));
			//Console.WriteLine($"Sum - {sum}");
			//Console.WriteLine($"Sub - {sub}");
			//Console.WriteLine($"Multip - {multip}");
			//Console.WriteLine($"Divide - {divide}");
			//Console.WriteLine($"Sin - {sin}");
			//Console.WriteLine($"Cos - {cos}");
			//Console.WriteLine($"Tan - {tan}");
			int b = 16,
				a = 24;
			string sign = "sin";
			Console.WriteLine($"{a} + {b} = {calculator.Operation(a,b,"+")}");
			Console.WriteLine($"{sign}({a}) = {calculator.Operation(a,sign)}");

			Console.ReadKey();
		}
	}
}