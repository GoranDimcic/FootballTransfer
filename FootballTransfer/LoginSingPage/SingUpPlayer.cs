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

        private void BtnRegistryAsPlayer_Click(object sender, EventArgs e)
        {
            Boolean correct = DataProvider.CheckPlayerRegistration(txtEmailPlayerSign.Text);
            if (correct == true)
            {
                Player player = new Player
                {
                    Email = txtEmailPlayerSign.Text,
                    Password = txtPasswordPlayerSign.Text,
                    Name = txtNamePlayerSign.Text,
                    Age = txtAgePlayerSign.Text,
                    Country = txtCountryPlayerSign.Text,
                    Position = comboBoxPosition.Text
                };

                if (player.Email == "")
                {
                    MessageBox.Show("You didn't enter an email, try again!");
                }
                else if (player.Password == "")
                {
                    MessageBox.Show("You didn't enter a password, try again!");
                }
                else
                {
                    DataProvider.AddPlayer(player);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                txtEmailPlayerSign.Text = "";
                MessageBox.Show("An account with that email already exists!");
            }
        }

        private void TxtAgePlayerSign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}