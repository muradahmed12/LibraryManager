using RestoranWeb.Models;

namespace LibraryManager.Models
{
    public class Fine : SharedModel
    {
        public DateTime DueDate { get; set; }
        public bool PaidStatus { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; }
        public List<SFine> FineList { get; set; }
    }
}
