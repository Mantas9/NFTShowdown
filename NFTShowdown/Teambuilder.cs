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
    public partial class Teambuilder : Form
    {
        
        public Teambuilder()
        {
            InitializeComponent();
        }

        int counter = 0;

        private void btnAddNFT_Click(object sender, EventArgs e)
        {
            switch (counter)
            {
                case 0:
                    groupNFTS1.Visible = true;
                    counter++;
                    break;
                default:
                    break;
            }
        }

        private void comboPickNFT1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboPickNFT1.SelectedItem)
            {
                case "Red Bored Ape":
                    picturePrev1.Image = Properties.Resources.redboredape;
                        break;
                case "Primal Bored Ape":
                    picturePrev1.Image= Properties.Resources.primalboredape;
                    break;
                default:
                    picturePrev1.Image = Properties.Resources.Default;
                    break;
            }
        }

        private void Teambuilder_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }
    }
}
