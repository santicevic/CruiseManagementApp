using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseManagementApp.Data.Entities.Models
{
    public class Ship
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime YearOfAssembly { get; set; }
        public ICollection<Cruise> Cruises { get; set; }

        public override string ToString()
        {
            return $"{Name} -- {YearOfAssembly.Year}";
        }
    }
}
