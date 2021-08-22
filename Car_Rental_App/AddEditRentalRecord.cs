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
    public partial class AddEditRentalRecord : Form
       

    {
        private bool isEditMode;
        private readonly CarRental2Entities carRental2Entities;

        public AddEditRentalRecord()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Rental Record";
            this.Text = "Add New Rental Record";
            isEditMode = false;

            carRental2Entities = new CarRental2Entities();
        }
        public AddEditRentalRecord(CarRentalRecord recordToEdit)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Rental Record";
            this.Text = "Edit Rental Record";
            if (recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                PopulateFields(recordToEdit);
                carRental2Entities = new CarRental2Entities();
            }

        }
        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            TBCustomerName.Text = recordToEdit.CustomerName;
            DtRented.Value = (DateTime) recordToEdit.DateRented;
            DtRented.Value = (DateTime) recordToEdit.DateReturned;
            TBCosttextBox.Text = recordToEdit.Cost.ToString();
            lblRecordId.Text = recordToEdit.id.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //select * from typeof cars
            //var cars = carRental2Entities.TypesOfCars.ToList();
            var cars = carRental2Entities.TypesOfCars
                .Select(q => new
                {
                    Id = q.Id,
                    Name = q.Make + " " + q.Model
                }).ToList();
            CbCheakboxCarType.DisplayMember = "Name";
            CbCheakboxCarType.ValueMember = "Id";
            CbCheakboxCarType.DataSource = cars;


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = TBCustomerName.Text;
                var dateOut = DtRented.Value;
                var dateIn = DtReturn.Value;
                var datein = DtReturn.Text;
                var dateout = DtRented.Text;
                double cost = Convert.ToDouble(TBCosttextBox.Text);




                var cartype = CbCheakboxCarType.Text;
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(cartype))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter misssing data\n\r";
                }
                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessage += "Error: Illigaldate selection";
                }


                //if(isValid == true)
                if (isValid)
                {
                    //Decalre an object of the record to be added
                    var rentalRecord = new CarRentalRecord();
                    if (isEditMode)
                    {
                        //If in edit mode, then get the ID and retrive the record from the databaseand place
                        //the result in the record object
                        var id = int.Parse(lblRecordId.Text);
                        rentalRecord = carRental2Entities.CarRentalRecords.FirstOrDefault(q => q.id == id);
                    }
                       // populate record object with values from the from
                        rentalRecord.CustomerName = customerName;
                        rentalRecord.DateRented = dateOut;
                        rentalRecord.DateReturned = dateIn;
                        rentalRecord.Cost = (decimal)cost;
                        rentalRecord.TypeOfCarId = (int)CbCheakboxCarType.SelectedValue;
                    //if not in edid mode, then add the record object to the database
                        carRental2Entities.SaveChanges();

                    if (!isEditMode)
                        carRental2Entities.CarRentalRecords.Add(rentalRecord);
                    //save change made to the entity 
                    carRental2Entities.SaveChanges();


                    MessageBox.Show($"Customer Name:{customerName}\n\r" +
                         $"Date Rented: {dateOut}\n\r" +
                         $"Date Renturned: {dateIn}\n\r" +
                         $"Date Cost: {cost}\n\r" +
                         $"Car Type: {cartype}\n\r" +
                         $"Thanq for your Business");
                    Close();

                }
                //    else
                //    {
                //        var rentalRecord = new CarRentalRecord();
                //        rentalRecord.CustomerName = customerName;
                //        rentalRecord.DateRented = dateOut;
                //        rentalRecord.DateReturned = dateIn;
                //        rentalRecord.Cost = (decimal)cost;
                //        rentalRecord.TypeOfCarId = (int)CbCheakboxCarType.SelectedValue;

                //        carRental2Entities.CarRentalRecords.Add(rentalRecord);
                //        carRental2Entities.SaveChanges();



                //        MessageBox.Show($"Customer Name:{customerName}\n\r" +
                //            $"Date Rented: {dateOut}\n\r" +
                //            $"Date Renturned: {dateIn}\n\r" +
                //            $"Date Cost: {cost}\n\r" +
                //            $"Car Type: {cartype}\n\r" +
                //            $"Thanq for your Business");
                        

                //    }
                //    Close();
                //}
                else
                {
                    MessageBox.Show(errorMessage);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void launchMainButton_Click(object sender, EventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();

        }

        private void CbCheakboxCarType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
