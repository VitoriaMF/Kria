using MongoDB.Driver;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class MongoService
    {
        private readonly IMongoCollection<TabTransacao> _collection;

        public MongoService(IConfiguration config)
        {
            var client = new MongoClient(config["Mongo:ConnectionString"]);
            var database = client.GetDatabase(config["Mongo:Database"]);
            _collection = database.GetCollection<TabTransacao>(config["Mongo:Collection"]);
        }

        public List<TabTransacao> ObterTransacoes() =>
            _collection.Find(_ => true).Limit(1000).ToList();
    }
}