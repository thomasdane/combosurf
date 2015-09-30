using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WebScraper
{
    public class Entity
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        //public HtmlAgilityPack.HtmlDocument Content { get; set; }
        public string Content { get; set; }
    }
    
    class Database
    {
        public static async void Persist(HtmlAgilityPack.HtmlDocument document)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("mixwave");
            var coastalwatch = database.GetCollection<Entity>("reports");
            var content = new Entity { Name = "swellnet", Content = "test"};
            await coastalwatch.InsertOneAsync(content);
        }
    }
}
