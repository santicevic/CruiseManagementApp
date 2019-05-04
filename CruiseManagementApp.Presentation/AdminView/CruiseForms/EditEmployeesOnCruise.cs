using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CruiseManagementApp.Domain.Repositories;
using CruiseManagementApp.Data.Enums;
using CruiseManagementApp.Presentation.Utils;
using CruiseManagementApp.Data.Entities.Models;

namespace CruiseManagementApp.Presentation.AdminView.CruiseForms
{
    public partial class EditEmployeesOnCruise : Form
    {
        private readonly CruiseRepository _cruises;
        private readonly EmployeeOnCruiseRepository _employeesOnCruise;
        private readonly EmployeeRepository _employees;
        private List<Employee> _employeesToRemove;
        private List<Employee> _employeesToAdd;
        public EditEmployeesOnCruise()
        {
            InitializeComponent();
            _cruises = new CruiseRepository();
            _employeesOnCruise = new EmployeeOnCruiseRepository();
            _employees = new EmployeeRepository();
            _employeesToRemove = new List<Employee>();
            _employeesToAdd = new List<Employee>();
            cruiseSelectCombobox.DataSource = _cruises.GetAll();
            UpdateEmployeeOnCruiseForm();
        }

        private void UpdateEmployeeOnCruiseForm()
        {
            var selectedCruise = (Cruise)cruiseSelectCombobox.SelectedItem;
            var employeesOnSelectedCruise = _employeesOnCruise.GetEmployeesOnSpecificCruise(selectedCruise.Id);
            var employeesOnThisCruise = new List<Employee>();

            employeesOnCruiseListbox.Items.Clear();
            employeeAddComobox.Items.Clear();

            foreach (Employee employee in _employees.GetAll())
            {
                foreach (EmployeeOnCruise employeeOnCruise in employeesOnSelectedCruise)
                {
                    if (employee.Id == employeeOnCruise.EmployeeId)
                    {
                        employeesOnCruiseListbox.Items.Add(employee);
                        employeesOnThisCruise.Add(employee);
                    }
                }
            }
            var employeesNotOnThisCruise = _employees.GetAll().Where(e1 => !employeesOnThisCruise.Any(e2 => e2.Id == e1.Id)).ToList();
            foreach(Employee employee in employeesNotOnThisCruise)
            {
                employeeAddComobox.Items.Add(employee);
            }
        }

        private void OnCruiseChange(object sender, EventArgs e)
        {
            _employeesToAdd.Clear();
            _employeesToRemove.Clear();
            UpdateEmployeeOnCruiseForm();
        }

        private void AddEmployeButton_Click(object sender, EventArgs e)
        {
            var selectedEmployee = (Employee)employeeAddComobox.SelectedItem;
            employeeAddComobox.Items.Remove(selectedEmployee);
            employeesOnCruiseListbox.Items.Add(selectedEmployee);
            if (_employeesToRemove.Contains(selectedEmployee))
            {
                _employeesToRemove.Remove(selectedEmployee);
            }
            else
            {
                _employeesToAdd.Add(selectedEmployee);
            }
        }

        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            var selectedEmployee = (Employee)employeesOnCruiseListbox.SelectedItem;
            employeeAddComobox.Items.Add(selectedEmployee);
            employeesOnCruiseListbox.Items.Remove(selectedEmployee);

            if (_employeesToAdd.Contains(selectedEmployee))
            {
                _employeesToAdd.Remove(selectedEmployee);
            }
            else
            {
                _employeesToRemove.Add(selectedEmployee);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var selectedCruise = (Cruise)cruiseSelectCombobox.SelectedItem;
            foreach (Employee employee in _employeesToAdd)
            {
                var employeeOnCruiseToAdd = new EmployeeOnCruise
                {
                    Employee = employee,
                    Cruise = selectedCruise,
                    StartDate = DateTime.Today
                };

                _employeesOnCruise.AddEmployeeOnCruise(employeeOnCruiseToAdd);
            }

            foreach (Employee employee in _employeesToRemove)
            {
                var employeeOnCruiseToRemove = _employeesOnCruise.GetByCruiseAndEmployee(employee.Id, selectedCruise.Id);
                _employeesOnCruise.RemoveEmployeeOnCruise(employeeOnCruiseToRemove.Id);
            }
            Close();
        }
    }
}
