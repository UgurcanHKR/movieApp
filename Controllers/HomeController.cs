using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using movieApp.Data;
using movieApp.Models;

namespace movieApp.Controllers;

public class HomeController : Controller
{
    // Home/Index/3
    public IActionResult Index(int? id)
    {
        //ProductRepository.Movies
        //CategoryRepository.Categories
        //MovieCategoryModel model = new MovieCategoryModel();
        //model.Categories = CategoryRepository.Categories;
        //model.Movies = MovieRepository.Movies;
        var movies = MovieRepository.Movies;

        if (id!=null)
        {
            movies = movies.Where(i=>i.CategoryId == id).ToList();
        }

        return View(movies);
    }
    
    public IActionResult Details(int id)
    {
        //MovieCategoryModel model = new MovieCategoryModel();
        //model.Categories = CategoryRepository.Categories;
        //model.Movie = MovieRepository.GetById(id);

        return View(MovieRepository.GetById(id));
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
