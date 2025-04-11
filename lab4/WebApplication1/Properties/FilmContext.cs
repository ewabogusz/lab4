using Microsoft.EntityFrameworkCore;

public class FilmContext : DbContext
{
    public FilmContext(DbContextOptions<FilmContext> options)
        : base(options)
    {
    }
}