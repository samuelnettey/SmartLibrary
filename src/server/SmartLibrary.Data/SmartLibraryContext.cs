using Microsoft.EntityFrameworkCore;
using SmartLibrary.Domain;

namespace SmartLibrary.Data
{
    public class SmartLibraryContext : DbContext
    {
        public DbSet<Member> Memebers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Competition> Competitions { get; set; }


        public SmartLibraryContext(DbContextOptions<SmartLibraryContext> options)
            : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberCompetition>()
                .HasKey(m => new { m.MemberId, m.CompetitionId });  // configuring Many- Many
        }
    }
}
