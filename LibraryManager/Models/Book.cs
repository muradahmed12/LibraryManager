namespace LibraryManager.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool Availability { get; set; }
        public DateTime DueDate { get; set; }
        public List<Borrowing> Borrowings { get; set; }
        public List<Category> Categories { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<Fine> Fines { get; set; }
    }
}
