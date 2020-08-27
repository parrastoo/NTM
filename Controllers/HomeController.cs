using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using WebApplication2.Models;
/*
This is home page
The controller for it is HomeController.cs
The view for is is Index
home page shows news from different sources in descending order.
category and image might exit or not I hard coded them in the controler
 */



namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        /*
         * Gets news feed from different sources and show it in descending order of date 
         */
        public ActionResult Index()
        {
            var s = RssReader.ReadAll();
            s.Sort((x, y) => DateTime.Compare(y.PublicationDate, x.PublicationDate)); //descending order
            return View(s);
        }

        /*
       * Action for the svd button, goes to the controller of svd which is RssNewsController with method svd
       */
        public ActionResult Svd()
        {
            ViewBag.Message = "SVD";

            return View();
        }

        /*
         * Action for the nt button, goes to the controller of nt which is RssNewsController with mehtod nt
        */
        public ActionResult nt()
        {
            ViewBag.Message = "NT";

            return View();
        }

        /*
        * Action for the expressen button, goes to the controller of nt which is RssNewsController with mehtod expressen
        */
        public ActionResult expressen()
        {
            ViewBag.Message = "Expressen";

            return View();
        }
    }
}
