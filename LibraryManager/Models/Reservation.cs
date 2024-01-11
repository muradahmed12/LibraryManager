using RestoranWeb.Models;

namespace LibraryManager.Models
{
    public class Reservation : SharedModel
    {
        public string UserId { get; set; }
        public string BookId { get; set; }
        public DateTime ReservationDate { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
