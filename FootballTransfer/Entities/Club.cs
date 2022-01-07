using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTransfer.Entities
{
    public class Club
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Town { get; set; }

        public string LeagueName { get; set; }

        public string StadionName { get; set; }

        public string StadionCapacity { get; set; }

        public DateTime FoundationDate { get; set; }

        public List<Player> Players { get; set; }

        public List<Player> FreePlayers { get; set; }

        public List<ClubOffer> ClubOffers { get; set; }
    }
}
