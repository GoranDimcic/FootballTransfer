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

        public UpdatePlayer(Player player)
        {
            InitializeComponent();
            updatePlayer = player;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            updatePlayer.name = GetCorrectField(txtUpdatePlayerName.Text, updatePlayer.name);
            updatePlayer.surname = GetCorrectField(txtUpdatePlayerSurname.Text, updatePlayer.surname);
            updatePlayer.country = GetCorrectField(txtUpdatePlayerCountry.Text, updatePlayer.country);
            updatePlayer.position = GetCorrectField(comboBoxUpdatePlayerPosition.Text, updatePlayer.position);

            DataProvider.UpdatePlayer(updatePlayer);
            this.DialogResult = DialogResult.OK;
        }

        private string GetCorrectField(string valueTxt, string valuePlayer)
            => string.IsNullOrEmpty(valueTxt)
                ? valuePlayer
                : valueTxt;
    }
}
