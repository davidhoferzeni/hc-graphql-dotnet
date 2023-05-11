public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Book> GetBook([Service] DatabaseContext context) =>
        context.Books;
}
 