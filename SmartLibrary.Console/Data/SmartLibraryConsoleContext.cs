using Microsoft.EntityFrameworkCore;
using SmartLibrary.ConsoleApp.Domain;

namespace SmartLibrary.ConsoleApp.Data
{
    public class SmartLibraryConsoleContext : DbContext
    {
        public DbContext Context { get; set; }

        public DbSet<Member> Memebers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Competition> Competitions { get; set; }


   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SmartLibraryConsoleDb;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberCompetition>()
                .HasKey(m => new { m.MemberId, m.CompetitionId });  // configuring Many- Many
        }
    }
}
