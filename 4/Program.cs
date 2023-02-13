internal class Program
{
    private static void Main(string[] args)
    {
        //Problem1();
        //Problem2();
        //Problem3();
        //Problem4();
        //Problem5();
        Problem6();
    }
    private static void Problem1(){
        Console.WriteLine("Enter string: ");
        string[] str = Console.ReadLine().Split(" ");
        for(int i = str.Length - 1; i>=0;i--){
            Console.Write(str[i] + " ");
        }
    }
    private static void Problem2(){
        Console.WriteLine("Enter string: ");
        string str = Console.ReadLine();
        int countSpaces = 0;
        for(int i = 0; i<str.Length - 1;i++){
            if(Char.IsWhiteSpace(str[i])){
                ++countSpaces;
            }
        }
        Console.WriteLine("Spaces in str: " + countSpaces);
    }
    private static void Problem3(){
        Console.WriteLine("Enter string: ");
        string str = Console.ReadLine();
        int countUpperLetters = 0;
        int countLowerLetters = 0;
        int countNotLetters = 0;
        for(int i = 0; i<str.Length;i++){
            
            if(Char.IsUpper(str[i])){
                ++countUpperLetters;
               
            }else if(Char.IsLower(str[i])){
                ++countLowerLetters;
                
            }else{
                ++countNotLetters;
           
            }
        }


        double upper = (double)countUpperLetters/str.Length;
        double lower = (double)countLowerLetters/str.Length;
        double symbols = (double)countNotLetters/str.Length;
        Console.WriteLine($"Upper: {upper*100}%\n" + 
                            $"Lower: {lower*100}%\n" + 
                            $"Not letters: {symbols*100}%");
    }
    private static void Problem4(){
        Console.Write("Enter str: ");
        string[] str = Console.ReadLine().Split(" ");
        for(int i = 0;i < str.Length;i++){
            Console.Write(Char.ToUpper(str[i][0]) );
        }


    }
    private static void Problem5(){
        Console.Write("Enter word: ");
        string str = Console.ReadLine()!;
        string res = str;
        while (!str.EndsWith('.'))
        {
            Console.Write("Enter word: ");
            str = Console.ReadLine();
            res += ", "  + str;
        }
        Console.WriteLine(res);
        Console.WriteLine();

    }
    private static void Problem6(){
        Console.Write("Enter str with two dots: ");
        string str = Console.ReadLine();
        string res = "";

        bool isBeetwenDots = false;
        char dot = '.';
        for(int i = 0;i<str.Length;i++){
            if(str[i] == dot){
                isBeetwenDots = !isBeetwenDots;
            }
            if( !(isBeetwenDots && Char.IsWhiteSpace(str[i]))){
                res+= str[i];
            }
        }
        Console.Write(res);
    }

}