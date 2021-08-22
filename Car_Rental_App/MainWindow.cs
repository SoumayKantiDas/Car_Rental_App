using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_App
{
    public partial class MainWindow : Form
    {
     
        private Login _login;
        public string _roleName;
        public User _user;
       
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Login login,User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _roleName = user.UserRoles.FirstOrDefault().Role.shortname;

           
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.ShowDialog();


            addRentalRecord.MdiParent = this;
            //addRentalRecord.Show();
        }

        private void manageVehichaleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
        }

      //  private void editVehicleToolStripMenuItem_Click(object sender, EventArgs e)
     //   {
           
            //if(!isOpen)
            //{
            //    var managerentalRecords = new ManageVehicleListing();
            //    managerentalRecords.MdiParent = this;
            //    managerentalRecords.Show();

            //}
       


      //  }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            SHA256 sha = SHA256.Create();

          



            
            //if (_user.password == Utils.HashPassword("ff7bd97b1a7789ddd2775122fd6817f3173672da9f802ceec57f284325bf589f                                    "))
            //{
            //    var resetPassword = new ResetPassword(_user);
            //   resetPassword.ShowDialog();
            //}
            var username = _user.username;
            tsiLoginText.Text = $"Loggned In As:{username}";
            if (_roleName != "admin                                             ")
            {
                manageUserToolStripMenuItem.Visible = false;
            }
            //else
            //{
            //    manageUserToolStripMenuItem.Visible = false;
            //}
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForm = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForm.Any(q => q.Name == "ManageRentalRecord");
            if (!isOpen)
            {
                var manageVehicleListing = new ManageRentalRecord
                {
                    MdiParent = this
                };
                manageVehicleListing.Show();
            }
        }

        private void editVehichaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var OpenForm = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForm.Any(q => q.Name == "ManageVehicleListing");
            if (!isOpen)
            {


                var managerentalRecords = new ManageVehicleListing();
                managerentalRecords.ShowDialog();
                managerentalRecords.MdiParent = this;

            }
            

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForm = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForm.Any(q => q.Name == "ManageUsers");
            if (!isOpen)
            {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show();
            }
        }

        private void editPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var OpenForm = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForm.Any(q => q.Name == "ResetPassword");
            if (!isOpen)
            {
                var resetPassword = new ResetPassword();
                resetPassword.ShowDialog();

            }
        }
    }
}
