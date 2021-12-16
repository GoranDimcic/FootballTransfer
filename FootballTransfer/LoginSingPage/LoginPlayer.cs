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
        public Player newPlayer;

        public LoginPlayer()
        {
            InitializeComponent();
        }

        private void BtnLoginAsPlayer_Click(object sender, EventArgs e)
        {
            if (txtEmailLoginPlayer.Text == "")
            {
                MessageBox.Show("You didn't enter an email, try again!");
            }
            else if (txtPasswordLoginPlayer.Text == "")
            {
                MessageBox.Show("You didn't enter a password, try again!");
            }
            else
            {
                newPlayer = DataProvider.PlayerLogin(txtEmailLoginPlayer.Text, txtPasswordLoginPlayer.Text);
                if (newPlayer == null)
                {
                    txtEmailLoginPlayer.Text = "";
                    txtPasswordLoginPlayer.Text = "";
                    MessageBox.Show("Incorrect login, try again!");
                }
                else
                {
                    PlayerView form = new PlayerView(newPlayer);
                    this.Visible = false;
                    form.ShowDialog();
                }
            }
        }
    }
}