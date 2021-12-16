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
    public partial class ClubView : Form
    {
        public Club loggedClub;

        public ClubView(Club club)
        {
            InitializeComponent();
            FillDescription(club);
            loggedClub = club;
        }

        public void FillDescription(Club club)
        {
            txtClubTown.Text = club.town;
            txtClubName.Text = club.name;
            txtClubStadionName.Text = club.stadionName;
            txtClubCapacity.Text = club.stadionCapacity.ToString();
            txtClubLeagueName.Text = club.leagueName;
            txtClubFoundationDate.Text = club.foundationDate.ToString();
        }

        private void BtnUpdatePlayer_Click(object sender, EventArgs e)
        {
            UpdateClub form = new UpdateClub(loggedClub);
            form.ShowDialog();
        }

        private void BtnDeleteClub_Click(object sender, EventArgs e)
        {
            DataProvider.DeleteClub(loggedClub);
            this.DialogResult = DialogResult.OK;
        }
    }
}
