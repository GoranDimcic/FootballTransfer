using FootballTransfer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballTransfer.Offers
{
    public partial class OfferClub : Form
    {
        public OfferClub(string email, string name, Club club)
        {
            InitializeComponent();
            ClubOfferPage(email, name, club);
        }

        public void ClubOfferPage(string email, string name, Club club)
        {
            TxtSelectedPlayerEmail.Text = email;
            TxtSelectedPlayerName.Text = name;
            TxtClubName.Text = club.Name;
            TxtClubEmail.Text = club.Email;
            TxtClubLeague.Text = club.LeagueName;
        }

        private void BtnCreateContract_Click(object sender, EventArgs e)
        {
            ClubOffer offer = new ClubOffer()
            {
                PlayerName = TxtSelectedPlayerName.Text,
                PlayerEmail = TxtSelectedPlayerEmail.Text,

                ClubName = TxtClubName.Text,
                ClubEmail = TxtClubEmail.Text,
                League = TxtClubLeague.Text,
                Duraction = TxtContractDuraction.Text,
                Salary = TxtContractSalary.Text
            };

            if (TxtContractDuraction.Text == "")
                MessageBox.Show("You must enter contract duraction!");
            else if (TxtContractSalary.Text == "")
                MessageBox.Show("You must enter offer price!");
            else
            {
                DataProvider.AddClubOffer(offer);
                DialogResult = DialogResult.OK;
            }
        }

        private void TxtNumberOnly_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtEnterClick_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnCreateContract.PerformClick();
        }
    }
}
