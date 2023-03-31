namespace Task16.Entities
{
    public class GenreEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<AlbumEntity> Albums { get; set; }
    }
}