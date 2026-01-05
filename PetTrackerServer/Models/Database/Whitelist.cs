using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PetTrackerServer.Models.Database
{
    public class Whitelist
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string OwnerId { get; set; } = null!;
        public string PetId { get; set; } = null!;
        
        public bool Consented { get; set; }
    }
}
