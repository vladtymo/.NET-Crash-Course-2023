namespace Task16.Entities
{
    public class PlaylistTracksEntity
    {
        public long PlaylistFK { get; set; }
        public PlaylistEntity Playlists { get; set; }

        public long TrackFK { get; set; }
        public TrackEntity Tracks { get; set; }
    }
}