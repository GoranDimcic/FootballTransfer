using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballTransfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            btnPlayer.Visible = false;
            btnLoginPlayer.Visible = true;
            btnRegistryPlayer.Visible = true;
            btnX1.Visible = true;
            lblPlayer.Visible = true;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            btnPlayer.Visible = true;
            btnLoginPlayer.Visible = false;
            btnRegistryPlayer.Visible = false;
            btnX1.Visible = false;
            lblPlayer.Visible = false;
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            btnManager.Visible = false;
            btnLoginManager.Visible = true;
            btnRegistryManager.Visible = true;
            btnX2.Visible = true;
            lblManager.Visible = true;
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            btnManager.Visible = true;
            btnLoginManager.Visible = false;
            btnRegistryManager.Visible = false;
            btnX2.Visible = false;
            lblManager.Visible = false;
        }

        private void btnClub_Click(object sender, EventArgs e)
        {
            btnClub.Visible = false;
            btnLoginClub.Visible = true;
            btnRegistryClub.Visible = true;
            btnX3.Visible = true;
            lblClub.Visible = true;
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            btnClub.Visible = true;
            btnLoginClub.Visible = false;
            btnRegistryClub.Visible = false;
            btnX3.Visible = false;
            lblClub.Visible = false;
        }

        private void btnLoginPlayer_Click(object sender, EventArgs e)
        {
            LoginPlayer form = new LoginPlayer();
            form.ShowDialog();
        }

        private void btnRegistryPlayer_Click(object sender, EventArgs e)
        {
            SingUpPlayer form = new SingUpPlayer();
            form.ShowDialog();
        }
    }
}
