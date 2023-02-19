namespace Task5
{
    public class Magazine
    {
        public Magazine(uint currentAmmo, uint ammoCapacity)
        {
            CurrentAmmo = currentAmmo;
            AmmoCapacity = ammoCapacity;
        }

        public uint CurrentAmmo { get; private set; }
        public uint AmmoCapacity { get; }

        public bool AddAmmo()
        {
            if(CurrentAmmo >= AmmoCapacity)
            {
                return false;
            }

            CurrentAmmo++;
            return true;
        }

        public bool RemoveAmmo()
        {
            if (CurrentAmmo > 0)
            {
                CurrentAmmo--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class MagazineLoader : ILoader<Magazine>
    {
        private const string PATH_TO_FILE = "Magazine.txt";

        public async void Save(bool append, Magazine value)
        {
            using (StreamWriter streamWriter = new StreamWriter(PATH_TO_FILE, append))
            {
                await streamWriter.WriteLineAsync(value.CurrentAmmo.ToString());
                await streamWriter.WriteLineAsync(value.AmmoCapacity.ToString());
            }
        }

        public async void Save(bool append, ICollection<Magazine> value)
        {
            // Creat the file
            if (!append)
            {
                using (StreamWriter cleaner = new StreamWriter(PATH_TO_FILE, false))
                {
                    await cleaner.WriteAsync("");
                }
            }

            foreach (Magazine magazine in value)
            {
                Save(true, magazine);
            }
        }

        public async Task<ICollection<Magazine>> Load()
        {
            List<Magazine> magazines = new List<Magazine>();
            using(StreamReader streamReader = new StreamReader(PATH_TO_FILE))
            {
                while(!streamReader.EndOfStream)
                {
                    string readLine = await streamReader.ReadLineAsync();
                    if (uint.TryParse(readLine, out uint currentAmmo))
                    {
                        readLine = await streamReader.ReadLineAsync();
                        if (uint.TryParse(readLine, out uint ammoCapacity))
                        {
                            magazines.Add(new Magazine(currentAmmo, ammoCapacity));
                        }
                        else
                        {
                            throw new Exception($"Can't read {readLine} as number");
                        }
                    }
                    else
                    {
                        throw new Exception($"Can't read {readLine} as number");
                    }
                }
            }
            return magazines;
        }
    }
}