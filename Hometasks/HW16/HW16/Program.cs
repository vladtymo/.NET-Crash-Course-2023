using HW16.Entities;
using Microsoft.EntityFrameworkCore;

namespace HW16
{
    internal class Program
    {
        static void AddPlaylist(MusicAppDbContext context)
        {
            Console.Write("Enter playlist name: ");
            string name = Console.ReadLine();

            Console.Write("Enter playlist category: ");
            string category = Console.ReadLine();

            List<Track> tracks = new();
            char isContinued = 'y';

            while(isContinued == 'y' || isContinued == 'Y')
            {
                Console.Write("Enter track name: ");
                string trackName = Console.ReadLine();

                Console.Write("Enter album name: ");
                string albumName = Console.ReadLine();
                Album album = new Album();
                foreach (Album album1 in context.Albums)
                {
                    if(album1.Name == albumName) { album = album1; }
                }
                if (album == null)
                {
                    Console.WriteLine("Album with this name not found! Try again...\n"); 
                    continue;
                }

                Console.Write("Enter track duration: ");
                decimal trackDuration = Decimal.Parse(Console.ReadLine());

                tracks.Add(new Track()
                {
                    Name = trackName,
                    AlbumId = album.Id,
                    Album = album,
                    Duration = trackDuration,
                });
                
                Console.Write("Track added to playlist!\nWanna add one more?\nEnter(y/n): ");
                isContinued = Char.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            context.Playlists.Add(new Playlist()
            {
                Name = name,
                Category = category,
                Tracks = tracks
            });
            context.SaveChanges();
        }
        static void Main(string[] args)
        {
            MusicAppDbContext context = new MusicAppDbContext();
            //context.Albums.Add(new Album()
            //{
            //    Name = "The Search",
            //    ArtistId = 1,
            //    Artist = context.Artists.Find(0)
            //});
            //context.Albums.Add(new Album()
            //{
            //    Name = "HOTIN",
            //    ArtistId = 2,
            //    Artist = context.Artists.Find(1)
            //});
            //context.Albums.Add(new Album()
            //{
            //    Name = "Meteora",
            //    ArtistId = 3,
            //    Artist = context.Artists.Find(2)
            //});
            //context.Albums.Add(new Album()
            //{
            //    Name = "Made in UA",
            //    ArtistId = 4,
            //    Artist = context.Artists.Find(3)
            //});
            //context.Albums.Add(new Album()
            //{
            //    Name = "Montero",
            //    ArtistId = 5,
            //    Artist = context.Artists.Find(4)
            //});
            //context.SaveChanges();

            foreach (Album album in context.Albums)
            {
                Console.WriteLine(album.Name);
            }
            AddPlaylist(context);
        }
    }
}