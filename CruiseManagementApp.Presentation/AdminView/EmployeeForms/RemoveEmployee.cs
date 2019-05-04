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

namespace CruiseManagementApp.Presentation.AdminView.EmployeeForms
{
    public partial class RemoveEmployee : Form
    {
        private readonly EmployeeRepository _employees;
        public RemoveEmployee()
        {
            InitializeComponent();
            _employees = new EmployeeRepository();
            employeeSelectCombobox.DataSource = _employees.GetAll();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var employeeToDelete = (Employee)employeeSelectCombobox.SelectedItem;
            _employees.RemoveEmployee(employeeToDelete.Id);
            Close();
        }
    }
}
