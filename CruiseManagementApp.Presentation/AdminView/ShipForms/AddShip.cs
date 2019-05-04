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

namespace CruiseManagementApp.Presentation.AdminView.ShipForms
{
    public partial class AddShip : Form
    {
        private readonly ShipRepository _ships;
        public AddShip()
        {
            InitializeComponent();
            _ships = new ShipRepository();
            yearOfAssemblyPicker.CustomFormat = "yyyy";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var shipToAdd = new Ship
            {
                Name = shipNameTextbox.Text,
                YearOfAssembly = yearOfAssemblyPicker.Value,
            };

            var validationResult = FormValidation.ShipFormValidation(shipToAdd);

            if (validationResult == "")
            {
                _ships.AddShip(shipToAdd);
                Close();
            }
            else
            {
                warningLabel.Text = validationResult;
            }
        }
    }
}
