using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartLibrary.ConsoleApp.Data;
using SmartLibrary.ConsoleApp.Domain;

namespace SmartLibrary.ConsoleApp
{
    public class ObjectGraphs
    {
        public static void InsertMemberObjectGraph()
        {
            var member = new Member
            {
                Name = "Zomi",
                Books = new List<Book>
                {
                 new Book  {Tilte = "Adam slow"},
                 new Book  {Tilte = "John Brew"},

                }

            };
            using (var ctx = new SmartLibraryConsoleContext())
            {
                ctx.Memebers.Add(member);
                ctx.SaveChanges();
            }
        }
        

        //Always use the parent key in the child object other than saving the the updared member
        public static void InsertMemberObjectGraphNotTracked()
        {
            using (var ctx = new SmartLibraryConsoleContext())
            {


                var member = ctx.Memebers.First();

                var book = new Book {Tilte = "Sam Jona", MemberId = member.Id};

                ctx.Books.Add(book);
                ctx.SaveChanges();
            }
        }
    }
}
