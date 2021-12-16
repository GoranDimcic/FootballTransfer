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

namespace FootballTransfer.Login
{
    public partial class SingUpManager : Form
    {
        public SingUpManager()
        {
            InitializeComponent();
        }

        private void BtnRegistryAsManager_Click(object sender, EventArgs e)
        {
            Boolean correct = DataProvider.CheckManagerRegistration(txtEmailManagerSign.Text);
            if (correct == true)
            {
                Manager manager = new Manager
                {
                    Email = txtEmailManagerSign.Text,
                    Password = txtPasswordManagerSign.Text,
                    Name = txtNameManagerSign.Text,
                    Surname = txtSurnameManagerSign.Text,
                    Country = txtCountryManagerSign.Text
                };

                if (manager.Email == "")
                {
                    MessageBox.Show("You didn't enter an email, try again!");
                }
                else if (manager.Password == "")
                {
                    MessageBox.Show("You didn't enter a password, try again!");
                }
                else
                {
                    DataProvider.AddManager(manager);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                txtEmailManagerSign.Text = "";
                MessageBox.Show("An account with that email already exists!");
            }
        }
    }
}
