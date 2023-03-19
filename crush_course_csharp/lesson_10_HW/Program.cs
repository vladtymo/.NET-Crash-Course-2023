
namespace lesson_10_HW
{
    public enum Genres { Бойовик = 1, Драма = 2, Детектив = 3, Історичний = 4, Комедія = 5, Фантастика = 6, Мелодрама = 7, Біографічні = 8, Фентезі = 9, Кримінал = 10, Мюзикл = 11, Спортивні = 12, Завершити = 0 };
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;


            //-------створення колекції фільмів
            Cinema films = new Cinema(2);

            //-------створення фільмів
            for(int i = 0; i < films.movies.Length; i++)
            {
                //--------зччитування основних даних
                Console.Write("Введіть назву фільму: ");
                string name = Console.ReadLine();
                Console.Write("Введіть опис: ");
                string description = Console.ReadLine();
                Console.Write("Країну: ");
                string country = Console.ReadLine();
                Console.Write("Рік випуску: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Рейтинг: ");
                double rating = double.Parse(Console.ReadLine());

                Console.Write("Введіть ім'я режисера: ");
                string directorFirstName = Console.ReadLine();
                Console.Write("Введіть прізвище режисера: ");
                string directorLastName = Console.ReadLine();
                Director director = films.CheckDirector(directorFirstName, directorLastName);
                if(director == null)
                {
                    Console.WriteLine("Бажаєте заповнити інші дані про режисера?\n" +
                        "1 - Yes\n2 - No");
                    string check = Console.ReadLine();
                    switch (check)
                    {
                        case "1":
                            Console.Write("Введіть дату народження: ");
                            DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
                            Console.Write("Введіть національність: ");
                            string nationality = Console.ReadLine();
                            director = new Director(directorFirstName, directorLastName, birthDate, nationality);
                            break;
                        case "2":
                            director = new Director(directorFirstName, directorLastName);
                            break;
                        default:
                            Console.WriteLine("Такого варіанту немає!");
                            director = new Director(directorFirstName, directorLastName);
                            break;
                    }
                }
                //---------вибір жанрів фільму
                Console.WriteLine("Оберіть жанри фільму: ");
                foreach (Genres genreObj in Enum.GetValues(typeof(Genres)))
                {
                    Console.WriteLine((int)genreObj + " - " + genreObj);
                }

                List<Genres> genres = new List<Genres>();
                Genres genre = Enum.Parse<Genres>(Console.ReadLine());

                bool checkGenre = false;
                while (!checkGenre)
                {
                    if ((int)genre != 0)
                    {
                        do
                        {
                            genres.Add(genre);
                            genre = Enum.Parse<Genres>(Console.ReadLine());
                        } while ((int)genre != 0);

                        checkGenre = true;
                    }
                    else
                    {
                        checkGenre = false;
                        Console.WriteLine("Фільм мусить мати жанр!!!");
                    }
                }
                //--------створення фільму у списку
                films.movies[i] = new Movie()
                {
                    Name = name,
                    Description = description,
                    Country = country,
                    Year = year,
                    Rating = rating,
                    director = director,
                    genres = genres
                };
            }
            Console.WriteLine(new string('-',40));
            foreach (Movie movie in films)
            {
                Console.WriteLine(movie.ToString());
            }

            Console.WriteLine(new string('-', 40));
            films.Sort();
            foreach (Movie movie in films)
            {
                Console.WriteLine(movie.ToString());
            }

            Console.WriteLine(new string('-', 40));
            IComparer<Movie> comparer = new CompareByRating();
            films.Sort(comparer);
            foreach (Movie movie in films)
            {
                Console.WriteLine(movie.ToString());
            }
        }
    }
}