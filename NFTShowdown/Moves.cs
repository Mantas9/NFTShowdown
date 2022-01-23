using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTShowdown
{
    public class Moves
    {
        public Moves(string name, string type, string moveType, int power, int accuracy)
        {
            Name = name;
            Type = type;
            MoveType = moveType;
            Power = power;
            Accuracy = accuracy;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string MoveType { get; set; }
        public int Power { get; set; }
        public int Accuracy { get; set; }
    }
}
