
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalApp.Controllers
{
    public class HomeController : Controller
    {
        private MyDatabase.ApplicationDbContext hollywooddb = new MyDatabase.ApplicationDbContext();
        private FinalApp.Models.ApplicationDbContext userdb = new FinalApp.Models.ApplicationDbContext();
       

        public ActionResult Index()
        {
            var orders = hollywooddb.MovieUserOrders.ToList();
            var movieTitles = from order in orders
                              join movie in hollywooddb.Movies on order.MovieId equals movie.MovieId
                              select new { title = movie.Title };

           return Json(movieTitles, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}