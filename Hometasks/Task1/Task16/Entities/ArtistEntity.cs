namespace Task16.Entities
{
    public class ArtistEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public long CountryFK { get; set; }
        public CountyEntity County { get; set; }

        public List<AlbumEntity> Albums { get; set; }
    }
}