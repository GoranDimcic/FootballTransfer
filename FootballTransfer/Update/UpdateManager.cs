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

namespace FootballTransfer.Update
{
    public partial class UpdateManager : Form
    {
        public Manager updateManager;

        public UpdateManager(Manager manager)
        {
            InitializeComponent();
            updateManager = manager;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            updateManager.Name = GetCorrectField(txtUpdateManagerName.Text, updateManager.Name);
            updateManager.Country = GetCorrectField(txtUpdateManagerCountry.Text, updateManager.Country);

            DataProvider.UpdateManager(updateManager);
            this.DialogResult = DialogResult.OK;
        }

        private string GetCorrectField(string valueTxt, string valueManager)
            => string.IsNullOrEmpty(valueTxt)
                ? valueManager
                : valueTxt;
    }
}
