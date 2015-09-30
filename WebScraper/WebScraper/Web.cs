using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper
{
    public class Web
    {
        public static HtmlAgilityPack.HtmlDocument Scrape()
        {
            using (var client = new System.Net.WebClient())
            {
                var filename = System.IO.Path.GetTempFileName();

                client.DownloadFile("http://www.coastalwatch.com/surf-cams-surf-reports/nsw/manly---nth-steyne", filename);

                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(filename);
                return doc;
            }
        }
    }
}
