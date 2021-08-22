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
    public partial class AddUser : Form
    {
        private readonly CarRental2Entities _db;
        private ManageUsers _manageUser;
        public AddUser(ManageUsers manageUsers)
        {
            InitializeComponent();
            _db = new CarRental2Entities();
            _manageUser = manageUsers;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _db.Roles.ToList();
            cbRole.DataSource = roles;
            cbRole.ValueMember = "id";
            cbRole.DisplayMember = "name";

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            

            try
            {
                SHA256 sha = SHA256.Create();
                var username = tbUserName.Text.Trim();

                //var username = tbUserName.Text;
                var RoleID = (int)cbRole.SelectedValue;
                //queary database for record
                //var user = _db.Users.FirstOrDefault(q => q.id == id);


                var genericPassword = "Password@123";


                var hashed_Password = Utils.HashPassword(genericPassword);

                var password = hashed_Password;

                var user = new User
                {
                    username = username,
                    password = password,
                    isActive = true
                };
                _db.Users.Add(user);
                _db.SaveChanges();
                var Userid = user.id;
                var userRole = new UserRole
                {
                    roleid = RoleID,
                    Userid = Userid
                };
                _db.UserRoles.Add(userRole);
                _db.SaveChanges();
                MessageBox.Show("New user has been added");
                _manageUser.PopulateGrid();

                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
            }

        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
