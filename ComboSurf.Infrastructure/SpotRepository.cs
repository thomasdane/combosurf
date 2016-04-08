using System;
using System.Collections.Generic;
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
		public async Task<BsonDocument> QueryDatabase()
		{
			var client = new MongoClient();
			var database = client.GetDatabase("partywave");
			var collection = database.GetCollection<BsonDocument>("scrapeResults");
			var sortFilter = Builders<BsonDocument>.Sort.Descending("spot");
			var document = await collection.Find(new BsonDocument()).Sort(sortFilter).FirstOrDefaultAsync();
			return document;
		}
		
		public SpotDto GetByName(string name)
		{
			var document = Task.Run(() => QueryDatabase()).Result;
			var jsonDocument = BsonSerializer.Deserialize<SpotDto>(document);
			var spot = Mapper.Map<SpotDto>(jsonDocument);
            return spot;
		}
	}
}