using HomeWork14.Data;

namespace HomeWork14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LibraryDbContext())
            {
                var artist1 = new Artist { FirstName = "Freddie", LastName = "Mercury", Country = "UK", Albums = new List<Album>() };
                var artist2 = new Artist { FirstName = "John", LastName = "Lennon", Country = "UK", Albums = new List<Album>() };


                var album1 = new Album { Name = "A Night at the Opera", Artist = artist1, Year = 1976, Genre = "Rock", Tracks = new List<Track>() };
                var album2 = new Album { Name = "Imagine", Artist = artist2, Year = 1971, Genre = "Rock", Tracks = new List<Track>() };

                context.Albums.Add(album1);
                context.Albums.Add(album2);

                var track1 = new Track { Name = "Bohemian Rhapsody", Album = album1, Duration = new TimeSpan(0, 6, 6), Playlists = new List<Playlist>() };
                var track2 = new Track { Name = "You're My Best Friend", Album = album1, Duration = new TimeSpan(0, 2, 52), Playlists = new List<Playlist>() };
                var track3 = new Track { Name = "Imagine", Album = album2, Duration = new TimeSpan(0, 3, 4), Playlists = new List<Playlist>() };
                var track4 = new Track { Name = "Jealous Guy", Album = album2, Duration = new TimeSpan(0, 4, 17), Playlists = new List<Playlist>() };

                album1.Tracks.Add(track1);
                album1.Tracks.Add(track2);
                album2.Tracks.Add(track3);
                album2.Tracks.Add(track4);

                var playlist1 = new Playlist { Name = "Rock Classics", Category = "Rock", Tracks = new List<Track> { track1, track2, track3, track4 } };
                var playlist2 = new Playlist { Name = "John Lennon Tribute", Category = "Rock", Tracks = new List<Track> { track3, track4 } };

                track1.Playlists.Add(playlist1);
                track2.Playlists.Add(playlist1);
                track3.Playlists.Add(playlist1);
                track3.Playlists.Add(playlist2);
                track4.Playlists.Add(playlist1);
                track4.Playlists.Add(playlist2);

                context.Artists.Add(artist1);
                context.Artists.Add(artist2);

                context.SaveChanges();
            }
        }
    }

}