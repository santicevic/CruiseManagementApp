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
    public partial class EditShip : Form
    {
        private readonly ShipRepository _ships;
        private Ship selectedShip;
        public EditShip()
        {
            InitializeComponent();
            _ships = new ShipRepository();
            shipSelectCombobox.DataSource = _ships.GetAll();
            UpdateForm();
        }

        private void UpdateForm()
        {
            selectedShip = (Ship)shipSelectCombobox.SelectedItem;

            shipNameTextbox.Text = selectedShip.Name;
            yearOfAssemblyPicker.Value = selectedShip.YearOfAssembly;
            editForm.Text = selectedShip.Id.ToString();
        }

        private void OnShipSelectChange(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var shipToAdd = new Ship
            {
                Id = selectedShip.Id,
                Name = shipNameTextbox.Text,
                YearOfAssembly = yearOfAssemblyPicker.Value
            };

            var validationResult = FormValidation.ShipFormValidation(shipToAdd);

            if (validationResult == "")
            {
                _ships.EditShip(shipToAdd);
                Close();
            }
            else
            {
                warningLabel.Text = validationResult;
            }
        }
    }
}
