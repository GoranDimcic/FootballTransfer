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
using FootballTransfer.Offers;

namespace FootballTransfer.ViewPage
{
    public partial class ManagerView : Form
    {
        public Manager loggedManager;
        public List<Player> players;
        public List<ManagerOffer> managerOffers;

        public ManagerView(Manager manager)
        {
            loggedManager = manager;
            InitializeComponent();
            ManagerPage();
        }

        public void ManagerPage()
        {
            FillManagerDescription();
            FillListWithMyOffers();
            FillListWithFreePlayers();
            FillListWithMyPlayers();
            Represent();
        }

        public void FillManagerDescription()
        {
            txtManagerName.Text = loggedManager.Name;
            txtManagerAddress.Text = loggedManager.Address;
            txtManagerCountry.Text = loggedManager.Country;
        }

        #region Fill ListView

        public void FillListWithMyOffers()
        {
            listViewMyOffers.View = View.Details;
            listViewMyOffers.FullRowSelect = true;
            listViewMyOffers.Columns.Add("Email", 150);
            listViewMyOffers.Columns.Add("Name", 150);
            listViewMyOffers.Columns.Add("Offer", 150);
            listViewMyOffers.Columns.Add("Duraction", 150);

            FillMyOffers();
        }

        public void FillMyOffers()
        {
            managerOffers = DataProvider.GetManagerOffers();

            foreach (ManagerOffer offer in managerOffers)
            {
                if (offer.ManagerEmail == loggedManager.Email)
                {
                    String[] row = { offer.PlayerEmail, offer.PlayerName, offer.Offer, offer.Duraction };
                    ListViewItem item = new ListViewItem(row);
                    listViewMyOffers.Items.Add(item);

                    if (offer.Pending == "pending")
                        item.BackColor = Color.Yellow;
                    else if (offer.Pending == "accepted")
                        item.BackColor = Color.LimeGreen;
                    else if (offer.Pending == "rejected")
                        item.BackColor = Color.Firebrick;
                }
            }
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
                if (player.ManagerOffer == "false")
                {
                    String[] row = { player.Email, player.Name, player.Address, player.Country, player.Position };
                    ListViewItem item = new ListViewItem(row);
                    listViewFreePlayers.Items.Add(item);

                    item.BackColor = Color.RoyalBlue;
                }
            }
        }

        public void FillListWithMyPlayers()
        {
            listViewMyPlayers.View = View.Details;
            listViewMyPlayers.FullRowSelect = true;
            listViewMyPlayers.Columns.Add("Email", 150);
            listViewMyPlayers.Columns.Add("Name", 150);
            listViewMyPlayers.Columns.Add("Offer", 150);
            listViewMyPlayers.Columns.Add("Duraction", 150);

            FillMyPlayers();
        }

        public void FillMyPlayers()
        {
            managerOffers = DataProvider.GetManagerOffers();

            foreach (ManagerOffer offer in managerOffers)
            {
                if (offer.ManagerEmail == loggedManager.Email)
                {
                    if (offer.Pending == "accepted")
                    {
                        String[] row = { offer.PlayerEmail, offer.PlayerName, offer.Offer, offer.Duraction };
                        ListViewItem item = new ListViewItem(row);
                        listViewMyPlayers.Items.Add(item);

                        item.BackColor = Color.LimeGreen;
                    }
                }
            }
        }

        public void RefreshListOffers()
        {
            listViewMyOffers.Clear();
            FillListWithMyOffers();
        }

        public void RefreshListAfterContractTerminated()
        {
            listViewMyOffers.Clear();
            listViewFreePlayers.Clear();
            listViewMyPlayers.Clear();
            FillListWithMyOffers();
            FillListWithFreePlayers();
            FillListWithMyPlayers();
        }

        public void Represent()
        {
            txtManagerRepresent.Text = listViewMyPlayers.Items.Count.ToString();
        }

        #endregion

        private void BtnUpdateManager_Click(object sender, EventArgs e)
        {
            OnUpdateClick();
        }

        private void BtnSaveUpdatedManager_Click(object sender, EventArgs e)
        {
            OnSaveClick();
            DataProvider.UpdateManager(loggedManager);

            string ManagerEmail = loggedManager.Email;
            string ManagerName = loggedManager.Name;

            for (int i = 0; i < listViewMyOffers.Items.Count; i++)
            {
                string PlayerEmail = listViewMyOffers.Items[i]
                                                     .SubItems[0].Text;
                DataProvider.UpdateManagerNameInManagerOffer(ManagerEmail, ManagerName, PlayerEmail);
            }
        }

