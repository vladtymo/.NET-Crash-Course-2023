using System;

public class Program{
    public delegate int ArrayVolume(int index);
    public static void Initialization(int[] array, ArrayVolume volume){
        for (int i = 0; i < array.Length; i++){
            array[i] = volume(i);
        }
    }

    public static int[] RandomArray(int size){
        Random randomValue = new Random();
        int[] randomArray = new int[size];
        Initialization(randomArray, index => randomValue.Next(0, 101));
        return randomArray;
    }

    public static int[] PowerOfTwoArray(int size){
        int[] powerOfTwoArray = new int[size];
        Initialization(powerOfTwoArray, index => (int)Math.Pow(2, index));
        return powerOfTwoArray;
    }

    public static int[] StepIncreaseByTreeArray(int size){
        int[] stepIncreaseByTreeArray = new int[size];
        Initialization(stepIncreaseByTreeArray, index => index * 3);
        return stepIncreaseByTreeArray;
    }

    public static int[] FibonacciArray(int size){
        int[] fibonacciArray = new int[size];
        Initialization(fibonacciArray, index => index < 2 ? index : fibonacciArray[index - 1] + fibonacciArray[index - 2]);
        return fibonacciArray;
    }

    public static void Main()
    {
        Console.WriteLine("random array:" + string.Join(", ", RandomArray(15)));
        Console.WriteLine("power of two array:" + string.Join(", ", PowerOfTwoArray(10)));
        Console.WriteLine("step increase by tree array:" + string.Join(", ", StepIncreaseByTreeArray(20)));
        Console.WriteLine("fibonacci array:" + string.Join(", ", FibonacciArray(10)));
    }
}
