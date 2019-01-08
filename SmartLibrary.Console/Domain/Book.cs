namespace SmartLibrary.ConsoleApp.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Tilte { get; set; }
        public Member Member { get; set; }
        public int MemberId { get; set; }
    }
}
