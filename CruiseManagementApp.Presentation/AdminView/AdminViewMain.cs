using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CruiseManagementApp.Presentation.AdminView.CabinForms;
using CruiseManagementApp.Presentation.AdminView.EmployeeForms;
using CruiseManagementApp.Presentation.AdminView.ShipForms;
using CruiseManagementApp.Presentation.AdminView.CruiseForms;

namespace CruiseManagementApp.Presentation.AdminView
{
    public partial class AdminViewMain : Form
    {
        public AdminViewMain()
        {
            InitializeComponent();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            var selectedOperation = operationGroupbox.Controls.OfType<RadioButton>()
                                    .FirstOrDefault(r => r.Checked);

            if(selectedOperation == null)
            {
                return;
            }

            switch (selectedOperation.Name)
            {
                case "addNewRadio":
                    var addEmployee = new AddEmployee();
                    addEmployee.ShowDialog();
                    break;
                case "editRadio":
                    var editEmployee = new EditEmployee();
                    editEmployee.ShowDialog();
                    break;
                case "removeRadio":
                    var removeEmployee = new RemoveEmployee();
                    removeEmployee.ShowDialog();
                    break;
            }
        }

        private void ShipButton_Click(object sender, EventArgs e)
        {
            var selectedOperation = operationGroupbox.Controls.OfType<RadioButton>()
                                    .FirstOrDefault(r => r.Checked);

            if (selectedOperation == null)
            {
                return;
            }

            switch (selectedOperation.Name)
            {
                case "addNewRadio":
                    var addShip = new AddShip();
                    addShip.ShowDialog();
                    break;
                case "editRadio":
                    var editShip = new EditShip();
                    editShip.ShowDialog();
                    break;
                case "removeRadio":
                    var removeShip = new RemoveShip();
                    removeShip.ShowDialog();
                    break;
            }
        }

        private void CabinButton_Click(object sender, EventArgs e)
        {
            var selectedOperation = operationGroupbox.Controls.OfType<RadioButton>()
                                    .FirstOrDefault(r => r.Checked);

            if (selectedOperation == null)
            {
                return;
            }

            switch (selectedOperation.Name)
            {
                case "addNewRadio":
                    var addCabin = new AddCabin();
                    addCabin.ShowDialog();
                    break;
                case "editRadio":
                    var editCabin = new EditCabin();
                    editCabin.ShowDialog();
                    break;
                case "removeRadio":
                    var removeCabin = new RemoveCabin();
                    removeCabin.ShowDialog();
                    break;
            }
        }

        private void CruiseButton_Click(object sender, EventArgs e)
        {
            var selectedOperation = operationGroupbox.Controls.OfType<RadioButton>()
                                    .FirstOrDefault(r => r.Checked);

            if (selectedOperation == null)
            {
                return;
            }

            switch (selectedOperation.Name)
            {
                case "addNewRadio":
                    var addCruise = new AddCruise();
                    addCruise.ShowDialog();
                    break;
                case "editRadio":
                    var editCruise = new EditEmployeesOnCruise();
                    editCruise.ShowDialog();
                    break;
                case "removeRadio":
                    var removeCruise = new RemoveCruise();
                    removeCruise.ShowDialog();
                    break;
            }
        }
    }
}
