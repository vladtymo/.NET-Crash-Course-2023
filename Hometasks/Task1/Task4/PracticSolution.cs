using System.Diagnostics.Tracing;

namespace Task4
{
    public static class PracticSolution
    {
        public static void Exercise1()
        {
            Console.Write("String: ");
            string original = Console.ReadLine();

            string[] words = original.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string reversedWord = string.Empty;
                for(int j = words[i].Length - 1; j >= 0; j--)
                {
                    reversedWord += words[i][j];
                }
                words[i] = reversedWord;
            }

            Console.WriteLine(String.Join(' ', words));
        }

        public static void Exercise2()
        {
            Console.Write("String: ");
            string userString = Console.ReadLine();
            int spaceCount = userString.Count(character => character == ' ');
            Console.WriteLine("Space count: " + spaceCount);
        }

        public static void Exercise3()
        {
            Console.Write("Text: ");
            string text = Console.ReadLine();

            int lowerCounter = default;
            int upperCounter = default;

            foreach(char symbol in text)
            {
                if(char.IsLetter(symbol))
                {
                    if(char.IsUpper(symbol))
                    {
                        upperCounter++;
                    }

                    if(char.IsLower(symbol))
                    {
                        lowerCounter++;
                    }
                }
            }

            double lowerPercent = lowerCounter * 100.0 / text.Length;
            double upperPercent = upperCounter * 100.0 / text.Length;
            double otherPercent = 100.0 - lowerPercent - upperPercent;

            Console.WriteLine("String length: " + text.Length);
            Console.WriteLine("Lower case percent: " + lowerPercent);
            Console.WriteLine("Upper case percent: " + upperPercent);
            Console.WriteLine("Other case percent: " + otherPercent);
        }

        public static void Exercise4()
        {
            Console.Write("String: ");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');
            string abbreviation = default;

            foreach(string word in words) 
            {
                abbreviation += char.ToUpper(word[0]);
            }

            Console.WriteLine(abbreviation);
        }

        public static void Exercise5()
        {
            Console.WriteLine("Strings: ");
            string[] strings = new string[1];

            int counter = 0;
            strings[counter] = Console.ReadLine();

            while (!strings[counter++].EndsWith('.'))
            {
                Array.Resize(ref strings, strings.Length + 1);
                strings[counter] = Console.ReadLine();
            }

            Console.WriteLine(String.Join(';', strings));
        }

        public static void Exercise6()
        {
            Console.Write("String: ");
            string str = Console.ReadLine();

            string[] splited = str.Split('.');
            splited[1] = splited[1].Replace(" ", "");

            Console.WriteLine(String.Join('.', splited));
        }
    }
}