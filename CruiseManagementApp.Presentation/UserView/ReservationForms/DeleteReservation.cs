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
using CruiseManagementApp.Domain.Repositories;

namespace CruiseManagementApp.Presentation.UserView.ReservationForms
{
    public partial class DeleteReservation : Form
    {
        private readonly ReservationRepository _reservations;
        public DeleteReservation()
        {
            InitializeComponent();
            _reservations = new ReservationRepository();
            reservationSelectorCombobox.DataSource = _reservations.GetAll();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var reservationToRemove = (Reservation)reservationSelectorCombobox.SelectedItem;
            _reservations.RemoveReservation(reservationToRemove.Id);
            Close();
        }
    }
}
