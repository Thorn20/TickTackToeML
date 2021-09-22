using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToeML.Game
{
    public class Player
    {
        public string Name;
        public bool IsHuman;
        public string Symbol;

        public Player( string name = "Human", bool isHuman = true)
        {
            Name = name;
            IsHuman = isHuman;
            Symbol = "";
        }

        public override string ToString()
        {
            return Name;
        }

        public static Player Copy(Player toCopy)
        {
            Player Copy = new Player(toCopy.Name, toCopy.IsHuman);
            Copy.Symbol = toCopy.Symbol;
            return Copy;
        }
    }
}
