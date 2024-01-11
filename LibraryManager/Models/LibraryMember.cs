namespace LibraryManager.Models
{
    public class LibraryMember
    {
        public string Name { get; set; }
        public string ContactDetails { get; set; }
        public List<Borrowing> Borrowings { get; set; }

    }
}
