using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModel;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext db;

        public MovieController()
        {
            db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var Movies = db.Movies.Include(c => c.Genre).ToList();

            return View(Movies);
        }

        public ActionResult Details(int id)
        {
            var movies = db.Movies.Include(c => c.Genre).SingleOrDefault(x => x.Id == id);

            return View(movies);
        }

        [HttpGet]
        public ActionResult Create()
        {

            var movieGenre = db.Genres.ToList();

            var viewModel = new MovieViewModel { Genres = movieGenre };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(MovieViewModel movieViewModel)
        {

            var movie = movieViewModel.Movie;
            db.Movies.Add(movie);

            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                Console.WriteLine(e);
            }


            return RedirectToAction("Index");
        }
    }
}