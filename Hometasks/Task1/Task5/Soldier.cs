namespace Task5
{
    public class Soldier
    {
        private Weapon _righthand;
        private ICollection<Magazine> _magarizes;

        public Soldier()
        {
            _magarizes = new List<Magazine>();
            _magarizes.Add(new Magazine(15, 30));
            _magarizes.Add(new Magazine(20, 30));
            _magarizes.Add(new Magazine(25, 30));

            _righthand = new Weapon(800, 7.62f, new Magazine(10, 30));
        }

        public Soldier(Weapon righthand, ICollection<Magazine> magarizes)
        {
            _righthand = righthand;
            _magarizes = magarizes;
        }

        public bool Shot() => _righthand.Shot();

        public bool CanShot => _righthand.Magazine.CurrentAmmo > 0;

        public bool Reload()
        {
            if (_magarizes.Count == 0)
            { 
                return false;
            }
            else
            {
                _righthand.Reload(_magarizes.First());
                _magarizes.Remove(_magarizes.First());
                return true;
            }
        }
    }
}