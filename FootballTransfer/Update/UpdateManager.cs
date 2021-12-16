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
            updateManager.name = GetCorrectField(txtUpdateManagerName.Text, updateManager.name);
            updateManager.surname = GetCorrectField(txtUpdateManagerSurname.Text, updateManager.surname);
            updateManager.country = GetCorrectField(txtUpdateManagerCountry.Text, updateManager.country);

            DataProvider.UpdateManager(updateManager);
            this.DialogResult = DialogResult.OK;
        }

        private string GetCorrectField(string valueTxt, string valueManager)
            => string.IsNullOrEmpty(valueTxt)
                ? valueManager
                : valueTxt;
    }
}
