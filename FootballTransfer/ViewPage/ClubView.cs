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
        public Player player;
        public List<Player> players;

        public ClubView(Club club)
        {
            InitializeComponent();
            FillDescription(club);
            loggedClub = club;
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

        public void FillDescription(Club club)
        {
            txtClubTown.Text = club.Town;
            txtClubName.Text = club.Name;
            txtClubStadionName.Text = club.StadionName;
            txtClubCapacity.Text = club.StadionCapacity.ToString();
            txtClubLeagueName.Text = club.LeagueName;
            txtClubFoundationDate.Text = club.FoundationDate.ToString();

            this.FillListView();
            this.FillFreePlayers();
        }

        public void FillListView()
        {
            listViewFreePlayers.View = View.Details;
            listViewFreePlayers.FullRowSelect = true;
            listViewFreePlayers.Columns.Add("Email", 120);
            listViewFreePlayers.Columns.Add("Name", 120);
            listViewFreePlayers.Columns.Add("Age", 80);
            listViewFreePlayers.Columns.Add("Country", 80);
            listViewFreePlayers.Columns.Add("Pos", 120);
        }

        public void FillFreePlayers()
        {
            players = DataProvider.GetPlayers();

            foreach (Player player in players)
            {
                this.FillListViewPlayers(player);
            }
        }

        public void FillListViewPlayers(Player player)
        {
            String[] row = { player.Email, player.Name, player.Age, player.Country, player.Position };
            ListViewItem item = new ListViewItem(row);
            listViewFreePlayers.Items.Add(item);
        }
    }
}
