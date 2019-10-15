using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCatalogASP.NETCore.Models
{
    public class Artist
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
