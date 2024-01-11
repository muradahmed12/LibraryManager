namespace LibraryManager.Models
{
    public class AuditTrail
    {
        public string Action { get; set; }
        public DateTime Timestamp { get; set; }
        public string Details { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
