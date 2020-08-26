using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


            var s = RssReader.ReadAll();
            s.Sort((x, y) => DateTime.Compare(y.PublicationDate, x.PublicationDate)); //descending order
            return View(s);




        }

  


        //Add New

        public ActionResult Svd()
        {
            ViewBag.Message = "SVD";

            return View();
        }

        public ActionResult nt()
        {
            ViewBag.Message = "NT";

            return View();
        }
        public ActionResult expressen()
        {
            ViewBag.Message = "Expressen";

            return View();
        }
    }
}