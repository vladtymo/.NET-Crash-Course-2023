enum Days {Sunday = 1,Monday,Thueday,Wednesday,Thursday,Friday,Saturday};
enum Currency {USD = 1,EUR,PLN};
enum Circle {GetRadius = 1,GetArea,GetLength};
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
        Console.WriteLine("Choose Day:\n" +
                            $"{(int)Days.Sunday} - {Days.Sunday}\n" +
                            $"{(int)Days.Monday} - {Days.Monday}\n" +
                            $"{(int)Days.Thueday} - {Days.Thueday}\n" +
                            $"{(int)Days.Wednesday} - {Days.Wednesday}\n" + 
                            $"{(int)Days.Thursday} - {Days.Thursday}\n" + 
                            $"{(int)Days.Friday} - {Days.Friday}\n" +
                            $"{(int)Days.Saturday} - {Days.Saturday}\n");

        Days days = Enum.Parse<Days>(Console.ReadLine());

        switch (days)
        {
            case Days.Sunday: Console.WriteLine(Days.Sunday);break;
            case Days.Monday: Console.WriteLine(Days.Monday);break;
            case Days.Thueday: Console.WriteLine(Days.Thueday);break;
            case Days.Wednesday: Console.WriteLine(Days.Wednesday);break;
            case Days.Thursday: Console.WriteLine(Days.Thursday);break;
            case Days.Friday: Console.WriteLine(Days.Friday);break;
            case Days.Saturday: Console.WriteLine(Days.Saturday);break;
        }
    }

    private static void Problem2(){
        Console.WriteLine("Enter your money(in uan): ");
        double money = double.Parse(Console.ReadLine()); 

        Console.WriteLine("Choose currency to convert:\n" +
                            $"{(int)Currency.USD} - {Currency.USD}\n" +
                            $"{(int)Currency.EUR} - {Currency.EUR}\n" +
                            $"{(int)Currency.PLN} - {Currency.PLN}\n");

        Currency currency = Enum.Parse<Currency>(Console.ReadLine());
        const double USD_IN_UAN = 36.74F;
        const double EUR_IN_UAN = 39.41F;
        const double PLM_IN_UAN = 8.31F;
        switch (currency)
        {
            case Currency.USD: Console.WriteLine(money/USD_IN_UAN);break;
            case Currency.EUR: Console.WriteLine(money/EUR_IN_UAN);break;
            case Currency.PLN: Console.WriteLine(money/PLM_IN_UAN);break;
        }
    }
    private static void Problem3(){
        Console.WriteLine("Enter diametr of circle: ");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine($"Choose your options: \n" + 
                            $"{(int)Circle.GetRadius} - {Circle.GetRadius}\n" +
                            $"{(int)Circle.GetArea} - {Circle.GetArea}\n" +
                            $"{(int)Circle.GetLength} - {Circle.GetLength}\n");
        
        Circle circle = Enum.Parse<Circle>(Console.ReadLine());
        switch(circle){
            case Circle.GetRadius: Console.WriteLine($"Radius of circle: {d/2}");break;
            case Circle.GetArea: Console.WriteLine($"Area of circle: {(d/2) * (d/2) * Math.PI}");break;
            case Circle.GetLength: Console.WriteLine($"Length of circle: {2*Math.PI * (d/2)}");break;
        }
    }
    private static void Problem4(){
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        bool ans = true;
        int div = 1;
        while(n / div >= 10){
            div *= 10;
        }

        while(n !=0){
            int head = n/ div;
            int tail = n % 10;

            if(head != tail){
                ans = false;
            }
            n = (n % div) / 10;
            div = div/100; 
        }
        if(ans){
            Console.WriteLine("is a Palindrome");
        }else{
            Console.WriteLine("is not a Palindrome");
        }
    }
}