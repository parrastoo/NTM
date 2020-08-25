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


namespace WebApplication2.Models
{
    public class NewsChannel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }


        public NewsChannel(string _name, string _Link)
        {
            Name = _name;
            Url = _Link;
        }


    }
}