using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Author{
    [Key]
    public int AuthorId { get; set; }
    
    public string? Name { get; set; }  
    public DateTime BirthDate { get; set; }
    
    public List<Book>? Books { get; set; } 
}