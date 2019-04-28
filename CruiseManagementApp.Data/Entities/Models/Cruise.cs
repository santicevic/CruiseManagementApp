using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseManagementApp.Data.Entities.Models
{
    public class Cruise
    {
        public int Id { get; set; }
        public string PortOfDeparture { get; set; }
        public int ShipId { get; set; }
        public ICollection<EmployeeOnCruise> Employees { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
