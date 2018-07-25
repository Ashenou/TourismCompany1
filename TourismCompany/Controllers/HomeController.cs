using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TourismCompany.Controllers
{
    public class HomeController : Controller
    {

        TourismCompany.Models.TourismCompanydbDataContext db=new Models.TourismCompanydbDataContext();
        public ActionResult Index()
        {
           var result= db.Trips.Select(t=>t).ToList();
            return View(result);
        }
        public ActionResult Details(int id)
        {
                var result = (db.Trips.Select(t=>t).Where(b=>b.Id==id)).ToList();
                Models.Trip trip=result[0];
                return View(trip);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Reservation()
        {
            var TripsResult=db.Trips.Select(b=>b);
            SelectList tripslist=new SelectList(TripsResult,"Id","Name");
            ViewBag.TripsList=tripslist;
            return View();
        }
        [HttpPost]
        public ActionResult Reservation(Models.User usermodel)
        {
        db.Users.InsertOnSubmit(usermodel);
        db.SubmitChanges();


           return RedirectToAction("Index","Home");
        }
  
    }
}
