using System;
using System.Collections.Generic;

public class OperationDelegate{
    public delegate double Operation(double x, double y);
    public Operation OperationMethod { get; set; }
    public OperationDelegate(Operation operation){
        OperationMethod = operation;
    }
    public double Execute(double x, double y = 0){
        return OperationMethod(x, y);
    }
}

public class Calculator{
    private Dictionary<string, OperationDelegate> operations = new Dictionary<string, OperationDelegate>();
    public Calculator(){
        RegisterOperation("+", (x, y) => x + y);
        RegisterOperation("-", (x, y) => x - y);
        RegisterOperation("*", (x, y) => x * y);
        RegisterOperation("/", (x, y) => y != 0 ? x / y : double.NaN);
        RegisterOperation("sin", (x, _) => Math.Sin(x));
        RegisterOperation("cos", (x, _) => Math.Cos(x));
        RegisterOperation("tg", (x, _) => Math.Tan(x));
    }
    public void RegisterOperation(string name, OperationDelegate.Operation operation){
        operations[name] = new OperationDelegate(operation);
    }
    public double Calculate(string operationName, double x, double y = 0){
        if (operations.TryGetValue(operationName, out var operation)){
            return operation.Execute(x, y);
        }
        else{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"error '{operationName}'");
            Console.ResetColor();
            return double.NaN;
        }
    }
}

public class Program{
    public static void Main(){
        Calculator calculator = new Calculator();
        double x = 3.0;
        double y = 2.0;
        string input = "+ 3 2 - * / sin cos tg error";
        string[] tokens = input.Split(' ');
        for (int i = 0; i < tokens.Length; i++){
            string operationName = tokens[i];
            double result = calculator.Calculate(operationName, x, y);
            if (!double.IsNaN(result)){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{operationName}({x}, {y}): {result}");
            }
            Console.ResetColor();
        }
    }
}
