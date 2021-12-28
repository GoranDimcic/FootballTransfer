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

        public PlayerView(Player player)
        {
            InitializeComponent();
            this.PlayerPage(player);
            loggedPlayer = player;
        }

        public void PlayerPage(Player player)
        {
            this.FillPlayerDescription(player);
            this.FillManagerOfferList();
            this.FillClubOfferList();
        }

        public void FillPlayerDescription(Player player)
        {
            txtPlayerName.Text = player.Name;
            txtPlayerAge.Text = player.Age;
            txtPlayerCountry.Text = player.Country;
            txtPlayerPosition.Text = player.Position;
        }

        public void FillManagerOfferList()
        {
            listViewManagerOffer.View = View.Details;
            listViewManagerOffer.FullRowSelect = true;
            listViewManagerOffer.Columns.Add("email", 80);
            listViewManagerOffer.Columns.Add("Name", 80);
            listViewManagerOffer.Columns.Add("Price", 80);
            listViewManagerOffer.Columns.Add("Contract date", 120);
        }

        public void FillClubOfferList()
        {
            listViewClubOffer.View = View.Details;
            listViewClubOffer.FullRowSelect = true;
            listViewClubOffer.Columns.Add("Club", 120);
            listViewClubOffer.Columns.Add("Offer", 120);
            listViewClubOffer.Columns.Add("Contract date", 120);
        }

        private void BtnUpdatePlayer_Click(object sender, EventArgs e)
        {
            this.OnUpdateClick();
        }

        private void BtnSaveUpdatedPlayer_Click(object sender, EventArgs e)
        {
            this.OnSaveClick();
            DataProvider.UpdatePlayer(loggedPlayer);
        }

        private void BtnCloseUpdate_Click(object sender, EventArgs e)
        {
            this.OnCloseClick();
        }

        private void BtnDeletePlayer_Click(object sender, EventArgs e)
        {
            DataProvider.DeletePlayer(loggedPlayer);
            this.DialogResult = DialogResult.OK;
        }

        public void OnUpdateClick()
        {
            txtPlayerName.ReadOnly = false;
            txtPlayerName.BorderStyle = BorderStyle.Fixed3D;

            txtPlayerCountry.ReadOnly = false;
            txtPlayerCountry.BorderStyle = BorderStyle.Fixed3D;

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
            loggedPlayer.Country = txtPlayerCountry.Text;
            loggedPlayer.Position = comboBoxUpdatePlayerPosition.Text;
            txtPlayerPosition.Text = comboBoxUpdatePlayerPosition.Text;

            txtPlayerName.ReadOnly = true;
            txtPlayerName.BorderStyle = BorderStyle.None;

            txtPlayerCountry.ReadOnly = true;
            txtPlayerCountry.BorderStyle = BorderStyle.None;

            comboBoxUpdatePlayerPosition.Visible = false;
            txtPlayerPosition.Visible = true;

            BtnSaveUpdatedPlayer.Visible = false;
            BtnDeletePlayer.Visible = true;
            BtnCloseUpdate.Visible = false;
        }

        public void OnCloseClick()
        {
            txtPlayerName.Text = loggedPlayer.Name;
            txtPlayerCountry.Text = loggedPlayer.Country;
            txtPlayerPosition.Text = loggedPlayer.Position;

            txtPlayerName.ReadOnly = true;
            txtPlayerName.BorderStyle = BorderStyle.None;

            txtPlayerCountry.ReadOnly = true;
            txtPlayerCountry.BorderStyle = BorderStyle.None;

            comboBoxUpdatePlayerPosition.Visible = false;
            txtPlayerPosition.Visible = true;

            BtnSaveUpdatedPlayer.Visible = false;
            BtnCloseUpdate.Visible = false;
            BtnDeletePlayer.Visible = true;
        }
    }
}