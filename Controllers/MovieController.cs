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

    [HttpGet]
    public JsonResult GetMovie()
    {
        var movie = new string[3]
        {
            "Iron Man",
            "Thor",
            "Avengers",
        };
        return new JsonResult(Ok(movie));
    }

    [HttpPost]
    public IActionResult CreateMovie(MovieModel movieModel)
    {
        // return View("Index");
        movies.Add(movieModel);  
        return Json(movies);
    }
    [HttpPost]
    public JsonResult TestPost(string firstName, string lastName)
    {
        string name = string.Format("Name: {0} {1}", firstName, lastName); ;
        return Json(new { Status = "success", Name = name });
    }

    [HttpPost]
    public JsonResult AjaxMethod(string name)
    {
        MovieModel person = new MovieModel
        {
        };
        return Json(person);
    }
}