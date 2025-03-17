using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Publisher
{
    [Key]
     public int PublisherId { get; set; }

    public string? Name { get; set; } 
    public string? Location { get; set; } 

    public List<Book>? Books { get; set; } 
}
