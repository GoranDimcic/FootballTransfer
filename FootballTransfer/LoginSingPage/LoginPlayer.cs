using FootballTransfer.Entities;
using FootballTransfer.ViewPage;
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
    public partial class LoginPlayer : Form
    {
        private Player newPlayer;

        public LoginPlayer()
        {
            InitializeComponent();
        }

        private void btnLoginAsPlayer_Click(object sender, EventArgs e)
        {
            string email, password;
            email = txtEmail.Text;
            password = txtPassword.Text;

            newPlayer = DataProvider.proveriSifruKupca(txtEmail.Text, txtPassword.Text);
            if (newPlayer == null)
            {
                txtEmail.Text = "";
                txtPassword.Text = "";
            }

            PlayerView form = new PlayerView();
            this.Visible = false;
            form.ShowDialog();
        }
    }
}
