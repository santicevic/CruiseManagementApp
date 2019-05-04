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

namespace CruiseManagementApp.Presentation.AdminView.ShipForms
{
    public partial class RemoveShip : Form
    {
        private readonly ShipRepository _ships;
        public RemoveShip()
        {
            InitializeComponent();
            _ships = new ShipRepository();
            shipSelectCombobox.DataSource = _ships.GetAll();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var shipToDelete = (Ship)shipSelectCombobox.SelectedItem;
            _ships.RemoveShip(shipToDelete.Id);
            Close();
        }
    }
}
