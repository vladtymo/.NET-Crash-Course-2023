using Task9.Entities;

Animal sparrow = new Bird("House sparrow", 40, 0.025f);
Animal perch = new Fish("River perch", 4, 1, Task9.Enums.Environment.Lake);
Animal elephant = new Mammal("Loxodonta africana", 10, 5000, Task9.Enums.Environment.Desert, "у-у-у-у-у-ууу-у-у-у-у");
Animal chameleon = new Reptile("Scaly", 0.8f, 0.1f, Task9.Enums.Environment.Desert, "Non sound");

Animal[] zoo =
{
    sparrow, perch, elephant, chameleon,
};

foreach(Animal animal in zoo)
{
    animal.MakeSound();
    Console.WriteLine($"{animal.Kind} say {animal.Voise}\n");
}