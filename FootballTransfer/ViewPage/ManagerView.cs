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

        public ManagerView(Manager manager)
        {
            loggedManager = manager;
            InitializeComponent();
            ManagerPage(manager);
        }

        public void ManagerPage(Manager manager)
        {
            FillManagerDescription(manager);
            FillListWithFreePlayers();
            FillListWithMyPlayers();
        }

        public void FillManagerDescription(Manager manager)
        {
            txtManagerName.Text = manager.Name;
            txtManagerAddress.Text = manager.Address;
            txtManagerCountry.Text = manager.Country;
        }

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
            listViewFreePlayers.Columns.Add("Age", 120);
            listViewFreePlayers.Columns.Add("Country", 120);
            listViewFreePlayers.Columns.Add("Pos", 120);

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

            for (int i = 0; i < listViewFreePlayers.Items.Count; i++)
            {
                string PlayerEmail = listViewFreePlayers.Items[i].SubItems[0].Text;
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

            for (int i = 0; i < listViewFreePlayers.Items.Count; i++)
            {
                string PlayerEmail = listViewFreePlayers.Items[i].SubItems[0].Text;
                DataProvider.DeleteManagerInManagerOffer(ManagerEmail, PlayerEmail);
            }

            DataProvider.DeleteManager(loggedManager);
            this.DialogResult = DialogResult.OK;
        }

        private void BtnCreateOffer_Click(object sender, EventArgs e)
        {
            if (listViewFreePlayers.SelectedItems.Count > 0)
            {
                string EmailPlayer = this.listViewFreePlayers.SelectedItems[0].SubItems[0].Text;
                string NamePlayer = this.listViewFreePlayers.SelectedItems[0].SubItems[1].Text;

                OfferManager form = new OfferManager(EmailPlayer, NamePlayer, loggedManager);
                form.ShowDialog();

                this.listViewFreePlayers.SelectedItems[0].BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("You must select player!");
            }
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
            LblChoose.Visible = false;
            BtnTerminateTheContract.Visible = false;
            listViewFreePlayers.Visible = true;
            listViewMyPlayers.Visible = false;
        }

        private void BtnSeeMyPlayers_Click(object sender, EventArgs e)
        {
            LblChoose.Visible = true;
            BtnTerminateTheContract.Visible = true;
            listViewFreePlayers.Visible = false;
            listViewMyPlayers.Visible = true;
        }
    }
}