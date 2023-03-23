using System;

public class Program {
    public delegate int ArrayVolume(int index);

    public static void Initialization(int[] array, ArrayVolume volume) {
        for (int i = 0; i < array.Length; i++) {
            array[i] = volume(i);
        }
    }

    public static void Main(){
        Random randomValue = new Random();
        //1
        int[] randomArray = new int[15];
        Initialization(randomArray, index => randomValue.Next(0, 101));
        //2 (math.pow(2, index) return double) use (int)
        int[] powerOfTwoArray = new int[10];
        Initialization(powerOfTwoArray, index => (int)Math.Pow(2, index));
        //3
        int[] stepIncreaseByTreeArray = new int[20];
        Initialization(stepIncreaseByTreeArray, index => index * 3);
        //4
        int[] fibonacciArray = new int[10];
        Initialization(fibonacciArray, index => index < 2 ? index : fibonacciArray[index - 1] + fibonacciArray[index - 2]);
        //output
        Console.WriteLine("random array:" + string.Join(", ", randomArray));
        Console.WriteLine("power of two array:" + string.Join(", ", powerOfTwoArray));
        Console.WriteLine("step increase by tree array:" + string.Join(", ", stepIncreaseByTreeArray));
        Console.WriteLine("fibonacci array:" + string.Join(", ", fibonacciArray));
    }
}
