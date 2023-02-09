enum Arr{GetSumOfArr = 1,SortArr,CountEvenNumbers,findMax};
internal class Program
{
    private static void Main(string[] args)
    {
        
        //Problem1();
        //Problem2();
        //Problem3();
        Problem4();
    }
    private static void Problem1(){
        Console.Write("Enter character to draw: ");
        char s = char.Parse(Console.ReadLine());
        Console.Write($"How many {s} i should draw: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write(s);
        }
    }
    private static void Problem2(){
        Random rnd = new Random();
        int n = rnd.Next(1,100);
        Console.Write("Guess the number between 1 and 100: ");
        int guess = int.Parse(Console.ReadLine());
        while(n!=guess){
            if(guess > n){
                Console.Write("Try lower: ");
            }else{
                Console.Write("Try higher: ");
            }
            guess = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Congratulation, yo guess the number - {n},we should celebrate");
        
    }
    private static void Problem3(){
        int size = 20;
        int[] arr = new int[size];
        Random rnd = new Random();
        for(int i = 0;i<size;i++){
            arr[i] = rnd.Next(1,100);
        }
        for(int i = 0;i<size;i++){
            Console.Write(arr[i] + " ");
        }
    }

    private static void Problem4(){
        int size = 20;
        int[] arr = new int[size];
        Random rnd = new Random();
        for(int i = 0;i<size;i++){
            arr[i] = rnd.Next(1,100);
        }
        for(int i = 0;i<size;i++){
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine($"Choose the option: \n" +
         $"{(int)Arr.GetSumOfArr} - {Arr.GetSumOfArr}" + 
        $"{(int)Arr.SortArr} - {Arr.SortArr}" +
         $"{(int)Arr.CountEvenNumbers} - {Arr.CountEvenNumbers}" +
          $"{(int)Arr.findMax} - {Arr.findMax}");

        Arr option = Enum.Parse<Arr>(Console.ReadLine());

        switch(option){
            case Arr.GetSumOfArr:
                int ans = arr.Sum();
                Console.WriteLine(ans);
                break;
            case Arr.SortArr:
                Array.Sort(arr);
                foreach (int num in arr) Console.Write(num + " ");
                Console.WriteLine();
                break;
            case Arr.CountEvenNumbers:
                int countEven = 0;
                for(int i = 0;i < size;i++){
                    if(arr[i] % 2 ==0){
                        ++countEven;
                    }
                }
                Console.WriteLine("Even number in array: " + countEven);
                break;
            case Arr.findMax:
                int maxV = arr[0];
                for(int i = 1;i < size;i++){
                    if(arr[i] > maxV){
                        maxV = arr[i];
                    }
                }
                Console.WriteLine("Max Value of the array is : " + maxV);
                break;
        }
    }

    
}