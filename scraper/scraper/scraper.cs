using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace scraper
{
    public class scraper
    {
        var web = new HtmlWeb();
        HtmlDocument doc = web.Load("http://google.com");


    }
}