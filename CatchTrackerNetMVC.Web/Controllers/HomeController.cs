using System.Diagnostics;
using CatchTrackerNetMVC.Web.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using CatchTrackerNetMVC.Web.Models;

namespace CatchTrackerNetMVC.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly StatsRepository _statsRepository;

    
    public HomeController(
        ILogger<HomeController> logger,
        StatsRepository statsRepository
    )
    {
        _logger = logger;
        _statsRepository = statsRepository;
    }

    public IActionResult Index()
    {
        IndexViewModel model = new IndexViewModel();

        model.YtdCatchStatsOverall = _statsRepository.YtdCatchStatsOverall();
        
        
        return View();
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