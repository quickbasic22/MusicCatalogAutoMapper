using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;


namespace MusicCatalogASP.NETCore.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureCreated();
            if (!context.Artists.Any())
            {
                context.Artists.Add(new Models.Artist() { ID = 1, Name = "We Lost The Sea" });
                context.Artists.Add(new Models.Artist() { ID = 2, Name = "Slint" });

                context.SaveChanges();

            }
            if (!context.Songs.Any())
            {
                context.Songs.Add(new Models.Song() { ID = 1, ArtistID = 1, Name = "A Gallant Gentleman", Length = 364 });
                context.Songs.Add(new Models.Song() { ID = 2, ArtistID = 1, Name = "Bogatyri", Length = 700 });
                context.Songs.Add(new Models.Song() { ID = 3, ArtistID = 1, Name = "The Last Dive Of David Shaw", Length = 1016 });
                context.Songs.Add(new Models.Song() { ID = 4, ArtistID = 2, Name = "Breadcrumb Trail", Length = 354 });
                context.Songs.Add(new Models.Song() { ID = 5, ArtistID = 2, Name = "Nosferatu Man", Length = 334 });
                context.Songs.Add(new Models.Song() { ID = 6, ArtistID = 2, Name = "Good Morning, Captain ", Length = 461 });
                context.Songs.Add(new Models.Song() { ID = 7, ArtistID = 2, Name = "Glenn", Length = 371 });

                context.SaveChanges();

            }

        }
    }
}
