﻿using Cassandra;
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
                getPlayer.Address = playerData["address"].ToString();
                getPlayer.Country = playerData["country"].ToString();
                getPlayer.Position = playerData["position"].ToString();
                getPlayer.ManagerOffer = playerData["manageroffer"].ToString();
                getPlayer.ClubOffer = playerData["cluboffer"].ToString();
            }
            return getPlayer;
        }

        public static List<Player> GetPlayers()
        {
            ISession session = SessionManager.GetSession();
            List<Player> players = new List<Player>();

            if (session == null)
                return null;

            var playersData = session.Execute("select * from \"Player\"");

            foreach (var playerData in playersData)
            {
                Player player = new Player
                {
                    Email = playerData["email"].ToString(),
                    Password = playerData["pasword"].ToString(),
                    Name = playerData["name"].ToString(),
                    Address = playerData["address"].ToString(),
                    Country = playerData["country"].ToString(),
                    Position = playerData["position"].ToString(),
                    ManagerOffer = playerData["manageroffer"].ToString(),
                    ClubOffer = playerData["cluboffer"].ToString()
                };
                players.Add(player);
            }
            return players;
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
                Player player = new Player
                {
                    Email = playerData["email"].ToString()
                };
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
                Player player = new Player
                {
                    Email = playerData["email"].ToString(),
                    Password = playerData["pasword"].ToString(),
                    Name = playerData["name"].ToString(),
                    Address = playerData["address"].ToString(),
                    Country = playerData["country"].ToString(),
                    Position = playerData["position"].ToString(),
                    ManagerOffer = playerData["manageroffer"].ToString(),
                    ClubOffer = playerData["cluboffer"].ToString()
                };

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

            _ = session.Execute("insert into \"Player\" (\"email\", address, cluboffer, country, manageroffer, name, pasword, position)  values ('" + player.Email + "', '" + player.Address + "', '" + "false" + "', '" + player.Country + "', '" + "false" + "', '" + player.Name + "', '" + player.Password + "', '" + player.Position + "')");
        }

        public static void UpdatePlayer(Player player)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"Player\" set name='" + player.Name + "' , country='" + player.Country + "' , position='" + player.Position + "' , address='" + player.Address + "'where \"email\"='" + player.Email + "'");
        }

        public static void UpdatePlayerAcceptedManagerOffer(string PlayerEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"Player\" set manageroffer='" + "true" + "'where \"email\"='" + PlayerEmail + "'");
        }

        public static void UpdatePlayerAcceptedClubOffer(string PlayerEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"Player\" set cluboffer='" + "true" + "'where \"email\"='" + PlayerEmail + "'");
        }

        public static void UpdatePlayerRejectedManagerOffer(string PlayerEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"Player\" set manageroffer='" + "false" + "'where \"email\"='" + PlayerEmail + "'");
        }

        public static void UpdatePlayerRejectedClubOffer(string PlayerEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"Player\" set cluboffer='" + "false" + "'where \"email\"='" + PlayerEmail + "'");
        }

        public static void DeletePlayer(Player player)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("delete from \"Player\" where \"email\" = '" + player.Email + "'");
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
                Manager manager = new Manager
                {
                    Email = managerData["email"].ToString()
                };
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
                Manager manager = new Manager
                {
                    Email = managerData["email"].ToString(),
                    Password = managerData["pasword"].ToString(),
                    Name = managerData["name"].ToString(),
                    Address = managerData["address"].ToString(),
                    Country = managerData["country"].ToString()
                };

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

            _ = session.Execute("insert into \"Manager\" (\"email\", address, country, name, pasword)  values ('" + manager.Email + "', '" + manager.Address + "','" + manager.Country + "', '" + manager.Name + "', '" + manager.Password + "')");
        }

        public static void UpdateManager(Manager manager)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"Manager\" set name='" + manager.Name + "' , country='" + manager.Country + "' , address='" + manager.Address + "'where \"email\"='" + manager.Email + "'");
        }

        public static void DeleteManager(Manager manager)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("delete from \"Manager\" where \"email\" = '" + manager.Email + "'");
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
                Club club = new Club
                {
                    Email = clubData["email"].ToString()
                };
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
                Club club = new Club
                {
                    Email = clubData["email"].ToString(),
                    Password = clubData["pasword"].ToString(),
                    Name = clubData["name"].ToString(),
                    StadionName = clubData["stadionname"].ToString(),
                    LeagueName = clubData["leaguename"].ToString(),
                    StadionCapacity = clubData["capacity"].ToString()
                };

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

            _ = session.Execute("insert into \"Club\" (\"email\", capacity, leaguename, name, pasword, stadionname)  values ('" + club.Email + "', '" + club.StadionCapacity + "', '" + club.LeagueName + "', '" + club.Name + "', '" + club.Password + "', '" + club.StadionName + "')");
        }

        public static void UpdateClub(Club club)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"Club\" set name='" + club.Name + "' , stadionname='" + club.StadionName + "' , leaguename='" + club.LeagueName + "' , capacity='" + club.StadionCapacity + "'where \"email\"='" + club.Email + "'");
        }

        public static void DeleteClub(Club club)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("delete from \"Club\" where \"email\" = '" + club.Email + "'");
        }

        #endregion

        #region ManagerOffer

        public static List<ManagerOffer> GetManagerOffers()
        {
            ISession session = SessionManager.GetSession();
            List<ManagerOffer> offers = new List<ManagerOffer>();

            if (session == null)
                return null;

            var playersData = session.Execute("select * from \"ManagerOffer\"");

            foreach (var playerData in playersData)
            {
                ManagerOffer offer = new ManagerOffer
                {
                    ManagerEmail = playerData["manageremail"].ToString(),
                    PlayerEmail = playerData["playeremail"].ToString(),
                    ManagerName = playerData["managername"].ToString(),
                    PlayerName = playerData["playername"].ToString(),
                    Duraction = playerData["duraction"].ToString(),
                    Offer = playerData["offer"].ToString(),
                    Pending = playerData["pending"].ToString()
                };
                offers.Add(offer);
            }
            return offers;
        }

        public static void AddManagerOffer(ManagerOffer offer)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("insert into \"ManagerOffer\" (\"manageremail\", \"playeremail\", duraction, managername, offer, pending, playername)  values ('" + offer.ManagerEmail + "', '" + offer.PlayerEmail + "', '" + offer.Duraction + "', '" + offer.ManagerName + "', '" + offer.Offer + "', '" + "pending" + "', '" + offer.PlayerName + "')");
        }

        public static void UpdatePlayerNameInManagerOffer(string PlayerEmail, string PlayerName, string ManagerEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"ManagerOffer\" set playername='" + PlayerName + "'where \"playeremail\"='" + PlayerEmail + "' and \"manageremail\"='" + ManagerEmail + "' ");
        }

        public static void UpdateManagerNameInManagerOffer(string ManagerEmail, string ManagerName, string PlayerEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"ManagerOffer\" set managername='" + ManagerName + "'where \"playeremail\"='" + PlayerEmail + "' and \"manageremail\"='" + ManagerEmail + "' ");
        }

        public static void UpdateAcceptedManagerOffer(string ManagerEmail, string PlayerEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"ManagerOffer\" set pending='" + "accepted" + "'where \"playeremail\"='" + PlayerEmail + "' and \"manageremail\"='" + ManagerEmail + "' ");
        }

        public static void UpdateRejectedManagerOffer(string ManagerEmail, string PlayerEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"ManagerOffer\" set pending='" + "rejected" + "'where \"manageremail\"='" + ManagerEmail + "' and \"playeremail\"='" + PlayerEmail + "' ");
        }

        public static void DeletePlayerInManagerOffer(string PlayerEmail, string ManagerEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("delete from \"ManagerOffer\" where \"playeremail\" = '" + PlayerEmail + "' and \"manageremail\"='" + ManagerEmail + "' ");
        }

        public static void DeleteManagerInManagerOffer(string ManagerEmail, string PlayerEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("delete from \"ManagerOffer\" where \"manageremail\" = '" + ManagerEmail + "' and \"playeremail\"='" + PlayerEmail + "' ");
        }

        #endregion

        #region ClubOffer

        public static List<ClubOffer> GetClubOffers()
        {
            ISession session = SessionManager.GetSession();
            List<ClubOffer> offers = new List<ClubOffer>();

            if (session == null)
                return null;

            var playersData = session.Execute("select * from \"ClubOffer\"");

            foreach (var playerData in playersData)
            {
                ClubOffer offer = new ClubOffer
                {
                    ClubEmail = playerData["clubemail"].ToString(),
                    PlayerEmail = playerData["playeremail"].ToString(),
                    ClubName = playerData["clubname"].ToString(),
                    League = playerData["league"].ToString(),
                    PlayerName = playerData["playername"].ToString(),
                    Duraction = playerData["duraction"].ToString(),
                    Salary = playerData["salary"].ToString(),
                    Pending = playerData["pending"].ToString()
                };
                offers.Add(offer);
            }
            return offers;
        }

        public static void AddClubOffer(ClubOffer offer)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("insert into \"ClubOffer\" (\"playeremail\", \"clubemail\", clubname, duraction, league, pending, playername, salary)  values ('" + offer.PlayerEmail + "', '" + offer.ClubEmail + "', '" + offer.ClubName + "', '" + offer.Duraction + "', '" + offer.League + "', '" + "pending" + "', '" + offer.PlayerName + "', '" + offer.Salary + "')");
        }

        public static void UpdatePlayerNameInClubOffer(string PlayerEmail, string PlayerName, string ClubEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"ClubOffer\" set playername='" + PlayerName + "'where \"playeremail\"='" + PlayerEmail + "' and \"clubemail\"='" + ClubEmail + "' ");
        }

        public static void UpdateClubNameInClubOffer(string ClubEmail, string ClubName, string ClubLeague, string PlayerEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"ClubOffer\" set clubname='" + ClubName + "' , league='" + ClubLeague + "'where \"clubemail\"='" + ClubEmail + "' and \"playeremail\"='" + PlayerEmail + "' ");
        }

        public static void UpdateAcceptedClubOffer(string ClubEmail, string PlayerEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"ClubOffer\" set pending='" + "accepted" + "'where \"playeremail\"='" + PlayerEmail + "' and \"clubemail\"='" + ClubEmail + "' ");
        }

        public static void UpdateRejectedClubOffer(string ClubEmail, string PlayerEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("update \"ClubOffer\" set pending='" + "rejected" + "'where \"playeremail\"='" + PlayerEmail + "' and \"clubemail\"='" + ClubEmail + "' ");
        }

        public static void DeletePlayerInClubOffer(string PlayerEmail, string ClubEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("delete from \"ClubOffer\" where \"playeremail\" = '" + PlayerEmail + "' and \"clubemail\"='" + ClubEmail + "' ");
        }

        public static void DeleteClubInClubOffer(string ClubEmail, string PlayerEmail)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            _ = session.Execute("delete from \"ClubOffer\" where \"clubemail\" = '" + ClubEmail + "' and \"playeremail\"='" + PlayerEmail + "' ");
        }

        #endregion
    }
}