using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_App
{

    public partial class ManageUsers : Form
    {
        private readonly CarRental2Entities _db;
        private User _user;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new CarRental2Entities();
            
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();     
        }

        public void PopulateGrid()
        {
            var users = _db.Users
                .Select(q => new
                {
                    q.id,
                    q.username,
                    q.UserRoles.FirstOrDefault().Role.name,
                    q.isActive
                })
                .ToList();
            gvUserList.DataSource = users;
            gvUserList.Columns["username"].HeaderText = "Username";
            gvUserList.Columns["name"].HeaderText = "Role name";
            gvUserList.Columns["isActive"].HeaderText = "Active";


            gvUserList.Columns["id"].Visible = false;

        }

        private void BtAddUser_Click(object sender, EventArgs e)
        {
           if(!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }
        }

       
        private void BtDeactivateUseer_Click(object sender, EventArgs e)
        {
            try
            {
                //get Id of selected Row
                var id = (int)gvUserList.SelectedRows[0].Cells["Id"].Value;

                //queary database for record
                var user = _db.Users.FirstOrDefault(q => q.id == id);

                //if(user.isActive == true)
                //user.isActive = false;
                //else
                // user.isActive = true;



                user.isActive = user.isActive == true? false: false;

                _db.SaveChanges();

                MessageBox.Show($"{user.username}'s activity status has been changed!");
                PopulateGrid();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void btnRefreshUser_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void gvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtEditUsers_Click(object sender, EventArgs e)
        {
            try
            {
                //get Id of selected Row
                var id = (int)gvUserList.SelectedRows[0].Cells["Id"].Value;

                //queary database for record
                var user = _db.Users.FirstOrDefault(q => q.id == id);


                var genericPassword = "Password@123";


                var hashed_Password = Utils.HashPassword(genericPassword);

                user.password = hashed_Password;

                _db.SaveChanges();

                MessageBox.Show($"{user.username}'s Password has been reset!");
                PopulateGrid();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
         
        }
    }
}
