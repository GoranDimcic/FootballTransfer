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
    public partial class PlayerView : Form
    {
        public Player loggedPlayer;
        public List<Player> players;
        public List<ManagerOffer> managerOffers;
        public List<ClubOffer> clubOffers;

        public PlayerView(Player player)
        {
            loggedPlayer = player;
            InitializeComponent();
            PlayerPage(player);
        }

        public void PlayerPage(Player player)
        {
            FillPlayerDescription(player);
            FillManagerOfferList();
            FillClubOfferList();
        }

        public void FillPlayerDescription(Player player)
        {
            txtPlayerName.Text = player.Name;
            txtPlayerAddress.Text = player.Address;
            txtPlayerCountry.Text = player.Country;
            txtPlayerPosition.Text = player.Position;
        }

        public void FillManagerOfferList()
        {
            listViewManagerOffer.View = View.Details;
            listViewManagerOffer.FullRowSelect = true;
            listViewManagerOffer.Columns.Add("Email", 150);
            listViewManagerOffer.Columns.Add("Name", 150);
            listViewManagerOffer.Columns.Add("Offer price", 150);
            listViewManagerOffer.Columns.Add("Contract duraction", 150);

            FillManagerOffers();
        }

        public void FillManagerOffers()
        {
            managerOffers = DataProvider.GetManagerOffers();

            Player player = new Player();
            player = DataProvider.GetPlayer(loggedPlayer);

            foreach (ManagerOffer offer in managerOffers)
            {
                if (offer.PlayerEmail == player.Email)
                {
                    String[] row = { offer.ManagerEmail, offer.ManagerName, offer.Offer, offer.Duraction };
                    ListViewItem item = new ListViewItem(row);
                    listViewManagerOffer.Items.Add(item);
                }
            }
        }

        public void FillClubOfferList()
        {
            listViewClubOffer.View = View.Details;
            listViewClubOffer.FullRowSelect = true;
            listViewClubOffer.Columns.Add("Email", 120);
            listViewClubOffer.Columns.Add("Name", 120);
            listViewClubOffer.Columns.Add("League", 120);
            listViewClubOffer.Columns.Add("Salary", 120);
            listViewClubOffer.Columns.Add("Contract date", 120);

            FillClubOffers();
        }

        public void FillClubOffers()
        {
            clubOffers = DataProvider.GetClubOffers();

            Player player = new Player();
            player = DataProvider.GetPlayer(loggedPlayer);

            foreach (ClubOffer offer in clubOffers)
            {
                if (offer.PlayerEmail == player.Email)
                {
                    String[] row = { offer.ClubEmail, offer.ClubName, offer.League, offer.Salary, offer.Duraction };
                    ListViewItem item = new ListViewItem(row);
                    listViewClubOffer.Items.Add(item);
                }
            }
        }

        private void BtnUpdatePlayer_Click(object sender, EventArgs e)
        {
            OnUpdateClick();
        }

        private void BtnSaveUpdatedPlayer_Click(object sender, EventArgs e)
        {
            OnSaveClick();
            DataProvider.UpdatePlayer(loggedPlayer);
            string PlayerEmail = loggedPlayer.Email;
            string PlayerName = loggedPlayer.Name;

            for (int i = 0; i < listViewManagerOffer.Items.Count; i++)
            {
                string ManagerEmail = listViewManagerOffer.Items[i].SubItems[0].Text;
                DataProvider.UpdatePlayerNameInManagerOffer(PlayerEmail, PlayerName, ManagerEmail);
                //DataProvider.UpdatePlayerNameInClubOffer(PlayerEmail, PlayerName, ClubEmail);
            }
        }

        private void BtnCloseUpdate_Click(object sender, EventArgs e)
        {
            OnCloseClick();
        }

        private void BtnDeletePlayer_Click(object sender, EventArgs e)
        {
            string PlayerEmail = loggedPlayer.Email;

            for (int i = 0; i < listViewManagerOffer.Items.Count; i++)
            {
                string ManagerEmail = listViewManagerOffer.Items[i].SubItems[0].Text;
                DataProvider.DeletePlayerInManagerOffer(PlayerEmail, ManagerEmail);
                //DataProvider.DeletePlayerInClubOffer(PlayerEmail, ClubEmail);
            }

            DataProvider.DeletePlayer(loggedPlayer);
            this.DialogResult = DialogResult.OK;
        }

        #region Button(Update, Save, Close)

        public void OnUpdateClick()
        {
            txtPlayerName.ReadOnly = false;
            txtPlayerName.BorderStyle = BorderStyle.Fixed3D;

            txtPlayerCountry.ReadOnly = false;
            txtPlayerCountry.BorderStyle = BorderStyle.Fixed3D;

            txtPlayerAddress.ReadOnly = false;
            txtPlayerAddress.BorderStyle = BorderStyle.Fixed3D;

            txtPlayerPosition.Visible = false;

            comboBoxUpdatePlayerPosition.Visible = true;
            comboBoxUpdatePlayerPosition.Text = loggedPlayer.Position;

            BtnSaveUpdatedPlayer.Visible = true;
            BtnDeletePlayer.Visible = false;
            BtnCloseUpdate.Visible = true;
        }

        public void OnSaveClick()
        {
            loggedPlayer.Name = txtPlayerName.Text;
            loggedPlayer.Address = txtPlayerAddress.Text;
            loggedPlayer.Country = txtPlayerCountry.Text;
            loggedPlayer.Position = comboBoxUpdatePlayerPosition.Text;
            txtPlayerPosition.Text = comboBoxUpdatePlayerPosition.Text;

            txtPlayerName.ReadOnly = true;
            txtPlayerName.BorderStyle = BorderStyle.None;

            txtPlayerCountry.ReadOnly = true;
            txtPlayerCountry.BorderStyle = BorderStyle.None;

            txtPlayerAddress.ReadOnly = true;
            txtPlayerAddress.BorderStyle = BorderStyle.None;

            comboBoxUpdatePlayerPosition.Visible = false;
            txtPlayerPosition.Visible = true;

            BtnSaveUpdatedPlayer.Visible = false;
            BtnDeletePlayer.Visible = true;
            BtnCloseUpdate.Visible = false;
        }

        public void OnCloseClick()
        {
            txtPlayerName.Text = loggedPlayer.Name;
            txtPlayerAddress.Text = loggedPlayer.Address;
            txtPlayerCountry.Text = loggedPlayer.Country;
            txtPlayerPosition.Text = loggedPlayer.Position;

            txtPlayerName.ReadOnly = true;
            txtPlayerName.BorderStyle = BorderStyle.None;

            txtPlayerCountry.ReadOnly = true;
            txtPlayerCountry.BorderStyle = BorderStyle.None;

            txtPlayerAddress.ReadOnly = true;
            txtPlayerAddress.BorderStyle = BorderStyle.None;

            comboBoxUpdatePlayerPosition.Visible = false;
            txtPlayerPosition.Visible = true;

            BtnSaveUpdatedPlayer.Visible = false;
            BtnCloseUpdate.Visible = false;
            BtnDeletePlayer.Visible = true;
        }

        #endregion

        private void BtnShowManagerOffer_Click(object sender, EventArgs e)
        {
            listViewManagerOffer.Visible = true;
            listViewClubOffer.Visible = false;
        }

        private void BtnShowClubOffer_Click(object sender, EventArgs e)
        {
            listViewManagerOffer.Visible = false;
            listViewClubOffer.Visible = true;
        }
    }
}