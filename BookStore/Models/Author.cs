using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Author
    {
        public Author() => Books = new HashSet<Book>();

        public int AuthorId { get; set; }

        [Required(ErrorMessage ="Please enter a name for author.")]
        public string AuthorName { get; set; } = string.Empty;

        public ICollection<Book> Books { get; set; }
    }
}
