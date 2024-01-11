using RestoranWeb.Models;

namespace LibraryManager.Models
{
    public class SFine : SharedModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal FineAmount {  get; set; }
        public string SFineId { get; set; }
        public SFine SFines { get; set; }
    }
}
