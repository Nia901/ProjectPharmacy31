using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Admin:User1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
    }
}
