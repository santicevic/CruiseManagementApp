using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CruiseManagementApp.Data.Entities;
using CruiseManagementApp.Data.Entities.Models;

namespace CruiseManagementApp.Domain.Repositories
{
    public class PassengerRepository
    {
        private readonly CruiseManagementContext _context;

        public PassengerRepository()
        {
            _context = new CruiseManagementContext();
        }

        public Passenger GetPassenger(int id)
        {
            return _context.Passengers.Find(id);
        }

        public List<Passenger> GetAll()
        {
            return _context.Passengers.ToList();
        }

        public void AddPassenger(Passenger passengerToAdd)
        {
            _context.Passengers.Add(passengerToAdd);
            _context.SaveChanges();
        }

        public bool RemovePassenger(int id)
        {
            var passengerToRemove = _context.Passengers.Find(id);

            if (passengerToRemove != null)
            {
                _context.Passengers.Remove(passengerToRemove);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Passenger> GetPassangersNotOnCruise(Cruise selctedCruise)
        {
            return _context.Passengers.Where(passenger => 
            !_context.Reservations.Any(reservation => 
            reservation.PassengerId == passenger.Id && reservation.CruiseId == selctedCruise.Id)).ToList();
        }

        public bool EditPassenger(Passenger passengerToEdit)
        {
            var currentPassenger = _context.Passengers.Find(passengerToEdit.Id);
            if (currentPassenger == null)
            {
                return false;
            }

            currentPassenger.FirstName = passengerToEdit.FirstName;
            currentPassenger.LastName = passengerToEdit.LastName;
            currentPassenger.Address = passengerToEdit.Address;
            currentPassenger.Gender = passengerToEdit.Gender;

            _context.SaveChanges();
            return true;
        }
    }
}
