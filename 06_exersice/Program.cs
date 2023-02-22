using System;

class Train
{
    // Class fields using nullable, const, readonly
    private string? trainNumber;
    private readonly string companyName;
    private readonly int maxSpeed;
    private int? passengerCount;
    private bool? isDelayed;

    // The default constructor
    public Train()
    {
        companyName = "Ukrzaliznytsia";
        maxSpeed = 120;
    }

    // Overloaded constructor with parameters
    public Train(string trainNumber, string companyName, int maxSpeed, int passengerCount, bool isDelayed)
    {
        trainNumber = trainNumber;
        companyName = companyName;
        maxSpeed = maxSpeed;
        passengerCount = passengerCount;
        isDelayed = isDelayed;
    }

    // Overloaded constructor with parameters
    public Train(string trainNumber, string companyName, int maxSpeed)
    {
        trainNumber = trainNumber;
        companyName = companyName;
        maxSpeed = maxSpeed;
    }

    // Class management methods
    public void SetTrainNumber(string trainNumber)
    {
        if (string.IsNullOrEmpty(trainNumber))
        {
            throw new ArgumentException("Train number cannot be empty");
        }

        trainNumber = trainNumber;
    }

    public void SetPassengerCount(int passengerCount)
    {
        if (passengerCount < 0)
        {
            throw new ArgumentException("Passenger count cannot be negative");
        }

        passengerCount = passengerCount;
    }

    public void SetIsDelayed(bool isDelayed)
    {
        isDelayed = isDelayed;
    }

    // Methods of accessing closed fields
    public string? GetTrainNumber()
    {
        return trainNumber;
    }

    public string GetCompanyName()
    {
        return companyName;
    }

    public int GetMaxSpeed()
    {
        return maxSpeed;
    }

    public int? GetPassengerCount()
    {
        return passengerCount;
    }

    public bool? GetIsDelayed()
    {
        return isDelayed;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Train[] trains = new Train[3];

        trains[0] = new Train();
        trains[1] = new Train("42", "Ukrzaliznytsia", 100, 300, true);
        trains[2] = new Train("13", "Ukrzaliznytsia", 150);

        Console.WriteLine(trains[0].GetCompanyName()); // Output: Ukrzaliznytsia

        trains[1].SetIsDelayed(false);

        Console.WriteLine(trains[1].GetIsDelayed()); // Output: False
    }
}