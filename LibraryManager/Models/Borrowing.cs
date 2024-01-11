using RestoranWeb.Models;

namespace LibraryManager.Models
{
    public class Borrowing : SharedModel
    {
        public string UserId { get; set; }
        public string BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
