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
        #region Player

        public static Player GetPlayer(Player player)
        {
            ISession session = SessionManager.GetSession();
            Player getPlayer = new Player();

            if (session == null)
                return null;

            Row playerData = session.Execute("select * from \"Player\" where \"email\"='" + player.email + "'").FirstOrDefault();

            if (playerData != null)
            {
                getPlayer.email = playerData["email"].ToString();
                getPlayer.password = playerData["pasword"].ToString();
                getPlayer.name = playerData["name"].ToString();
                getPlayer.surname = playerData["surname"].ToString();
                getPlayer.country = playerData["country"].ToString();
                getPlayer.position = playerData["position"].ToString();
            }
            return getPlayer;
        }

        public static Boolean CheckPlayerRegistration(string newEmail)
        {
            Boolean matching = true;

            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            var playersData = session.Execute("select * from \"Player\"");

            foreach (var playerData in playersData)
            {
                Player player = new Player();
                player.email = playerData["email"].ToString();
                if (player.email == newEmail)
                {
                    matching = false;
                }
            }
            return matching;
        }

        public static Player PlayerLogin(string emailCheck, string passwordCheck)
        {
            ISession session = SessionManager.GetSession();
            Player playerReturn = new Player();

            if (session == null)
                return null;

            var playersData = session.Execute("select * from \"Player\" where \"email\"='" + emailCheck + "'");

            foreach (var playerData in playersData)
            {
                Player player = new Player();
                player.email = playerData["email"].ToString();
                player.password = playerData["pasword"].ToString();
                player.name = playerData["name"].ToString();
                player.surname = playerData["surname"].ToString();
                player.country = playerData["country"].ToString();
                player.position = playerData["position"].ToString();

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

        public static void AddPlayer(Player player)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            RowSet playerData = session.Execute("insert into \"Player\" (\"email\", country, name, pasword, position, surname)  values ('" + player.email + "', '" + player.country + "', '" + player.name + "', '" + player.password + "', '" + player.position + "', '" + player.surname + "')");
        }

        public static void UpdatePlayer(Player player)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet playerUpdateData = session.Execute("update \"Player\" set name=" + player.name + " where \"email\"='" + player.email + "' ");
        }

        public static void DeletePlayer(Player player)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet playerData = session.Execute("delete from \"Player\" where \"email\" = '" + player.email + "'");
        }

        #endregion

        #region Manager

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
                manager.email = managerData["email"].ToString();
                if (manager.email == newEmail)
                {
                    matching = false;
                }
            }
            return matching;
        }

        public static Manager ManagerLogin(string emailCheck, string passwordCheck)
        {
            ISession session = SessionManager.GetSession();
            Manager managerReturn = new Manager();

            if (session == null)
                return null;

            var managersData = session.Execute("select * from \"Manager\" where \"email\"='" + emailCheck + "'");

            foreach (var managerData in managersData)
            {
                Manager manager = new Manager();
                manager.email = managerData["email"].ToString();
                manager.password = managerData["pasword"].ToString();
                manager.name = managerData["name"].ToString();
                manager.surname = managerData["surname"].ToString();
                manager.country = managerData["country"].ToString();

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

        public static void AddManager(Manager manager)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            RowSet playerData = session.Execute("insert into \"Manager\" (\"email\", country, name, pasword, surname)  values ('" + manager.email + "', '" + manager.country + "', '" + manager.name + "', '" + manager.password + "', '" + manager.surname + "')");
        }

        public static void UpdateManager() { }

        public static void DeleteManager(Manager manager)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet managerData = session.Execute("delete from \"Manager\" where \"email\" = '" + manager.email + "'");
        }

        #endregion

        #region Club

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
                club.email = clubData["email"].ToString();
                if (club.email == newEmail)
                {
                    matching = false;
                }
            }
            return matching;
        }

        public static Club ClubLogin(string emailCheck, string passwordCheck)
        {
            ISession session = SessionManager.GetSession();
            Club clubReturn = new Club();

            if (session == null)
                return null;

            var clubsData = session.Execute("select * from \"Club\" where \"email\"='" + emailCheck + "'");

            foreach (var clubData in clubsData)
            {
                Club club = new Club();
                club.email = clubData["email"].ToString();
                club.password = clubData["pasword"].ToString();
                club.name = clubData["name"].ToString();
                club.stadionName = clubData["stadionname"].ToString();
                club.leagueName = clubData["leaguename"].ToString();
                club.stadionCapacity = clubData["capacity"].ToString();
                club.town = clubData["town"].ToString();
                club.foundationDate = DateTime.Parse(clubData["foundationdate"].ToString());

                clubReturn = club;
            }

            if (clubReturn.email == emailCheck && clubReturn.password == passwordCheck)
            {
                return clubReturn;
            }
            else
            {
                return null;
            }
        }

        public static void AddClub(Club club)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            RowSet playerData = session.Execute("insert into \"Club\" (\"email\", capacity, foundationdate, leaguename, name, pasword, stadionname, town)  values ('" + club.email + "', '" + club.stadionCapacity + "', '" + club.foundationDate + "', '" + club.leagueName + "', '" + club.name + "', '" + club.password + "', '" + club.stadionName + "', '" + club.town + "')");
        }

        public static void UpdateClub() { }

        public static void DeleteClub(Club club)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet clubData = session.Execute("delete from \"Club\" where \"email\" = '" + club.email + "'");
        }

        #endregion
    }
}