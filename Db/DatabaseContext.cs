using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
       : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        // modelBuilder.Entity<Author>()
        //        .HasMany(e => e.Books);

        var theAuthor = new Author { Id = 1, Name = "Timmy" };
        modelBuilder.Entity<Author>().HasData(theAuthor);
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, AuthorId = 1, Title = "The Book" },
            new Book { Id = 2, AuthorId = 1, Title = "Some More Book" },
           new Book { Id = 3, AuthorId = 1, Title = "Book The Third" });
    }

    public DbSet<Book>? Books { get; set; }
    public DbSet<Author>? Authors { get; set; }

}