using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTShowdown
{
    internal class Moves
    {
        public Moves(string name, string type, string damageType, int damage, int accuracy)
        {
            Name = name;
            Type = type;
            DamageType = damageType;
            Damage = damage;
            Accuracy = accuracy;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string DamageType { get; set; }
        public int Damage { get; set; }
        public int Accuracy { get; set; }
    }
}
