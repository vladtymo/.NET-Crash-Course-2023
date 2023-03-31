namespace Task16.Entities
{
    public class CategoryEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public List<PlaylistEntity> Playlists { get; set; }
    }
}