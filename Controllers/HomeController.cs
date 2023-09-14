using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using titanitedb.Models;
using titanitedb.Utility;

namespace titanitedb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private IMemoryCache _memoryCache;

    public HomeController(ILogger<HomeController> logger, IMemoryCache memoryCache)
    {
        _logger = logger;
        _memoryCache = memoryCache;
    }

    [HttpPost]
    [HttpGet]
    public IActionResult Index(string searchString = "")
    {
        Titanite[]? titanites;
        MineralViewModel[]? data = Array.Empty<MineralViewModel>();

        // checks to see if there is anything in the cache yet
        // otherwise just cache it and then return
        if (_memoryCache.TryGetValue("T1", out titanites))
        {

            data = titanites?.Select(t => new MineralViewModel()
            {
                lat_max = t.latitude_max,
                long_max = t.longitude_max,
                rock_name = t.rock_name,
                sample_name = t.sample_name,
                mineral = t.mineral,
                tectonic_setting = t.tectonic_setting
            })
                        .Take(250)
                        .ToArray();

        }
        else
        {
            titanites = CsvParser.GetTitanitesFromLocalCsvFile();
            _memoryCache.Set("T1", titanites);

            data = titanites?.Select(t => new MineralViewModel()
            {
                lat_max = t.latitude_max,
                long_max = t.longitude_max,
                rock_name = t.rock_name,
                sample_name = t.sample_name,
                mineral = t.mineral,
                tectonic_setting = t.tectonic_setting
            })
                    .Take(250)
                    .ToArray();
        }

        // simple search
        if (!string.IsNullOrEmpty(searchString))
        {
            var filtered = data?.Where(d =>
            d.lat_max.Contains(searchString, StringComparison.OrdinalIgnoreCase)
            || d.long_max.Contains(searchString, StringComparison.OrdinalIgnoreCase)
            || d.rock_name.Contains(searchString, StringComparison.OrdinalIgnoreCase)
            || d.sample_name.Contains(searchString, StringComparison.OrdinalIgnoreCase)
            || d.mineral.Contains(searchString, StringComparison.OrdinalIgnoreCase)
            || d.tectonic_setting.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            .ToArray();
            return View(filtered);
        }

        return View(data);
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
