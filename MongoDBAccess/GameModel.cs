using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBAccess
{
    public class GameModel
    {
        public int MaxTurns { get; set; }
        public int TurnsPlayed { get; set; }
        public bool IsWin { get; set; } = false;
    }
}
