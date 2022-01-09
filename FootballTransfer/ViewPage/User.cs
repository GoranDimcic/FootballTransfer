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
    public partial class User : Form
    {
        public Player player;
        public List<ManagerOffer> managerOffers;
        public List<ClubOffer> clubOffers;

        public User()
        {
            InitializeComponent();
            FillManagerTransfer();
            FillClubTransfer();
        }

        public void FillManagerTransfer()
        {
            listViewManagerTransfer.View = View.Details;
            listViewManagerTransfer.FullRowSelect = true;
            listViewManagerTransfer.Columns.Add("From", 150);
            listViewManagerTransfer.Columns.Add("To", 120);
            listViewManagerTransfer.Columns.Add("Country", 100);
            listViewManagerTransfer.Columns.Add("Position", 100);
            listViewManagerTransfer.Columns.Add("Offer", 100);
            listViewManagerTransfer.Columns.Add("Years of contract", 150);

            ManagerTransfer();
        }

        public void ManagerTransfer()
        {
            managerOffers = DataProvider.GetManagerOffers();

            foreach (ManagerOffer offer in managerOffers)
            {
                string PlayerEmail = offer.PlayerEmail;
                player = DataProvider.GetNewPlayer(PlayerEmail);

                if (offer.Pending == "accepted")
                {
                    String[] row = { offer.ManagerName, offer.PlayerName, player.Country, player.Position, offer.Offer + "$", offer.Duraction };
                    ListViewItem item = new ListViewItem(row);
                    listViewManagerTransfer.Items.Add(item);
                }
            }
        }

        public void FillClubTransfer()
        {
            listViewClubTransfer.View = View.Details;
            listViewClubTransfer.FullRowSelect = true;
            listViewClubTransfer.Columns.Add("From", 150);
            listViewClubTransfer.Columns.Add("To", 120);
            listViewClubTransfer.Columns.Add("Position", 100);
            listViewClubTransfer.Columns.Add("League", 100);
            listViewClubTransfer.Columns.Add("Salary", 100);
            listViewClubTransfer.Columns.Add("Years of contract", 150);

            ClubTransfer();
        }

        public void ClubTransfer()
        {
            clubOffers = DataProvider.GetClubOffers();

            foreach (ClubOffer offer in clubOffers)
            {
                string PlayerEmail = offer.PlayerEmail;
                player = DataProvider.GetNewPlayer(PlayerEmail);

                if (offer.Pending == "accepted")
                {
                    String[] row = { offer.ClubName, offer.PlayerName, player.Position, offer.League, offer.Salary + "$", offer.Duraction };
                    ListViewItem item = new ListViewItem(row);
                    listViewClubTransfer.Items.Add(item);
                }
            }
        }

        private void BtnManagerTransfer_Click(object sender, EventArgs e)
        {
            listViewManagerTransfer.Visible = true;
            listViewClubTransfer.Visible = false;
        }

        private void BtnClubTransfer_Click(object sender, EventArgs e)
        {
            listViewManagerTransfer.Visible = false;
            listViewClubTransfer.Visible = true;
        }
    }
}
