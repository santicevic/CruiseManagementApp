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

namespace CruiseManagementApp.Presentation.UserView.PassengerForms
{
    public partial class DeletePassenger : Form
    {
        private readonly PassengerRepository _passengers;
        public DeletePassenger()
        {
            InitializeComponent();
            _passengers = new PassengerRepository();
            passengerSelectorCombobox.DataSource = _passengers.GetAll();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var passengerToDelete = (Passenger)passengerSelectorCombobox.SelectedItem;

            _passengers.RemovePassenger(passengerToDelete.Id);
            Close();
        }
    }
}
