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
    public partial class UpdateClub : Form
    {
        public Club updateClub;

        public UpdateClub(Club club)
        {
            InitializeComponent();
            updateClub = club;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            updateClub.Name = GetCorrectField(txtUpdateClubName.Text, updateClub.Name);
            updateClub.StadionName = GetCorrectField(txtUpdateClubStadionName.Text, updateClub.StadionName);
            updateClub.StadionCapacity = GetCorrectField(txtUpdateClubCapacity.Text, updateClub.StadionCapacity);
            updateClub.LeagueName = GetCorrectField(comboBoxUpdateClubLeagueName.Text, updateClub.LeagueName);

            DataProvider.UpdateClub(updateClub);
            this.DialogResult = DialogResult.OK;
        }

        private string GetCorrectField(string valueTxt, string valueClub)
            => string.IsNullOrEmpty(valueTxt)
                ? valueClub
                : valueTxt;
    }
}
