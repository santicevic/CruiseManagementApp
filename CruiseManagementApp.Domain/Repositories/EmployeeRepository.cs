using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CruiseManagementApp.Data.Entities;
using CruiseManagementApp.Data.Entities.Models;

namespace CruiseManagementApp.Domain.Repositories
{
    public class EmployeeRepository
    {
        private readonly CruiseManagementContext _context;

        public EmployeeRepository()
        {
            _context = new CruiseManagementContext();
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.Find(id);
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public void AddEmployee(Employee employeeToAdd)
        {
            _context.Employees.Add(employeeToAdd);
            _context.SaveChanges();
        }

        public bool RemoveEmployee(int id)
        {
            var employeeToRemove = _context.Employees.Find(id);

            if (employeeToRemove != null)
            {
                _context.Employees.Remove(employeeToRemove);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EditEmployee(Employee employeeToEdit)
        {
            var currentEmployee = _context.Employees.Find(employeeToEdit.Id);
            if (currentEmployee == null)
            {
                return false;
            }

            currentEmployee.FirstName = employeeToEdit.FirstName;
            currentEmployee.LastName = employeeToEdit.LastName;
            currentEmployee.DateOfBirth = employeeToEdit.DateOfBirth;
            currentEmployee.Gender = employeeToEdit.Gender;

            _context.SaveChanges();
            return true;
        }
    }
}
