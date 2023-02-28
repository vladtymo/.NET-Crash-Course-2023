namespace dz8{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Cacatua cacatua = new Cacatua();
            cacatua.Show();
            cacatua.MakeNewSound();
            cacatua.Fly();

            Chamaeleo chamaeleo = new Chamaeleo();
            chamaeleo.Show();
            chamaeleo.MakeNewSound();
            chamaeleo.amIColdOrWarmBloodet();

            Xiphias xiphias = new Xiphias();
            xiphias.Show();
            xiphias.MakeNewSound();
            xiphias.amIInsaltyOrNotWater();  
        }
    }
}