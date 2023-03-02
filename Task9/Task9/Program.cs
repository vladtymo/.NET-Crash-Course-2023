namespace Task9
{
    interface IInstrument
    {
        void Tune();
        void Play();
    }

    interface IStringInstrument : IInstrument
    {
        void PluckStrings();
    }

    interface IWindInstrument : IInstrument
    {
        void BlowAir();
    }

    class Guitar : IStringInstrument
    {
        public void Tune()
        {
            Console.WriteLine("Tuning the guitar.");
        }

        public void Play()
        {
            Console.WriteLine("Playing the guitar.");
        }

        public void PluckStrings()
        {
            Console.WriteLine("Plucking the guitar strings.");
        }
    }

    class Violin : IStringInstrument
    {
        public void Tune()
        {
            Console.WriteLine("Tuning the violin.");
        }

        public void Play()
        {
            Console.WriteLine("Playing the violin.");
        }

        public void PluckStrings()
        {
            Console.WriteLine("Plucking the violin strings.");
        }
    }

    class Harp : IStringInstrument
    {
        public void Tune()
        {
            Console.WriteLine("Tuning the harp.");
        }

        public void Play()
        {
            Console.WriteLine("Playing the harp.");
        }

        public void PluckStrings()
        {
            Console.WriteLine("Plucking the harp strings.");
        }
    }

    class Trumpet : IWindInstrument
    {
        public void Tune()
        {
            Console.WriteLine("Tuning the trumpet.");
        }

        public void Play()
        {
            Console.WriteLine("Playing the trumpet.");
        }

        public void BlowAir()
        {
            Console.WriteLine("Blowing air into the trumpet.");
        }
    }

    class Flute : IWindInstrument
    {
        public void Tune()
        {
            Console.WriteLine("Tuning the flute.");
        }

        public void Play()
        {
            Console.WriteLine("Playing the flute.");
        }

        public void BlowAir()
        {
            Console.WriteLine("Blowing air into the flute.");
        }
    }

    class Clarinet : IWindInstrument
    {
        public void Tune()
        {
            Console.WriteLine("Tuning the clarinet.");
        }

        public void Play()
        {
            Console.WriteLine("Playing the clarinet.");
        }

        public void BlowAir()
        {
            Console.WriteLine("Blowing air into the clarinet.");
        }

        public void ProduceSound()
        {
            Console.WriteLine("Producing sound with the clarinet.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IInstrument guitar = new Guitar();
            guitar.Tune();
            guitar.Play();
            ((IStringInstrument)guitar).PluckStrings();

            IInstrument violin = new Violin();
            violin.Tune();
            violin.Play();
            ((IStringInstrument)violin).PluckStrings();

            IInstrument harp = new Harp();
            harp.Tune();
            harp.Play();
            ((IStringInstrument)harp).PluckStrings();

            IInstrument trumpet = new Trumpet();
            trumpet.Tune();
            trumpet.Play();
            ((IWindInstrument)trumpet).BlowAir();

            IInstrument flute = new Trumpet();
            flute.Tune();
            flute.Play();
            ((IWindInstrument)flute).BlowAir();

            IInstrument clarnet = new Trumpet();
            clarnet.Tune();
            clarnet.Play();
            ((IWindInstrument)clarnet).BlowAir();
        }
    }
}