using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16.Entities
{
    class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        public decimal Duration { get; set; }
    }
}
