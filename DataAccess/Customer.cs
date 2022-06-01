using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Customer
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateBirth { get; set; }
        public string Country { get; set; }
    }
}
