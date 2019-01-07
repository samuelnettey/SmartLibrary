using Microsoft.EntityFrameworkCore;
using SmartLibrary.Domain;

namespace SmartLibrary.Data
{
    public interface ISmartLibraryContext
    {
        DbSet<Book> Books { get; set; }
        DbSet<Competition> Competitions { get; set; }
        DbContext Context { get; set; }
        DbSet<Member> Memebers { get; set; }
    }
}