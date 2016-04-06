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

			var sort = Builders<BsonDocument>.Sort.Descending("spot");
			var document = await collection.Find(new BsonDocument()).Sort(sort).FirstOrDefaultAsync();
			return document;
		}
		
		public SpotDto GetByName(string name)
		{
			var result = Task.Run(() => QueryDatabase()).Result;
			var results = BsonSerializer.Deserialize<SpotDto>(result);

			var blah = Mapper.Map<SpotDto>(results);
			
            return blah;
		}

	}
}
				
