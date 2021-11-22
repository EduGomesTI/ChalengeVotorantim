using MongoDB.Bson.Serialization.Attributes;

namespace Votorantim.Domain.Aggregates.Docks.Entities
{
    public record Dock: BaseEntity<string>
    {
        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public List<CheckPoint> CheckPoints { get; set; }

        public Dock()
        {

        }

        [BsonConstructor]
        public Dock(string id, string name, List<CheckPoint> checkPoints)
        {
            Id = id;
            Name = name;
            CheckPoints = checkPoints;
        }
    }
}
