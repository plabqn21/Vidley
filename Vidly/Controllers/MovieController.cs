using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

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

        public ActionResult Details(int Id)
        {
            var Movies = db.Movies.Include(c => c.Genre).SingleOrDefault(x => x.Id == Id);

            return View(Movies);
        }
    }
}