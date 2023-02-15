using System.Runtime.ExceptionServices;
using System.Text;

namespace Tasks_4
{
    class Program
    {
		public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Task1_Version_1("Hello world!");// !dlrow olleH
            Task1_Version_2("Hello world!");// world! Hello
            Console.WriteLine($"Кількість пробілів в рядку = {Task2("Hello world !")}");
            Task3("AAbb");
            Console.WriteLine(Task4("об'єктно орієнтоване програмування"));
            Console.WriteLine(Task5());
            Task6();
            Console.ReadKey();
        }
		#region  1. Вводиться рядок слів. Вивести слова в зворотньому порядку.
		static void Task1_Version_1(string line)
		{
            char[] charArray = line.ToCharArray();
            StringBuilder stringBuilder= new StringBuilder();
            for (int i = charArray.Length - 1; i >= 0; i--)  stringBuilder.Append(charArray[i]); 
            Console.WriteLine(stringBuilder.ToString());
        }
        
        static void Task1_Version_2(string line)
        {
            string[] words =  line.Split(' ');
            Array.Reverse(words);
            foreach (string word in words)  Console.Write(word + " ");
            Console.WriteLine();
        }
		#endregion
		#region  2. Обрахувати кількість пробілів в рядку, яку введе користувач.
		static int Task2(string line)
        {
            int counter = 0;
            for(int i = 0; i < line.Length; i++)
            if (line[i] == ' ') ++counter;
            return counter;
        }
		#endregion
		#region  3. Дано текст. Визначте відсоткове відношення малих і великих літер до загальної кількості символів в ньому.
		static void Task3(string line)
        {      
            int countUpper = 0,countLower = 0 ;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] >= 'A' && line[i] <= 'Z') ++countUpper;
                else if (line[i] >= 'a' && line[i] <= 'z') ++countLower;
            }           
            Console.WriteLine($"Відсоток великих літер =  {(countUpper / (double)line.Length)*100}%");
            Console.WriteLine($"Відсоток малих літер =  {(countLower / (double)line.Length) * 100}%");  
        }
		#endregion
		#region 4. Написати функцію, яка приймає словосполучення і перетворює його в абревіатуру. 
		//Наприклад: cascading style sheets в CSS, об'єктно орієнтоване програмування в ООП.
		static string Task4(string line)
        {
            string[] words = line.Split(" ");
            StringBuilder result = new StringBuilder();
            for(int i=0; i< words.Length;i++) result.Append(words[i].Remove(1));
            return result.ToString().ToUpper();
		}
		#endregion
		#region  5. Користувач вводить слова, поки не буде введено слово з символом крапки вкінці. Сформувати з введених слів рядок, розділивши їх комою з пробілом.
		static string Task5()
        {
            string line = "";
            StringBuilder result = new StringBuilder();
            while (line != ".")
            {
                Console.Write("Enter a word: ");
                line = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    if (line != ".") 
                        result.Append(line + " , ");
                }
                else
                    Console.WriteLine("The line must not be empty");
            }
            return ("Result: " + result.ToString().TrimEnd(',', ' '));
        }
		#endregion
		#region 6. У введеному рядку видалити пробіли між першим і другим символом крапки.
		public static void Task6()
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int dotIndex = input.IndexOf(".");
            if (dotIndex != -1) 
            { 
                string temp = input.Substring(0, dotIndex + 1);
                result.Append(temp);
                input = input.Substring(dotIndex + 1);    
                dotIndex = input.IndexOf(".");
                if(dotIndex != -1)
                {
                    temp = input.Substring(0, dotIndex);
                    temp = temp.Replace(" ", "");                                
                    result.Append(temp);
                    result.Append(input.Substring(dotIndex));
                    Console.WriteLine("Result: " + result.ToString());
                }
                else Console.WriteLine("This line does not have a second dot.");
            }
            else Console.WriteLine("This line does not have a dot.");
        }
		#endregion
	}
}