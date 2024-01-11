namespace LibraryManager.Models
{
    public class Reservation
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime ReservationDate { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
