
namespace Car_Rental_App
{
    partial class AddEditRentalRecord
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.TBCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBCosttextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DtRented = new System.Windows.Forms.DateTimePicker();
            this.DtReturn = new System.Windows.Forms.DateTimePicker();
            this.CbCheakboxCarType = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.launchMainButton = new System.Windows.Forms.Button();
            this.lblRecordId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(52, -15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(662, 112);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Rental Record";
            // 
            // TBCustomerName
            // 
            this.TBCustomerName.Location = new System.Drawing.Point(12, 124);
            this.TBCustomerName.Name = "TBCustomerName";
            this.TBCustomerName.Size = new System.Drawing.Size(287, 20);
            this.TBCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // TBCosttextBox
            // 
            this.TBCosttextBox.Location = new System.Drawing.Point(446, 124);
            this.TBCosttextBox.Name = "TBCosttextBox";
            this.TBCosttextBox.Size = new System.Drawing.Size(287, 20);
            this.TBCosttextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Rented";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date Return";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Type of Car";
            // 
            // DtRented
            // 
            this.DtRented.Location = new System.Drawing.Point(16, 250);
            this.DtRented.Name = "DtRented";
            this.DtRented.Size = new System.Drawing.Size(283, 20);
            this.DtRented.TabIndex = 8;
            // 
            // DtReturn
            // 
            this.DtReturn.Location = new System.Drawing.Point(446, 250);
            this.DtReturn.Name = "DtReturn";
            this.DtReturn.Size = new System.Drawing.Size(283, 20);
            this.DtReturn.TabIndex = 9;
            this.DtReturn.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // CbCheakboxCarType
            // 
            this.CbCheakboxCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCheakboxCarType.FormattingEnabled = true;
            this.CbCheakboxCarType.Location = new System.Drawing.Point(18, 337);
            this.CbCheakboxCarType.Name = "CbCheakboxCarType";
            this.CbCheakboxCarType.Size = new System.Drawing.Size(283, 21);
            this.CbCheakboxCarType.TabIndex = 10;
            this.CbCheakboxCarType.SelectedIndexChanged += new System.EventHandler(this.CbCheakboxCarType_SelectedIndexChanged);
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(485, 321);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(205, 53);
            this.Submit.TabIndex = 11;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // launchMainButton
            // 
            this.launchMainButton.Location = new System.Drawing.Point(71, 392);
            this.launchMainButton.Name = "launchMainButton";
            this.launchMainButton.Size = new System.Drawing.Size(141, 29);
            this.launchMainButton.TabIndex = 12;
            this.launchMainButton.Text = "Launch Main Window";
            this.launchMainButton.UseVisualStyleBackColor = true;
            this.launchMainButton.Click += new System.EventHandler(this.launchMainButton_Click);
            // 
            // lblRecordId
            // 
            this.lblRecordId.AutoSize = true;
            this.lblRecordId.Location = new System.Drawing.Point(370, 400);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(0, 13);
            this.lblRecordId.TabIndex = 13;
            this.lblRecordId.Visible = false;
            // 
            // AddEditRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRecordId);
            this.Controls.Add(this.launchMainButton);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.CbCheakboxCarType);
            this.Controls.Add(this.DtReturn);
            this.Controls.Add(this.DtRented);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBCosttextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBCustomerName);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddEditRentalRecord";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox TBCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBCosttextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtRented;
        private System.Windows.Forms.DateTimePicker DtReturn;
        private System.Windows.Forms.ComboBox CbCheakboxCarType;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button launchMainButton;
        private System.Windows.Forms.Label lblRecordId;
    }
}

