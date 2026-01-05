namespace PetTrackerServer.Models
{
    public class MongoSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;

        public string UserCollection { get; set; } = null!;
        public string PetInfoCollection { get; set; } = null!;
        public string PartyInfoCollection { get; set; } = null!;
    }
}
