using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PetTrackerServer.Models.Database
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Username { get; set; } = null!;
        public string Server { get; set; } = null!;

        public string UserPublicId { get; set; } = null!;
        public string UserPrivateId { get; set; } = null!;
    }
}
