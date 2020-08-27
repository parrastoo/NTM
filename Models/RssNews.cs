using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace WebApplication2.Models
{

    /// <summary>
    /// RSSNews is the object of the news
    /// </summary>
    public class RssNews
    {
        public string Title;
        public string Text;
        public DateTime PublicationDate;
        public string Category_html; //if there was
        public string Category;
        public string Link;
        public string Source;
        public string Image; //if there was
    }


    /// <summary>
    /// RssReader is respinsible to read news and generated the list of RssNews objects
    /// </summary>
    public class RssReader
    {

        //input :  the URL of RSSFeed and the name of the source
        //output:  list of RssNews objects from that url
        public static List<RssNews> Read(string url, string source)
        {
            var webClient = new WebClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string result = Encoding.UTF8.GetString(webClient.DownloadData(url));
            XDocument document = XDocument.Parse(result);
            var news_list = new List<RssNews>();
            foreach (var descendant in document.Descendants("item"))
            {
                RssNews r = new RssNews();
                r.Title = descendant.Element("title").Value;
                r.Text = descendant.Element("description").Value;
                r.PublicationDate = Convert.ToDateTime(descendant.Element("pubDate").Value);
                r.Link = descendant.Element("link").Value;
                r.Source = source;
                if (descendant.Element("category") != null)
                {
                    r.Category = descendant.Element("category").Value;
                    r.Category_html= "<li> Category : "+ descendant.Element("category").Value+" <a href = '/RssNews/Category/"+ descendant.Element("category").Value +"' target = '_blank' > Get Same Category </a></li>";
                }
                if (descendant.Element("image") != null)
                {
                    r.Image = "<li > " + descendant.Element("image").Value + "</li>";
                }

                news_list.Add(r);
            }
            return (news_list);

        }


       //reads from three sources provided 
        //output:  list of RssNews objects from the three different url
        public static List<RssNews> ReadAll()
        {

            string url_svd = "https://www.svd.se/?service=rss";
            string url_nt = "https://www.nt.se/rss/lokalt/norrkoping";
            string url_expressen = "https://feeds.expressen.se/nyheter/";
            var webClient = new WebClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string result = Encoding.UTF8.GetString(webClient.DownloadData(url_svd));
            XDocument document = XDocument.Parse(result);
            var news_list = new List<RssNews>();
            foreach (var descendant in document.Descendants("item"))
            {
                RssNews r = new RssNews();
                r.Title = descendant.Element("title").Value;
                r.Text = descendant.Element("description").Value;
                r.PublicationDate = Convert.ToDateTime(descendant.Element("pubDate").Value);
                r.Link = descendant.Element("link").Value;
                r.Source = "svd";
                if (descendant.Element("category") != null)
                {
                    r.Category = descendant.Element("category").Value;
                    r.Category_html = "<li> Category : " + descendant.Element("category").Value + " <a href = '/RssNews/Category/" + descendant.Element("category").Value + "' target = '_blank' > Get Same Category </a></li>";
                }
                if (descendant.Element("image") != null)
                {
                    r.Image = "<li > " + descendant.Element("image").Value + "</li>";
                }
                news_list.Add(r);

            }


             result = Encoding.UTF8.GetString(webClient.DownloadData(url_nt));
             document = XDocument.Parse(result);
            foreach (var descendant in document.Descendants("item"))
            {
                RssNews r = new RssNews();
                r.Title = descendant.Element("title").Value;
                r.Text = descendant.Element("description").Value;
                r.PublicationDate = Convert.ToDateTime(descendant.Element("pubDate").Value);
                r.Link = descendant.Element("link").Value;
                r.Source = "nt";
                if (descendant.Element("category") != null)
                {
                    r.Category = descendant.Element("category").Value;
                    r.Category_html = "<li> Category : " + descendant.Element("category").Value + " <a href = '/RssNews/Category/" + descendant.Element("category").Value + "' target = '_blank' > Get Same Category </a></li>";
                }
                if (descendant.Element("image") != null)
                {
                    r.Image = "<li > " + descendant.Element("image").Value + "</li>";
                }
                news_list.Add(r);

            }

            result = Encoding.UTF8.GetString(webClient.DownloadData(url_expressen));
            document = XDocument.Parse(result);
            foreach (var descendant in document.Descendants("item"))
            {
                RssNews r = new RssNews();
                r.Title = descendant.Element("title").Value;
                r.Text = descendant.Element("description").Value;
                r.PublicationDate = Convert.ToDateTime(descendant.Element("pubDate").Value);
                r.Link = descendant.Element("link").Value;
                r.Source = "expressen";
                if (descendant.Element("category") != null)
                {
                    r.Category = descendant.Element("category").Value;
                    r.Category_html = "<li> Category : " + descendant.Element("category").Value + " <a href = '/RssNews/Category/" + descendant.Element("category").Value + "' target = '_blank' > Get Same Category </a></li>";
                }
                if (descendant.Element("image") != null)
                {
                    r.Image = "<li > " + descendant.Element("image").Value + "</li>";
                }
                news_list.Add(r);

            }

            return (news_list);


        }



    }
}