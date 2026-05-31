using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public abstract class User1
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public RoleType Role { get; set; }
    }
}
