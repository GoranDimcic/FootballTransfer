﻿using FootballTransfer.Entities;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateManager.name = GetCorrentField(txtUpdateManagerName.Text, updateManager.name);
            updateManager.surname = GetCorrentField(txtUpdateManagerSurname.Text, updateManager.surname);
            updateManager.country = GetCorrentField(txtUpdateManagerCountry.Text, updateManager.country);

            DataProvider.UpdateManager(updateManager);
            this.DialogResult = DialogResult.OK;
        }

        private string GetCorrentField(string valueTxt, string valueManager)
            => string.IsNullOrEmpty(valueTxt)
                ? valueManager
                : valueTxt;
    }
}
