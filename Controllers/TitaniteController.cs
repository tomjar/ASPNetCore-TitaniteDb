using Microsoft.AspNetCore.Mvc;
using titanitedb.Data;
using titanitedb.Models;

namespace titanitedb.Controllers;

public class TitaniteController : Controller
{
    private readonly TitanitesContext _context;

    public TitaniteController(TitanitesContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        Titanite[]? titanites;


        titanites = _context.Titanites.ToArray();

        var data = titanites?
                .Take(100)
                .ToArray();
        
        return View("~/Views/Home/Index.cshtml",data);
    }

    public IActionResult Search(string searchString = "")
    {
        Console.WriteLine(searchString);
        var results = Titanite.Search(_context, searchString);

        return View("~/Views/Home/Index.cshtml", results);
    }
}