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

namespace FootballTransfer.Login
{
    public partial class LoginClub : Form
    {
        private Club newClub;

        public LoginClub()
        {
            InitializeComponent();
        }

        private void btnLoginAsPlayer_Click(object sender, EventArgs e)
        {
            if (txtEmailLoginClub.Text == "")
            {
                MessageBox.Show("You didn't enter an email, try again!");
            }
            else if (txtPasswordLoginClub.Text == "")
            {
                MessageBox.Show("You didn't enter a password, try again!");
            }
            else
            {
                newClub = DataProvider.ClubLogin(txtEmailLoginClub.Text, txtPasswordLoginClub.Text);
                if (newClub == null)
                {
                    txtEmailLoginClub.Text = "";
                    txtPasswordLoginClub.Text = "";
                    MessageBox.Show("Incorrect login, try again!");
                }
                else
                {
                    ClubView form = new ClubView();
                    this.Visible = false;
                    form.ShowDialog();
                }
            }
        }
    }
}
