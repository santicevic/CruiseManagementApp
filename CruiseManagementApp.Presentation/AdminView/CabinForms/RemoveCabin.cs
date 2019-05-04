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

namespace CruiseManagementApp.Presentation.AdminView.CabinForms
{
    public partial class RemoveCabin : Form
    {
        private readonly CabinRepository _cabins;
        public RemoveCabin()
        {
            InitializeComponent();
            _cabins = new CabinRepository();
            cabinSelectCombobox.DataSource = _cabins.GetAll();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var cabinToDelete = (Cabin)cabinSelectCombobox.SelectedItem;
            _cabins.RemoveCabin(cabinToDelete.Id);
            Close();
        }
    }
}
