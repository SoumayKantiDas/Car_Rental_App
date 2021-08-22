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
    public partial class ManageRentalRecord : Form
    {
        private readonly CarRental2Entities _db;
        public ManageRentalRecord()
        {
            InitializeComponent();
            _db = new CarRental2Entities();
        }

        private void ManageRentalRecord_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PopulateGrid()
        {
            //Select a custom modle collection of carsfrom database
            var records = _db.CarRentalRecords
                .Select(q => new
                {
                    Customer = q.CustomerName,
                    DateOut = q.DateRented,
                    DateIn = q.DateReturned,
                    Id = q.id,
                    Cost = q.Cost,
                    Car = q.TypesOfCar.Make + " " + q.TypesOfCar.Model
                }).ToList();
            gvRecordList.DataSource = records;
            gvRecordList.Columns["DateIn"].HeaderText = "DateIn";
            gvRecordList.Columns["DateOut"].HeaderText = "DateOut";
            //hide the Column for Id. Change from the hard coded column value to the name
            // to make it more dynamic
            //gvRecordList.Columns["Id"].Visible = false;

        }

        private void btnRefreshRecord_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void BtAddRecord_Click(object sender, EventArgs e)
        {
            AddEditRentalRecord addEditVehicle = new AddEditRentalRecord
            {
                MdiParent = this.MdiParent
            };
            addEditVehicle.Show();
        }

        private void BtEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //get Id of selected Row
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;
                //queary database for record
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);
                //launch AddEditVehicle withow with data
                var addEditRentalRecord = new AddEditRentalRecord(record);
                addEditRentalRecord.MdiParent = this.MdiParent;
                addEditRentalRecord.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void BtDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //get Id of selected Row
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;
                //queary database for record
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);
                //Delete velecle
                _db.CarRentalRecords.Remove(record);
                _db.SaveChanges();

                PopulateGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
