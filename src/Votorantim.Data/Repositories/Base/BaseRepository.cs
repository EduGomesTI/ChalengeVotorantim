using MongoDB.Bson;
using MongoDB.Driver;
using Votorantim.Domain.Aggregates;
using Votorantim.Domain.Base.MongoDB;
using Votorantim.Domain.Base.Repository;

namespace Votorantim.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        private readonly IMongoCollection<TEntity> _collection;

        public BaseRepository(IMongoDBContext mongoDBContext, string collectionName)
        {
            _collection = mongoDBContext.GetCollection<TEntity>(collectionName);
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);

            return entity;
        }

        public async Task<IList<TEntity>> GetAllAsync()
        {
            IList<TEntity> result = await _collection.FindAsync(new BsonDocument()).Result.ToListAsync();

            return result;
        }

        public async Task<TEntity> GetByIdAsync(TId id)
        {
            var filter = Builders<TEntity>.Filter.Eq("_id", id);

            var result = await _collection.FindAsync(filter).Result.FirstOrDefaultAsync();

            return result;  
        }
    }
}
