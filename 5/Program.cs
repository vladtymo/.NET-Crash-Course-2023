internal class Program
{
    class Weapon{
        float range;
        float caliber;
        int bullets;
        int maxSize;

        public void Initialize(int r, float c, int ms){
            range = r;
            caliber = c;
            maxSize = ms;
            bullets = maxSize;
        }
        public bool Shot(){
            if(bullets > 0){
                --bullets;
                Console.WriteLine("Shoooooooot!!!");
                return true;
            }
            Console.WriteLine("No ammo");
            return false;
            
        }
        public void Recharge(){
            bullets = maxSize;
            Console.WriteLine("Reacharge completed");
        }
        public void Save(){       
            using (StreamWriter sw = new StreamWriter("weapon_data.txt")){
                sw.WriteLine(this.range);
                sw.WriteLine(this.caliber);
                sw.WriteLine(this.bullets);
                sw.WriteLine(this.maxSize);     
            }     
        }     
        public void Load() {
            using (StreamReader sr = new StreamReader("weapon_data.txt")){
                float line1 = float.Parse(sr.ReadLine());
                float line2 = float.Parse(sr.ReadLine());
                int line3 = int.Parse(sr.ReadLine());
                int line4 = int.Parse(sr.ReadLine());
                range = line1;
                caliber = line2;
                bullets = line3;
                maxSize = line4;
            }
        }
    }
    private static void Main(string[] args)
    {
        Weapon ak = new Weapon();
        ak.Initialize(525,7.62F,30);
        for(int i = 0; i<15;i++){
            ak.Shot();
        }
        ak.Save();
        ak.Recharge();
        
    }
}