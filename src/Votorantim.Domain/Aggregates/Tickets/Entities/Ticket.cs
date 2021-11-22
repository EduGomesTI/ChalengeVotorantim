using MongoDB.Bson.Serialization.Attributes;
using Votorantim.Domain.Aggregates.Docks.Entities;
using Votorantim.Domain.Aggregates.Trucks.Entities;

namespace Votorantim.Domain.Aggregates.Tickets.Entities
{
    public record Ticket : BaseEntity<string>
    {
        [BsonElement]
        public Truck Truck { get; set; }
        [BsonElement]
        public Dock Dock { get; set; }
        [BsonElement]
        public DateTime Entrance { get; set; }
        [BsonElement]
        public DateTime Exit { get; set; }

        public Ticket()
        {
            
        }

        public Ticket(string id, Truck truck, Dock dock, DateTime entrance, DateTime exit)
        {
            Id = id;
            Truck = truck;
            Dock = dock;
            Entrance = entrance;
            Exit = exit;
        }
    }
}
