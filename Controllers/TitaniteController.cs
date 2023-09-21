using System.Collections.Immutable;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using titanitedb.Data;
using titanitedb.Models;

namespace titanitedb.Controllers;

public class TitaniteController : Controller
{
    private readonly IMemoryCache _memoryCache;
    private readonly TitaniteDbContext _context;

    public TitaniteController(TitaniteDbContext context, IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        Titanite[]? titanites;
        MineralViewModel[]? data = Array.Empty<MineralViewModel>();

        // checks to see if there is anything in the cache yet
        // otherwise just cache it and then return
        if (_memoryCache.TryGetValue("T1", out titanites))
        {

            data = titanites?.Select(t => new MineralViewModel(t))
                        .Take(100)
                        .ToArray();
        }
        else
        {
            titanites = await _context.Titanites.ToArrayAsync();
            _memoryCache.Set("T1", titanites);

            data = titanites?.Select(t => new MineralViewModel(t))
                    .Take(100)
                    .ToArray();
        }

        return View(data);
    }

    public async Task<IActionResult> Search(string searchString = "")
    {
        // MineralViewModel[] filtered = Array.Empty<MineralViewModel>();
        List<MineralViewModel> filtered = new List<MineralViewModel>();
        // simple search
        var results = await _context.Titanites?
        .Where(d =>
        d.latitude_max.Contains(searchString)
        || d.longitude_max.Contains(searchString)
        || d.rock_name.Contains(searchString)
        || d.sample_name.Contains(searchString)
        || d.mineral.Contains(searchString)
        || d.tectonic_setting.Contains(searchString))
        .Take(100)
        .ToArrayAsync();

        for (int i = 0; i <= results.Length; i++)
        {
            filtered.Add(new MineralViewModel(results[i]));
        }

        return View(filtered);
    }
}