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
        public LoginManager()
        {
            InitializeComponent();
        }

        private void btnLoginAsManager_Click(object sender, EventArgs e)
        {
            ManagerView form = new ManagerView();
            this.Visible = false;
            form.ShowDialog();
        }
    }
}
