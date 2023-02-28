using System;
using System.IO;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            var crane = new Bird("рiд птахiв родини Журавлевих", 50, 7, "Усi види однак пов'язанi з водними," +
           " переважно заболоченими територiями.");
            var pinguin = new Bird("родина кілегрудих птахів", 7, 30, "мешкають в південній півкулі нашої планети," +
          " більше всього воліючи холодну Антарктиду.");
            var white__Shark = new Fish("вид хрящових риб єдина сучасна з роду білих акул родини оселедцевих акул. ", 56, 900, "Великі білі акули живуть у водах всіх океанів, де температура коливається в межах від 11 ° С до 25 ° С");
            object[] zoo = new object[] { crane, pinguin,white__Shark };
            for (int i = 0; i < zoo.Length; i++)
            {
                if (zoo[i] is Bird)
                {
                    Console.WriteLine("Птах:");
                    ((Bird)zoo[i]).showInfo();
                    Console.WriteLine();
                }
               else if(zoo[i] is Fish)
                {
                    Console.WriteLine("Акула:");
                    ((Fish)zoo[i]).showInfo();
                    Console.WriteLine();
                }

            }


        }




    }
}