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

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bgHome = new Bitmap(Properties.Resources.bgDefault);
            this.BackgroundImage = bgHome;
        }

        private void comboFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFormat.SelectedItem.ToString() == "Teams Battle")
            {
                label2.Visible = true;
                comboTeams.Visible = true;
            }
            else
            {
                label2.Visible = false;
                comboTeams.Visible = false;
            }
        }

        private void btnNewTeam_Click(object sender, EventArgs e)
        {
            Teambuilder teambuilder = new Teambuilder();
            teambuilder.Show();
            this.Hide();
        }
    }
}
