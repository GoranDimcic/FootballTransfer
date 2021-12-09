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
        public LoginClub()
        {
            InitializeComponent();
        }

        private void btnLoginAsPlayer_Click(object sender, EventArgs e)
        {
            ClubView form = new ClubView();
            form.ShowDialog();
        }
    }
}
