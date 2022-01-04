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
    public partial class ManagerView : Form
    {
        public Manager loggedManager;
        public Player player;
        public List<Player> players;

        public ManagerView(Manager manager)
        {
            loggedManager = manager;
            InitializeComponent();
            ManagerPage(manager);
        }

        public void ManagerPage(Manager manager)
        {
            this.FillManagerDescription(manager);
            this.FillListWithFreePlayers();
        }

        public void FillManagerDescription(Manager manager)
        {
            txtManagerName.Text = manager.Name;
            txtManagerAddress.Text = manager.Address;
            txtManagerCountry.Text = manager.Country;
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
            this.OnUpdateClick();
        }

        private void BtnSaveUpdatedManager_Click(object sender, EventArgs e)
        {
            this.OnSaveClick();
            DataProvider.UpdateManager(loggedManager);
        }

        private void BtnCloseUpdate_Click(object sender, EventArgs e)
        {
            this.OnCloseClick();
        }

        private void BtnDeleteManager_Click(object sender, EventArgs e)
        {
            DataProvider.DeleteManager(loggedManager);
            this.DialogResult = DialogResult.OK;
        }

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
    }
}