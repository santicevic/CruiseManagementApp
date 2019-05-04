using CruiseManagementApp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CruiseManagementApp.Data.Entities.Models;
using CruiseManagementApp.Data.Enums;
using CruiseManagementApp.Presentation.Utils;

namespace CruiseManagementApp.Presentation.UserView.PassengerForms
{
    public partial class EditPassenger : Form
    {
        private readonly PassengerRepository _passengers;
        private Passenger selectedPassenger;
        public EditPassenger()
        {
            InitializeComponent();
            _passengers = new PassengerRepository();
            passengerSelectorCombobox.DataSource = _passengers.GetAll();
            genderCombobox.DataSource = Enum.GetValues(typeof(Gender));
            UpdateForm();
        }

        private void UpdateForm()
        {
            selectedPassenger = (Passenger)passengerSelectorCombobox.SelectedItem;
            firstNameTextbox.Text = selectedPassenger.FirstName;
            lastNameTextbox.Text = selectedPassenger.LastName;
            addressTextbox.Text = selectedPassenger.Address;
            genderCombobox.SelectedItem = selectedPassenger.Gender;
            editForm.Text = selectedPassenger.Id.ToString();
        }

        private void OnPassengerSelectChange(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var passengerToEdit = new Passenger
            {
                Id = selectedPassenger.Id,
                FirstName = firstNameTextbox.Text,
                LastName = lastNameTextbox.Text,
                Address = addressTextbox.Text,
                Gender = (Gender)genderCombobox.SelectedItem
            };

            var validationResult = FormValidation.PassengerFormValidation(passengerToEdit);
            if (validationResult == "")
            {
                _passengers.EditPassenger(passengerToEdit);
                Close();
            }
            else
            {
                warningLabel.Text = validationResult;
            }
        }
    }
}
