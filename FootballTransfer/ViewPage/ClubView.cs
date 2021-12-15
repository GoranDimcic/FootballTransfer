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
        public Club updateClub;

        public ClubView(Club club)
        {
            InitializeComponent();
            fillDescription(club);
        }

        public void fillDescription(Club club)
        {
            txtClubName.Text = club.name;
            txtClubLeagueName.Text = club.leagueName;
            txtClubStadionName.Text = club.stadionName;
            txtClubFoundationDate.Text = club.foundationDate.ToString();
        }

        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            UpdateClub form = new UpdateClub();
            form.ShowDialog();
        }
    }
}
