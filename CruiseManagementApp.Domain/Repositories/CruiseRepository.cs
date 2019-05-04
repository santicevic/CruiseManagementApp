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
    public class CruiseRepository
    {
        private readonly CruiseManagementContext _context;

        public CruiseRepository()
        {
            _context = new CruiseManagementContext();
        }

        public Cruise GetCruise(int id)
        {
            return _context.Cruises.Find(id);
        }

        public List<Cruise> GetAll()
        {
            return _context.Cruises.Include(cruise => cruise.Ship).ToList();
        }

        public void AddCruise(Cruise cruiseToAdd)
        {
            cruiseToAdd.Ship = _context.Ships.Find(cruiseToAdd.Ship.Id);
            _context.Cruises.Add(cruiseToAdd);
            _context.SaveChanges();
        }

        public bool RemoveCruise(int id)
        {
            var cruiseToRemove = _context.Cruises.Find(id);

            if (cruiseToRemove != null)
            {
                _context.Cruises.Remove(cruiseToRemove);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EditCruise(Cruise cruiseToEdit)
        {
            var currentCruise = _context.Cruises.Find(cruiseToEdit.Id);
            if (currentCruise == null)
            {
                return false;
            }

            currentCruise.PortOfDeparture = cruiseToEdit.PortOfDeparture;
            currentCruise.Ship = cruiseToEdit.Ship;

            _context.SaveChanges();
            return true;
        }
    }
}
