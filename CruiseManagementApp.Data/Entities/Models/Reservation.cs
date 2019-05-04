using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseManagementApp.Data.Entities.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int CabinId { get; set; }
        public int CruiseId { get; set; }
        public int PassengerId { get; set; }
        public Cabin Cabin { get; set; }
        public Cruise Cruise { get; set; }
        public Passenger Passenger { get; set; }
    }
}
