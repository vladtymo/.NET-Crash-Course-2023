Console.Title = "Blue Bunny";

Console.WriteLine("Blue");
Console.WriteLine("Bunny");
Console.Write("Blue");
Console.Write("Bunny");

Console.WriteLine();
string login = Console.ReadLine();
Console.WriteLine(login);
int loginInt = Convert.ToInt32(login);
Console.WriteLine(loginInt);

/*
 * Escape sequences: 
 * \n - new
 * \t - tab
 * \", \', \\
 */

/*
 * Snippets:
 * cw + tab + tab - Console.WriteLine();
 * cr + tab + tab - Console.ReadLine() (custom);
 */

Console.ReadKey();