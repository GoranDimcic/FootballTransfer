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
    public partial class UpdateClub : Form
    {
        public Club updateClub;

        public UpdateClub(Club club)
        {
            InitializeComponent();
            updateClub = club;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateClub.name = txtUpdateClubName.Text ?? updateClub.name;
            updateClub.stadionName = txtUpdateClubStadionName.Text ?? updateClub.stadionName;
            updateClub.stadionCapacity = txtUpdateClubCapacity.Text ?? updateClub.stadionCapacity;
            updateClub.leagueName = comboBoxUpdateClubLeagueName.Text ?? updateClub.leagueName;

            DataProvider.UpdateClub(updateClub);
            this.DialogResult = DialogResult.OK;
        }
    }
}
