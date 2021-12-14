﻿using FootballTransfer.Entities;
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
        public PlayerView(Player player)
        {
            InitializeComponent();
            this.fillManagerOffer();
            this.fillClubOffer();
            this.fillDescription(player);
        }

        public PlayerView()
        {
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

        public void fillDescription(Player player)
        {
            txtProbaName.Text = player.name;
            txtProbaSurname.Text = player.surname;
            txtProbaCountry.Text = player.country;
            txtProbaPosition.Text = player.position;
        }

        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            UpdatePlayer form = new UpdatePlayer();
            form.ShowDialog();
        }
    }
}
