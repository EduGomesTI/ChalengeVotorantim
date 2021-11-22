using MongoDB.Bson.Serialization.Attributes;

namespace Votorantim.Domain.Aggregates.Trucks.Entities
{
    public record Truck : BaseEntity<string>
    {
        [BsonElement]
        public string Drivername { get; set; }
        [BsonElement]
        public string LicensePlate { get; set; }

        public Truck()
        {

        }

        [BsonConstructor]
        public Truck(string id, string drivername, string licensePlate)
        {
            Id = id;
            Drivername = drivername;
            LicensePlate = licensePlate;
        }
    }
}
