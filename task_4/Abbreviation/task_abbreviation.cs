internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter phrase:");
        string str = Console.ReadLine();
        int size = str.Length;
        string abreviatur="";
        for (int i = 0; i < str.Split(" ",StringSplitOptions.RemoveEmptyEntries).Length; i++)
        {
            abreviatur += string.Join(" ",str.Split(" ", StringSplitOptions.RemoveEmptyEntries)[i][0]);
        }
        abreviatur = abreviatur.ToUpper();
        Console.WriteLine(abreviatur);

    }
}