        private void BtnCloseUpdate_Click(object sender, EventArgs e)
        {
            OnCloseClick();
        }

        private void BtnDeleteManager_Click(object sender, EventArgs e)
        {
            string ManagerEmail = loggedManager.Email;

            for (int i = 0; i < listViewMyOffers.Items.Count; i++)
            {
                string PlayerEmail = listViewMyOffers.Items[i]
                                                        .SubItems[0].Text;
                DataProvider.DeleteManagerInManagerOffer(ManagerEmail, PlayerEmail);
                DataProvider.UpdatePlayerRejectedManagerOffer(PlayerEmail);
            }

            DataProvider.DeleteManager(loggedManager);
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

                OfferManager form = new OfferManager(EmailPlayer, NamePlayer, loggedManager);
                form.ShowDialog();

                listViewFreePlayers.SelectedItems[0].BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("You must select player!");
            }

            RefreshListOffers();
        }

        private void BtnTerminateTheContract_Click(object sender, EventArgs e)
        {
            if (listViewMyPlayers.SelectedItems.Count > 0)
            {
                string ManagerEmail = loggedManager.Email;
                string PlayerEmail = listViewMyPlayers.SelectedItems[0]
                                                      .SubItems[0].Text;

                DataProvider.ManagerDeleteContact(ManagerEmail, PlayerEmail);
                DataProvider.ManagerTerminatedContactWithPlayer(PlayerEmail);
            }
            else
            {
                MessageBox.Show("You must select player!");
            }

            RefreshListAfterContractTerminated();
            Represent();
        }

        #region Button(Update, Save, Close)

        public void OnUpdateClick()
        {
            txtManagerName.ReadOnly = false;
            txtManagerName.BorderStyle = BorderStyle.Fixed3D;

            txtManagerAddress.ReadOnly = false;
            txtManagerAddress.BorderStyle = BorderStyle.Fixed3D;

            txtManagerCountry.ReadOnly = false;
            txtManagerCountry.BorderStyle = BorderStyle.Fixed3D;

            BtnSaveUpdatedManager.Visible = true;
            BtnDeleteManager.Visible = false;
            BtnCloseUpdate.Visible = true;
        }

        public void OnSaveClick()
        {
            loggedManager.Name = txtManagerName.Text;
            loggedManager.Address = txtManagerAddress.Text;
            loggedManager.Country = txtManagerCountry.Text;

            txtManagerName.ReadOnly = true;
            txtManagerName.BorderStyle = BorderStyle.None;

            txtManagerAddress.ReadOnly = true;
            txtManagerAddress.BorderStyle = BorderStyle.None;

            txtManagerCountry.ReadOnly = true;
            txtManagerCountry.BorderStyle = BorderStyle.None;

            BtnSaveUpdatedManager.Visible = false;
            BtnDeleteManager.Visible = true;
            BtnCloseUpdate.Visible = false;
        }

        public void OnCloseClick()
        {
            txtManagerName.Text = loggedManager.Name;
            txtManagerAddress.Text = loggedManager.Address;
            txtManagerCountry.Text = loggedManager.Country;

            txtManagerName.ReadOnly = true;
            txtManagerName.BorderStyle = BorderStyle.None;

            txtManagerAddress.ReadOnly = true;
            txtManagerAddress.BorderStyle = BorderStyle.None;

            txtManagerCountry.ReadOnly = true;
            txtManagerCountry.BorderStyle = BorderStyle.None;

            BtnSaveUpdatedManager.Visible = false;
            BtnCloseUpdate.Visible = false;
            BtnDeleteManager.Visible = true;
        }

        #endregion

        private void BtnSeeFreePlayers_Click(object sender, EventArgs e)
        {
            LblChoose.Visible = true;
            BtnTerminateTheContract.Visible = false;
            BtnCreateOffer.Visible = true;
            listViewFreePlayers.Visible = true;
            listViewMyOffers.Visible = false;
            listViewMyPlayers.Visible = false;
        }

        private void BtnSeeMyPlayers_Click(object sender, EventArgs e)
        {
            LblChoose.Visible = true;
            BtnTerminateTheContract.Visible = true;
            BtnCreateOffer.Visible = false;
            listViewFreePlayers.Visible = false;
            listViewMyOffers.Visible = false;
            listViewMyPlayers.Visible = true;
        }

        private void BtnSeeMyOffers_Click(object sender, EventArgs e)
        {
            LblChoose.Visible = false;
            BtnTerminateTheContract.Visible = false;
            BtnCreateOffer.Visible = false;
            listViewFreePlayers.Visible = false;
            listViewMyOffers.Visible = true;
            listViewMyPlayers.Visible = false;
        }
    }
}