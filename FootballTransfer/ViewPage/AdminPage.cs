using FootballTransfer.Login;
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
    public partial class TransferList : Form
    {
        public TransferList()
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

            btnManager.Visible = true;
            btnLoginManager.Visible = false;
            btnRegistryManager.Visible = false;
            btnX2.Visible = false;
            lblManager.Visible = false;

            btnClub.Visible = true;
            btnLoginClub.Visible = false;
            btnRegistryClub.Visible = false;
            btnX3.Visible = false;
            lblClub.Visible = false;
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

            btnPlayer.Visible = true;
            btnLoginPlayer.Visible = false;
            btnRegistryPlayer.Visible = false;
            btnX1.Visible = false;
            lblPlayer.Visible = false;

            btnClub.Visible = true;
            btnLoginClub.Visible = false;
            btnRegistryClub.Visible = false;
            btnX3.Visible = false;
            lblClub.Visible = false;
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

            btnManager.Visible = true;
            btnLoginManager.Visible = false;
            btnRegistryManager.Visible = false;
            btnX2.Visible = false;
            lblManager.Visible = false;

            btnPlayer.Visible = true;
            btnLoginPlayer.Visible = false;
            btnRegistryPlayer.Visible = false;
            btnX1.Visible = false;
            lblPlayer.Visible = false;
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

        private void btnLoginManager_Click(object sender, EventArgs e)
        {
            LoginManager form = new LoginManager();
            form.ShowDialog();
        }

        private void btnRegistryManager_Click(object sender, EventArgs e)
        {
            SingUpManager form = new SingUpManager();
            form.ShowDialog();
        }

        private void btnLoginClub_Click(object sender, EventArgs e)
        {
            LoginClub form = new LoginClub();
            form.ShowDialog();
        }

        private void btnRegistryClub_Click(object sender, EventArgs e)
        {
            SingUpClub form = new SingUpClub();
            form.ShowDialog();
        }
    }
}
