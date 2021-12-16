using FootballTransfer.Entities;
using FootballTransfer.ViewPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballTransfer.Update
{
    public partial class UpdatePlayer : Form
    {
        public Player updatePlayer;

        public UpdatePlayer(Player newPlayer)
        {
            InitializeComponent();
            updatePlayer = newPlayer;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatePlayer.name = txtUpdatePlayerName.Text ?? updatePlayer.name;
            updatePlayer.surname = txtUpdatePlayerSurname.Text ?? updatePlayer.surname;
            updatePlayer.country = txtUpdatePlayerCountry.Text ?? updatePlayer.country;
            updatePlayer.position = comboBoxUpdatePlayerPosition.Text ?? updatePlayer.position;

            DataProvider.UpdatePlayer(updatePlayer);
            this.DialogResult = DialogResult.OK;
        }
    }
}
