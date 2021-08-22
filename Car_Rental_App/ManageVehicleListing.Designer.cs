
namespace Car_Rental_App
{
    partial class ManageVehicleListing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvVehicleList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtAddNewCar = new System.Windows.Forms.Button();
            this.BtDeleteCar = new System.Windows.Forms.Button();
            this.BtEditCar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvVehicleList
            // 
            this.gvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVehicleList.Location = new System.Drawing.Point(4, 118);
            this.gvVehicleList.Name = "gvVehicleList";
            this.gvVehicleList.Size = new System.Drawing.Size(670, 228);
            this.gvVehicleList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 112);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Vehicle Listing";
            // 
            // BtAddNewCar
            // 
            this.BtAddNewCar.Location = new System.Drawing.Point(4, 371);
            this.BtAddNewCar.Name = "BtAddNewCar";
            this.BtAddNewCar.Size = new System.Drawing.Size(108, 38);
            this.BtAddNewCar.TabIndex = 2;
            this.BtAddNewCar.Text = "Add New Car";
            this.BtAddNewCar.UseVisualStyleBackColor = true;
            this.BtAddNewCar.Click += new System.EventHandler(this.BtAddNewCar_Click);
            // 
            // BtDeleteCar
            // 
            this.BtDeleteCar.Location = new System.Drawing.Point(460, 371);
            this.BtDeleteCar.Name = "BtDeleteCar";
            this.BtDeleteCar.Size = new System.Drawing.Size(108, 38);
            this.BtDeleteCar.TabIndex = 4;
            this.BtDeleteCar.Text = "Delete Car";
            this.BtDeleteCar.UseVisualStyleBackColor = true;
            this.BtDeleteCar.Click += new System.EventHandler(this.BtDeleteCar_Click);
            // 
            // BtEditCar
            // 
            this.BtEditCar.Location = new System.Drawing.Point(239, 371);
            this.BtEditCar.Name = "BtEditCar";
            this.BtEditCar.Size = new System.Drawing.Size(108, 38);
            this.BtEditCar.TabIndex = 5;
            this.BtEditCar.Text = "Edit Car";
            this.BtEditCar.UseVisualStyleBackColor = true;
            this.BtEditCar.Click += new System.EventHandler(this.BtEditCar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(680, 118);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 38);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.BtEditCar);
            this.Controls.Add(this.BtDeleteCar);
            this.Controls.Add(this.BtAddNewCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvVehicleList);
            this.Name = "ManageVehicleListing";
            this.Text = "Manage Vehicle Listing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvVehicleList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtAddNewCar;
        private System.Windows.Forms.Button BtDeleteCar;
        private System.Windows.Forms.Button BtEditCar;
        private System.Windows.Forms.Button btnRefresh;
    }
}