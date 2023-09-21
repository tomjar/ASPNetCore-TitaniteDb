using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using titanitedb.Models;

namespace titanitedb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;


    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    [HttpGet]
    public IActionResult Index()
    {
        MineralViewModel[] empty = Array.Empty<MineralViewModel>();
        return View(empty);
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
