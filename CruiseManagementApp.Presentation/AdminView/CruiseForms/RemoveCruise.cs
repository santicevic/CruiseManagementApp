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

namespace CruiseManagementApp.Presentation.AdminView.CruiseForms
{
    public partial class RemoveCruise : Form
    {
        private readonly CruiseRepository _cruises; 
        public RemoveCruise()
        {
            InitializeComponent();
            _cruises = new CruiseRepository();
            cruiseSelectCombobox.DataSource = _cruises.GetAll();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedItem = (Cruise)cruiseSelectCombobox.SelectedItem;
            _cruises.RemoveCruise(selectedItem.Id);
            Close();
        }
    }
}
