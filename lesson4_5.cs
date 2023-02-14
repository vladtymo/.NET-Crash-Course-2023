using System;

namespace Word {
    class Program {
        static void Main(string[] argss) {
            Console.WriteLine("Enter words:");
            string inputStr = Console.ReadLine();
            string resultStr = "";

            while (!inputStr.EndsWith(".")){
                resultStr += inputStr + ", ";
                inputStr = Console.ReadLine();
            }

            resultStr += inputStr.TrimEnd('.');
            Console.WriteLine("Result : " + resultStr);
        }
    }
}

