using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using movieApp.Models;

namespace movieApp.Controllers;

public class MovieController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public MovieController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Details()
    {
        return View();
    }   
    public IActionResult List()
    {
        return View();
    }   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
