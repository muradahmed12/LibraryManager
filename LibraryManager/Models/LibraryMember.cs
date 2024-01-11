using RestoranWeb.Models;

namespace LibraryManager.Models
{
    public class LibraryMember : SharedModel
    {
        public string Name { get; set; }
        public string ContactDetails { get; set; }
        public List<Borrowing> Borrowings { get; set; }

    }
}
