// -=-=-=-=-=-=-=- Cycels -=-=-=-=-=-=-=-
// while cycle: while(condition) { ...code... }

int counter = 0; // create once

while (counter < 10) // check 11 times
{
    Console.WriteLine("Good!");
    ++counter; // increment 10 times
}

// for cycle: for (initialize; condition; expression) { ...code... }

for (int i = 0; i < 10; ++i)
{
    Console.WriteLine(i + " - Excellent!");
}

// -------------------- randomize
Random random = new Random();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Random value: " + random.Next(20, 50));
}
