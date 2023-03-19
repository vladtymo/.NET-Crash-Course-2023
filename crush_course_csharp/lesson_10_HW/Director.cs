
namespace lesson_10_HW
{
    public class Director : ICloneable
    {
        public string FirstName;
        public string LastName;
        public DateOnly? birthDate;
        public string? nationality;
        public Director(string name, string surname)
        {
            this.FirstName = name;
            this.LastName = surname;
            birthDate = null;
            nationality = null;
        }
        public Director(string name, string lastname, DateOnly birthDate, string nationality)
        {
            this.FirstName = name;
            this.LastName = lastname;
            this.birthDate = birthDate;
            this.nationality = nationality;
        }

        public override string ToString()
        {
            return $"Name: {FirstName}\nSurname: {LastName}\n" +
                $"Birth Date: {(birthDate == null ? "unknown" : birthDate.ToString())}\n" +
                $"Nationality: {(nationality == null ? "unknown" : nationality)}";
        }

        public object Clone()
        {
            return (Director)this.MemberwiseClone();
        }
    }
}
