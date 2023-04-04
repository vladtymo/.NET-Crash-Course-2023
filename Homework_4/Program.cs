using System.Linq.Expressions;

internal class Program{
    private static void Main(string[] args){
        //question 1
        //Console.WriteLine("Input your sentence: ");
        //string str1=Console.ReadLine()!;
        //string[] words=str1.Split(' ');
        //Array.Reverse(words);
        //foreach (var word in words) {
        //    Console.Write(word+" ");
        //}

        //question 2
        //Console.WriteLine("Input your line: ");
        //string str=Console.ReadLine()!;
        //int spaceCounter = 0;
        //for (int i = 0; i < str.Length; ++i) {
        //    if (str[i]==' ') { ++spaceCounter; }
        //}
        //Console.WriteLine($"Nums of spaces on line\n" +
        //    $"{str}\n" +
        //    $"= {spaceCounter }");

        //question 3
        //Console.WriteLine("Enter the text:");
        //string text = Console.ReadLine();
        //int lowercaseCount = 0;
        //int uppercaseCount = 0;
        //int totalCount = text.Length;
        //foreach (char c in text){
        //    if (char.IsLower(c)){
        //        lowercaseCount++;
        //    }
        //    else if (char.IsUpper(c)){
        //        uppercaseCount++;
        //    }
        //}
        //double lowercasePercentage = (double)lowercaseCount / totalCount * 100;
        //double uppercasePercentage = (double)uppercaseCount / totalCount * 100;
        //Console.WriteLine("Percentage of lowercase letters: " + lowercasePercentage + "%");
        //Console.WriteLine("Percentage of uppercase letters: " + uppercasePercentage + "%");

        //question 4
        //Console.WriteLine("Enter a phrase: ");
        //    string phrase = Console.ReadLine();
        //    Console.WriteLine("Acronym: " + GenerateAcronym(phrase));
        //    static string GenerateAcronym(string phrase){
        //        string[] words = phrase.Split(' ');
        //        string acronym = "";
        //        foreach (string word in words){
        //            acronym += word[0];
        //        }
        //        return acronym.ToUpper();
        //    }

        //question 5
        string input;
        string result = "";
        Console.WriteLine("Enter words (end with a period):");
        do{
            input = Console.ReadLine();
            if (!input.EndsWith(".")){
                result += input + ", ";
            }
            else{
                result += input;
            }
        } while (!input.EndsWith("."));
        Console.WriteLine("Result: " + result);
    }
}
