using Microsoft.EntityFrameworkCore;

namespace ProductManagementSystem.Models
{
    // class representing Database
    public class TeaContext : DbContext
    {
        public TeaContext(DbContextOptions<TeaContext> options):base(options)
        {

        }
        public DbSet<Tea> Teas { get; set; }
        public DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // data seeding
            modelBuilder.Entity<Type>().HasData(
                new Type { TypeID = 1, TypeName = "Black"},
                new Type { TypeID = 2, TypeName = "Green"},
                new Type { TypeID = 3, TypeName = "White"},
                new Type { TypeID = 4, TypeName = "Oolong"},
                new Type { TypeID = 5, TypeName = "Puerh"},
                new Type { TypeID = 6, TypeName = "Purple"},
                new Type { TypeID = 7, TypeName = "Herbal"}
                );

            modelBuilder.Entity<Tea>().HasData(
                new Tea() { Id = 1, TypeID = 2, TypeOfTea = Models.Types.Green, Name = "Sencha", Description = "Sencha is a type of Japanese ryokucha which is prepared by infusing the processed whole tea leaves in hot water", ImageName = "sencha.jpg", Price = 16.99 },
                new Tea() { Id = 2, TypeID = 3, TypeOfTea = Models.Types.White, Name = "White Tea", Description = "White tea may refer to one of several styles of tea which generally feature young or minimally processed leaves of the Camellia sinensis plant", ImageName = "whitetea.jpg", Price = 8.99 },
                new Tea() { Id = 3, TypeID = 2, TypeOfTea = Models.Types.Green, Name = "Matcha", Description = "Matcha is a Chinese green tea variety that is unique for its harvesting, processing, and preparation methods. Three or four weeks before the harvest, the bush (Camellia sinensis) is covered to prevent direct sunlight, allowing the leaves to grow in the shade.", ImageName = "matcha.jpg", Price = 24.99 }
                );
        }
    }
}
