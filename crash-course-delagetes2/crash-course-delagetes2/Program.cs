namespace crash_course_delagetes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Dictionary<string, CalcOperation> operations = calculator.AddOperations();

            Console.WriteLine("Enter your expression");
            string equation = Console.ReadLine()!;

            int result = calculator.CalculatePostfixExpression(equation, operations);
            //if (operationType == "sin" || operationType == "cos" || operationType == "tan") 
            //    num2 = 0; 
            //else
            //    num2 = int.Parse(Console.ReadLine()!);

            //double result = calculator.MakeCalc(num1, num2, operations[operationType]);

            //if (operationType == "sin" || operationType == "cos" || operationType == "tan")
            //    Console.WriteLine($"{operationType}({num1}) = {result}");
            //else
            //    Console.WriteLine($"{num1} {operationType} {num2} = {result}");

            Console.WriteLine($"{equation} = {result}");
        }
    }
}