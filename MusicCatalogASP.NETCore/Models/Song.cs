using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCatalogASP.NETCore.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ArtistID { get; set; }
        public int Length { get; set; }

        public Artist Artist { get; set; }
    }
}
