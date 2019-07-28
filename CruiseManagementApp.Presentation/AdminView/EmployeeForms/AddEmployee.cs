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
    public partial class AddEmployee : Form
    {
        private readonly EmployeeRepository _employees;
        public AddEmployee()
        {
            InitializeComponent();
            _employees = new EmployeeRepository();
            genderCombobox.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var employeeToAdd = new Employee
            {
                FirstName = firstNameTextbox.Text,
                LastName = lastNameTextbox.Text,
                DateOfBirth = dateOfBirthPicker.Value,
                Gender = (Gender)genderCombobox.SelectedValue
            };

            var validationResult = FormValidation.EmployeeFormValidation(employeeToAdd);

            if(validationResult == "")
            {
                _employees.AddEmployee(employeeToAdd);
                Close();
            }
            else
            {
                warningLabel.Text = validationResult;
            }
        }

        private void OnYesRadioButtonCheckChange(object sender, EventArgs e)
        {
            saveButton.Enabled = yesRadioButton.Checked ? true : false;
        }
    }
}
