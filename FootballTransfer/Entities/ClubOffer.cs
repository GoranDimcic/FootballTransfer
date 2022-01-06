using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTransfer.Entities
{
    public class ClubOffer
    {
        public string ClubEmail { get; set; }

        public string PlayerEmail { get; set; }

        public string ClubName { get; set; }

        public string PlayerName { get; set; }

        public string Duraction { get; set; }

        public string League { get; set; }

        public string Salary { get; set; }
    }
}
