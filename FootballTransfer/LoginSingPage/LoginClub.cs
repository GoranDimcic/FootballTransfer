﻿using FootballTransfer.Entities;
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
        public Club newClub;

        public LoginClub()
        {
            InitializeComponent();
        }

        private void BtnLoginAsPlayer_Click(object sender, EventArgs e)
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
                    ClubView form = new ClubView(newClub);
                    this.Visible = false;
                    form.ShowDialog();
                }
            }
        }

        private void TxtEmailLoginClub_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnLoginAsPlayer.PerformClick();
        }

        private void TxtPasswordLoginClub_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnLoginAsPlayer.PerformClick();
        }
    }
}
