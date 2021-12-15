using FootballTransfer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballTransfer.Login
{
    public partial class SingUpClub : Form
    {
        public SingUpClub()
        {
            InitializeComponent();
        }

        private void btnRegistryAsPlayer_Click(object sender, EventArgs e)
        {
            Boolean correct = DataProvider.CheckClubRegistration(txtEmailClubSign.Text);
            if (correct == true)
            {
                Club club = new Club();
                club.email = txtEmailClubSign.Text;
                club.password = txtPasswordClubSign.Text;
                club.name = txtNameClubSign.Text;
                club.leagueName = comboBoxClubCountry.Text;
                club.stadionName = txtStadionNameClubSign.Text;
                club.foundationDate = dateFoundationDate.Value.Date;
                club.town = txtTownClubSign.Text;
                club.stadionCapacity = Int32.Parse(txtCapacityClubSign.Text);

                if (club.email == "")
                {
                    MessageBox.Show("You didn't enter an email, try again!");
                }
                else if (club.password == "")
                {
                    MessageBox.Show("You didn't enter a password, try again!");
                }
                else
                {
                    DataProvider.AddClub(club);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                txtEmailClubSign.Text = "";
                MessageBox.Show("An account with that email already exists!");
            }
        }
    }
}
