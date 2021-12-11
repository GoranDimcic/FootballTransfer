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

        private void btnRegistryAsManager_Click(object sender, EventArgs e)
        {
            Boolean correct = DataProvider.CheckManagerRegistration(txtEmailManagerSign.Text);
            if (correct == true)
            {
                Manager manager = new Manager();
                manager.email = txtEmailManagerSign.Text;
                manager.password = txtPasswordManagerSign.Text;
                manager.name = txtNameManagerSign.Text;
                manager.surname = txtSurnameManagerSign.Text;
                manager.country = txtCountryManagerSign.Text;

                if (manager.password == "")
                {
                    MessageBox.Show("You didn't enter a password, try again!");
                }
                else
                {
                    DataProvider.addManager(manager);
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
