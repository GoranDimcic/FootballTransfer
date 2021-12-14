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
        public Player globalPlayer;

        //public PlayerView()
        //{
        //    InitializeComponent();
        //}

        public PlayerView(Player player)
        {
            InitializeComponent();
            globalPlayer = player;
            this.fillManagerOffer();
            this.fillClubOffer();
            this.fillDescription(globalPlayer);
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

        public void fillDescription(Player globalPlayer)
        {
            txtProbaName.Text = globalPlayer.name;
            txtProbaSurname.Text = globalPlayer.surname;
            txtProbaCountry.Text = globalPlayer.country;
            txtProbaPosition.Text = globalPlayer.position;
        }
    }
}
