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
    public partial class Login : Form
    {
        private readonly CarRental2Entities _db;
        public Login()
        {
            InitializeComponent();
            _db = new CarRental2Entities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                SHA256 sha = SHA256.Create();
                var username = tbName.Text.Trim();
                var password = tbPassword.Text;

              

                var hashed_password = Utils.HashPassword(password);

                //chack for matching username, password and active flag
                var user = _db.Users.FirstOrDefault(q => q.username == username && q.password == hashed_password);
                if(user == null)
                {
                    MessageBox.Show("Please provide vaild credentials");
                }
                else
                {
                   // var role = user.UserRoles.FirstOrDefault();
                    //var roleShortName = role.Role.shortname;
                    var mainWindow = new MainWindow(this, user);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong. Please try again"+ "\n " + $"{ex.Message}");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
