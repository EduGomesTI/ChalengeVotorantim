using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Votorantim.Domain.Base.MongoDB;

namespace Votorantim.Data.Repositories.Base.MongoDB
{
    public class MongoDBContext : IMongoDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;

        public MongoDBContext()
        {
            MongoClientSettings mongoClientSettings = MongoClientSettings
                .FromUrl(new MongoUrl("mongodb://admin:admin@localhost:27017"));

            mongoClientSettings.SslSettings = new SslSettings()
            {
                EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
            };

            MongoClient mongoClient = new(settings: mongoClientSettings);

            MongoCredential mongoCredential = MongoCredential.CreateCredential("votorantim", "admin", "admin");

            _mongoDatabase = mongoClient.GetDatabase("votorantim");
        }

        public IMongoCollection<TEntity> GetCollection<TEntity>(string collection)
        {
            return _mongoDatabase.GetCollection<TEntity>(collection);
        }
    }
}
