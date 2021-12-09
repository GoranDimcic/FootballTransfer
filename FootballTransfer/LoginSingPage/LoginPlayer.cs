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

namespace FootballTransfer
{
    public partial class LoginPlayer : Form
    {
        public LoginPlayer()
        {
            InitializeComponent();
        }

        private void btnLoginAsPlayer_Click(object sender, EventArgs e)
        {
            PlayerView form = new PlayerView();
            this.Visible = false;
            form.ShowDialog();
        }
    }
}
