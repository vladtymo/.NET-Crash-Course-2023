namespace task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director1 = new Director("Guy", "Ritchie", 21);
            Director director2 = new Director("Peter ", "Jackson", 55);
            Director director1Copy = (Director)director1.Clone();
            director1.CountFilms = 10;

            Movies movies1 = new Movies("The Gentlemen", director1, Movies.Genre.Comedy, 2019, 8);
            Movies movies2 = new Movies("The Lord of the Rings: The Fellowship of the Ring", director2, Movies.Genre.Adventure, 2001, 9);
            Movies copyMov1 = (Movies)movies1.Clone();

            Movies[] mov = new Movies[3];
            mov[0] = copyMov1;
            mov[1] = movies1;
            mov[2] = movies2;
            Cinema cinema = new Cinema(mov, "St 91");
            Console.WriteLine("\n----------------------------------------------------------------\n");
            Console.WriteLine("Director 1\n" + director1);
            Console.WriteLine("\n----------------------------------------------------------------\n");
            Console.WriteLine("Clone \n" + director1Copy);
            Console.WriteLine("\n----------------------------------------------------------------\n");
            Console.WriteLine("Director 2\n" + director2);
            Console.WriteLine("\n----------------------------------------------------------------\n");
            /* Console.WriteLine("Movie 1\n" + movies1);
             Console.WriteLine("\n----------------------------------------------------------------\n");
             Console.WriteLine("Movie 2\n" + movies2);
             Console.WriteLine("\n----------------------------------------------------------------\n");
             Console.WriteLine("Movie copy\n" + copyMov1);
             Console.WriteLine("\n----------------------------------------------------------------\n");*/

            foreach (Movies item in cinema)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\n----------------------------------------------------------------\n");

            cinema.Sort();
            foreach (Movies item in cinema)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\n----------------------------------------------------------------\n");



        }
    }
}