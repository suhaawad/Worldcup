using Microsoft.EntityFrameworkCore;
using worldcup.Models;

namespace worldcup.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Cities>()
                    .HasOne(c => c.Province)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(p => p.ProvinceId); // Specify foreign key
                
                // One-to-many relationship: Schedule -> Stadium
                    modelBuilder.Entity<Schedule>()
                        .HasOne(s => s.Stadium)
                        .WithMany(st => st.Schedule)
                        .HasForeignKey(st => st.StadiumId);

                    // Configure the many-to-many relationship between Schedule and Team
                    modelBuilder.Entity<Schedule>()
                        .HasMany(s => s.Teams)
                        .WithMany(t => t.Schedules);
            }

        

        public DbSet<Categories> Categories { get; set; }
        public DbSet<TransportType> TransportType { get; set; }
        public DbSet<Stadiums> Stadiums { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Provinces> Provinces { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Transport> Transport { get; set; }
    }
}
