using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Book
{
    [Key]
    public int BookId { get; set; }

    public string? Title { get; set; } 
    public int PublicationYear { get; set; }

    public int AuthorId { get; set; }
    [ForeignKey("AuthorId")]
    public Author? Author { get; set; }

    public int PublisherId { get; set; }
    [ForeignKey("PublisherId")]
    public Publisher? Publisher { get; set; } 
}
