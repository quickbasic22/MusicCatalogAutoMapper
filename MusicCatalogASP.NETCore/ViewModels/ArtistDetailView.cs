using MusicCatalogASP.NETCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace MusicCatalogASP.NETCore.ViewModels
{
    public class ArtistDetailView
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public int TotalTime
        {
            get
            {
                return Songs.Select(s => s.Length).Sum();
            }
        }
    }
}