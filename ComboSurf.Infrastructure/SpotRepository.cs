using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using ComboSurf.Domain.Repositories;
using DataTransferObjects;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ComboSurf.Infrastructure
{
	public class SpotRepository : ISpotRepository
	{
	

		public List<string> GetAll()
		{
			//hard code this for now because we are only doing 3 spots
			//later we will extend to actually query database here
			var spots = new List<string> 
			{"Sydney North", "Sydney East", "Sydney South"};
			return spots;
		}

	    public SpotDto GetOldSpot()
	    {
            var oldResults = Task.Run(() => GetLatestReport()).Result;
            var json = BsonSerializer.Deserialize<SpotDto>(oldResults);
            var oldSpot = Mapper.Map<SpotDto>(json);
            return oldSpot;
        }

		public SpotDto GetByName(string name)
		{
			var document = Task.Run(() => QueryDatabaseByName(name)).Result;
			var jsonDocument = BsonSerializer.Deserialize<SpotDto>(document);
			var spot = Mapper.Map<SpotDto>(jsonDocument);
			if (spot.reports.Count < 1)
			{
			    GetOldSpot();
			}

            var review = new Reviews
            {
                positive = 1,
                negative = 1
            };

            spot.reports[0].reviews = review;
            spot.reports[1].reviews = review;
            return spot;	
		}

	    

	    public bool AddReview(string name, string review)
	    {
            var spot = GetByName(name);

            var reviewParts = review.Split(',');
	        var report = reviewParts[0];
	        var rating = reviewParts[1];

            var ratedReport = spot.reports.First(x => x.name == report);

	        if (rating == "Positive")
	        {
                ratedReport.reviews.positive += 1;
	        }
	        else
	        {
                ratedReport.reviews.negative += 1;
	        }

	        Task.Run(() => QueryDatabaseById(spot._id, ratedReport.reviews));

            return true;
	    }


        public async Task QueryDatabaseById(object spotId, Reviews reviews)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("partywave");
            var collection = database.GetCollection<BsonDocument>("scrapeResults");
            var query = Builders<BsonDocument>.Filter.Eq("_id", spotId);
            var update = Builders<BsonDocument>.Update.Set("reviews", reviews);
            await collection.UpdateOneAsync(query, update);
        }

        public async Task<BsonDocument> QueryDatabaseByName(string name)
		{
			var client = new MongoClient();
			var database = client.GetDatabase("partywave");
			var collection = database.GetCollection<BsonDocument>("scrapeResults");
			var query = Builders<BsonDocument>.Filter.Eq("name", name); 
			var sortFilter = Builders<BsonDocument>.Sort.Descending("_id");
			var document = await collection.Find(query).Sort(sortFilter).FirstOrDefaultAsync();
			return document;
		}

		public async Task<BsonDocument> GetLatestReport()
		{
			var client = new MongoClient();
			var database = client.GetDatabase("partywave");
			var collection = database.GetCollection<BsonDocument>("scrapeResults");
			FilterDefinition<BsonDocument> query = ("{'reports.1': {$exists: true}}.limit(1).sort({$natural:-1})");
			var document = await collection.Find(query).FirstOrDefaultAsync();
			return document;
		}
	}
}