using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CruiseManagementApp.Presentation.AdminView;
using CruiseManagementApp.Presentation.UserView;

namespace CruiseManagementApp.Presentation
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AdminView_Click(object sender, EventArgs e)
        {
            var adminView = new AdminViewMain();
            adminView.ShowDialog();
        }

        private void UserView_Click(object sender, EventArgs e)
        {
            var userView = new UserViewMain();
            userView.ShowDialog();
        }
    }
}
