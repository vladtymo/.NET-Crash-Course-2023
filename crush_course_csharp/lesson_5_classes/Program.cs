namespace lesson_5_classes
{
    class Weapon
    {
        string name;
        float shotRange;
        float caliber;
        int countOfBullets;
        int maxSize;
        public void Initialize(string name, float range, float caliber, int maxSize)
        {
            this.name = name;
            shotRange = range;
            this.caliber = caliber;
            this.maxSize = maxSize;
            countOfBullets = maxSize;
        }
        public bool Shot()
        {
            if (countOfBullets - 1 >= 0)
            {
                Console.WriteLine("Постріл виконано!\n");
                countOfBullets--;
                return true;
            }
            else
            {
                Console.WriteLine("Недостатньо патронів...\nПерезарядіть зброю");
                return false;
            }
        }
        public void Recharge()
        {
            countOfBullets = maxSize;
            Console.WriteLine($"\n{name} перезаряджено...\n");
        }
        public void Save()
        {
            string path = @"..\..\..\..\weapons.txt";
            File.AppendAllText(path, $"{name}\n{shotRange}\n{caliber}\n{maxSize}\n\n");
        }
        public bool Load(string name)
        {
            IEnumerable<string> s = new string[] { };
            s = File.ReadLines(@"..\..\..\..\weapons.txt");
            string[] infoAboutWeapons = s.ToArray();
            int sCount = s.Count() / 5;
            int j = 0;
            int indexName = Array.IndexOf(infoAboutWeapons, name);
            if(indexName == -1)
            {
                Console.WriteLine("Такої зброї немає в переліку");
                return false;
            }
            else
            {
                //-----Save info values
                this.name = name;
                shotRange = float.Parse(infoAboutWeapons[indexName + 1]);
                caliber = float.Parse(infoAboutWeapons[indexName + 2]);
                maxSize = int.Parse(infoAboutWeapons[indexName + 3]);
                countOfBullets = maxSize;
                //-------Write info
                Console.WriteLine("\nWeapon Info:\n" +
                    $"   Name: {name}\n" +
                    $"   Shot Range: {shotRange}\n" +
                    $"   Caliber: {caliber}\n" +
                    $"   Max Size Of Magazine: {maxSize}\n");
                return true;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            
            bool checkValue = false;
            while (!checkValue)
            {
                Console.WriteLine("\nЩо бажаєте зробити?\n" +
                "   1 - Додати нову зброю\n" +
                "   2 - Дізнатись дані про вже додану\n" +
                "   3 - Покинути програму");
                int check = int.Parse(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("Введіть назву зброї, щоб додати або \"n\", щоб перестати додавати:");
                            string nameNewWeapon = Console.ReadLine();
                            if (nameNewWeapon != "n")
                            {
                                //--------input values------//
                                Console.Write("Тепер введіть дальність пострілу (в км): ");
                                string shotRangeString = Console.ReadLine();
                                shotRangeString = shotRangeString.Replace(".", ",");
                                float shotRange = float.Parse(shotRangeString);

                                Console.Write("Калібр: ");
                                string caliberString = Console.ReadLine();
                                caliberString = shotRangeString.Replace(".", ",");
                                float caliber = float.Parse(caliberString);

                                Console.Write("Вмісткість магазину: ");
                                int maxSize = int.Parse(Console.ReadLine());

                                //-------create new weapon--------
                                Weapon newObject = new Weapon();
                                newObject.Initialize(nameNewWeapon, shotRange, caliber, maxSize);

                                //------save objects-----
                                Console.WriteLine("Зберегти дані у файл?\n" +
                                    "1 - Yes\n" +
                                    "2 - No");
                                string checkSave = Console.ReadLine();
                                if(checkSave == "1" || checkSave == "Yes")
                                {
                                    newObject.Save();
                                }
                                else if(checkSave == "2" || checkSave == "No")
                                {
                                    Console.WriteLine("Вихід в головне меню...");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Такого варіанту немає...");
                                }
                            }
                            else
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введіть назву зброї або \"\\help\" щоб дізнатись наявну зброю");
                        string nameWeapon = Console.ReadLine();
                        if(nameWeapon == "\\help")
                        {
                            IEnumerable<string> s = new string[] { };
                            s = File.ReadLines(@"..\..\..\..\weapons.txt");
                            string[] fileInfo = s.ToArray();
                            for(int i = 0; i < fileInfo.Length; i += 5)
                            {
                                Console.WriteLine($"\t- {fileInfo[i]}");
                            }
                        }
                        else
                        {
                            Weapon loadObject = new Weapon();
                            bool checkLoad = loadObject.Load(nameWeapon);
                            if (checkLoad)
                            {
                                while (true)
                                {
                                    Console.WriteLine("Бажаєте зробити вистріл?\n" +
                                        "1 - Yes\n" +
                                        "2 - No");
                                    string checkShot = Console.ReadLine();
                                    if (checkShot == "1" || checkShot == "Yes")
                                    {
                                        bool checkBullets = loadObject.Shot();
                                        if (!checkBullets)
                                        {
                                            Console.WriteLine("Перезарядити зброю?" +
                                                "1 - Yes" +
                                                "2 - No");
                                            string checkRecharge = Console.ReadLine();
                                            if (checkRecharge == "1" || checkRecharge == "Yes")
                                            {
                                                loadObject.Recharge();
                                            }
                                            else if (checkRecharge == "2" || checkRecharge == "No")
                                            {
                                                Console.WriteLine("Вихід в головне меню...");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Такого варіанту немає...");
                                                break;
                                            }
                                        }
                                    }
                                    else if (checkShot == "2" || checkShot == "No")
                                    {
                                        Console.WriteLine("Вихід в головне меню...");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Такого варіанту немає...");
                                        break;
                                    }
                                }
                            }
                            
                        }
                        

                        break;
                    case 3:
                        checkValue = true;
                        Console.WriteLine("Дякуємо що завітали!");
                        break;
                    default:
                        Console.WriteLine("Такого варіанту відповіді немає...");
                        break;

                }
            }
            
            
        }
    }
}