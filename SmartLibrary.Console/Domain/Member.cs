using System.Collections.Generic;

namespace SmartLibrary.ConsoleApp.Domain
{



    public class Member
    {
        public Member()
        {
            Books = new List<Book>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SmartLibrary.ConsoleApp.Domain.Book> Books { get; set; }
        public List<MemberCompetition> Competitions { get; set; }
        public MemberIdentity MemberIdentity { get; set; }
    }
}
