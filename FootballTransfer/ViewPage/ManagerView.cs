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
        public Manager loggedManager;

        public ManagerView(Manager manager)
        {
            InitializeComponent();
            FillDescription(manager);
            loggedManager = manager;
        }

        public void FillDescription(Manager manager)
        {
            txtManagerName.Text = manager.Name;
            txtManagerSurname.Text = manager.Surname;
            txtManagerCountry.Text = manager.Country;
        }

        private void BtnUpdatePlayer_Click(object sender, EventArgs e)
        {
            UpdateManager form = new UpdateManager(loggedManager);
            form.ShowDialog();
        }

        private void BtnDeleteManager_Click(object sender, EventArgs e)
        {
            DataProvider.DeleteManager(loggedManager);
            this.DialogResult = DialogResult.OK;
        }
    }
}
