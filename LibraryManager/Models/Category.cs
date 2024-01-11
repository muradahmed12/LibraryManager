using RestoranWeb.Models;

namespace LibraryManager.Models
{
    public class Category : SharedModel
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
