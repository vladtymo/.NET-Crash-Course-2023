namespace dz12{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Wars wars = new Wars();
            Tank tank1 = new Tank("MBT","Abrams",15000);
            Tank tank2 = new Tank("MBT","Leopard",12000);
            Tank tank3 = new Tank("MT","T-34",5000);
            ArmoredCar armoredCar1 = new ArmoredCar("BMP","Breadly",1000);
            ArmoredCar armoredCar2 = new ArmoredCar("ACV","AMX-10RC",1000);
            ArmoredCar armoredCar3 = new ArmoredCar("ACV","Archer",1000);
            AirDefenseVehicle airDefenseVehicle1 = new AirDefenseVehicle("ZRK","Patriot",500);
            AirDefenseVehicle airDefenseVehicle2 = new AirDefenseVehicle("ZRK","C-300",500);
            AirDefenseVehicle airDefenseVehicle3 = new AirDefenseVehicle("ZRK","Starstreak",500);
            // tank.ShowInfo();
            // armoredCar.ShowInfo();
            // airDefenseVehicle.ShowInfo();
            wars.addCombatVehicle(tank1,1);
            wars.addCombatVehicle(tank2,2);
            wars.addCombatVehicle(tank3,1);
            wars.addCombatVehicle(armoredCar1,2);
            // wars.addCombatVehicle(armoredCar2,1);
            // wars.addCombatVehicle(armoredCar3,2);
            // wars.addCombatVehicle(airDefenseVehicle1,1);
            // wars.addCombatVehicle(airDefenseVehicle2,2);
            // wars.addCombatVehicle(airDefenseVehicle3,1);

            wars.Battle();
            
        }
    }
}