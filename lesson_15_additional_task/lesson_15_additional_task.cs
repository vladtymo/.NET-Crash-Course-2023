using System;
using System.Collections.Generic;

public class OperationExecutor{
    public delegate double Operation(double x, double y);
    public Operation OperationMethod { get; set; }
    public OperationExecutor(Operation operation){
        OperationMethod = operation;
    }
    public double Perform(double x, double y = 0){
        return OperationMethod(x, y);
    }
}

public class MathCalculator{
    private Dictionary<string, OperationExecutor> mathOperations = new Dictionary<string, OperationExecutor>();
    public MathCalculator(){
        InitializeOperations();
    }

    private void InitializeOperations(){
        RegisterOperation("add", (x, y) => x + y);
        RegisterOperation("subtract", (x, y) => x - y);
        RegisterOperation("multiply", (x, y) => x * y);
        RegisterOperation("divide", (x, y) => y != 0 ? x / y : double.NaN);
        RegisterOperation("sine", (x, _) => Math.Sin(x));
        RegisterOperation("cosine", (x, _) => Math.Cos(x));
        RegisterOperation("tangent", (x, _) => Math.Tan(x));
    }

    public void RegisterOperation(string name, OperationExecutor.Operation operation){
        mathOperations[name] = new OperationExecutor(operation);
    }

    public double Evaluate(string operationName, double x, double y = 0){
        if (mathOperations.TryGetValue(operationName, out var operation)){
            return operation.Perform(x, y);
        }
        else{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: '{operationName}'");
            Console.ResetColor();
            return double.NaN;
        }
    }
}

public class Program{
    public static void Main(){
        MathCalculator mathCalculator = new MathCalculator();
        double x = 9.0;
        double y = 1.0;
        string input = "add subtract multiply divide sine cosine tangent error";
        string[] tokens = input.Split(' ');
        foreach (string operationName in tokens){
            double result = mathCalculator.Evaluate(operationName, x, y);
            if (!double.IsNaN(result)){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{operationName}({x}, {y}): {result}");
            }
            Console.ResetColor();
        }
    }
}
