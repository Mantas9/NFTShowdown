﻿using System;
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
    public partial class Teambuilder : Form
    {
        #region Variables
        List<NFTs> nfts = new List<NFTs>();
        List<Moves> moves = new List<Moves>();
        List<Teams> teams = new List<Teams>();

        int counter = 0;
        bool teamValidated = false;

        // NFT stats
        int id;
        string name;
        int hp;
        int attack;
        int defence;
        int speed;
        string ability;
        string type;
        bool validated = false;
        Moves move1;
        Moves move2;
        Moves move3;
        Moves move4;

        // Team NFTS
        NFTs nft1;
        NFTs nft2;
        NFTs nft3;


        #endregion

        public Teambuilder(List<Moves> moves, List<Teams> teams)
        {
            InitializeComponent();
            this.moves = moves;
            this.teams = teams;
        }



        private void btnAddNFT_Click(object sender, EventArgs e)
        {
            // Setting maximum amount of NFTs in a team
            if (counter <= 3)
            {
                groupNFTS1.Visible = true;
                counter++;

                // When max NFTs reached, nft button disappears
                if (counter == 3)
                {
                    btnAddNFT.Visible = false;
                }
            }
            
        }

        private void comboPickNFT1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Selecting NFTs
            switch (comboPickNFT1.SelectedItem)
            {
                case "Red Bored Ape":
                    #region Redboredape
                    // Clearing previous values
                    comboMove1.Items.Clear();
                    comboMove2.Items.Clear();
                    comboMove3.Items.Clear();
                    comboMove4.Items.Clear();

                    // Stats
                    name = "Red Bored Ape";
                    id = 1;
                    hp = 250;
                    attack = 120;
                    defence = 60;
                    speed = 110;
                    ability = "Intimidate";
                    type = "Fire";

                    // Adding the values to GUI
                    picturePrev1.Image = Properties.Resources.redboredape;
                    lblHP.Text = hp.ToString();
                    lblATK.Text = attack.ToString();
                    lblDEF.Text = defence.ToString();
                    lblSPE.Text = speed.ToString();
                    lblAbility.Text = ability.ToString();
                    lblType.Text = type.ToString();

                    foreach (var item in moves)
                    {
                        if (item.Type == "Fire")
                        {
                            comboMove1.Items.Add(item.Name);
                            comboMove2.Items.Add(item.Name);
                            comboMove3.Items.Add(item.Name);
                            comboMove4.Items.Add(item.Name);
                        }
                        if (item.MoveType == "AtkBoost" || item.MoveType == "SpeBoost")
                        {
                            comboMove1.Items.Add(item.Name);
                            comboMove2.Items.Add(item.Name);
                            comboMove3.Items.Add(item.Name);
                            comboMove4.Items.Add(item.Name);
                        }
                    }
                    #endregion
                    break;
                case "Primal Bored Ape":
                    #region PrimalBoredApe
                    // Clearing previous values
                    comboMove1.Items.Clear();
                    comboMove2.Items.Clear();
                    comboMove3.Items.Clear();
                    comboMove4.Items.Clear();

                    // Stats
                    name = "Primal Bored Ape";
                    id = 2;
                    hp = 600;
                    attack = 50;
                    defence = 150;
                    speed = 30;
                    ability = "Spiky Body";
                    type = "Grass";

                    // Adding the values to GUI
                    picturePrev1.Image = Properties.Resources.primalboredape;
                    lblHP.Text = hp.ToString();
                    lblATK.Text = attack.ToString();
                    lblDEF.Text = defence.ToString();
                    lblSPE.Text = speed.ToString();
                    lblAbility.Text = ability.ToString();
                    lblType.Text = type.ToString();

                    foreach (var item in moves)
                    {
                        if (item.Type == "Grass")
                        {
                            comboMove1.Items.Add(item.Name);
                            comboMove2.Items.Add(item.Name);
                            comboMove3.Items.Add(item.Name);
                            comboMove4.Items.Add(item.Name);
                        }
                        if (item.MoveType == "Healing" || item.MoveType == "AtkBoost")
                        {
                            comboMove1.Items.Add(item.Name);
                            comboMove2.Items.Add(item.Name);
                            comboMove3.Items.Add(item.Name);
                            comboMove4.Items.Add(item.Name);
                        }
                    }
                    #endregion
                    break;
                case "Laser Bored Ape":
                    #region LaserlBoredApe
                    // Clearing previous values
                    comboMove1.Items.Clear();
                    comboMove2.Items.Clear();
                    comboMove3.Items.Clear();
                    comboMove4.Items.Clear();

                    // Stats
                    name = "Laser Bored Ape";
                    id = 3;
                    hp = 50;
                    attack = 400;
                    defence = 10;
                    speed = 300;
                    ability = "none";
                    type = "Water";

                    // Adding the values to GUI
                    picturePrev1.Image = Properties.Resources.laserBoredApe;
                    lblHP.Text = hp.ToString();
                    lblATK.Text = attack.ToString();
                    lblDEF.Text = defence.ToString();
                    lblSPE.Text = speed.ToString();
                    lblAbility.Text = ability.ToString();
                    lblType.Text = type.ToString();

                    foreach (var item in moves)
                    {
                        if (item.Type == "Water")
                        {
                            comboMove1.Items.Add(item.Name);
                            comboMove2.Items.Add(item.Name);
                            comboMove3.Items.Add(item.Name);
                            comboMove4.Items.Add(item.Name);
                        }
                        if (item.MoveType == "SpeBoost" || item.MoveType == "AtkBoost")
                        {
                            comboMove1.Items.Add(item.Name);
                            comboMove2.Items.Add(item.Name);
                            comboMove3.Items.Add(item.Name);
                            comboMove4.Items.Add(item.Name);
                        }
                    }
                    #endregion
                    break;
                default:
                    picturePrev1.Image = Properties.Resources.Default;
                    break;
            }
        }

        private void Teambuilder_Load(object sender, EventArgs e)
        {

        }


        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (comboMove1.SelectedIndex == -1 || comboMove2.SelectedIndex == -1 || comboMove3.SelectedIndex == -1 || comboMove4.SelectedIndex == -1 || comboPickNFT1.SelectedIndex == -1)
            {
                MessageBox.Show("NFT is invalid. Please recheck how it's made.");
            }
            else
            {
                MessageBox.Show("NFT Validated, please add.");
                btnAddToTeam.Visible = true;
            }

        }

        #region MoveChangers
        private void comboMove1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddToTeam.Visible = false;
            foreach (var item in moves)
            {
                if (item.Name == comboMove1.Text)
                {
                    move1 = item;
                }
            }
        }

        private void comboMove2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddToTeam.Visible = false;
            foreach (var item in moves)
            {
                if (item.Name == comboMove2.Text)
                {
                    move1 = item;
                }
            }
        }

        private void comboMove3_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddToTeam.Visible = false;
            foreach (var item in moves)
            {
                if (item.Name == comboMove3.Text)
                {
                    move1 = item;
                }
            }
        }

        private void comboMove4_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddToTeam.Visible = false;
            foreach (var item in moves)
            {
                if (item.Name == comboMove4.Text)
                {
                    move1 = item;
                }
            }
        }
        #endregion

        private void btnAddToTeam_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add this NFT? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Adding respective NFT to team
                switch (counter)
                {
                    case 1:
                        nft1 = new NFTs(id, name, type, ability, hp, attack, defence, speed);
                        break;
                    case 2:
                        nft2 = new NFTs(id, name, type, ability, hp, attack, defence, speed);
                        break;
                    case 3:
                        nft3 = new NFTs(id, name, type, ability, hp, attack, defence, speed);
                        break;
                    default:
                        break;
                }

                // Clearing NFT creation window
                groupNFTS1.Visible = false;
                picturePrev1.Image = Properties.Resources.Default;
                comboPickNFT1.SelectedIndex = -1;

                comboMove1.SelectedIndex = -1;
                comboMove2.SelectedIndex = -1;
                comboMove3.SelectedIndex = -1;
                comboMove4.SelectedIndex = -1;

                lblAbility.Text = "-";
                lblType.Text = "-";
                lblHP.Text = "-";
                lblATK.Text = "-";
                lblDEF.Text = "-";
                lblSPE.Text = "-";
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (teamValidated)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save this Team and exit? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                        teams.Add(new Teams(txtTeamName.Text, nft1, nft2, nft3));
                        MessageBox.Show("Team successfully saved! Exiting...");
                }
                else
                {
                    MessageBox.Show("Exiting...");
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Team has not been validated yet. Would ypu like to exit and lose all progress? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Exiting...");
                }
            }

            this.Close();
            Form1 main = new Form1();
            main.Show();
        }

        private void btnValidateTeam_Click(object sender, EventArgs e)
        {
            
            if (counter != 3)
            {
                MessageBox.Show("Team is not valid, please add NFTs.");

            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtTeamName.Text))
                {
                    MessageBox.Show("Please enter the team name.");
                }
                else
                {
                    MessageBox.Show("Team Validated, click DONE to complete creation.");
                    teamValidated = true;

                }
            }
        }
    }
}
