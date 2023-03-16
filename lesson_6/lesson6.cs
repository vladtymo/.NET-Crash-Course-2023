using System;

class Airplane{
    private string model;
    private int? passengerCapacity;
    private double fuelСapacity;
    private readonly double maxSpeed;
    private bool isThePlaneFlying;
    public Airplane(string model, int? passengerCapacity, double fuelСapacity, double maxSpeed){
        this.model = model;
        this.passengerCapacity = passengerCapacity;
        this.fuelСapacity = fuelСapacity;
        this.maxSpeed = maxSpeed;
        isThePlaneFlying = false;
    }
    public Airplane(string model, double fuelСapacity, double maxSpeed):this(model, null, fuelСapacity, maxSpeed){
        //this for an explicit constructor call
    }
    public string GetModel(){
        return model;
    }
    public int? GetPassengerCapacity(){
        return passengerCapacity;
    }
    public void SetPassengerCapacity(int? passengerCapacity){
        this.passengerCapacity = passengerCapacity;
    }
    public double GetFuelCapacity(){
        return fuelСapacity;
    }
    public void SetFuelCapacity(double fuelСapacity){
        this.fuelСapacity = fuelСapacity;
    }
    public double GetMaxSpeed(){
        return maxSpeed;
    }
    public void TakeOff(){
        if(isThePlaneFlying){
            Console.WriteLine("The plane is flying now");
        } else {
            isThePlaneFlying = true;
            Console.WriteLine("Plane takes off");
        }
    }
    public void Landing(){
        if(isThePlaneFlying){
            isThePlaneFlying = false;
            Console.WriteLine("The plane is landing");
        } else {
            Console.WriteLine("The plane has already landed");
        }
    }
    public void Refueling(double amount){
        fuelСapacity += amount;
        Console.WriteLine($"The plane refueled on {amount} liters");
    }
}

class Program{
    static void Main(string[] args){
        Airplane firstAirplane = new Airplane("Boeing", 150, 2100, 600);
        Console.WriteLine($"Model: {firstAirplane.GetModel()}");
        Console.WriteLine($"PassengerCapacity: {firstAirplane.GetPassengerCapacity()}");
        Console.WriteLine($"FuelСapacity: {firstAirplane.GetFuelCapacity()}");
        Console.WriteLine($"MaxSpeed: {firstAirplane.GetMaxSpeed()}");
        firstAirplane.TakeOff();
        firstAirplane.TakeOff();
        firstAirplane.TakeOff();
        firstAirplane.Landing();
        firstAirplane.Refueling(5000);
        firstAirplane.SetFuelCapacity(325);
        Console.WriteLine($"Updated capacity of people: {firstAirplane.GetPassengerCapacity()}");
    }
}