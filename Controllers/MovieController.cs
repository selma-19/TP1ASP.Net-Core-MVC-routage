using Microsoft.AspNetCore.Mvc;
using tp1.Models;

namespace tp1.Controllers
{
    public class MovieController : Controller
    {

        [Route("/movie")]

        public IActionResult Index()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie{Id=1,Name="Test movie"},
                new Movie{Id=1,Name="Test movie"},
                new Movie{Id=2,Name="Test movie 2"}
            };
            return View(movies);
        }
        [Route("released/{month}/{year}")]
        public IActionResult ByRelease(int month, int year)
        {
            return Content(month + "/" + year);
        }
        
        [Route("movie/{id}")]


        public IActionResult Details(int? id)
        {
            if (id == null)
                return Content("id not found");
            var testDetails=getAllMovies().
                FirstOrDefault(x => x.Id == id);
            return View(testDetails);
        }
        private IEnumerable<Movie> getAllMovies()
        {
            var movies = new List<Movie>()
            {
                new Movie { Id = 1, Name = "TEST" },
                 new Movie { Id = 2, Name = "TEST2" },
                 new Movie { Id = 3, Name = "TEST3" }
            };
            return movies;
        }

    }
}
