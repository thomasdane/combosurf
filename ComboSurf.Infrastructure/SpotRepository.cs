using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

		public class Report
		{
			public Object _id { get; set; }
			public Spot spot { get; set; }
		}
		
		public class Spot
		{
				public string Name { get; set; }
				public string swellHeight { get; set; }
				public string swellDirection { get; set; }
				public string period { get; set; }
				public string windDirection { get; set; }
				public string windSpeed { get; set; }
				public string content { get; set; }
		}
		
		public async Task<BsonDocument> Db()
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
			var spotDto = CreateDummySpotDto("Eastern Beaches");

			var result = Task.Run(() => Db()).Result;
			var blah = BsonSerializer.Deserialize<Report>(result);

			var x = blah;
            return spotDto;
		}

		private SpotDto CreateDummySpotDto(string name)
		{
			var swellnetDto = new SwellnetDto()
			{
				Name = "SwellNet",
                SwellHeight = "1",
                SwellDirection = "NE",
                Period = "18s",
                WindDirection = "W", 
                WindSpeed = "3 Knots",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
			};

			var coastalwatchDto = new SwellnetDto()
			{
                Name = "coastalWatch",
                SwellHeight = "1",
                SwellDirection = "NE",
                Period = "18s",
                WindDirection = "W",
                WindSpeed = "3 Knots",
                Content = "Still looks a bit average but decent 3ft now at S facing beaches. Morning Report: Waves 2ft +, Swell SE @ 7.7 sec, Winds SSE-SE-ESE 8-18 knots. Still looks a bit average but improvement on yesterday. Size around 2ft, maybe a little bigger S facing mostly from the SE."
			};


			List<SwellnetDto> reports = new List<SwellnetDto> { coastalwatchDto, swellnetDto}; 

			return new SpotDto
			{
				Name = name,
				Reports = reports
			};
		}
	}
}
				
