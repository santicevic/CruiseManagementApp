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
    public partial class AddCabin : Form
    {
        private readonly CabinRepository _cabins;
        public AddCabin()
        {
            InitializeComponent();
            _cabins = new CabinRepository();
            categoryCombobox.DataSource = Enum.GetValues(typeof(CabinCategory));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var cabinPrice = 0;
            int.TryParse(priceTextbox.Text, out cabinPrice);

            var cabinToAdd = new Cabin
            {
                Name = cabinNameTextbox.Text,
                Category = (CabinCategory)categoryCombobox.SelectedItem,
                Price = cabinPrice
            };

            var validationResult = FormValidation.CabinFormValidation(cabinToAdd);

            if (validationResult == "")
            {
                _cabins.AddCabin(cabinToAdd);
                Close();
            }
            else
            {
                warningLabel.Text = validationResult;
            }
        }
    }
}
