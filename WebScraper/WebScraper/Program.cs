using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var coastalwatch = WebScraper.Web.Scrape();
            Database.Persist(coastalwatch);
            //var client = new MongoClient();
            //var database = client.GetDatabase("mixwave");
            //var coastalwatch = database.GetCollection<Entity>("reports");
            //coastalwatch.InsertOneAsync(new Entity { Name = "magicseaweed", Content = "testing" });
        }

        public class Entity
        {
            public ObjectId Id { get; set; }
            public string Name { get; set; }
            //public HtmlAgilityPack.HtmlDocument Content { get; set; }
            public string Content { get; set; }
        }
    }
}
