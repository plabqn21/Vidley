using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer

        private ApplicationDbContext db;

        public CustomerController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        public ActionResult Index()
        {
            var Customers = db.Customers.Include(c => c.MembershipType).ToList();
            return View(Customers);
        }
        public ActionResult Details(int Id)
        {


            var Customer = db.Customers.Include(x => x.MembershipType).SingleOrDefault(x => x.Id == Id);
            if (Customer == null)
            {
                return HttpNotFound();
            }


            return View(Customer);
        }



    }
}