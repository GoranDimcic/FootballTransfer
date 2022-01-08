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
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            TransferList form = new TransferList();
            form.ShowDialog();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            User form = new User();
            form.ShowDialog();
        }
    }
}
