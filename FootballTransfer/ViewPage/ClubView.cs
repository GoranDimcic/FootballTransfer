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

namespace FootballTransfer.ViewPage
{
    public partial class ClubView : Form
    {
        public Club loggedClub;
        public Player player;
        public List<Player> players;

        public ClubView(Club club)
        {
            loggedClub = club;
            InitializeComponent();
            ClubPage(club);
        }

        public void ClubPage(Club club)
        {
            this.FillClubDescription(club);
            this.FillListWithFreePlayers();
        }

        public void FillClubDescription(Club club)
        {
            txtClubTown.Text = club.Town;
            txtClubName.Text = club.Name;
            txtClubStadionName.Text = club.StadionName;
            txtClubCapacity.Text = club.StadionCapacity.ToString();
            txtClubLeagueName.Text = club.LeagueName;
            txtClubFoundationDate.Text = club.FoundationDate.ToShortDateString();
        }

        public void FillListWithFreePlayers()
        {
            listViewFreePlayers.View = View.Details;
            listViewFreePlayers.FullRowSelect = true;
            listViewFreePlayers.Columns.Add("Email", 120);
            listViewFreePlayers.Columns.Add("Name", 120);
            listViewFreePlayers.Columns.Add("Age", 80);
            listViewFreePlayers.Columns.Add("Country", 80);
            listViewFreePlayers.Columns.Add("Pos", 120);

            this.FillFreePlayers();
        }

        public void FillFreePlayers()
        {
            players = DataProvider.GetPlayers();

            foreach (Player player in players)
            {
                String[] row = { player.Email, player.Name, player.Address, player.Country, player.Position };
                ListViewItem item = new ListViewItem(row);
                listViewFreePlayers.Items.Add(item);
            }
        }

        private void BtnCreateOffer_Click(object sender, EventArgs e)
        {
            if (listViewFreePlayers.SelectedItems.Count > 0)
            {
                string EmailPlayer = this.listViewFreePlayers.SelectedItems[0].SubItems[0].Text;
                string NamePlayer = this.listViewFreePlayers.SelectedItems[0].SubItems[1].Text;
                Offers.OfferClub form = new Offers.OfferClub(EmailPlayer, NamePlayer, loggedClub);
                form.ShowDialog();

                this.listViewFreePlayers.SelectedItems[0].BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("You must select player!");
            }
        }

        private void BtnUpdatePlayer_Click(object sender, EventArgs e)
        {
            this.OnUpdateClick();
        }

        private void BtnSaveUpdatedClub_Click(object sender, EventArgs e)
        {
            this.OnSaveClick();
            DataProvider.UpdateClub(loggedClub);
        }

        private void BtnCloseUpdate_Click(object sender, EventArgs e)
        {
            this.OnCloseClick();
        }

        private void BtnDeleteClub_Click(object sender, EventArgs e)
        {
            DataProvider.DeleteClub(loggedClub);
            this.DialogResult = DialogResult.OK;
        }

        public void OnUpdateClick()
        {
            txtClubTown.ReadOnly = false;
            txtClubTown.BorderStyle = BorderStyle.Fixed3D;

            txtClubName.ReadOnly = false;
            txtClubName.BorderStyle = BorderStyle.Fixed3D;

            txtClubStadionName.ReadOnly = false;
            txtClubStadionName.BorderStyle = BorderStyle.Fixed3D;

            txtClubCapacity.ReadOnly = false;
            txtClubCapacity.BorderStyle = BorderStyle.Fixed3D;

            txtClubLeagueName.Visible = false;

            comboBoxUpdateClubLeagueName.Visible = true;
            comboBoxUpdateClubLeagueName.Text = loggedClub.LeagueName;

            BtnSaveUpdatedClub.Visible = true;
            BtnDeleteClub.Visible = false;
            BtnCloseUpdate.Visible = true;
        }

        public void OnSaveClick()
        {
            loggedClub.Town = txtClubTown.Text;
            loggedClub.Name = txtClubName.Text;
            loggedClub.StadionName = txtClubStadionName.Text;
            loggedClub.StadionCapacity = txtClubCapacity.Text;
            loggedClub.LeagueName = comboBoxUpdateClubLeagueName.Text;
            txtClubLeagueName.Text = comboBoxUpdateClubLeagueName.Text;

            txtClubTown.ReadOnly = true;
            txtClubTown.BorderStyle = BorderStyle.None;

            txtClubName.ReadOnly = true;
            txtClubName.BorderStyle = BorderStyle.None;

            txtClubStadionName.ReadOnly = true;
            txtClubStadionName.BorderStyle = BorderStyle.None;

            txtClubCapacity.ReadOnly = true;
            txtClubCapacity.BorderStyle = BorderStyle.None;

            comboBoxUpdateClubLeagueName.Visible = false;
            txtClubLeagueName.Visible = true;

            BtnSaveUpdatedClub.Visible = false;
            BtnDeleteClub.Visible = true;
            BtnCloseUpdate.Visible = false;
        }

        public void OnCloseClick()
        {
            txtClubTown.Text = loggedClub.Town;
            txtClubName.Text = loggedClub.Name;
            txtClubStadionName.Text = loggedClub.StadionName;
            txtClubCapacity.Text = loggedClub.StadionCapacity;
            txtClubLeagueName.Text = loggedClub.LeagueName;

            txtClubTown.ReadOnly = true;
            txtClubTown.BorderStyle = BorderStyle.None;

            txtClubName.ReadOnly = true;
            txtClubName.BorderStyle = BorderStyle.None;

            txtClubStadionName.ReadOnly = true;
            txtClubStadionName.BorderStyle = BorderStyle.None;

            txtClubCapacity.ReadOnly = true;
            txtClubCapacity.BorderStyle = BorderStyle.None;

            comboBoxUpdateClubLeagueName.Visible = false;
            txtClubLeagueName.Visible = true;

            BtnSaveUpdatedClub.Visible = false;
            BtnDeleteClub.Visible = true;
            BtnCloseUpdate.Visible = false;
        }

        private void TxtClubCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
