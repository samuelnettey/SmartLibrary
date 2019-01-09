using System;
using SmartLibrary.ConsoleApp.Data;
using SmartLibrary.ConsoleApp.Domain;

namespace SmartLibrary.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            InsertNewMember();
            Console.WriteLine("END");
            Console.ReadKey();
        }

        private static void InsertNewMember()
        {
            using (var ctx = new SmartLibraryConsoleContext())
            {
                ctx.Memebers.Add(new Member {Name = "Atta Sammy"});
                ctx.SaveChanges();
            }
        }
    }
}
