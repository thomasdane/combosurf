using System;
using System.Collections.Generic;
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
		public async Task<BsonDocument> QueryDatabase(string name)
		{
			var client = new MongoClient();
			var database = client.GetDatabase("partywave");
			var collection = database.GetCollection<BsonDocument>("scrapeResults");
			var query = Builders<BsonDocument>.Filter.Eq("name", name.ToLower());
			var sortFilter = Builders<BsonDocument>.Sort.Descending("_id");
			var document = await collection.Find(query).Sort(sortFilter).FirstOrDefaultAsync();
			return document;
		}

		public List<string> GetAll()
		{
			//hard code this for now because we are only doing 3 spots
			//later we will extend to more and actually query data base here
			var spots = new List<string> 
			{"EasternBeaches", "NorthernBeaches", "BatemansBay"};
			return spots;
		} 
		
		public SpotDto GetByName(string name)
		{
			var document = Task.Run(() => QueryDatabase(name)).Result;
			var jsonDocument = BsonSerializer.Deserialize<SpotDto>(document);
			var spot = Mapper.Map<SpotDto>(jsonDocument);
			return spot;	
		}
	}
}