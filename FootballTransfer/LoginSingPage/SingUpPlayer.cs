using Cassandra;
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
    public partial class SingUpPlayer : Form
    {
        public SingUpPlayer()
        {
            InitializeComponent();
        }

        private void btnRegistryAsPlayer_Click(object sender, EventArgs e)
        {
            Boolean correct = DataProvider.checkPlayerRegistration(txtEmailPlayerSign.Text);
            if (correct == true)
            {
                Player player = new Player();
                player.email = txtEmailPlayerSign.Text;
                player.pasword = txtPasswordPlayerSign.Text;
                player.name = txtNamePlayerSign.Text;
                player.surname = txtSurnamePlayerSign.Text;
                player.country = txtCountryPlayerSign.Text;
                player.position = comboBoxPosition.Text;

                if(player.email == "")
                {
                    MessageBox.Show("You didn't enter an email, try again!");
                }
                else if (player.pasword == "")
                {
                    MessageBox.Show("You didn't enter a password, try again!");
                }
                else
                {
                    DataProvider.addPlayer(player);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                txtEmailPlayerSign.Text = "";
                MessageBox.Show("An account with that email already exists!");
            }
        }
    }
}