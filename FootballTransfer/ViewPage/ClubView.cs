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
        public Club newClub;

        public ClubView(Club club)
        {
            InitializeComponent();
            fillDescription(club);
            newClub = club;
        }

        public void fillDescription(Club club)
        {
            txtClubTown.Text = club.town;
            txtClubName.Text = club.name;
            txtClubStadionName.Text = club.stadionName;
            txtClubCapacity.Text = club.stadionCapacity.ToString();
            txtClubLeagueName.Text = club.leagueName;
            txtClubFoundationDate.Text = club.foundationDate.ToString();
        }

        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            UpdateClub form = new UpdateClub();
            form.ShowDialog();
        }

        private void btnDeleteClub_Click(object sender, EventArgs e)
        {
            DataProvider.DeleteClub(newClub);
            this.DialogResult = DialogResult.OK;

        }
    }
}
