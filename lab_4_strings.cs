using System.Text;

internal class lab_4_strings{
 
    static void Main(string[] args)
    {        //Console.WriteLine("Task 1");
        //Console.WriteLine("Enter a tring:");        //string str = Console.ReadLine()!;        //string[] words = str.Split(' ');        //Array.Reverse(words);        //str = string.Join(" ", words);        //Console.WriteLine("String: " + str);        //Console.WriteLine();        //Console.WriteLine("Task 2");
        //Console.WriteLine("Enter string: ");
        //string string_ = Console.ReadLine()!;
        //int counter = 0;
        //for (int i = 0; i < string_.Length; ++i)
        //{
        //    if (str[i] == ' ') ++counter;
        //}
        //Console.WriteLine("Spaces in line= " + counter);
        //Console.WriteLine();

        //Console.WriteLine("Task 3");
        //Console.WriteLine("Enter a text:");
        //string text = Console.ReadLine()!;
        //int countLower = 0;
        //int countUpper = 0;
        //for (int i = 0; i < text.Length; ++i)
        //{
        //    if (Char.IsLower(text[i])) ++countLower;
        //    if (Char.IsUpper(text[i])) ++countUpper;
        //}
        //double percentLower = countLower * 100.0 / text.Length;
        //double percentUpper = countUpper * 100.0 / text.Length;
        //Console.WriteLine($"Upper={percentUpper} \nLower={percentLower}");
        //Console.WriteLine();

        //Console.WriteLine("Task 4");        //Console.WriteLine("Enter a word combinations:");
        //string line = Console.ReadLine()!;
        //string[] someWords = line.Split(' ');
        //StringBuilder result = new StringBuilder();
        //for (int i = 0; i < someWords.Length; ++i)
        //{
        //    result.Append(someWords[i].Remove(1));
        //}
        //Console.WriteLine(result.ToString().ToUpper());        Console.WriteLine("Task 5");
        string word;
        StringBuilder builder= new StringBuilder();
        Console.WriteLine("Enter a word:");
        word = Console.ReadLine()!;
        builder.Append(word + ", ");
        while (word[word.Length - 1] != '.')
        {
            Console.WriteLine("Enter a word:");
            word = Console.ReadLine()!;
            builder.Append(word + ", ");
        }
        Console.WriteLine(builder.ToString().TrimEnd(',',' '));
        Console.WriteLine();

        Console.WriteLine("Task 6");
        Console.WriteLine("Enter a string:");
        string str1= Console.ReadLine()!;
        int firstIndex=-1, lastIndex=-1;
        for(int i=0;i<str1.Length;++i)
        {
            if (str1[i]=='.')
            {
                firstIndex = i;
                for(int j=++i;j<str1.Length;++j)
                {
                   if(str1[j]=='.')
                   {
                        lastIndex = j;
                        break;
                   }
                }
                break;
            }
        }
        for(int i=firstIndex;i<lastIndex;++i)
        {
            if (str1[i]==' ')
            {
                str1 = str1.Remove(i, 1);
                --lastIndex;
            }
        }
        Console.WriteLine("New String: " + str1);
        
    }}