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
    public partial class ManageVehicleListing : Form
    {
        
        private readonly CarRental2Entities _db;

        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRental2Entities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            //New Function to PopulateGrid. Can be Called anytime we need a grid refresh
           
            //Select * From TypeofCar
            //var car = _db.TypeofCars.ToList();
            //select Id as carId, name as CarName from TypesOfCars
            //  var cars = _db.TypesOfCars.Select(q => new { CarID = q.Id, CarName = q.Make }).ToList(); 
           // var cars = _db.TypesOfCars
             //     .Select(q => new
                 // {
                  //    Make = q.Make,
                  //    Model = q.Model,
                    //  VIN = q.VIN,
                    //  Year = q.Year,
                   //   LicenceplateNumber = q.LicencePlateNumber,
                 //      q.Id 
                //  })
                //  .ToList();
           // gvVehicleList.DataSource = cars;
           // gvVehicleList.Columns[4].HeaderText = "Licance Plate Number";
         //   gvVehicleList.Columns[5].Visible = false;
           // gvVehicleList.Columns[0].HeaderText = "ID";
            //gvVehicleList.Columns[1].HeaderText = "Make";

        }

        public void PopulateGrid()
        {
            //Select a custom modle collection of carsfrom database
            var cars = _db.TypesOfCars
                .Select(q => new
                {
                    Make = q.Make,
                    Modle = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicenceplateNumber = q.LicencePlateNumber,
                    q.Id
                }).ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "Licance Plate Number";
            //hide the Column for Id. Change from the hard coded column value to the name
            // to make it more dynamic
            gvVehicleList.Columns["Id"].Visible = false;
        }

        private void BtAddNewCar_Click(object sender, EventArgs e)
        {
            AddEditVehicle addEditVehicle = new AddEditVehicle(this);
            addEditVehicle.ShowDialog();
            addEditVehicle.MdiParent = this.MdiParent;
           
            
        }

        private void BtEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                //get Id of selected Row
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
                //queary database for record
                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);
                //launch AddEditVehicle withow with data
                var addEditVehicle = new AddEditVehicle(car, this);
                addEditVehicle.ShowDialog();
                addEditVehicle.MdiParent = this.MdiParent;
              


            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
           
        }

        private void BtDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                //get Id of selected Row
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
                //queary database for record
                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);
                DialogResult dr = MessageBox.Show("Are You Sure want to Delete this record?!!!",
                    "Delete", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    //delete vehicle from table
                    _db.TypesOfCars.Remove(car);
                    _db.SaveChanges();
                }
                PopulateGrid();

                

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
