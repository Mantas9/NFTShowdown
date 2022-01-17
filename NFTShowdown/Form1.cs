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

        List<NFTs> nfts = new List<NFTs>();
        List<Moves> moves = new List<Moves>();
        List<Teams> teams = new List<Teams>();
        private void Form1_Load(object sender, EventArgs e)
        {
            AddMoves();
        }

        // Adding the moves
        private void AddMoves()
        {
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
            // For stats boost/decrease - Damage is now the points of the stat (hp excluded) added
            Moves stats1 = new Moves("Fresh Minting", "Normal", "Healing", 50, 100);
            moves.Add(stats1);
            Moves stats2 = new Moves("Price Rise", "Normal", "AtkBoost", 40, 100);
            moves.Add(stats2);
            Moves stats3 = new Moves("Hype Rise", "Normal", "SpeBoost", 40, 100);
            moves.Add(stats3);
            Moves stats4 = new Moves("Regular Customers", "Normal", "DefBoost", 40, 100);
            moves.Add(stats4);

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
            Teambuilder teambuilder = new Teambuilder(moves, teams);
            teambuilder.ShowDialog();
            foreach (var item in teams)
            {
                comboTeams.Items.Add(item.Name);
            }
        }
    }
}
