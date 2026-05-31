using Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public Categories Category { get; set; }
        public string ProductType { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
