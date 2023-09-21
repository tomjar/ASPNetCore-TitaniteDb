using Microsoft.EntityFrameworkCore;
using titanitedb.Models;

public static class ModelBuilderExtensions
{
    /// <summary>
    /// Adds a extension method on the ModelBuilder
    /// </summary>
    /// <param name="modelBuilder"></param>
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Titanite>().HasData(
            titanitedb.Utility.CsvParser.GetTitanitesFromLocalCsvFile()
        );
        // modelBuilder.Entity<Book>().HasData(
        //     new Book { BookId = 1, AuthorId = 1, Title = "Hamlet" },
        //     new Book { BookId = 2, AuthorId = 1, Title = "King Lear" },
        //     new Book { BookId = 3, AuthorId = 1, Title = "Othello" }
        // );
    }
}