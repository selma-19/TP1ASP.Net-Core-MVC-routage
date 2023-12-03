using Microsoft.EntityFrameworkCore;


namespace tp1.Models
{
    public class ApplicationdbContext : DbContext
    {
        public ApplicationdbContext(DbContextOptions<ApplicationdbContext> options)
           : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasMany(m => m.Customers).WithMany(c => c.Movies);
            modelBuilder.Entity<Genres>().HasMany(g => g.movies).WithOne(m => m.Genre).HasForeignKey(m => m.GenreId).IsRequired(false);
            modelBuilder.Entity<MembershipType>().HasMany(m => m.Customers).WithOne(c => c.MembershipType).HasForeignKey(c => c.MembershipTypeId).IsRequired(false);
        }

    }
}
