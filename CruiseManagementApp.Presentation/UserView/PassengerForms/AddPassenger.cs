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

namespace CruiseManagementApp.Presentation.UserView.PassengerForms
{
    public partial class AddPassenger : Form
    {
        private readonly PassengerRepository _passengers;
        public AddPassenger()
        {
            InitializeComponent();
            genderCombobox.DataSource = Enum.GetValues(typeof(Gender));
            _passengers = new PassengerRepository();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var passengerToAdd = new Passenger
            {
                FirstName = firstNameTextbox.Text,
                LastName = lastNameTextbox.Text,
                Address = addressTextbox.Text,
                Gender = (Gender)genderCombobox.SelectedItem
            };

            var validationResult = FormValidation.PassengerFormValidation(passengerToAdd);
            if (validationResult == "")
            {
                _passengers.AddPassenger(passengerToAdd);
                Close();
            }
            else
            {
                warningLabel.Text = validationResult;
            }
        }
    }
}
