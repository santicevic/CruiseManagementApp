﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CruiseManagementApp.Data.Enums;

namespace CruiseManagementApp.Data.Entities.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
