using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBAccess
{
    public class GameModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int MaxTurns { get; set; }

        public int TurnsPlayed { get; set; }

        public bool IsWin { get; set; } = false;


        public PropertyInfo[] GetProperties()
        {
            Type gameType = this.GetType();

            return gameType.GetProperties();
        }
    }
}
