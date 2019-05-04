using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CruiseManagementApp.Data.Enums;
using System.Threading.Tasks;

namespace CruiseManagementApp.Data.Entities.Models
{
    public class Cabin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CabinCategory Category { get; set; }
        public int Price { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

        public override string ToString()
        {
            return $"{Name} {Category}";
        }
    }
}
