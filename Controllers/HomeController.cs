using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using titanitedb.Data;
using titanitedb.Models;

namespace titanitedb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly TitaniteDbContext _context;

    public HomeController(TitaniteDbContext context, ILogger<HomeController> logger)
    {
        _logger = logger;
        _context = context;
    }

    [HttpPost]
    [HttpGet]
    public IActionResult Index()
    {

        MineralViewModel[] top100 = _context.Titanites.Take(100).Select(t => new MineralViewModel(t)).ToArray();


        MineralViewModel[] empty = Array.Empty<MineralViewModel>();
        return View(top100);
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
