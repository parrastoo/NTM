using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var channelList = new List<NewsChannel>();
            var news1 = new NewsChannel("svd", "https://www.svd.se/?service=rss");
            channelList.Add(news1);

            var news2 = new NewsChannel("nt", "https://www.nt.se/rss/lokalt/norrkoping");
            channelList.Add(news2);

            var news3 = new NewsChannel("expressen", "https://feeds.expressen.se/nyheter/");
            channelList.Add(news3);



            return View(channelList);
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