using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult Index()
        {          
            return View();
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


        public ActionResult Admin()
        {
            ViewBag.Message = "Your admin page.";

            return View();
        }


        public ActionResult News()
        {
            //ViewBag.Message = "Your news page.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Your blog page.";

            return View();
        }

        public ActionResult Sales()
        {
            ViewBag.Message = "Your sales page.";

            return View();
        }


        public ActionResult Coffee()
        {
            ViewBag.Message = "Your Coffee page.";

            return View();
        }


        public ActionResult Dessert()
        {
            ViewBag.Message = "Your Dessert page.";

            return View();
        }


        public ActionResult Sandwich()
        {
            ViewBag.Message = "Your Sandwich page.";

            return View();
        }


        public ActionResult Drinks()
        {
            ViewBag.Message = "Your Drinks page.";

            return View();
        }


        public ActionResult Other()
        {
            ViewBag.Message = "Your Other page.";

            return View();
        }

        public ActionResult Review()
        {
            ViewBag.Message = "Your Coffee page.";

            return View();
        }



    }
}