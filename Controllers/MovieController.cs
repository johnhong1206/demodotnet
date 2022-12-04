using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;
public class MovieController : Controller
{
    private static readonly List<MovieModel> movies = new List<MovieModel>();
     public IActionResult Index()
    {
        return View(movies);
    }
    public IActionResult Create()
    {   
        var movieVm = new MovieModel();
        return View(movieVm);
    }
    public IActionResult CreateMovie(MovieModel movieModel)
    {
        // return View("Index");
        movies.Add(movieModel);  
        return Json(movies);
    }
}