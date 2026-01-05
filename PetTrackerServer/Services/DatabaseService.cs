using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PetTrackerServer.Models;
using PetTrackerServer.Models.Database;

namespace PetTrackerServer.Services
{
    public class DatabaseService
    {
        private readonly IMongoCollection<User> userCollection;

        public DatabaseService(IOptions<MongoSettings> mongoDatabaseSettings) {
            var mongoClient 
                = new MongoClient(mongoDatabaseSettings.Value.ConnectionString);

            var mongoDatabase 
                = mongoClient.GetDatabase(mongoDatabaseSettings.Value.DatabaseName);

            userCollection
                = mongoDatabase.GetCollection<User>(mongoDatabaseSettings.Value.UserCollection);
        }

        public async Task AddUserAsync(User newUser) =>
            await userCollection.InsertOneAsync(newUser);

        public async Task DeleteUserAsync(string userId) =>
            await userCollection.DeleteOneAsync(x => x.UserPublicId == userId);
    }
}
