using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PetTrackerServer.Models;

namespace PetTrackerServer.Services
{
    public class DatabaseService
    {
        public MongoClient mongoClient;
        public IMongoDatabase mongoDatabase;

        public DatabaseService(IOptions<MongoSettings> mongoDatabaseSettings) 
        {
            mongoClient
                = new MongoClient(mongoDatabaseSettings.Value.ConnectionString);

            mongoDatabase
                = mongoClient.GetDatabase(mongoDatabaseSettings.Value.DatabaseName);
        }
    }
}
