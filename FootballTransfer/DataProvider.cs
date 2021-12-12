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
        //provera da li postoji email igraca u bazi

        public static void addManager(Manager manager)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            RowSet playerData = session.Execute("insert into \"Manager\" (\"email\", country, name, pasword, surname)  values ('" + manager.email + "', '" + manager.country + "', '" + manager.name + "', '" + manager.password + "', '" + manager.surname + "')");
        }

        public static Boolean CheckManagerRegistration(string newEmail)
        {
            Boolean matching = true;

            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            var managersData = session.Execute("select * from \"Manager\"");

            foreach (var managerData in managersData)
            {
                Manager manager = new Manager();
                manager.email = managerData["email"] != null ? managerData["email"].ToString() : string.Empty;
                if (manager.email == newEmail)
                {
                    matching = false;
                }
            }
            return matching;
        }
        //provera da li postoji email menadzera u bazi

        public static void addClub(Club club)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            RowSet playerData = session.Execute("insert into \"Club\" (\"email\", foundationdate, leaguename, name, pasword)  values ('" + club.email + "', '" + club.foundationDate + "', '" + club.leagueName + "', '" + club.name + "', '" + club.password + "')");
        }

        public static Boolean CheckClubRegistration(string newEmail)
        {
            Boolean matching = true;

            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            var clubsData = session.Execute("select * from \"Club\"");

            foreach (var clubData in clubsData)
            {
                Club club = new Club();
                club.email = clubData["email"] != null ? clubData["email"].ToString() : string.Empty;
                if (club.email == newEmail)
                {
                    matching = false;
                }
            }
            return matching;
        }
        //provera da li postoji email kluba u bazi

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
