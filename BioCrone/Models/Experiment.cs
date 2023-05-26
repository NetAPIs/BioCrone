using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BioCrone.Models
{
    public class Experiment
    {
        [BsonId]
        public int Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("Description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("StartDate")]
        public DateTime StartDate { get; set; }

        [BsonElement("EndDate")]
        public DateTime EndDate { get; set; }

        [BsonElement("Location")]
        public string Location { get; set; } = string.Empty;
    }
}
