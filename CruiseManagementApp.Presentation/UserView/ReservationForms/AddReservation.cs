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
    public partial class AddReservation : Form
    {
        private readonly ReservationRepository _reservations;
        private readonly PassengerRepository _passengers;
        private readonly CruiseRepository _cruises;
        private readonly CabinRepository _cabins;
        public AddReservation()
        {
            InitializeComponent();
            _reservations = new ReservationRepository();
            _passengers = new PassengerRepository();
            _cruises = new CruiseRepository();
            _cabins = new CabinRepository();

            passengerSelectCombobox.DataSource = _passengers.GetAll();
            cabinSelectCombobox.DataSource = _cabins.GetAll();
            UpdateCruises();
        }

        private void UpdateCruises()
        {
            var selectedPassenger = (Passenger)passengerSelectCombobox.SelectedItem;
            var cruisesThatPassengerIsNotOn = _cruises.GetAll()
                .Where(cruise => !_reservations.IsPassengerOnCruise(selectedPassenger.Id, cruise.Id)).ToList();

            cruiseSelectCombobox.DataSource = cruisesThatPassengerIsNotOn;
        }
        private void OnPassengerSelectionChange(object sender, EventArgs e)
        {
            UpdateCruises();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var reservationToAdd = new Reservation
            {
                Passenger = (Passenger)passengerSelectCombobox.SelectedItem,
                Cruise = (Cruise)cruiseSelectCombobox.SelectedItem,
                Cabin = (Cabin)cabinSelectCombobox.SelectedItem
            };

            _reservations.AddReservation(reservationToAdd);
            Close();
        }

    }
}
