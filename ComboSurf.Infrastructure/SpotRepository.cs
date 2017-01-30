using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ComboSurf.Domain.Repositories;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using DataTransferObjects;

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
		
		public SpotDto GetByName(string name)
		{
			var document = Task.Run(() => QueryDatabaseByName(name)).Result;
			var jsonDocument = BsonSerializer.Deserialize<SpotDto>(document);
			var spot = Mapper.Map<SpotDto>(jsonDocument);
			if (spot.reports.Count < 1)
			{
				var oldResults = Task.Run(() => GetLatestReport()).Result;
				var json = BsonSerializer.Deserialize<SpotDto>(oldResults);
				var oldSpot = Mapper.Map<SpotDto>(json);
				return oldSpot;
			}
			return spot;	
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