using MongoDB.Driver;

namespace Votorantim.Domain.Base.MongoDB
{
    public interface IMongoDBContext
    {
        IMongoCollection<TEntity> GetCollection<TEntity>(string collection);
    }
}
