using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseManagementApp.Data.Entities.Models
{
    public class EmployeeOnCruise
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int CruiseId { get; set; }
        public DateTime StartDate { get; set; }
        public Cruise Cruise { get; set; }
        public Employee Employee { get; set; }
    }
}
