using BioCrone.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BioCrone.Data
{
    public class DataContext
    {
        private readonly IMongoDatabase _database;

        public DataContext(IOptions<MongoDBSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _database = client.GetDatabase(settings.Value.DatabaseName);
        }

        public IMongoCollection<Experiment> Experiments => _database.GetCollection<Experiment>("experiments");
    }
}
