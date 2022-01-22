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
    public partial class BattleWindow : Form
    {
        #region Variables
        string format = "";
        List<NFTs> nfts = new List<NFTs>();
        NFTs player;

        //AI
        Random randomAI = new Random();
        NFTs ai;

        //Damage
        Moves attackingMove;
        Moves aiMove;

        //GUI
        int turn = 1;

        #endregion

        public BattleWindow(string format, List<NFTs> nfts)
        {
            InitializeComponent();
            this.format = format;
            this.nfts = nfts;
        }

        // Battle window has multiple functions for different formats.
        private void BattleWindow_Load(object sender, EventArgs e)
        {
            switch (format)
            {
                case "Random 1v1 Battle":
                    // Randomizing NFTs used for battle
                    Random random = new Random();
                    int playerID = random.Next(1, nfts.Count+1);
                    int cpuID = random.Next(1, nfts.Count+1);
                    for (int i = 0; i < random.Next(1, 100); i++)
                    {
                        cpuID = random.Next(1, nfts.Count);
                    }
                    // Adding images of selected NFTs
                    switch (playerID)
                    {
                        case 1:
                            picturePlayer.Image = Properties.Resources.redboredape;
                            break;
                        case 2:
                            picturePlayer.Image = Properties.Resources.primalboredape;
                            break;
                        case 3:
                            picturePlayer.Image = Properties.Resources.laserBoredApe;
                            break;
                        default:
                            break;
                    }
                    switch (cpuID)
                    {
                        case 1:
                            pictureCPU.Image = Properties.Resources.redboredape;
                            break;
                        case 2:
                            pictureCPU.Image = Properties.Resources.primalboredape;
                            break;
                        case 3:
                            pictureCPU.Image = Properties.Resources.laserBoredApe;
                            break;
                        default:
                            break;
                    }
                    // Initializing the battle
                    Initialize1v1Battle(playerID, cpuID);
                    break;
                default:
                    break;
            }
        }

        private void Initialize1v1Battle(int playerID, int cpuID)
        {
            // Adding player/cpu NFT objects to further use in battle
            foreach (var item in nfts)
            {
                if (item.ID == playerID)
                {
                    btnMove1.Text = $"{item.Move1.Name} \n{item.Move1.Type}, Pow: {item.Move1.Damage}, Acc: {item.Move1.Accuracy}, {item.Move1.MoveType}";
                    btnMove2.Text = $"{item.Move2.Name} \n{item.Move2.Type}, Pow: {item.Move2.Damage}, Acc: {item.Move2.Accuracy}, {item.Move2.MoveType}";
                    btnMove3.Text = $"{item.Move3.Name} \n{item.Move3.Type}, Pow: {item.Move3.Damage}, Acc: {item.Move3.Accuracy}, {item.Move3.MoveType}";
                    btnMove4.Text = $"{item.Move4.Name} \n{item.Move4.Type}, Pow: {item.Move4.Damage}, Acc: {item.Move4.Accuracy}, {item.Move4.MoveType}";
                    player = item;
                }
                if (item.ID == cpuID)
                {
                    ai = item;
                }
            }
        }

        // Player selects move. Commence damage calculation
        #region Move Selection
        private void btnMove1_Click(object sender, EventArgs e)
        {
            MasterDamageCalculation(player, ai, 1);
        }

        private void btnMove2_Click(object sender, EventArgs e)
        {
            MasterDamageCalculation(player, ai, 2);
        }

        private void btnMove3_Click(object sender, EventArgs e)
        {
            MasterDamageCalculation(player, ai, 3);
        }

        private void btnMove4_Click(object sender, EventArgs e)
        {
            MasterDamageCalculation(player, ai, 4);
        }
        #endregion

        private void MasterDamageCalculation(NFTs player, NFTs ai, int moveIndx)
        {
            // Defining chosen move by player
            switch (moveIndx)
            {
                case 1:
                    attackingMove = player.Move1;
                    break;
                case 2:
                    attackingMove = player.Move2;
                    break;
                case 3:
                    attackingMove = player.Move3;
                    break;
                case 4:
                    attackingMove = player.Move4;
                    break;
                default:
                    break;
            }
            // Calling branch damage calculation functions
            #region Calling Branch Calculations
            if (player.Speed > ai.Speed)
            {
                PlayerDamageCalculation(player, ai, attackingMove, 1);
                AIDamageCalculation(player, ai, 0);
            }
            else if(player.Speed < ai.Speed)
            {
                AIDamageCalculation(player, ai, 1);
                PlayerDamageCalculation(player, ai, attackingMove, 0);
            }
            else
            {
                int tieBreak = randomAI.Next(0, 1);
                for (int i = 0; i < randomAI.Next(0,100); i++)
                {
                    tieBreak = randomAI.Next(0, 1);
                }
                if (tieBreak == 0)
                {
                    PlayerDamageCalculation(player, ai, attackingMove, 1);
                    AIDamageCalculation(player, ai, 0);
                }
                else
                {
                    AIDamageCalculation(player, ai, 1);
                    PlayerDamageCalculation(player, ai, attackingMove, 0);
                }
            }
            turn++;
            #endregion
        }

        private void PlayerDamageCalculation(NFTs player, NFTs ai, Moves move, int first)
        {
            int damage = ((((((2*100)/5)+2)*move.Damage*(player.Attack/ai.Defense))/50)+2);
            //Checking if player went first, adding to logs
            // True
            if (first == 1)
            {
                txtLogs.Text += ($"Turn {turn}:\n{player.Name} used {move.Name}! \nThe opposing {ai.Name} took {damage} damage!\n");
            }
            // False
            else
            {
                txtLogs.Text += ($"{player.Name} used {move.Name}! \nThe opposing {ai.Name} took {damage} damage!\n");
            }
            
        }

        private void AIDamageCalculation(NFTs player, NFTs ai, int first)
        {
            // Defining AI move id
            int moveID = randomAI.Next(1, 4);
            for (int i = 0; i < randomAI.Next(0,100); i++)
            {
                moveID = randomAI.Next(1, 4);
            }
            // transfering the move ID to a move
            switch (moveID)
            {
                case 1:
                    aiMove = ai.Move1;
                    break;
                case 2:
                    aiMove = ai.Move2;
                    break;
                case 3:
                    aiMove = ai.Move3;
                    break;
                case 4:
                    aiMove = ai.Move4;
                    break;
                default:
                    break;
            }

            int damage = ((((((2 * 100) / 5) + 2) * aiMove.Damage * (ai.Attack / player.Defense)) / 50) + 2);
            //Checking if ai went first, adding to logs
            // True
            if (first == 1)
            {
                txtLogs.Text += ($"Turn {turn}:\n{ai.Name} used {aiMove.Name}! \nThe opposing {player.Name} took {damage} damage!\n");
            }
            // False
            else
            {
                txtLogs.Text += ($"{ai.Name} used {aiMove.Name}! \nThe opposing {player.Name} took {damage} damage!\n");
            }
        }

    }
}
