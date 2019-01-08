namespace SmartLibrary.ConsoleApp.Domain
{
    public class MemberCompetition
    {

        public int MemberId { get; set; }
        public Member Member { get; set; }
        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }
    }
}
