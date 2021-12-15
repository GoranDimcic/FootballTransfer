using FootballTransfer.Entities;
using FootballTransfer.Update;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballTransfer.ViewPage
{
    public partial class ManagerView : Form
    {
        public Manager updateManager;

        public ManagerView(Manager manager)
        {
            InitializeComponent();
            fillDescription(manager);
        }

        public void fillDescription(Manager manager)
        {
            txtManagerName.Text = manager.name;
            txtManagerSurname.Text = manager.surname;
            txtManagerCountry.Text = manager.country;
        }

        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            UpdateManager form = new UpdateManager();
            form.ShowDialog();
        }
    }
}
