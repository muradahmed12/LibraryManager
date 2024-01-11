namespace LibraryManager.Models
{
    public class Borrowing
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
