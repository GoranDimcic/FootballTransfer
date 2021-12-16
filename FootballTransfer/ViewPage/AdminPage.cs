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

        private void BtnPlayer_Click(object sender, EventArgs e)
        {
            BtnPlayer.Visible = false;
            BtnLoginPlayer.Visible = true;
            BtnRegistryPlayer.Visible = true;
            BtnX1.Visible = true;
            lblPlayer.Visible = true;

            BtnManager.Visible = true;
            BtnLoginManager.Visible = false;
            BtnRegistryManager.Visible = false;
            BtnX2.Visible = false;
            lblManager.Visible = false;

            BtnClub.Visible = true;
            BtnLoginClub.Visible = false;
            BtnRegistryClub.Visible = false;
            BtnX3.Visible = false;
            lblClub.Visible = false;
        }

        private void BtnX1_Click(object sender, EventArgs e)
        {
            BtnPlayer.Visible = true;
            BtnLoginPlayer.Visible = false;
            BtnRegistryPlayer.Visible = false;
            BtnX1.Visible = false;
            lblPlayer.Visible = false;
        }

        private void BtnManager_Click(object sender, EventArgs e)
        {
            BtnManager.Visible = false;
            BtnLoginManager.Visible = true;
            BtnRegistryManager.Visible = true;
            BtnX2.Visible = true;
            lblManager.Visible = true;

            BtnPlayer.Visible = true;
            BtnLoginPlayer.Visible = false;
            BtnRegistryPlayer.Visible = false;
            BtnX1.Visible = false;
            lblPlayer.Visible = false;

            BtnClub.Visible = true;
            BtnLoginClub.Visible = false;
            BtnRegistryClub.Visible = false;
            BtnX3.Visible = false;
            lblClub.Visible = false;
        }

        private void BtnX2_Click(object sender, EventArgs e)
        {
            BtnManager.Visible = true;
            BtnLoginManager.Visible = false;
            BtnRegistryManager.Visible = false;
            BtnX2.Visible = false;
            lblManager.Visible = false;
        }

        private void BtnClub_Click(object sender, EventArgs e)
        {
            BtnClub.Visible = false;
            BtnLoginClub.Visible = true;
            BtnRegistryClub.Visible = true;
            BtnX3.Visible = true;
            lblClub.Visible = true;

            BtnManager.Visible = true;
            BtnLoginManager.Visible = false;
            BtnRegistryManager.Visible = false;
            BtnX2.Visible = false;
            lblManager.Visible = false;

            BtnPlayer.Visible = true;
            BtnLoginPlayer.Visible = false;
            BtnRegistryPlayer.Visible = false;
            BtnX1.Visible = false;
            lblPlayer.Visible = false;
        }

        private void BtnX3_Click(object sender, EventArgs e)
        {
            BtnClub.Visible = true;
            BtnLoginClub.Visible = false;
            BtnRegistryClub.Visible = false;
            BtnX3.Visible = false;
            lblClub.Visible = false;
        }

        private void BtnLoginPlayer_Click(object sender, EventArgs e)
        {
            LoginPlayer form = new LoginPlayer();
            form.ShowDialog();
        }

        private void BtnRegistryPlayer_Click(object sender, EventArgs e)
        {
            SingUpPlayer form = new SingUpPlayer();
            form.ShowDialog();
        }

        private void BtnLoginManager_Click(object sender, EventArgs e)
        {
            LoginManager form = new LoginManager();
            form.ShowDialog();
        }

        private void BtnRegistryManager_Click(object sender, EventArgs e)
        {
            SingUpManager form = new SingUpManager();
            form.ShowDialog();
        }

        private void BtnLoginClub_Click(object sender, EventArgs e)
        {
            LoginClub form = new LoginClub();
            form.ShowDialog();
        }

        private void BtnRegistryClub_Click(object sender, EventArgs e)
        {
            SingUpClub form = new SingUpClub();
            form.ShowDialog();
        }
    }
}
