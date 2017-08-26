using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModel;

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

        [HttpGet]
        public ActionResult Create()
        {

            var membershipTypess = db.MembershipTypes.ToList();

            var viewmodel = new CustomerViewModel
            {
                ViewModelMembershipTypes = membershipTypess
            };

            return View(viewmodel);
        }



        [HttpPost]
        public ActionResult Create(Customer customer)
        {

            db.Customers.Add(customer);
            db.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }


        public ActionResult Index()
        {
            var customers = db.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }
        public ActionResult Details(int id)
        {


            var customer = db.Customers.Include(x => x.MembershipType).SingleOrDefault(x => x.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }


            return View(customer);
        }



        public ActionResult Edit(int id)
        {


            var customer = db.Customers.SingleOrDefault(x => x.Id == id);
            var membershipType = db.MembershipTypes.ToList();

            var viewModel = new CustomerViewModel();
            viewModel.Customer = customer;
            viewModel.ViewModelMembershipTypes = membershipType;

            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(viewModel);
        }


        public ActionResult EditPost(Customer customer)
        {

            var customerindb = db.Customers.Single(x => x.Id == customer.Id);

            customerindb.Name = customer.Name;
            customerindb.Birthday = customer.Birthday;
            customerindb.IsSubscribeToNewsLetter = customer.IsSubscribeToNewsLetter;
           
            customerindb.MembershipTypeId = customer.MembershipTypeId;

            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}