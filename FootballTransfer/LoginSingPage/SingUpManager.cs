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
                    email = txtEmailManagerSign.Text,
                    password = txtPasswordManagerSign.Text,
                    name = txtNameManagerSign.Text,
                    surname = txtSurnameManagerSign.Text,
                    country = txtCountryManagerSign.Text
                };

                if (manager.email == "")
                {
                    MessageBox.Show("You didn't enter an email, try again!");
                }
                else if (manager.password == "")
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
