using Task6;

Console.WriteLine("Task6");

Train train = new Train();
train.Print();

train.AddCarriageToEnd(10);
train.AddCarriageToEnd(20);
train.AddCarriageToEnd(30);

Console.WriteLine();
train.Print();

train.AddCarriageToStart(100);
train.AddCarriageToStart(90);
train.AddCarriageToStart(80);
train.AddCarriageToStart(70);

Console.WriteLine();
train.Print();