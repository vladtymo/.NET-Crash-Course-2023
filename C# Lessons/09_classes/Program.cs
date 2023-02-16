namespace _09_classes
{
    // Object-Oriented Programming
    /* Principles: 
     *  - incapsulation
     *  - inheritance
     *  - polymorphism
     */


    // ------ object prototype
    class Conditioner
    {
        // access specifiers:
        // private (by default) - access only from the class
        // public - access from everywhere

        enum PowerType { LOW, MEDIUM, HIGH, TURDO }
        enum ModeType { DRY, COOL, HEAT }

        // properties
        string model; // private by default
        private int year;
        private string color;
        private int minTemperature; // 16
        private int maxTemperature; // 32
        private float currentTemperature;
        private PowerType power;
        private ModeType mode;
        private bool isPowerOn;

        // default values: bool: false, number: 0, reference: null

        // methods (public interface)
        // return_type name(parameters) { ...code... }

        public void Initializer(string m, int y, string c)
        {
            model = m;
            year = y;
            color = c;
            minTemperature = 16;
            maxTemperature = 32;
            currentTemperature = minTemperature;
            power = PowerType.LOW;
            mode = ModeType.COOL;
            isPowerOn = false;
        }

        public void SwitchPower()
        {
            isPowerOn = !isPowerOn;
        }

        public void IncreaseT()
        {
            // data validation
            if (currentTemperature < maxTemperature)
                currentTemperature += 0.5F;
        }
        public void DecreaseT()
        {
            if (currentTemperature > minTemperature)
                currentTemperature -= 0.5F;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Model: {model} {color} {year}\n" +
                $"Temperature: {minTemperature} -> {currentTemperature} <- {maxTemperature} ^C\n" +
                $"Power status: {(isPowerOn ? "ON" : "OFF")}\n" +
                $"{new string('-', 40)}\n");

            // ternary operator: (condition ? value1 : value2);
            // return value1 of condition is true, otherwise - value2
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // ------ object instance
            Conditioner my = new Conditioner(); // default constructor

            my.Initializer("Phillips", 2022, "White");

            my.SwitchPower();

            for (int i = 0; i < 50; i++)
                my.IncreaseT();

            //my.currentTemperature = -555; // cannot modify private members
            my.ShowInfo();

            Conditioner your = new Conditioner();

            your.Initializer("Samsung", 2018, "Black");
            your.SwitchPower();

            your.IncreaseT(); your.IncreaseT(); your.IncreaseT();

            your.ShowInfo();
        }
    }
}