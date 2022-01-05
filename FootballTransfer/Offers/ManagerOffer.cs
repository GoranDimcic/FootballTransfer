﻿using FootballTransfer.Entities;
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
    public partial class ManagerOffer : Form
    {
        public ManagerOffer(string name, string email, Manager manager)
        {
            InitializeComponent();
            ManagerOfferPage(name, email, manager);
        }

        public void ManagerOfferPage(string name, string email, Manager manager)
        {
            TxtSelectedPlayerEmail.Text = email;
            TxtSelectedPlayerName.Text = name;
            TxtManagerEmail.Text = manager.Email;
            TxtManagerName.Text = manager.Name;
        }

        private void BtnCreateContract_Click(object sender, EventArgs e)
        {
            if (TxtContractDuraction.Text == "")
                MessageBox.Show("You must enter contract duraction!");
            else if (TxtOfferPrice.Text == "")
                MessageBox.Show("You must enter offer price!");

            DialogResult = DialogResult.Cancel;
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
