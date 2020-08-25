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
            var s = RssReader.Read(url2);
            StringBuilder sb = new StringBuilder();
            foreach (RssNews rs in s)
            {
                sb.AppendLine("title: " + rs.Title);
                sb.AppendLine("text :" + rs.Text);
                sb.AppendLine("pb : " + rs.PublicationDate);
                sb.AppendLine("link :" + rs.Link);
                sb.AppendLine("source :" + rs.Source + "\n");
            }

            string Text = sb.ToString();
            return View(s);
        }


        public ActionResult nt()
        {
            string url2 = "https://www.nt.se/rss/lokalt/norrkoping";
            var s = RssReader.Read(url2);
            StringBuilder sb = new StringBuilder();
            foreach (RssNews rs in s)
            {
                sb.AppendLine("title: " + rs.Title);
                sb.AppendLine("text :" + rs.Text);
                sb.AppendLine("pb : " + rs.PublicationDate);
                sb.AppendLine("link :" + rs.Link);
                sb.AppendLine("source :" + rs.Source + "\n");
            }

            string Text = sb.ToString();
            return View(s);
        }

        public ActionResult expressen()
        {
            string url2 = "https://feeds.expressen.se/nyheter/";
            var s = RssReader.Read(url2);
            StringBuilder sb = new StringBuilder();
            foreach (RssNews rs in s)
            {
                sb.AppendLine("title: " + rs.Title);
                sb.AppendLine("text :" + rs.Text);
                sb.AppendLine("pb : " + rs.PublicationDate);
                sb.AppendLine("link :" + rs.Link);
                sb.AppendLine("source :" + rs.Source + "\n");
            }

            string Text = sb.ToString();
            return View(s);
        }

      

    }
}