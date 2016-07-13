using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontAngry.Engines
{
    public enum PlayerType
    {
        Green,
        Red,
        Blue,
        Yellow
    }

    public class Player
    {
        public PlayerType PlayerName { get; set; }
         
    }
}
