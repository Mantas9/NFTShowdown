using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFTShowdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables
        List<NFTs> nfts = new List<NFTs>();
        List<Moves> moves = new List<Moves>();
        List<Teams> teams = new List<Teams>();
        int teamID = 0;
        int wins = 0;
        int losses = 0;

        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            AddInfo();
            comboFormat.SelectedItem = comboFormat.Items[2];
            lblWins.Text =  wins.ToString();
            lblLosses.Text = losses.ToString();
        }

        // Adding the moves
        private void AddInfo()
        {
            // Adding moves
            #region MOVES
            // Damaging moves
            Moves attack1 = new Moves("Fire Screenshot", "Fire", "Damage", 80, 100);
            moves.Add(attack1);
            Moves attack2 = new Moves("Water Screenshot", "Water", "Damage", 80, 100);
            moves.Add(attack2);
            Moves attack3 = new Moves("Grass Screenshot", "Grass", "Damage", 80, 100);
            moves.Add(attack3);
            Moves attack4 = new Moves("Fire Metadata Steal", "Fire", "Damage", 130, 50);
            moves.Add(attack4);
            Moves attack5 = new Moves("Water Metadata Steal", "Water", "Damage", 130, 50);
            moves.Add(attack5);
            Moves attack6 = new Moves("Grass Metadata Steal", "Grass", "Damage", 130, 50);
            moves.Add(attack6);

            // stats moves
            // For healing moves - Damage points are now the precentage of hp one recovers
            // For stats boost/decrease - Damage is now the multiplier of the selected stat
            Moves stats1 = new Moves("Fresh Minting", "Normal", "Healing", 50, 100);
            moves.Add(stats1);
            Moves stats2 = new Moves("Price Rise", "Normal", "AtkBoost", 2, 100);
            moves.Add(stats2);
            Moves stats3 = new Moves("Hype Rise", "Normal", "SpeBoost", 2, 100);
            moves.Add(stats3);
            Moves stats4 = new Moves("Regular Customers", "Normal", "DefBoost", 2, 100);
            moves.Add(stats4);
            #endregion

            // Adding NFT sets for random battles/1v1
            // Bored Apes
            NFTs nft1 = new NFTs(1, "Red Bored Ape", "Fire", "Intimidate", 250, 50, 60, 110, attack1, attack4, stats1, stats3);
            nfts.Add(nft1);
            NFTs nft2 = new NFTs(2, "Primal Bored Ape", "Grass", "Spiky Body", 600, 10, 150, 30, attack3, attack6, stats2, stats1);
            nfts.Add(nft2);
            NFTs nft3 = new NFTs(3, "Laser Bored Ape", "Water", "None", 300, 90, 60, 300, attack2, attack5, stats1, stats3);
            nfts.Add(nft3);

            // Meta Moles
            NFTs nft4 = new NFTs(4, "Sombrero Meta Mole", "Fire", "None", 200, 60, 150, 10, attack1, attack4, stats3, stats2);
            nfts.Add(nft4);
            NFTs nft5 = new NFTs(5, "Hallowed Meta Mole", "Water", "None", 200, 55, 150, 10, attack2, attack5, stats3, stats2);
            nfts.Add(nft5);
            NFTs nft6 = new NFTs(6, "King Meta Mole", "Grass", "None", 200, 75, 150, 10, attack3, attack6, stats3, stats2);
            nfts.Add(nft6);
        }

        // Choosing battle format
        private void comboFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFormat.SelectedItem.ToString() == "Teams Battle")
            {
                label2.Visible = true;
                comboTeams.Visible = true;
                foreach (var item in teams)
                {
                    comboTeams.Items.Add(item.Name);
                }
            }
            else
            {
                label2.Visible = false;
                comboTeams.Visible = false;
            }
        }

        // Opening teambuilder
        private void btnNewTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teambuilder teambuilder = new Teambuilder(moves, teams, teamID);
            if (teambuilder.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                if (comboTeams.Items.Count != 0)
                {
                    comboTeams.SelectedItem = comboTeams.Items[0];
                }
            }
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            switch (comboFormat.Text)
            {
                case "Random 1v1 Battle":
                    BattleWindow battle = new BattleWindow(comboFormat.Text, nfts, ref wins,ref losses);
                    this.Hide();
                    if (battle.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                        lblWins.Text = wins.ToString();
                        lblLosses.Text = losses.ToString();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
