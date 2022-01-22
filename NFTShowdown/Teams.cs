using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTShowdown
{
    public class Teams
    {
        public Teams(string name, int id, NFTs nFT1, NFTs nFT2, NFTs nFT3)
        {
            Name = name;
            this.ID = id;
            NFT1 = nFT1;
            NFT2 = nFT2;
            NFT3 = nFT3;
        }

        public string Name { get; set; }
        public int ID { get; set; }
        public NFTs NFT1 { get; set; }
        public NFTs NFT2 { get; set; }
        public NFTs NFT3 { get; set; }
    }
}
