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

            Row playerData = session.Execute("select * from \"Player\" where \"email\"='" + player.Email + "'").FirstOrDefault();

            if (playerData != null)
            {
                getPlayer.Email = playerData["email"].ToString();
                getPlayer.Password = playerData["pasword"].ToString();
                getPlayer.Name = playerData["name"].ToString();
                getPlayer.Surname = playerData["surname"].ToString();
                getPlayer.Country = playerData["country"].ToString();
                getPlayer.Position = playerData["position"].ToString();
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
                player.Email = playerData["email"].ToString();
                if (player.Email == newEmail)
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
                player.Email = playerData["email"].ToString();
                player.Password = playerData["pasword"].ToString();
                player.Name = playerData["name"].ToString();
                player.Surname = playerData["surname"].ToString();
                player.Country = playerData["country"].ToString();
                player.Position = playerData["position"].ToString();

                playerReturn = player;
            }

            if (playerReturn.Email == emailCheck && playerReturn.Password == passwordCheck)
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
            RowSet playerData = session.Execute("insert into \"Player\" (\"email\", country, name, pasword, position, surname)  values ('" + player.Email + "', '" + player.Country + "', '" + player.Name + "', '" + player.Password + "', '" + player.Position + "', '" + player.Surname + "')");
        }

        public static void UpdatePlayer(Player player)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            var playerUpdateData = session.Execute("update \"Player\" set name='" + player.Name + "' , surname='" + player.Surname + "' , country='" + player.Country + "' , position='" + player.Position + "'where \"email\"='" + player.Email + "'");
        }

        public static void DeletePlayer(Player player)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet playerData = session.Execute("delete from \"Player\" where \"email\" = '" + player.Email + "'");
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
                manager.Email = managerData["email"].ToString();
                if (manager.Email == newEmail)
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
                manager.Email = managerData["email"].ToString();
                manager.Password = managerData["pasword"].ToString();
                manager.Name = managerData["name"].ToString();
                manager.Surname = managerData["surname"].ToString();
                manager.Country = managerData["country"].ToString();

                managerReturn = manager;
            }

            if (managerReturn.Email == emailCheck && managerReturn.Password == passwordCheck)
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
            RowSet playerData = session.Execute("insert into \"Manager\" (\"email\", country, name, pasword, surname)  values ('" + manager.Email + "', '" + manager.Country + "', '" + manager.Name + "', '" + manager.Password + "', '" + manager.Surname + "')");
        }

        public static void UpdateManager(Manager manager)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet managerUpdateData = session.Execute("update \"Manager\" set name='" + manager.Name + "' , surname='" + manager.Surname + "' , country='" + manager.Country + "'where \"email\"='" + manager.Email + "'");
        }

        public static void DeleteManager(Manager manager)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet managerData = session.Execute("delete from \"Manager\" where \"email\" = '" + manager.Email + "'");
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
                club.Email = clubData["email"].ToString();
                if (club.Email == newEmail)
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
                club.Email = clubData["email"].ToString();
                club.Password = clubData["pasword"].ToString();
                club.Name = clubData["name"].ToString();
                club.StadionName = clubData["stadionname"].ToString();
                club.LeagueName = clubData["leaguename"].ToString();
                club.StadionCapacity = clubData["capacity"].ToString();
                club.Town = clubData["town"].ToString();
                club.FoundationDate = DateTime.Parse(clubData["foundationdate"].ToString());

                clubReturn = club;
            }

            if (clubReturn.Email == emailCheck && clubReturn.Password == passwordCheck)
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
            RowSet playerData = session.Execute("insert into \"Club\" (\"email\", capacity, foundationdate, leaguename, name, pasword, stadionname, town)  values ('" + club.Email + "', '" + club.StadionCapacity + "', '" + club.FoundationDate + "', '" + club.LeagueName + "', '" + club.Name + "', '" + club.Password + "', '" + club.StadionName + "', '" + club.Town + "')");
        }

        public static void UpdateClub(Club club)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet clubUpdateData = session.Execute("update \"Club\" set name='" + club.Name + "' , stadionname='" + club.StadionName + "' , leaguename='" + club.LeagueName + "' , capacity='" + club.StadionCapacity + "'where \"email\"='" + club.Email + "'");
        }

        public static void DeleteClub(Club club)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet clubData = session.Execute("delete from \"Club\" where \"email\" = '" + club.Email + "'");
        }

        #endregion
    }
}