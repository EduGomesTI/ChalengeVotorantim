using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Votorantim.Domain.Aggregates.Devices.Entites
{
    public record Device: BaseEntity<string>
    {
        [BsonElement]
        public string Location { get; set; }

        public Device()
        {

        }

        [BsonConstructor]
        public Device(string id, string location)
        {
            Id = id;
            Location = location;
        }

    }
}
