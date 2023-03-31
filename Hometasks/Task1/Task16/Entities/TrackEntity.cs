namespace Task16.Entities
{
    public class TrackEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }

        public long AlbumFK { get; set; }
        public AlbumEntity Album { get; set; }

        public List<PlaylistTracksEntity> PlaylistTracks { get; set; }
    }
}