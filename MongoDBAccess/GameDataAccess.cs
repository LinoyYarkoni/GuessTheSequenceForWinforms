using MongoDB.Driver;
using MongoDBAccess;
using System.Threading.Tasks;

namespace Logic
{
    public class GameDataAccess
    {
        private const string connectionString = "mongodb://127.0.0.1:27017";
        private const string databaseName = "gamesdb";
        private const string gamesCollection = "games_chart";

        private IMongoCollection<T> connectToMongo<T>(in string collection)
        {
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);

            return db.GetCollection<T>(collection);
        }

        public Task CreateGame(GameModel game)
        {
            var games = connectToMongo<GameModel>(gamesCollection);

            return games.InsertOneAsync(game);
        }
    }
}
