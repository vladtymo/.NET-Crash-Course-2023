namespace Task5
{
    public sealed class Weapon
    {
        private float _firingRange;
        private float _calibre;

        public Weapon(float firingRange, float calibre, Magazine magarize)
        {
            _firingRange = firingRange;
            _calibre = calibre;
            Magazine = magarize;
        }

        public Magazine Magazine { get; private set; }

        public bool Shot() => Magazine.RemoveAmmo();

        public uint Reload(Magazine magarize)
        {
            Magazine = magarize;
            return Magazine.CurrentAmmo;
        }
    }
}