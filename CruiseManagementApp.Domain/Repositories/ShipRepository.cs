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
    public class ShipRepository
    {
        private readonly CruiseManagementContext _context;

        public ShipRepository()
        {
            _context = new CruiseManagementContext();
        }

        public Ship GetShip(int id)
        {
            return _context.Ships.Find(id);
        }

        public List<Ship> GetAll()
        {
            return _context.Ships.ToList();
        }

        public void AddShip(Ship shipToAdd)
        {
            _context.Ships.Add(shipToAdd);
            _context.SaveChanges();
        }

        public bool RemoveShip(int id)
        {
            var shipToRemove = _context.Ships.Find(id);

            if(shipToRemove != null)
            {
                _context.Ships.Remove(shipToRemove);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EditShip(Ship shipToEdit)
        {
            var currentShip = _context.Ships.Find(shipToEdit.Id);
            if(currentShip == null)
            {
                return false;
            }

            currentShip.Name = shipToEdit.Name;
            currentShip.YearOfAssembly = shipToEdit.YearOfAssembly;

            _context.SaveChanges();
            return true;
        }
    }
}
