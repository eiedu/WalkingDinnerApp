using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WalkingDinnerWeb.Controllers
{
    public class HomeController : Controller
    {
        //TODO: People should be able to edit their profile/duo model
        //TODO: People should see a list of dinners and should be able to be invited
        //TODO: People should be able to generate a dinner
        //TODO: People should Have an IBAN Number so people know where to deposit money / DONE
        //TODO: people should be able to see the applicants for their dinner and check if they deposited money and accept their applications


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
    }
}