using System.Data.SqlTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using SmartLibrary.ConsoleApp.Domain;

namespace SmartLibrary.ConsoleApp.Data
{
    public class SmartLibraryConsoleContext : DbContext
    {
        public DbContext Context { get; set; }

        public DbSet<Member> Memebers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Competition> Competitions { get; set; }



        public static readonly LoggerFactory ConsoleLoggerFactory
            = new LoggerFactory(new[] {
                new ConsoleLoggerProvider((category, level)
                => category ==DbLoggerCategory.Database.Command.Name
                   && level == LogLevel.Information, true)

            });
   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(ConsoleLoggerFactory);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SmartLibraryConsoleDb;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberCompetition>()
                .HasKey(m => new { m.MemberId, m.CompetitionId });  // configuring Many- Many
        }
    }
}
