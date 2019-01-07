using System.Collections.Generic;

namespace SmartLibrary.Domain
{



    public class Member
    {
        public Member()
        {
            Books = new List<Book>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        /// <summary>
        /// Many - Many- 
        /// </summary>
        public List<MemberCompetition> Competitions { get; set; }

        //One -One
        public MemberIdentity MemberIdentity { get; set; }
    }
}
// https://github.com/descco-tools/uml-library-management-system/blob/master/diagrams/class/library-management-system.svg