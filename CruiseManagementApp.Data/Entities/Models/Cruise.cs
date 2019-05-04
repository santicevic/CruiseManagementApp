using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CruiseManagementApp.Data.Enums;

namespace CruiseManagementApp.Data.Entities.Models
{
    public class Cruise
    {
        public int Id { get; set; }
        public Port PortOfDeparture { get; set; }
        public int ShipId { get; set; }
        public Ship Ship { get; set; }
        public ICollection<EmployeeOnCruise> Employees { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

        public override string ToString()
        {
            return $"Polazište: {PortOfDeparture} Brod: {Ship}";
        }
    }
}
