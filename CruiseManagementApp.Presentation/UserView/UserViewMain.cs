using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CruiseManagementApp.Presentation.UserView.PassengerForms;
using CruiseManagementApp.Presentation.UserView.ReservationForms;

namespace CruiseManagementApp.Presentation.UserView
{
    public partial class UserViewMain : Form
    {
        public UserViewMain()
        {
            InitializeComponent();
        }

        private void AddPassenger_Click(object sender, EventArgs e)
        {
            var addPassenger = new AddPassenger();
            addPassenger.ShowDialog();
        }

        private void EditPassenger_Click(object sender, EventArgs e)
        {
            var editPassenger = new EditPassenger();
            editPassenger.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var deletePassenger = new DeletePassenger();
            deletePassenger.ShowDialog();
        }

        private void AddReservationButton_Click(object sender, EventArgs e)
        {
            var addReservation = new AddReservation();
            addReservation.ShowDialog();
        }
    }
}
