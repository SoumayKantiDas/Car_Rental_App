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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private ManageVehicleListing _manageVehicleListing;
        private TypesOfCar car;
        private ManageUsers manageUsers;
        private readonly CarRental2Entities _db;


        public AddEditVehicle(ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lvlTitle.Text = "Add new Vehicle";
            this.Text = "Add New Vehicle";
            isEditMode = false;
            _manageVehicleListing = manageVehicleListing;
            
            _db = new CarRental2Entities();
        }
        public AddEditVehicle(TypesOfCar carToEdit, ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lvlTitle.Text = "Edit Vehicle";
            this.Text = "Edit vehicle";
            _manageVehicleListing = manageVehicleListing;
            if (carToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                PopulateField(carToEdit);
                _db = new CarRental2Entities();
            }
        }

        public AddEditVehicle(TypesOfCar car, ManageUsers manageUsers)
        {
            this.car = car;
            this.manageUsers = manageUsers;
        }

        private void PopulateField(TypesOfCar car)
        {
            lblid.Text = car.Id.ToString();
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbVIN.Text = car.VIN;
            TbYear.Text = car.Year.ToString();
            tbLincencePlateNumber.Text = car.LicencePlateNumber;
        }

        private void AddEditVehicle_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Added Validation for make and model
                if(string.IsNullOrWhiteSpace(tbMake.Text) || string.IsNullOrWhiteSpace(tbModel.Text))
                {
                    MessageBox.Show("Please ensure that you provide a make and a model");
                }
                else
                {
                    //if editmode == true;
                    if (isEditMode)
                    {
                        //edit code;
                        var id = int.Parse(lblid.Text);
                        var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);
                        car.Model = tbModel.Text;
                        car.Make = tbMake.Text;
                        car.VIN = tbVIN.Text;
                        car.Year = int.Parse(TbYear.Text);
                        car.LicencePlateNumber = tbLincencePlateNumber.Text;

                        _db.SaveChanges();
                        _manageVehicleListing.PopulateGrid();
                        MessageBox.Show("Update Operation Completed. Refresh Grid to see Change");
                        Close();

                    }
                    else
                    {
                        //add code;
                        var newCar = new TypesOfCar
                        {
                            LicencePlateNumber = tbLincencePlateNumber.Text,
                            Make = tbMake.Text,
                            Model = tbModel.Text,
                            VIN = tbVIN.Text,
                            Year = int.Parse(TbYear.Text)


                        };

                        _db.TypesOfCars.Add(newCar);
                        _db.SaveChanges();
                        _manageVehicleListing.PopulateGrid();
                        MessageBox.Show("Insert Operation Complete. Refresh Grid to see Changes");
                        Close();

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
   
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //this will clse
            Close();

        }


        private void tbMake_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
