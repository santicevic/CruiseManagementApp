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
    public class EmployeeOnCruiseRepository
    {
        private readonly CruiseManagementContext _context;

        public EmployeeOnCruiseRepository()
        {
            _context = new CruiseManagementContext();
        }

        public EmployeeOnCruise GetEmployeeOnCruise(int id)
        {
            return _context.EmployeesOnCruises.Find(id);
        }

        public List<EmployeeOnCruise> GetAll()
        {
            return _context.EmployeesOnCruises.ToList();
        }

        public EmployeeOnCruise GetByCruiseAndEmployee(int employeeId, int cruiseId)
        {
            return _context.EmployeesOnCruises
                .First(employeeOnCruise => employeeOnCruise.EmployeeId == employeeId && employeeOnCruise.CruiseId == cruiseId);
        }

        public List<EmployeeOnCruise> GetEmployeesOnSpecificCruise(int cruiseId)
        {
            return _context.EmployeesOnCruises.Include(employee => employee.Employee)
                .Where(employeeOnCruise => employeeOnCruise.CruiseId == cruiseId).ToList();
        }

        public void AddEmployeeOnCruise(EmployeeOnCruise employeeOnCruiseToAdd)
        {
            employeeOnCruiseToAdd.Employee = _context.Employees.Find(employeeOnCruiseToAdd.Employee.Id);
            employeeOnCruiseToAdd.Cruise = _context.Cruises.Find(employeeOnCruiseToAdd.Cruise.Id);
            _context.EmployeesOnCruises.Add(employeeOnCruiseToAdd);
            _context.SaveChanges();
        }

        public bool RemoveEmployeeOnCruise(int id)
        {
            var employeeOnCruiseToRemove = _context.EmployeesOnCruises.Find(id);

            if (employeeOnCruiseToRemove != null)
            {
                _context.EmployeesOnCruises.Remove(employeeOnCruiseToRemove);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EditEmployeeOnCruise(EmployeeOnCruise employeeOnCruiseToEdit)
        {
            var currentEmployeeOnCruise = _context.EmployeesOnCruises.Find(employeeOnCruiseToEdit.Id);
            if (currentEmployeeOnCruise == null)
            {
                return false;
            }

            currentEmployeeOnCruise.StartDate = employeeOnCruiseToEdit.StartDate;
            currentEmployeeOnCruise.Cruise = employeeOnCruiseToEdit.Cruise;
            currentEmployeeOnCruise.Employee = employeeOnCruiseToEdit.Employee;

            _context.SaveChanges();
            return true;
        }
    }
}
