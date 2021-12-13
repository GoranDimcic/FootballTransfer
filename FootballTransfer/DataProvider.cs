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
            RowSet playerData = session.Execute("insert into \"Player\" (\"email\", country, name, pasword, position, surname)  values ('" + player.email + "', '" + player.country + "', '" + player.name + "', '" + player.password + "', '" + player.position + "', '" + player.surname + "')");
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
        //provera da li postoji email igraca

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
        //provera da li postoji email menadzera

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
        //provera da li postoji email kluba

        public static Player CheckPlayerLogin(string emailCheck, string passwordCheck)
        {
            ISession session = SessionManager.GetSession();
            Player playerReturn = new Player();

            if (session == null)
                return null;

            var playersData = session.Execute("select * from \"Player\" where \"email\"='" + emailCheck + "'");

            foreach (var playerData in playersData)
            {
                Player player = new Player();
                player.email = playerData["email"] != null ? playerData["email"].ToString() : string.Empty;
                player.password = playerData["pasword"] != null ? playerData["pasword"].ToString() : string.Empty;
                player.name = playerData["name"] != null ? playerData["name"].ToString() : string.Empty;
                player.surname = playerData["surname"] != null ? playerData["surname"].ToString() : string.Empty;
                player.country = playerData["country"] != null ? playerData["country"].ToString() : string.Empty;
                player.position = playerData["position"] != null ? playerData["position"].ToString() : string.Empty;

                playerReturn = player;
            }

            if (playerReturn.email == emailCheck && playerReturn.password == passwordCheck)
            {
                return playerReturn;
            }
            else
            {
                return null;
            }
        }
        //provera da li je postoji email i sifra igraca

        public static Manager CheckManagerLogin(string emailCheck, string passwordCheck)
        {
            ISession session = SessionManager.GetSession();
            Manager managerReturn = new Manager();

            if (session == null)
                return null;

            var managersData = session.Execute("select * from \"Manager\" where \"email\"='" + emailCheck + "'");

            foreach (var managerData in managersData)
            {
                Manager manager = new Manager();
                manager.email = managerData["email"] != null ? managerData["email"].ToString() : string.Empty;
                manager.password = managerData["pasword"] != null ? managerData["pasword"].ToString() : string.Empty;
                manager.name = managerData["name"] != null ? managerData["name"].ToString() : string.Empty;
                manager.surname = managerData["surname"] != null ? managerData["surname"].ToString() : string.Empty;
                manager.country = managerData["country"] != null ? managerData["country"].ToString() : string.Empty;

                managerReturn = manager;
            }

            if (managerReturn.email == emailCheck && managerReturn.password == passwordCheck)
            {
                return managerReturn;
            }
            else
            {
                return null;
            }
        }
        //provera da li je postoji email i sifra menadzera

    }
}
