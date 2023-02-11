using System.Runtime.ExceptionServices;
using System.Text;

namespace Tasks_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Console.WriteLine(Task1_Version_1("Hello world!"));
            // Task2("Hello world !");

            // Task3("Abcderfsat");

            // Console.WriteLine(Task4("об'єктно орієнтоване програмування"));


            // Console.WriteLine(Task5());
            Task6();
          
            Console.ReadKey();
        }
        static string Task1_Version_1(string input)
        {
            char[] charArray = input.ToCharArray();
            

            StringBuilder stringBuilder= new StringBuilder();
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(charArray[i]);
               
            }
            return stringBuilder.ToString();
        }
        
        static void Task1_Version_2(string line)
        {
            string[] word =  line.Split(' ');
            Array.Reverse(word);
            foreach (string word2 in word)
            {
                Console.Write(word2 + " ");
            }
            Console.WriteLine();
        }
        static void Task2(string line)
        {
            int counter = 0;
            for(int i = 0; i < line.Length; i++)
            if (line[i] == ' ')
            {
                    ++counter;
            }
            Console.WriteLine($"Кількість пробілів в рядку = {counter}");
        }
        static void Task3(string line)
        {
            int counterUpper = 0,counter = 0 ;
            for (int i = 0; i < line.Length; i++)
                if (line[i] >= 'A' && line[i] <= 'Z')
                {
                    ++counterUpper;
                }
                else ++counter;

           
            Console.WriteLine($"Відсоток великих літер =  {(counterUpper / (double)line.Length)*100}%");
            Console.WriteLine($"Відсоток малих літер =  {(counter / (double)line.Length) * 100}%");
           
        }
        /*
         * 4. Написати функцію, яка приймає словосполучення і перетворює його в абревіатуру. 
            Наприклад: cascading style sheets в CSS, об'єктно орієнтоване програмування в ООП.



*6. У введеному рядку видалити пробіли між першим і другим символом крапки.
         */
        static string Task4(string line)
        {
            string[] lines= line.Split(" ");
            StringBuilder stringBuilder= new StringBuilder();
            for(int i=0; i< lines.Length;i++)
            {
                stringBuilder.Append(lines[i].Remove(1));
                //string newWord = lines[i].Remove(1);
                
            }
            
           
            return stringBuilder.ToString().ToUpper();
        }
        //5. Користувач вводить слова, поки не буде введено слово з символом крапки вкінці.
       // Сформувати з введених слів рядок, розділивши їх комою з пробілом.
        static string Task5()
        {
            string input = "";
           
            StringBuilder result = new StringBuilder();
            while (input != ".")
            {
                Console.Write("Enter a word: ");
                input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    if (input != ".") result.Append(input + " , ");
                }
                else
                    Console.WriteLine("The field must not be empty");
                
                
            }

            return ("Result: " + result.ToString().TrimEnd(',', ' '));
           
            //// str.Replace(' ', '-')
            // StringBuilder stringBuilder = new StringBuilder();
            // string[] lines = (Console.ReadLine());


            // while (true)
            // {
            //     stringBuilder.Append(Console.ReadLine());
            //     if (stringBuilder.ToString().Contains('.'))
            //     {

            //         break;
            //     }

            // }
            // string a = stringBuilder.ToString().Join(" / ", stringBuilder.ToString());
            // Console.WriteLine(stringBuilder.ToString());


        }
        //*6. У введеному рядку видалити пробіли між першим і другим символом крапки.

        public static void Task6()
        {
            string input = "This is a first string. Second string is also here. Third string is here. Fourth string is there";
            //input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
        
            int startIndex = input.IndexOf(".");

            if (startIndex != -1) 
            { 
                string res = input.Substring(0, startIndex + 1);
                result.Append(res);
            Console.WriteLine(res + " 1");
            }
           
            input = input.Substring(startIndex + 1);
            Console.WriteLine(input + " 2");
            startIndex = input.IndexOf(".");
            if (startIndex != -1)
            {
                string res = input.Substring(0, startIndex);
                res = res.Replace(" ", "");
                Console.WriteLine(res + " 3");
                result.Append(res);
            }
            result.Append(input.Substring(startIndex)); Console.WriteLine(" string builder : " + result.ToString());
        }
    }
}