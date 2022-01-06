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
    public partial class OfferManager : Form
    {
        public OfferManager(string email, string name, Manager manager)
        {
            InitializeComponent();
            ManagerOfferPage(email, name, manager);
        }

        public void ManagerOfferPage(string email, string name, Manager manager)
        {
            TxtSelectedPlayerEmail.Text = email;
            TxtSelectedPlayerName.Text = name;
            TxtManagerEmail.Text = manager.Email;
            TxtManagerName.Text = manager.Name;
        }

        private void BtnCreateContract_Click(object sender, EventArgs e)
        {
            ManagerOffer offer = new ManagerOffer
            {
                ManagerEmail = TxtManagerEmail.Text,
                ManagerName = TxtManagerName.Text,
                PlayerEmail = TxtSelectedPlayerEmail.Text,
                PlayerName = TxtSelectedPlayerName.Text,
                Duraction = TxtContractDuraction.Text,
                Offer = TxtOfferPrice.Text
            };

            //if (TxtContractDuraction.Text == "")
            //    MessageBox.Show("You must enter contract duraction!");
            //else if (TxtOfferPrice.Text == "")
            //    MessageBox.Show("You must enter offer price!");

            //DialogResult = DialogResult.Cancel;

            DataProvider.AddManagerOffer(offer);
            this.DialogResult = DialogResult.OK;
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
    }
}
