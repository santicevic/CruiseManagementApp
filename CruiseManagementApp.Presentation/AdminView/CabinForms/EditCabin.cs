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

namespace CruiseManagementApp.Presentation.AdminView.CabinForms
{
    public partial class EditCabin : Form
    {
        private readonly CabinRepository _cabins;
        private Cabin selectedCabin;
        public EditCabin()
        {
            InitializeComponent();
            _cabins = new CabinRepository();
            cabinSelectCombobox.DataSource = _cabins.GetAll();
            categoryCombobox.DataSource = Enum.GetValues(typeof(CabinCategory));
            UpdateForm();
        }

        private void UpdateForm()
        {
            selectedCabin = (Cabin)cabinSelectCombobox.SelectedItem;

            cabinNameTextbox.Text = selectedCabin.Name;
            priceTextbox.Text = selectedCabin.Price.ToString();
            categoryCombobox.SelectedItem = selectedCabin.Category;
            editForm.Text = selectedCabin.Id.ToString();
        }

        private void OnCabinChange(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var cabinPrice = 0;
            int.TryParse(priceTextbox.Text, out cabinPrice);

            var cabinToAdd = new Cabin
            {
                Id = selectedCabin.Id,
                Name = cabinNameTextbox.Text,
                Category = (CabinCategory)categoryCombobox.SelectedItem,
                Price = cabinPrice
            };

            var validationResult = FormValidation.CabinFormValidation(cabinToAdd);

            if(validationResult == "")
            {
                _cabins.EditCabin(cabinToAdd);
                Close();
            }
            else
            {
                warningLabel.Text = validationResult;
            }
        }
    }
}
