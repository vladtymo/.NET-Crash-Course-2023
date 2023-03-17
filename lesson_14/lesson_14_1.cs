using System;
using System.Collections.Generic;
using System.Linq;

class Program{
    static void Main(string[] args){
        List<string> words = new List<string>{
            "karina", "anton", "tim", "vlad", "alina", "kate", "lena"
        };
        string maxLengthWord = words
            .OrderBy(word => word) 
            .OrderByDescending(word => word.Length)
            .FirstOrDefault(); 
        if (maxLengthWord != null){
            Console.WriteLine($"The maximum length word: {maxLengthWord}");
        }
        else{
            Console.WriteLine("Is empty.");
        }
    }
}
