using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16.Entities
{
    class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}
