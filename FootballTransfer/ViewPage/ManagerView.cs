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
    public partial class ManagerView : Form
    {
        public Manager loggedManager;
        public Player player;
        public List<Player> players;

        public ManagerView(Manager manager)
        {
            InitializeComponent();
            FillDescription(manager);
            loggedManager = manager;
        }

        private void BtnUpdatePlayer_Click(object sender, EventArgs e)
        {
            UpdateManager form = new UpdateManager(loggedManager);
            form.ShowDialog();
        }

        private void BtnDeleteManager_Click(object sender, EventArgs e)
        {
            DataProvider.DeleteManager(loggedManager);
            this.DialogResult = DialogResult.OK;
        }

        public void FillDescription(Manager manager)
        {
            txtManagerName.Text = manager.Name;
            txtManagerAge.Text = manager.Age;
            txtManagerCountry.Text = manager.Country;

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
                if (player.HaveManager == false)
                {
                    this.FillListViewPlayers(player);
                }
            }
        }

        public void FillListViewPlayers(Player player)
        {
            String[] row = { player.Email, player.Name, player.Age, player.Country, player.Position };
            ListViewItem item = new ListViewItem(row);
            listViewFreePlayers.Items.Add(item);
        }

        private void BtnCreateOffer_Click(object sender, EventArgs e)
        {

        }
    }
}
