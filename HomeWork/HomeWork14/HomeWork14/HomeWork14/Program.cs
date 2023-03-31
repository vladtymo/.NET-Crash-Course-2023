using HomeWork14.Data;
using Microsoft.EntityFrameworkCore;

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

                var result = context.Tracks.ToList();

                Console.WriteLine("----------- Tracks:");
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.TrackId}: {item.Name} ({item.Duration})");
                }

                Console.WriteLine("What would you like to do? (I)nsert playlist or (D)elete playlist?");
                var input = Console.ReadLine();

                if (input.ToLower() == "i")
                {
                    // INSERT

                    Console.Write("Enter playlist name:");
                    var playlistName = Console.ReadLine();
                    Console.Write("Enter playlist category:");
                    var playlistCategory = Console.ReadLine();
                    var newPlaylist = new Playlist()
                    {
                        Name = playlistName,
                        Category = playlistCategory,
                        Tracks = new List<Track>()
                    };
                    context.Playlists.Add(newPlaylist);
                    context.SaveChanges();



                    string response;

                    do
                    {
                        Console.Write("Enter track name and duration (mm:ss):");
                        var track = new Track()
                        {
                            Name = Console.ReadLine(),
                            Duration = TimeSpan.Parse($"00:{Console.ReadLine()}")
                        };
                        newPlaylist.Tracks.Add(track);

                        Console.WriteLine($"Track {track.Name} has been added to the playlist.");
                        Console.WriteLine($"There are now {newPlaylist.Tracks.Count} tracks in the playlist.");


   

                        Console.WriteLine("Add another track (y/n)?");
                        response = Console.ReadLine();
                    } while (response.ToLower() == "y");

                    // UPDATE
                    if (artist1 != null)
                    {
                        artist1.FirstName += " de";
                        context.SaveChanges();
                    }
                }



                if (input.ToLower() == "d")
                {
                    // DELETE
                    Console.Write("Enter the ID of the track you want to delete:");
                    // get by id
                    Console.WriteLine("Enter Tracks id to find:");
                    int id = int.Parse(Console.ReadLine());

                    var tracks = context.Tracks.Find(id);

                    if (tracks == null) Console.WriteLine("Tracks with your id not found!");
                    else
                        Console.WriteLine($"Found tracks: {tracks.TrackId} {tracks.Name}!");

                    if (tracks != null)
                    { 
                    int trackId = id;
                    var trackToDelete = context.Tracks.Find(trackId);
                    if (trackToDelete != null)
                    {
                        context.Tracks.Remove(trackToDelete);
                        context.SaveChanges();
 
                        Console.WriteLine($"Track {trackId} has been deleted from the playlist.");

                    }
                    }
                }




            }




        }
    }

}