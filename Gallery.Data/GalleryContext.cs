using Gallery.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Gallery.Data
{
    public class GalleryContext : DbContext
    {
        public GalleryContext(DbContextOptions<GalleryContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Artwork> Artwork { get; set; }
        public DbSet<ArtworkType> ArtworkType { get; set; }
        public DbSet<Person> Person { get; set; }
    }
}
