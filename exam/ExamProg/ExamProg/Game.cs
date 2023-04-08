
namespace ExamProg
{
    public class Game
    {
        public void Play()
        {
            Console.WriteLine("Вітаємо вас у грі морський бій!!!\n" +
                   "Для перемоги у ній вам потрібно буде знищити всі кораблі вашого супротивника\n\n");


            Console.Write("Введіть своє ім'я: ");
            string name1 = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Оберіть з ким бажаєте зіграти:\n" +
                   "   1 - Проти іншого гравця\n" +
                   "   2 - Проти комп'ютера");
                string playerCheck = Console.ReadLine();
                Player player1 = new HumanPlayer()
                {
                    Name = name1,
                    Color = ConsoleColor.Yellow
                };
                Player player2;
                string name2 = "";
                switch (playerCheck)
                {
                    case "1":
                        Console.Write("Введіть ім'я другого гравця: ");
                        name2 = Console.ReadLine();
                        player2 = new HumanPlayer()
                        { 
                            Name = name2,
                            Color = ConsoleColor.Cyan
                        };
                        break;
                    case "2":
                        player2 = new PCPlayer();
                        break;
                    default:
                        Console.WriteLine("Такого варіанту немає!!!\n");
                        continue;
                }
                Console.WriteLine("Що ж...приступимо до гри...");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine(name1 + ", бажаєте створити поле вручну(1) чи заповнити випадковим чином (2)?");
                string checkFieldFill = Console.ReadLine();
                if(checkFieldFill == "1")
                {
                    player1.setField();
                }
                else
                {
                    player1.setRandomField();
                    Console.Clear();
                    Console.WriteLine("Ось ваше поле!");
                    player1.printField();
                    Thread.Sleep(2000);
                }

                Console.Clear();

                if(player2.getName() == "PC")
                {
                    Console.WriteLine("Зараз ваш супротивник створить своє поле...");
                    Thread.Sleep(2000);
                    player2.setField();
                    
                }
                else
                {
                    Console.WriteLine(name2 + ", бажаєте створити поле вручну(1) чи заповнити випадковим чином (2)?");
                    checkFieldFill = Console.ReadLine();
                    if (checkFieldFill == "1")
                    {
                        player2.setField();
                    }
                    else
                    {
                        player2.setRandomField();
                        Console.Clear();
                        Console.WriteLine("Ось ваше поле!");
                        player2.printField();
                        Thread.Sleep(2000);
                    }
                }

                //--------start game
                int countRounds = 1;
                while(player1.isLive() && player2.isLive())
                {
                    Console.Clear();
                    Console.WriteLine("Раунд №" + countRounds + "...\nПершим ходить " + name1);
                    Thread.Sleep(2000);

                    bool checkDamage = player2.checkDamage(player1.makeAttack(player1.playField));
                    player1.confirmDamage(checkDamage, player1.playField, player2.playField);
                    Thread.Sleep(2000);
                    checkDamage = player1.checkDamage(player2.makeAttack(player2.playField));
                    Thread.Sleep(2000);
                    player2.confirmDamage(checkDamage, player2.playField, player1.playField);
                    Thread.Sleep(2000);
                    countRounds++;
                }
                if (player2.getName() == "PC")
                {
                    if(!player2.isLive())
                        Console.WriteLine("Вітаємо, ви перемогли!!!");
                    else
                        Console.WriteLine("Нажаль ви програли...");
                }
                else
                {
                    Console.WriteLine($"Вітаємо, {(!player1.isLive() ? name2 : name1)}! Ви перемогли");
                }
            }
        }
    }
}
