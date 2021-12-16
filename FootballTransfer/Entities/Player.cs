using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTransfer.Entities
{
    public class Player
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Country { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Position { get; set; }

        public Boolean Taken { get; set; }
    }
}
