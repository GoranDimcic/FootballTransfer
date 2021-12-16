using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTransfer.Entities
{
    public class Player
    {
        public string name { get; set; }

        public string surname { get; set; }

        public string country { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string position { get; set; }

        public Boolean taken { get; set; }
    }
}
