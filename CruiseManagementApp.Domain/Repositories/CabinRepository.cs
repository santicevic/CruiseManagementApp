using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CruiseManagementApp.Data.Entities.Models;
using CruiseManagementApp.Data.Entities;

namespace CruiseManagementApp.Domain.Repositories
{
    public class CabinRepository
    {
        private readonly CruiseManagementContext _context;

        public CabinRepository()
        {
            _context = new CruiseManagementContext();
        }

        public Cabin GetCabin(int id)
        {
            return _context.Cabins.Find(id);
        }

        public List<Cabin> GetAll()
        {
            return _context.Cabins.ToList();
        }

        public void AddCabin(Cabin cabinToAdd)
        {
            _context.Cabins.Add(cabinToAdd);
            _context.SaveChanges();
        }

        public bool RemoveCabin(int id)
        {
            var cabinToRemove = _context.Cabins.Find(id);

            if (cabinToRemove != null)
            {
                _context.Cabins.Remove(cabinToRemove);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EditCabin(Cabin cabinToEdit)
        {
            var currentCabin = _context.Cabins.Find(cabinToEdit.Id);
            if (currentCabin == null)
            {
                return false;
            }

            currentCabin.Name = cabinToEdit.Name;
            currentCabin.Price = cabinToEdit.Price;
            currentCabin.Category = cabinToEdit.Category;

            _context.SaveChanges();
            return true;
        }
    }
}
