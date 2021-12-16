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
    public partial class PlayerView : Form
    {
        public Player loggedPlayer;
        public List<Player> players;

        public PlayerView(Player player)
        {
            InitializeComponent();
            this.FillDescription(player);
            this.FillManagerOffer();
            this.FillClubOffer();
            loggedPlayer = player;
        }

        public void FillDescription(Player player)
        {
            txtPlayerName.Text = player.Name;
            txtPlayerAge.Text = player.Age;
            txtPlayerCountry.Text = player.Country;
            txtPlayerPosition.Text = player.Position;
        }

        public void FillClubOffer()
        {
            listViewClubOffer.View = View.Details;
            listViewClubOffer.FullRowSelect = true;
            listViewClubOffer.Columns.Add("Club", 120);
            listViewClubOffer.Columns.Add("Offer", 120);
            listViewClubOffer.Columns.Add("Contract date", 120);
        }

        public void FillManagerOffer()
        {
            listViewManagerOffer.View = View.Details;
            listViewManagerOffer.FullRowSelect = true;
            listViewManagerOffer.Columns.Add("email", 80);
            listViewManagerOffer.Columns.Add("Name", 80);
            listViewManagerOffer.Columns.Add("Price", 80);
            listViewManagerOffer.Columns.Add("Contract date", 120);
        }

        private void BtnUpdatePlayer_Click(object sender, EventArgs e)
        {
            UpdatePlayer form = new UpdatePlayer(loggedPlayer);
            form.ShowDialog();
        }

        private void BtnDeletePlayer_Click(object sender, EventArgs e)
        {
            DataProvider.DeletePlayer(loggedPlayer);
            this.DialogResult = DialogResult.OK;
        }

        private void BtnShowManagerOffer_Click(object sender, EventArgs e)
        {
            players = DataProvider.GetPlayers();
            foreach(Player player in players)
            {
                MessageBox.Show("Ime " + player.Name + " " + player.Position);
            }
        }
    }
}
