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
        public Player newPlayer;

        public PlayerView(Player player)
        {
            InitializeComponent();
            this.fillManagerOffer();
            this.fillClubOffer();
            this.fillDescription(player);
            newPlayer = player;
        }

        public void fillDescription(Player player)
        {
            txtPlayerName.Text = player.name;
            txtPlayerSurname.Text = player.surname;
            txtPlayerCountry.Text = player.country;
            txtPlayerPosition.Text = player.position;
        }

        public void fillClubOffer()
        {
            listViewClubOffer.View = View.Details;
            listViewClubOffer.FullRowSelect = true;
            listViewClubOffer.Columns.Add("Club", 120);
            listViewClubOffer.Columns.Add("Offer", 120);
            listViewClubOffer.Columns.Add("Contract date", 120);
        }

        public void fillManagerOffer()
        {
            listViewManagerOffer.View = View.Details;
            listViewManagerOffer.FullRowSelect = true;
            listViewManagerOffer.Columns.Add("Name", 120);
            listViewManagerOffer.Columns.Add("Surname", 120);
            listViewManagerOffer.Columns.Add("Contract date", 120);
        }


        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            //txtPlayerName.BorderStyle = BorderStyle.Fixed3D;
            //txtPlayerName.ReadOnly = false;
            //txtPlayerSurname.BorderStyle = BorderStyle.Fixed3D;
            //txtPlayerSurname.ReadOnly = false;
            //txtPlayerCountry.BorderStyle = BorderStyle.Fixed3D;
            //txtPlayerCountry.ReadOnly = false;
            //btnConfirmUpdate.Visible = true;

            UpdatePlayer form = new UpdatePlayer(newPlayer);
            form.ShowDialog();
            //btnDeletePlayer.Location = new System.Drawing.Point(400, 22);
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            DataProvider.DeletePlayer(newPlayer);
            this.DialogResult = DialogResult.OK;
        }
    }
}
