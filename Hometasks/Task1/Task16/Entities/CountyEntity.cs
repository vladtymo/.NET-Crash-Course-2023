namespace Task16.Entities
{
    public class CountyEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Code { get; set; }

        public List<ArtistEntity> Artists { get; set; }
    }
}