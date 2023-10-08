namespace BookStore.Models
{
    public class Book
    {
        public Book() => Authors = new HashSet<Author>();

        public int BookId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        
        public int? PublishYear { get; set; }

        public byte[]? Content { get; set; }
        

        public ICollection<Author> Authors { get; set; }//nav property

        public int CategoryId { get; set; }

        //navigation propetry
        public Category Category { get; set; } = null!;

        
    }
}
