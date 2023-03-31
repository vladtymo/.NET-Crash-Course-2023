namespace Task16.Entities
{
    public class AlbumEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseYear { get; set; }

        public long ArtistFK { get; set; }
        public ArtistEntity Artist { get; set; }

        public long GenreFK { get; set; }
        public GenreEntity Genre { get; set; }

        public List<TrackEntity> Tracks { get; set; }
    }
}