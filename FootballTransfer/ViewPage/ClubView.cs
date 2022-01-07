using FootballTransfer.Entities;
using FootballTransfer.Offers;
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
        public List<Player> players;
        public List<ClubOffer> clubOffers;

        public ClubView(Club club)
        {
            loggedClub = club;
            InitializeComponent();
            ClubPage();
        }

        public void ClubPage()
        {
            FillClubDescription();
            FillListWithFreePlayers();
            FillListWithMyOffers();
        }

        public void FillClubDescription()
        {
            txtClubName.Text = loggedClub.Name;
            txtClubStadionName.Text = loggedClub.StadionName;
            txtClubCapacity.Text = loggedClub.StadionCapacity.ToString();
            txtClubLeagueName.Text = loggedClub.LeagueName;
        }

        #region Fill ListView

        public void FillListWithMyPlayers()
        {


            FillMyPlayers();
        }

        public void FillMyPlayers()
        {

        }

        public void FillListWithFreePlayers()
        {
            listViewFreePlayers.View = View.Details;
            listViewFreePlayers.FullRowSelect = true;
            listViewFreePlayers.Columns.Add("Email", 120);
            listViewFreePlayers.Columns.Add("Name", 120);
            listViewFreePlayers.Columns.Add("Address", 120);
            listViewFreePlayers.Columns.Add("Country", 120);
            listViewFreePlayers.Columns.Add("Position", 120);

            FillFreePlayers();
        }

        public void FillFreePlayers()
        {
            players = DataProvider.GetPlayers();

            foreach (Player player in players)
            {
                if (player.HaveManager == false)
                {
                    String[] row = { player.Email, player.Name, player.Address, player.Country, player.Position };
                    ListViewItem item = new ListViewItem(row);
                    listViewFreePlayers.Items.Add(item);
                }
            }
        }

        public void FillListWithMyOffers()
        {
            listViewMyOffers.View = View.Details;
            listViewMyOffers.FullRowSelect = true;
            listViewMyOffers.Columns.Add("Email", 150);
            listViewMyOffers.Columns.Add("Name", 150);
            listViewMyOffers.Columns.Add("Salary", 150);
            listViewMyOffers.Columns.Add("Duraction", 150);

            FillMyOffers();
        }

        public void FillMyOffers()
        {
            clubOffers = DataProvider.GetClubOffers();

            foreach (ClubOffer offer in clubOffers)
            {
                if (offer.ClubEmail == loggedClub.Email)
                {
                    String[] row = { offer.PlayerEmail, offer.PlayerName, offer.Salary, offer.Duraction };
                    ListViewItem item = new ListViewItem(row);
                    listViewMyOffers.Items.Add(item);
                }
            }
        }

        public void RefreshListOffers()
        {
            listViewMyOffers.Clear();
            FillListWithMyOffers();
        }

        #endregion

        private void BtnUpdatePlayer_Click(object sender, EventArgs e)
        {
            OnUpdateClick();
        }

        private void BtnSaveUpdatedClub_Click(object sender, EventArgs e)
        {
            OnSaveClick();
            DataProvider.UpdateClub(loggedClub);

            string ClubEmail = loggedClub.Email;
            string ClubName = loggedClub.Name;
            string ClubLeague = loggedClub.LeagueName;

            for (int i = 0; i < listViewMyOffers.Items.Count; i++)
            {
                string PlayerEmail = listViewMyOffers.Items[i]
                                                        .SubItems[0].Text;
                DataProvider.UpdateClubNameInClubOffer(ClubEmail, ClubName, ClubLeague, PlayerEmail);
            }
        }

        private void BtnCloseUpdate_Click(object sender, EventArgs e)
        {
            OnCloseClick();
        }

        private void BtnDeleteClub_Click(object sender, EventArgs e)
        {
            string ClubEmail = loggedClub.Email;

            for (int i = 0; i < listViewFreePlayers.Items.Count; i++)
            {
                string PlayerEmail = listViewFreePlayers.Items[i]
                                                        .SubItems[0].Text;
                DataProvider.DeleteClubInClubOffer(ClubEmail, PlayerEmail);
            }

            DataProvider.DeleteClub(loggedClub);
            this.DialogResult = DialogResult.OK;
        }

        private void BtnCreateOffer_Click(object sender, EventArgs e)
        {
            if (listViewFreePlayers.SelectedItems.Count > 0)
            {
                string EmailPlayer = listViewFreePlayers.SelectedItems[0]
                                                        .SubItems[0].Text;
                string NamePlayer = listViewFreePlayers.SelectedItems[0]
                                                       .SubItems[1].Text;
                OfferClub form = new OfferClub(EmailPlayer, NamePlayer, loggedClub);
                form.ShowDialog();

                listViewFreePlayers.SelectedItems[0].BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("You must select player!");
            }

            RefreshListOffers();
        }

        #region Button (Update, Save, Delete)

        public void OnUpdateClick()
        {
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
            loggedClub.Name = txtClubName.Text;
            loggedClub.StadionName = txtClubStadionName.Text;
            loggedClub.StadionCapacity = txtClubCapacity.Text;
            loggedClub.LeagueName = comboBoxUpdateClubLeagueName.Text;
            txtClubLeagueName.Text = comboBoxUpdateClubLeagueName.Text;

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
            txtClubName.Text = loggedClub.Name;
            txtClubStadionName.Text = loggedClub.StadionName;
            txtClubCapacity.Text = loggedClub.StadionCapacity;
            txtClubLeagueName.Text = loggedClub.LeagueName;

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

        #endregion

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

        private void BtnSeeFreePlayers_Click(object sender, EventArgs e)
        {
            LblChoose.Visible = true;
            BtnTerminateTheContract.Visible = false;
            BtnCreateOffer.Visible = true;
            listViewFreePlayers.Visible = true;
            listViewMyPlayers.Visible = false;
            listViewMyOffers.Visible = false;
        }

        private void BtnSeeMyTeam_Click(object sender, EventArgs e)
        {
            LblChoose.Visible = true;
            BtnTerminateTheContract.Visible = true;
            BtnCreateOffer.Visible = false;
            listViewFreePlayers.Visible = false;
            listViewMyPlayers.Visible = true;
            listViewMyOffers.Visible = false;
        }

        private void BtnSeeMyOffers_Click(object sender, EventArgs e)
        {
            LblChoose.Visible = false;
            BtnTerminateTheContract.Visible = false;
            BtnCreateOffer.Visible = false;
            listViewFreePlayers.Visible = false;
            listViewMyPlayers.Visible = false;
            listViewMyOffers.Visible = true;
        }
    }
}