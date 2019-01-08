using Microsoft.EntityFrameworkCore;
using SmartLibrary.Domain;

namespace SmartLibrary.Data
{
    public class SmartLibraryContext : DbContext, ISmartLibraryContext
    {
        public DbContext Context { get; set; }

        public DbSet<SmartLibrary.Domain.Member> Memebers { get; set; }
        public DbSet<SmartLibrary.Domain.Book> Books { get; set; }
        public DbSet<SmartLibrary.Domain.Competition> Competitions { get; set; }



        public SmartLibraryContext()
        {
                
        }




        public SmartLibraryContext(DbContextOptions<SmartLibraryContext> options)
            : base(options)
        {
            Context = this;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberCompetition>()
                .HasKey(m => new { m.MemberId, m.CompetitionId });  // configuring Many- Many
        }
    }
}
