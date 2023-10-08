namespace BookStore.Models
{
    public class Category
    {
        public Category() => Books = new HashSet<Book>(); 

        public int CategoryId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string LogoImage { get; set; } = string.Empty;//this use for logo

        public ICollection<Book> Books { get; set; }
    }
}
