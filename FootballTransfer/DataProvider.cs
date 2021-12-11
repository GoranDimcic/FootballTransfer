using Cassandra;
using FootballTransfer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballTransfer
{
    class DataProvider
    {
        public static void addPlayer(Player player)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            RowSet playerData = session.Execute("insert into \"Player\" (\"email\", country, name, pasword, position, surname)  values ('" + player.email + "', '" + player.country + "', '" + player.name + "', '" + player.pasword + "', '" + player.position + "', '" + player.surname + "')");
        }

        public static Boolean checkPlayerRegistration(string newEmail)
        {
            Boolean matching = true;

            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            var playersData = session.Execute("select * from \"Player\"");

            foreach (var playerData in playersData)
            {
                Player player = new Player();
                player.email = playerData["email"] != null ? playerData["email"].ToString() : string.Empty;
                if (player.email == newEmail)
                {
                    matching = false;
                }
            }
            return matching;
        }
        //provera da li postoji email u bazi

        public static Player proveriSifruKupca(string emailCheck, string passwordCheck)
        {
            ISession session = SessionManager.GetSession();
            List<Player> players = new List<Player>();
            Player playerReturn = new Player();

            if (session == null)
                return null;

            var playersData = session.Execute("select * from \"Player\" where \"email\"='" + emailCheck + "'");

            foreach (var playerData in playersData)
            {
                Player player = new Player();
                player.name = playerData["name"] != null ? playerData["name"].ToString() : string.Empty;
                player.surname = playerData["surname"] != null ? playerData["surname"].ToString() : string.Empty;
                player.country = playerData["country"] != null ? playerData["country"].ToString() : string.Empty;
                player.email = playerData["email"] != null ? playerData["email"].ToString() : string.Empty;
                player.pasword = playerData["pasword"] != null ? playerData["pasword"].ToString() : string.Empty;
                players.Add(player);

                if (player.email == emailCheck)
                {
                    playerReturn = player;
                }
            }

            if (playerReturn.email == null)
            {
                MessageBox.Show("Email does not exist!");
                return null;
            }
            else
            {
                if (playerReturn.pasword != passwordCheck)
                {
                    MessageBox.Show("Incorect password!");
                    return null;
                }
            }

            return playerReturn;
        }
    }
}
