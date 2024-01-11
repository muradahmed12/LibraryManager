namespace LibraryManager.Models
{
    public class Fine
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public decimal FineAmount { get; set; }
        public DateTime DueDate { get; set; }
        public bool PaidStatus { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
