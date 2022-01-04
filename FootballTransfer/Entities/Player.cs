using System;
using System.Collections.Generic;

namespace FootballTransfer.Entities
{
    public class Player
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Position { get; set; }

        public Boolean HaveManager;

        public Boolean HaveClub;

        public List<ManagerOffer> ManagerOffers { get; set; }

        public List<ClubOffer> ClubOffers { get; set; }
    }
}
