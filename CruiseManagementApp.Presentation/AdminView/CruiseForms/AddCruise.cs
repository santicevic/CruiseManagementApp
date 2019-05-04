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
using CruiseManagementApp.Data.Entities.Models;
using CruiseManagementApp.Data.Enums;

namespace CruiseManagementApp.Presentation.AdminView.CruiseForms
{
    public partial class AddCruise : Form
    {
        private readonly CruiseRepository _cruises;
        private readonly ShipRepository _ships;
        private readonly EmployeeRepository _employees;
        private readonly EmployeeOnCruiseRepository _employeesOnCruise;
        private Cruise _cruiseToAdd;
        public AddCruise()
        {
            InitializeComponent();
            _cruises = new CruiseRepository();
            _ships = new ShipRepository();
            _employees = new EmployeeRepository();
            _employeesOnCruise = new EmployeeOnCruiseRepository();
            shipCombobox.DataSource = _ships.GetAll();
            portCombobox.DataSource = Enum.GetValues(typeof(Port));
            RefreshEmployees();
        }

        private void RefreshEmployees()
        {
            var employeeList = _employees.GetAll();
            foreach(Employee employee in employeeList)
            {
                employeeListbox.Items.Add(employee);
            }
        }

        private void SaveShipButton_Click(object sender, EventArgs e)
        {
            var selectedShip = (Ship)shipCombobox.SelectedValue;
            _cruiseToAdd = new Cruise
            {
                PortOfDeparture = (Port)portCombobox.SelectedValue,
                Ship = selectedShip
            };
            shipForm.Enabled = false;
            employeeOnCruiseForm.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _cruises.AddCruise(_cruiseToAdd);

            foreach (Employee employee in employeeListbox.CheckedItems)
            {
                var employeeOnCruiseToAdd = new EmployeeOnCruise
                {
                    StartDate = startDatePicker.Value,
                    Cruise = _cruiseToAdd,
                    Employee = employee
                };

                _employeesOnCruise.AddEmployeeOnCruise(employeeOnCruiseToAdd);
            }
            Close();
        }
    }
}
