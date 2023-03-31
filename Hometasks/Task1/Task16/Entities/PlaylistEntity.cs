namespace Task16.Entities
{
    public class PlaylistEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public List<PlaylistTracksEntity> PlaylistTracks { get; set; }

        public long CategoryFK { get; set; }
        public CategoryEntity Category { get; set; }
    }
}