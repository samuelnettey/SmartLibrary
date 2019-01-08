using System;
using System.Collections.Generic;

namespace SmartLibrary.ConsoleApp.Domain
{
    public class Competition
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<MemberCompetition> Competitions { get; set; }
    }
}
