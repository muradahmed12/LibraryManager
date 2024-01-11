namespace LibraryManager.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string ContactDetails { get; set; }
        public List<Borrowing> Borrowings { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<Fine> Fines { get; set; }
        public List<AuditTrail> AuditTrials { get; set; }

    }
}
