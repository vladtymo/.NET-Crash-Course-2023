namespace Task8
{
    public class ForeignPassport : Passport
    {
        public long Id { get; set; }
        public ICollection<Visa> Visas { get; set; }
    }
}