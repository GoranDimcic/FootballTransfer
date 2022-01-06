using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTransfer.Entities
{
    public class Manager
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Offer { get; set; }

        public List<Player> Players { get; set; }

        public List<Player> FreePlayers { get; set; }
    }
}
