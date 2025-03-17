using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Publisher> Publishers { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().HasData(
            new Author { AuthorId = 1, Name = "John Smith", BirthDate = new DateTime(2001, 1, 1) }
        );

        modelBuilder.Entity<Publisher>().HasData(
            new Publisher { PublisherId = 1, Name = "Tech Books", Location = "USA" }
        );
    }
}
