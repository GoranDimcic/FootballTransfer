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

namespace FootballTransfer.Login
{
    public partial class LoginManager : Form
    {
        public Manager newManager;

        public LoginManager()
        {
            InitializeComponent();
        }

        private void BtnLoginAsManager_Click(object sender, EventArgs e)
        {
            if (txtEmailLoginManager.Text == "")
            {
                MessageBox.Show("You didn't enter an email, try again!");
            }
            else if (txtPasswordLoginManager.Text == "")
            {
                MessageBox.Show("You didn't enter a password, try again!");
            }
            else
            {
                newManager = DataProvider.ManagerLogin(txtEmailLoginManager.Text, txtPasswordLoginManager.Text);
                if (newManager == null)
                {
                    txtEmailLoginManager.Text = "";
                    txtPasswordLoginManager.Text = "";
                    MessageBox.Show("Incorrect login, try again!");
                }
                else
                {
                    ManagerView form = new ManagerView(newManager);
                    this.Visible = false;
                    form.ShowDialog();
                }
            }
        }

        private void TxtEmailLoginManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnLoginAsManager.PerformClick();
        }

        private void TxtPasswordLoginManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnLoginAsManager.PerformClick();
        }
    }
}
