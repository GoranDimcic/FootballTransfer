using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTransfer.Entities
{
    public class ManagerOffer
    {
        public string ManagerEmail { get; set; }

        public string PlayerEmail { get; set; }

        public string ManagerName { get; set; }

        public string PlayerName { get; set; }

        public string Duraction { get; set; }

        public string Offer { get; set; }

        public string Pending { get; set; }
    }
}
