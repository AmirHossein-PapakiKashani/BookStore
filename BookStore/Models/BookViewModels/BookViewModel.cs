namespace BookStore.Models.BookViewModels
{
    public class BookViewModel
    {
        public Book Book { get; set; } = new Book();

        public IEnumerable<Author> Author { get; set; } = new List<Author>();

        public IEnumerable<Category> Categories { get; set; } = new List<Category>();


    }
}
