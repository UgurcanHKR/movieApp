using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using movieApp.Data;
using movieApp.Models;

namespace movieApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(ProductRepository.Movies);
    }
    
    public IActionResult Details(int id)
    {
        return View(ProductRepository.GetById(id));
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
