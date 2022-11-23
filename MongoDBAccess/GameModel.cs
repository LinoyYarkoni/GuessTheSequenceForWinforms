using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Reflection;

namespace MongoDBAccess
{
    public class GameModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int MaxTurns { get; set; }

        public int TurnsPlayed { get; set; }

        public string GameResult { get; set; } = "Lose";


        public PropertyInfo[] GetProperties()
        {
            Type gameType = this.GetType();

            return gameType.GetProperties();
        }
    }
}
