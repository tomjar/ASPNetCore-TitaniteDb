using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using titanitedb.Data;
using titanitedb.Models;

namespace titanitedb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly TitanitesContext _context;

    public HomeController(ILogger<HomeController> logger, TitanitesContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpPost]
    [HttpGet]
    public IActionResult Index()
    {
        Titanite[]? titanites;


        titanites = _context.Titanites.ToArray();

        var data = titanites?
                .Take(100)
                .ToArray();

        return View("~/Views/Home/Index.cshtml", data);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }




}
