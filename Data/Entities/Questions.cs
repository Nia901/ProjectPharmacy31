using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Questions
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int SpecialistId { get; set; }
        public Specialists Specialist { get; set; }
        public string Description { get; set; }
        public DateTime ConsultationDate { get; set; }
    }
}
