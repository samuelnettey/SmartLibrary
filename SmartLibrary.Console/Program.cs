using System;
using System.Collections.Generic;
using SmartLibrary.ConsoleApp.Data;
using SmartLibrary.ConsoleApp.Domain;

namespace SmartLibrary.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //InsertNewMember();
            //AddRangeOfNewCustomers();
            // AddUnrelatedObjects();
            //ObjectGraphs.InsertMemberObjectGraph();
            ObjectGraphs.InsertMemberObjectGraphNotTracked();


            Console.WriteLine("END");
            Console.ReadKey();
        }

        private static void AddUnrelatedObjects()
        {
            using (var ctx = new SmartLibraryConsoleContext())
            {
                var m1 = new Member {Name = "Doe Boy"};
                var b1 = new Book { Tilte = "Lost Symbol"};
                ctx.AddRange(m1, b1);
                ctx.SaveChanges();
            }
        }

        private static void AddRangeOfNewCustomers()
        {
            List<Member> members = new List<Member>
            {
                new Member {Name = "Joseph"},
                new Member{Name = "Thomas"} ,
                new Member{Name = "Christian"}

            };
            using (var ctx = new SmartLibraryConsoleContext())
            {
                ctx.Memebers.AddRange(members);
                ctx.SaveChanges();
            }
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
