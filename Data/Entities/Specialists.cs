using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Specialists:User1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ProfessionalFields ProField { get; set; }
        public ICollection<Questions> Questions { get; set; } = new List<Questions>();
    }
}
