using RestoranWeb.Models;

namespace LibraryManager.Models
{
    public class Fine : SharedModel
    {
        public string UserId { get; set; }
        public string BookId { get; set; }
        public decimal FineAmount { get; set; }
        public DateTime DueDate { get; set; }
        public bool PaidStatus { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
