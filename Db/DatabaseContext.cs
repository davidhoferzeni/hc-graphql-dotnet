using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
       : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().HasData(
            new Author { Id = 1, Name = "Timmy" },
            new Author { Id = 2, Name = "J.R.R. Tolkien" }
        );
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, AuthorId = 1, Title = "The Book" },
            new Book { Id = 2, AuthorId = 1, Title = "Some More Book" },
            new Book { Id = 3, AuthorId = 1, Title = "Book The Third" },
            new Book { Id = 4, AuthorId = 2, Title = "The Fellowship of the Ring" },
            new Book { Id = 5, AuthorId = 2, Title = "The Two Towers" },
            new Book { Id = 6, AuthorId = 2, Title = "The Return of the King" });
    }

    public DbSet<Book>? Books { get; set; }
    public DbSet<Author>? Authors { get; set; }

}