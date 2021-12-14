using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTransfer.Entities
{
    public class Club
    {
        public string name { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string leagueName { get; set; }

        public string stadionName { get; set; }

        public DateTime foundationDate { get; set; }
    }
}
