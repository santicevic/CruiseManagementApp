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
using CruiseManagementApp.Presentation.Utils;

namespace CruiseManagementApp.Presentation.AdminView.EmployeeForms
{

    public partial class EditEmployee : Form
    {
        private readonly EmployeeRepository _employees;
        private Employee selectedEmployee;
        public EditEmployee()
        {
            InitializeComponent();
            _employees = new EmployeeRepository();
            employeeSelectCombobox.DataSource = _employees.GetAll();
            genderCombobox.DataSource = Enum.GetValues(typeof(Gender));
            UpdateForm();
        }

        private void UpdateForm()
        {
            selectedEmployee = (Employee)employeeSelectCombobox.SelectedItem;

            firstNameTextbox.Text = selectedEmployee.FirstName;
            lastNameTextbox.Text = selectedEmployee.LastName;
            genderCombobox.SelectedItem = selectedEmployee.Gender;
            dateOfBirthPicker.Value = selectedEmployee.DateOfBirth;
            editForm.Text = selectedEmployee.Id.ToString();
        }

        private void OnSelectionChange(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var employeeToAdd = new Employee
            {
                Id = selectedEmployee.Id,
                FirstName = firstNameTextbox.Text,
                LastName = lastNameTextbox.Text,
                Gender = (Gender)genderCombobox.SelectedItem,
                DateOfBirth = dateOfBirthPicker.Value
            };

            var validationResult = FormValidation.EmployeeFormValidation(employeeToAdd);

            if (validationResult == "")
            {
                _employees.EditEmployee(employeeToAdd);
                Close();
            }
            else
            {
                warningLabel.Text = validationResult;
            }
        }
    }
}
