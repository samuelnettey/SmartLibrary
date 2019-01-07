using System;

namespace SmartLibrary.Domain
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DueDate { get; set; }
    }
}
