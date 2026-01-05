using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PetTrackerServer.Models;
using PetTrackerServer.Models.Database;
using PetTrackerServer.Models.Registration;

namespace PetTrackerServer.Services
{
    public class UserService(IOptions<MongoSettings> mongoDatabaseSettings, DatabaseService databaseService)
    {
        private readonly IMongoCollection<User> userCollection
                = databaseService.mongoDatabase.GetCollection<User>(mongoDatabaseSettings.Value.UserCollection);

        public async Task<(RegistrationResponse response, User? user, string? message)> CreateUser(RegistrationModel newUser)
        {
            var existingCharacter 
                = await userCollection.FindAsync(
                    x => x.Username.Equals(newUser.Username, StringComparison.CurrentCultureIgnoreCase) 
                    && x.Server.Equals(newUser.World, StringComparison.CurrentCultureIgnoreCase));

            if (existingCharacter != null)
                return (RegistrationResponse.UserExists, null, $"User already exists.");

            Guid userPublicGuid = Guid.NewGuid();
            string publicUserId = userPublicGuid.ToString().Split('-').Last();

            var newDataUser = new User()
            {
                Username = newUser.Username,
                Server = newUser.World,

                UserPublicId = publicUserId
            };

            try
            {
                await userCollection.InsertOneAsync(newDataUser);
                return (RegistrationResponse.UserExists, newDataUser, null);
            }
            catch (Exception ex)
            {
                return (RegistrationResponse.Error, null, ex.Message);
            }
        }



        public async Task DeleteUserAsync(string userId) =>
            await userCollection.DeleteOneAsync(x => x.Id == userId);
    }
}
