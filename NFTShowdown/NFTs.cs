using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTShowdown
{
    internal class NFTs
    {
        public NFTs(int iD, string name, string type, string ability, int hP, int attack, int defense, int speed)
        {
            ID = iD;
            Name = name;
            Type = type;
            Ability = ability;
            HP = hP;
            Attack = attack;
            Defense = defense;
            Speed = speed;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Ability { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public Moves Move1 { get; set; }
        public Moves Move2 { get; set; }
        public Moves Move3 { get; set; }
        public Moves Move4 { get; set; }
        public bool Validated { get; set; }

    }
}
