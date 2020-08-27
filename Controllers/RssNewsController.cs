using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    //TODO: make the links from the chanel list in setting
    public class RssNewsController : Controller
    {
        // GET: RssNews
        public ActionResult Svd()
        {
            string url2 = "https://www.svd.se/?service=rss";
            var s = RssReader.Read(url2,"svd");
            s.Sort((x, y) => DateTime.Compare(y.PublicationDate, x.PublicationDate)); //descending order
            return View(s);
        }


        public ActionResult nt()
        {
            string url2 = "https://www.nt.se/rss/lokalt/norrkoping";
            var s = RssReader.Read(url2,"nt");
            s.Sort((x, y) => DateTime.Compare(y.PublicationDate, x.PublicationDate)); //descending order
            return View(s);
        }

        public ActionResult expressen()
        {
            string url2 = "https://feeds.expressen.se/nyheter/";
            var s = RssReader.Read(url2,"expressen");
            s.Sort((x, y) => DateTime.Compare(y.PublicationDate, x.PublicationDate)); //descending order
            return View(s);
        }

 




        public ActionResult Bycategory(string category)
        {
            string url2 = "https://www.svd.se/?service=rss";
            var s = RssReader.Read(url2,"svd");
            s.Sort((x, y) => DateTime.Compare(y.PublicationDate, x.PublicationDate)); //descending orders
            var filter_list = new List<RssNews>();
            foreach (var item in s)
            {
                //RssNews r = new RssNews();
                if (string.Equals(item.Category, category))
                {
                    filter_list.Add(item);
                }

            }
            return View(filter_list);
            //return Content(category);

        }



    }
}