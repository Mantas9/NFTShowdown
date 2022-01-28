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
        List<Bitmap> bgs = new List<Bitmap>();
        int bgIndex;
        NFTs player;
        int wins = 0;
        int losses = 0;

        //AI
        Random randomAI = new Random();
        NFTs ai;

        //Damage
        Moves attackingMove;
        Moves aiMove;

        //GUI
        int turn = 1;
        int dead = 0;

        #endregion

        public BattleWindow(string format, List<NFTs> nfts, ref int wins, ref int losses)
        {
            InitializeComponent();
            this.format = format;
            this.nfts = nfts;
            this.wins = wins;
            this.losses = losses;
        }

        // Battle window has multiple functions for different formats.
        private void BattleWindow_Load(object sender, EventArgs e)
        {
            switch (format)
            {
                case "Random 1v1 Battle":
                    // Randomizing NFTs used for battle
                    Random random = new Random();
                    int playerID = random.Next(1, nfts.Count + 1);
                    int cpuID = random.Next(1, nfts.Count + 1);
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
                        case 4:
                            picturePlayer.Image = Properties.Resources.sombrerometamole;
                            break;
                        case 5:
                            picturePlayer.Image = Properties.Resources.hallowedmetamole;
                            break;
                        case 6:
                            picturePlayer.Image = Properties.Resources.kingmetamole;
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
                        case 4:
                            pictureCPU.Image = Properties.Resources.sombrerometamole;
                            break;
                        case 5:
                            pictureCPU.Image = Properties.Resources.hallowedmetamole;
                            break;
                        case 6:
                            pictureCPU.Image = Properties.Resources.kingmetamole;
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
                    // Assign moves to buttons
                    #region MovesButtons
                    btnMove1.Text = $"{item.Move1.Name} \n{item.Move1.Type}, Pow: {item.Move1.Power}, Acc: {item.Move1.Accuracy}, {item.Move1.MoveType}";
                    btnMove2.Text = $"{item.Move2.Name} \n{item.Move2.Type}, Pow: {item.Move2.Power}, Acc: {item.Move2.Accuracy}, {item.Move2.MoveType}";
                    btnMove3.Text = $"{item.Move3.Name} \n{item.Move3.Type}, Pow: {item.Move3.Power}, Acc: {item.Move3.Accuracy}, {item.Move3.MoveType}";
                    btnMove4.Text = $"{item.Move4.Name} \n{item.Move4.Type}, Pow: {item.Move4.Power}, Acc: {item.Move4.Accuracy}, {item.Move4.MoveType}";
                    #endregion
                    player = new NFTs(item.ID, item.Name, item.Type, item.Ability, item.HP, item.Attack, item.Defense, item.Speed, item.Move1, item.Move2, item.Move3, item.Move4); ;
                    // Linking Progress bar/label with HP
                    progPlayerHP.Maximum = player.HP;
                    progPlayerHP.Value = player.HP;
                    lblPlayerHP.Text = progPlayerHP.Value.ToString();
                }
                if (item.ID == cpuID)
                {
                    ai = new NFTs(item.ID, item.Name, item.Type, item.Ability, item.HP, item.Attack, item.Defense, item.Speed, item.Move1, item.Move2, item.Move3, item.Move4);
                    // Linking Progress bar/label with HP
                    progCPUHP.Maximum = ai.HP;
                    progCPUHP.Value = ai.HP;
                    lblCPUHP.Text = ai.HP.ToString();
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
                if (dead != 1)
                {
                    AIDamageCalculation(player, ai, 0);
                }
            }
            else if (player.Speed < ai.Speed)
            {
                AIDamageCalculation(player, ai, 1);
                if (dead != 1)
                {
                    PlayerDamageCalculation(player, ai, attackingMove, 0);
                }
            }
            else
            {
                int tieBreak = randomAI.Next(0, 1);
                for (int i = 0; i < randomAI.Next(0, 100); i++)
                {
                    tieBreak = randomAI.Next(0, 1);
                }
                if (tieBreak == 0)
                {
                    PlayerDamageCalculation(player, ai, attackingMove, 1);
                    if (dead != 1)
                    {
                        AIDamageCalculation(player, ai, 0);
                    }
                }
                else
                {
                    AIDamageCalculation(player, ai, 1);
                    if (dead != 1)
                    {
                        PlayerDamageCalculation(player, ai, attackingMove, 0);
                    }
                }
            }
            turn++;
            #endregion
        }

        private void PlayerDamageCalculation(NFTs player, NFTs ai, Moves move, int first)
        {
            #region Variables
            double calculated = ((((((2 * 100) / 5) + 2) * move.Power * ((double)player.Attack / (double)ai.Defense)) / 50) + 2);
            int damage = Convert.ToInt32(calculated);
            Random rand = new Random();
            #endregion
                // Move type checks
            switch (move.MoveType)
                {
                    case "Healing":
                        #region Healing
                        if (player.HP <= progPlayerHP.Maximum && player.HP <= progPlayerHP.Maximum / 2)
                        {
                            // NFT recovers half its health
                            player.HP += progPlayerHP.Maximum / 2;
                            progPlayerHP.Value = player.HP;
                            lblPlayerHP.Text = player.HP.ToString();
                            if (first == 1)
                            {
                                txtLogs.Text += ($"Turn {turn}:\n{player.Name} used {move.Name}! \n{player.Name} recovered 50% HP!\n");

                            }
                            else
                            {
                                txtLogs.Text += ($"{player.Name} used {move.Name}! \n{player.Name} recovered 50% HP!\n");
                            }
                        }
                        else if (player.HP > progPlayerHP.Maximum / 2)
                        {
                            player.HP = progPlayerHP.Maximum;
                            progPlayerHP.Value = player.HP;
                            lblPlayerHP.Text = player.HP.ToString();
                            if (first == 1)
                            {
                                txtLogs.Text += ($"Turn {turn}:\n{player.Name} used {move.Name}! \n{player.Name} recovered 50% HP!\n");

                            }
                            else
                            {
                                txtLogs.Text += ($"{player.Name} used {move.Name}! \n{player.Name} recovered 50% HP!\n");
                            }
                        }
                        #endregion
                        break;
                    case "Damage":
                        #region Damage
                        int chance = rand.Next(0, 100);
                        for (int i = 0; i < rand.Next(1, 100); i++)
                        {
                            chance = rand.Next(0, 100);
                        }
                        if (chance < move.Accuracy)
                        {
                            if (ai.HP - damage <= 0)
                            {
                                ai.HP = 0;
                                progCPUHP.Value = 0;
                                lblCPUHP.Text = "0";
                                if (first == 1)
                                {
                                    txtLogs.Text += ($"Turn: {turn}\n{player.Name} used {move.Name}! \nThe opposing {ai.Name} took {damage} damage! A knockout!\n");

                                }
                                else
                                {
                                    txtLogs.Text += ($"{player.Name} used {move.Name}! \nThe opposing {ai.Name} took {damage} damage! A knockout!\n");
                                }
                                btnMove1.Enabled = false;
                                btnMove2.Enabled = false;
                                btnMove3.Enabled = false;
                                btnMove4.Enabled = false;
                                pictureDeadAI.Visible = true;
                                dead = 1;
                                wins++;
                                MessageBox.Show("Player Won!");
                                btnExit.Visible = true;
                            }
                            else
                            {
                                ai.HP -= damage;
                                progCPUHP.Value = ai.HP;
                                lblCPUHP.Text = progCPUHP.Value.ToString();
                                if (first == 1)
                                {
                                    txtLogs.Text += ($"Turn: {turn}\n{player.Name} used {move.Name}! \nThe opposing {ai.Name} took {damage} damage!\n");

                                }
                                else
                                {
                                    txtLogs.Text += ($"{player.Name} used {move.Name}! \nThe opposing {ai.Name} took {damage} damage!\n");
                                }
                            }

                        }
                        else
                        {
                            if (first == 1)
                            {
                                txtLogs.Text += ($"Turn {turn}:\n{player.Name} used {move.Name}! \nThe opposing {ai.Name} avoided the attack!\n");

                            }
                            else
                            {
                                txtLogs.Text += ($"{player.Name} used {move.Name}! \nThe opposing {ai.Name} avoided the attack!\n");
                            }
                        }
                        #endregion
                        break;
                    case "AtkBoost":
                        #region AtkBoost
                        player.Attack *= move.Power;
                        if (first == 1)
                        {
                            txtLogs.Text += ($"Turn {turn}:\n{player.Name} used {move.Name}! \n{player.Name} Multiplied their Atk stat by {move.Power}!\n");

                        }
                        else
                        {
                            txtLogs.Text += ($"{player.Name} used {move.Name}! \n{player.Name} Multiplied their Atk stat by {move.Power}!\n");
                        }
                        #endregion
                        break;
                    case "DefBoost":
                        #region DefBoost
                        player.Defense *= move.Power;
                        if (first == 1)
                        {
                            txtLogs.Text += ($"Turn {turn}:\n{player.Name} used {move.Name}! \n{player.Name} Multiplied their Def stat by {move.Power}!\n");

                        }
                        else
                        {
                            txtLogs.Text += ($"{player.Name} used {move.Name}! \n{player.Name} Multiplied their Def stat by {move.Power}!\n");
                        }
                        #endregion
                        break;
                    case "SpeBoost":
                        #region SpeBoost
                        player.Attack *= move.Power;
                        if (first == 1)
                        {
                            txtLogs.Text += ($"Turn {turn}:\n{player.Name} used {move.Name}! \n{player.Name} Multiplied their Spe stat by {move.Power}!\n");

                        }
                        else
                        {
                            txtLogs.Text += ($"{player.Name} used {move.Name}! \n{player.Name} Multiplied their Spe stat by {move.Power}!\n");
                        }
                        #endregion
                        break;
                    default:
                        break;
                }
            

        }

        private void AIDamageCalculation(NFTs player, NFTs ai, int first)
        {
            //Variables
            #region Variables
            // Defining AI move id
            int moveID = randomAI.Next(1, 4);
            for (int i = 0; i < randomAI.Next(0, 100); i++)
            {
                moveID = randomAI.Next(1, 4);
            }
            // transfering the move ID to a move
            switch (moveID)
            {
                case 1:
                    aiMove = player.Move1;
                    break;
                case 2:
                    aiMove = player.Move2;
                    break;
                case 3:
                    aiMove = player.Move3;
                    break;
                case 4:
                    aiMove = player.Move4;
                    break;
                default:
                    break;
            }

            double calculated = ((((((2 * 100) / 5) + 2) * aiMove.Power * ((double)player.Attack / (double)ai.Defense)) / 50) + 2);
            int damage = Convert.ToInt32(calculated);
            Random rand = new Random();
            #endregion
            // Move type checks
            switch (aiMove.MoveType)
                {
                    case "Healing":
                        #region Healing
                        if (ai.HP <= progCPUHP.Maximum && ai.HP <= progCPUHP.Maximum / 2)
                        {
                            // NFT recovers half its health
                            ai.HP += progCPUHP.Maximum / 2;
                            progCPUHP.Value = ai.HP;
                            lblCPUHP.Text = progCPUHP.Value.ToString(); ;
                            if (first == 1)
                            {
                                txtLogs.Text += ($"Turn {turn}:\nThe opposing {ai.Name} used {aiMove.Name}! \nThe opposing {ai.Name} recovered 50% HP!\n");
                            }
                            else
                            {
                                txtLogs.Text += ($"The opposing {ai.Name} used {aiMove.Name}! \nThe opposing {ai.Name} recovered 50% HP!\n");
                            }
                        }
                        else if (ai.HP > progPlayerHP.Maximum / 2)
                        {
                            ai.HP = progCPUHP.Maximum;
                            progCPUHP.Value = ai.HP;
                            lblCPUHP.Text = progCPUHP.Value.ToString();
                            if (first == 1)
                            {
                                txtLogs.Text += ($"Turn {turn}:\nThe opposing {ai.Name} used {aiMove.Name}! \nThe opposing {ai.Name} recovered 50% HP!\n");
                            }
                            else
                            {
                                txtLogs.Text += ($"The opposing {ai.Name} used {aiMove.Name}! \nThe opposing {ai.Name} recovered 50% HP!\n");
                            }
                        }
                        
                        #endregion
                        break;
                    case "Damage":
                        #region Damage
                        int chance = rand.Next(0, 100);
                        for (int i = 0; i < rand.Next(1, 100); i++)
                        {
                            chance = rand.Next(0, 100);
                        }
                        if (chance < aiMove.Accuracy)
                        {
                            if (player.HP - damage <= 0)
                            {
                                player.HP = 0;
                                progPlayerHP.Value = 0;
                                lblPlayerHP.Text = "0";
                                if (first == 1)
                                {
                                    txtLogs.Text += ($"Turn {turn}:\nThe opposing {ai.Name} used {aiMove.Name}! \n{player.Name} took {damage} damage! A knockout!\n");
                                }
                                else
                                {
                                    txtLogs.Text += ($"The opposing {ai.Name} used {aiMove.Name}! \n{player.Name} took {damage} damage! A knockout!\n");
                                }
                                btnMove1.Enabled = false;
                                btnMove2.Enabled = false;
                                btnMove3.Enabled = false;
                                btnMove4.Enabled = false;
                                pictureDead.Visible = true;
                                dead = 1;
                                losses++;
                                MessageBox.Show("CPU Wins! Good luck next time!");
                                btnExit.Visible = true;
                            }
                            else
                            {
                                player.HP -= damage;
                                progPlayerHP.Value = player.HP;
                                lblPlayerHP.Text = progPlayerHP.Value.ToString();
                                if (first == 1)
                                {
                                    txtLogs.Text += ($"Turn {turn}:\nThe opposing {ai.Name} used {aiMove.Name}! \n{player.Name} took {damage} damage!\n");
                                }
                                else
                                {
                                    txtLogs.Text += ($"The opposing {ai.Name} used {aiMove.Name}! \n{player.Name} took {damage} damage!\n");
                                }
                            }
                        }
                        else
                        {
                            if (first == 1)
                            {
                                txtLogs.Text += ($"Turn {turn}:\nThe opposing {ai.Name} used {aiMove.Name}! \n{player.Name} avoided the attack!\n");

                            }
                            else
                            {
                                txtLogs.Text += ($"The opposing {ai.Name} used {aiMove.Name}! \n{player.Name} avoided the attack!\n");
                            }
                        }
                        #endregion
                        break;
                    case "AtkBoost":
                        #region AtkBoost
                        ai.Attack *= aiMove.Power;
                        if (first == 1)
                        {
                            txtLogs.Text += ($"Turn {turn}:\nThe opposing {ai.Name} used {aiMove.Name}! \nThe opposing {ai.Name} Multiplied their Atk stat by {aiMove.Power}!\n");

                        }
                        else
                        {
                            txtLogs.Text += ($"The opposing {ai.Name} used {aiMove.Name}! \nThe opposing {ai.Name} Multiplied their Atk stat by {aiMove.Power}!\n");
                        }
                        #endregion
                        break;
                    case "DefBoost":
                        #region DefBoost
                        ai.Defense *= aiMove.Power;
                        if (first == 1)
                        {
                            txtLogs.Text += ($"Turn {turn}:\nThe opposing {ai.Name} used {aiMove.Name}! \nThe opposing {ai.Name} Multiplied their Def stat by {aiMove.Power}!\n");

                        }
                        else
                        {
                            txtLogs.Text += ($"The opposing {ai.Name} used {aiMove.Name}! \nThe opposing {ai.Name} Multiplied their Def stat by {aiMove.Power}!\n");
                        }
                        #endregion
                        break;
                    case "SpeBoost":
                        #region SpeBoost
                        ai.Attack *= aiMove.Power;
                        if (first == 1)
                        {
                            txtLogs.Text += ($"Turn {turn}:\nThe opposing {ai.Name} used {aiMove.Name}! \nThe opposing {ai.Name} Multiplied their Spe stat by {aiMove.Power}!\n");

                        }
                        else
                        {
                            txtLogs.Text += ($"The opposing {ai.Name} used {aiMove.Name}! \nThe opposing {ai.Name} Multiplied their Spe stat by {aiMove.Power}!\n");
                        }
                        #endregion
                        break;
                    default:
                        break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
