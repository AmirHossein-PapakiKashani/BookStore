
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Models.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
       
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData
                (
                    new Book { BookId = 1 , CategoryId = 1, Title= "Introduction to Algorithm", PublishYear = 2009, Description = "This about science", Content = File.ReadAllBytes("wwwroot/books/2009 Introduction to Algorithms Third Ed.pdf") }
                );
        }

      
    }
   
  
}