using System.Text;

namespace Home3
{
    internal class Tasks
    {
        static public void Task1()
        {
            string slova = Console.ReadLine();
            string[] words = slova.Split(new[] { ' ', '.', '?', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"Words {words.Length}");
            Array.Reverse(words);

            foreach (var w in words)
            {
                Console.Write(w + " ");
            }

        }
        static public void Task2()
        {
            string slova = Console.ReadLine();
            Console.Write(slova.Split(' ').Length.ToString());
        }
        static public void Task3()
        {
            //3. Дано текст.
            //Визначте відсоткове відношення малих і великих літер
            //до загальної кількості символів в ньому.
            string text = "Alfa romeo is cool car";
            int verh = 0;
            int niz = 0;



            for (int i = 0; i < text.Length; ++i)
            {
                if (char.IsUpper(text[i]) & char.IsLetter(text[i]))
                {
                    ++verh;
                }
                else if (char.IsLower(text[i]) & char.IsLetter(text[i]))
                {
                    ++niz;
                }
            }

            niz = (niz * 100) / text.Length;
            verh = (verh * 100) / text.Length;
            Console.WriteLine($"нижній регістр {niz}%");
            Console.WriteLine($"верхній регістр {verh}%");
        }
        static public void Task4()
        {
            Console.WriteLine("Введіть строку для відображення абривіатури");
            string InputText = Console.ReadLine();
            string[] words = InputText.Split(new[] { ' ', '.', '?', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Console.Write(word.ToUpper()[0]);
            }

        }
        static public void Task5()
        {

            StringBuilder builder = new StringBuilder();
            Console.WriteLine("Введіть слова");
            do
            {
                string word = Console.ReadLine();
                builder.Append(word + ", ");

                if (word.EndsWith("."))
                {

                    break;
                };

            } while (1 == 1);

            Console.WriteLine("Reuslt:\n" + builder.ToString());
        }


    }
}
