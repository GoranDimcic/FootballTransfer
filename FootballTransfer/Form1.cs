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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            btnPlayer.Visible = false;
            btnLoginPlayer.Visible = true;
            btnRegistryPlayer.Visible = true;
            btnX.Visible = true;
            lblPlayer.Visible = true;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            btnPlayer.Visible = true;
            btnLoginPlayer.Visible = false;
            btnRegistryPlayer.Visible = false;
            btnX.Visible = false;
            lblPlayer.Visible = false;
        }
    }
}
