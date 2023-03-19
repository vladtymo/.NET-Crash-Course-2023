namespace lesson_9_HW_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            List<IInstruments> allInstruments = new List<IInstruments>();

            allInstruments.Add(new Guitar()
            {
                Producer = "Jack&Danny Brothers",
                Model = "Unknown",
                Price = 5500
            });
            allInstruments.Add(new Piano()
            {
                Producer = "Yamaha",
                Model = "CLP-785PE",
                Price = 221950
            });
            
            foreach(IInstruments instrument in allInstruments) 
            {
                instrument.WriteInfo();
                Console.WriteLine("\n" + new string('-',20) + "\n");
            }

        }
    }
}