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

namespace CruiseManagementApp.Presentation.UserView.ReservationForms
{
    public partial class EditReservation : Form
    {
        private readonly ReservationRepository _reservations;
        private readonly PassengerRepository _passengers;
        private readonly CruiseRepository _cruises;
        private readonly CabinRepository _cabins;
        public EditReservation()
        {
            InitializeComponent();
            _reservations = new ReservationRepository();
            _passengers = new PassengerRepository();
            _cruises = new CruiseRepository();
            _cabins = new CabinRepository();
            reservationSelectCombobox.DataSource = _reservations.GetAll();
            passengerSelectCombobox.DataSource = _passengers.GetAll();
            cruiseSelectCombobox.DataSource = _cruises.GetAll();
            cabinSelectCombobox.DataSource = _cabins.GetAll();
            UpdateForm();
        }

        private void UpdateForm()
        {
            var selectedReservation = (Reservation)reservationSelectCombobox.SelectedItem;
            if (selectedReservation == null) return;
            passengerSelectCombobox.SelectedItem = passengerSelectCombobox.Items
                .Cast<Passenger>()
                .First(passenger => passenger.Id == selectedReservation.Passenger.Id);
            cruiseSelectCombobox.SelectedItem = cruiseSelectCombobox.Items
                .Cast<Cruise>()
                .First(cruise => cruise.Id == selectedReservation.Cruise.Id);
            cabinSelectCombobox.SelectedItem = cabinSelectCombobox.Items
                .Cast<Cabin>()
                .First(cabin => cabin.Id == selectedReservation.Cabin.Id);
            UpdateCabinPrice();
        }

        private void OnReservationChange(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void OnCabinChange(object sender, EventArgs e)
        {
            UpdateCabinPrice();
        }

        private void UpdateCabinPrice()
        {
            var selectedCabin = (Cabin)cabinSelectCombobox.SelectedItem;
            priceTextbox.Text = selectedCabin.Price.ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var oldReservation = (Reservation)reservationSelectCombobox.SelectedItem;

            var reservationToEdit = new Reservation
            {
                Id = oldReservation.Id,
                Cabin = (Cabin)cabinSelectCombobox.SelectedItem,
                Passenger = (Passenger)passengerSelectCombobox.SelectedItem,
                Cruise = (Cruise)cruiseSelectCombobox.SelectedItem
            };

            _reservations.EditReservation(reservationToEdit);
            Close();
        }
    }
}
