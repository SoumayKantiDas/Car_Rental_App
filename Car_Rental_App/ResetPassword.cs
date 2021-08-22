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
    public partial class ResetPassword : Form
    {
        private readonly CarRental2Entities _db;
        public User _user;
        public ResetPassword()
        {
            InitializeComponent();
            _db = new CarRental2Entities();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbNew.Text;
                var confirm_password = tbConfirm.Text;
                var user = (int)cbUsername.SelectedValue;

                if (password != confirm_password)
                {
                    MessageBox.Show("Password do not match. Please try again ");
                }

                else
                {
                    password = Utils.HashPassword(password);
                    _db.SaveChanges();
                    MessageBox.Show("Password was reset sucessfully");
                    Close();
                }
            }
            catch (Exception )
            {
               MessageBox.Show("An Error has occured.Please try again");

            }
           
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            var user = _db.Users.ToList();
            cbUsername.DisplayMember = "username";
            cbUsername.ValueMember = "id";
            cbUsername.DataSource = user;
        }
    }
}
