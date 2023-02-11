using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] AS;
            int count;
            string s;
            string[] AS2;
            string dot = ".";


            Console.WriteLine("Вводьте слова:");

            count = 0;
            AS = new string[count];

            do
            {

                s = Console.ReadLine();


                if (s != "")
                {

                    count++;


                    AS2 = new string[count];


                    for (int i = 0; i < AS2.Length - 1; i++)
                        AS2[i] = AS[i];


                    AS2[count - 1] = s;


                    AS = AS2;
                }

                if (s[s.Length - 1] == dot[0])
                {
                    break;
                }
            } while (true);


            for (int i = 0; i < AS.Length; i++)
                Console.WriteLine("AS[{0}] = {1}", i, AS[i]);

            string str = String.Join(", ", AS);
            Console.WriteLine(str);
        }
    }
}
