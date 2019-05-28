using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CruiseManagementApp.Data.Entities;
using CruiseManagementApp.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CruiseManagementApp.Domain.Repositories
{
    public class ReservationRepository
    {
        private readonly CruiseManagementContext _context;

        public ReservationRepository()
        {
            _context = new CruiseManagementContext();
        }

        public Reservation GetReservation(int id)
        {
            return _context.Reservations.Find(id);
        }

        public List<Reservation> GetAll()
        {
            return _context.Reservations
                .Include(reservation => reservation.Cabin)
                .Include(reservation => reservation.Cruise)
                .Include(reservation => reservation.Passenger)
                .ToList();
        }

        public void AddReservation(Reservation reservationToAdd)
        {
            reservationToAdd.Passenger = _context.Passengers.Find(reservationToAdd.Passenger.Id);
            reservationToAdd.Cruise = _context.Cruises.Find(reservationToAdd.Cruise.Id);
            reservationToAdd.Cabin = _context.Cabins.Find(reservationToAdd.Cabin.Id);

            _context.Reservations.Add(reservationToAdd);
            _context.SaveChanges();
        }

        public bool IsPassengerOnCruise(int passengerId, int cruiseId)
        {
            var passengerOnCruise = _context.Reservations
                .FirstOrDefault(reservation => reservation.PassengerId == passengerId && cruiseId == reservation.CruiseId);
            if(passengerOnCruise != null)
            {
                return true;
            }
            return false;
        }

        public bool RemoveReservation(int id)
        {
            var reservationToRemove = _context.Reservations.Find(id);

            if (reservationToRemove != null)
            {
                _context.Reservations.Remove(reservationToRemove);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EditReservation(Reservation reservationToEdit)
        {
            var currentReservation = _context.Reservations.Find(reservationToEdit.Id);
            if (currentReservation == null)
            {
                return false;
            }

            currentReservation.Cabin = _context.Cabins.Find(reservationToEdit.Cabin.Id);
            currentReservation.Cruise = _context.Cruises.Find(reservationToEdit.Cruise.Id);
            currentReservation.Passenger = _context.Passengers.Find(reservationToEdit.Passenger.Id);

            _context.SaveChanges();
            return true;
        }
    }
}
