
namespace Car_Rental_App
{
    partial class ManageRentalRecord
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
            this.btnRefreshRecord = new System.Windows.Forms.Button();
            this.BtEditRecord = new System.Windows.Forms.Button();
            this.BtDeleteRecord = new System.Windows.Forms.Button();
            this.BtAddRecord = new System.Windows.Forms.Button();
            this.MngRntalRd = new System.Windows.Forms.Label();
            this.gvRecordList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefreshRecord
            // 
            this.btnRefreshRecord.Location = new System.Drawing.Point(684, 137);
            this.btnRefreshRecord.Name = "btnRefreshRecord";
            this.btnRefreshRecord.Size = new System.Drawing.Size(108, 38);
            this.btnRefreshRecord.TabIndex = 12;
            this.btnRefreshRecord.Text = "Refresh";
            this.btnRefreshRecord.UseVisualStyleBackColor = true;
            this.btnRefreshRecord.Click += new System.EventHandler(this.btnRefreshRecord_Click);
            // 
            // BtEditRecord
            // 
            this.BtEditRecord.Location = new System.Drawing.Point(243, 390);
            this.BtEditRecord.Name = "BtEditRecord";
            this.BtEditRecord.Size = new System.Drawing.Size(108, 38);
            this.BtEditRecord.TabIndex = 11;
            this.BtEditRecord.Text = "Edit Rental Record";
            this.BtEditRecord.UseVisualStyleBackColor = true;
            this.BtEditRecord.Click += new System.EventHandler(this.BtEditRecord_Click);
            // 
            // BtDeleteRecord
            // 
            this.BtDeleteRecord.Location = new System.Drawing.Point(464, 390);
            this.BtDeleteRecord.Name = "BtDeleteRecord";
            this.BtDeleteRecord.Size = new System.Drawing.Size(108, 38);
            this.BtDeleteRecord.TabIndex = 10;
            this.BtDeleteRecord.Text = "Delete Rental Record";
            this.BtDeleteRecord.UseVisualStyleBackColor = true;
            this.BtDeleteRecord.Click += new System.EventHandler(this.BtDeleteRecord_Click);
            // 
            // BtAddRecord
            // 
            this.BtAddRecord.Location = new System.Drawing.Point(8, 390);
            this.BtAddRecord.Name = "BtAddRecord";
            this.BtAddRecord.Size = new System.Drawing.Size(108, 38);
            this.BtAddRecord.TabIndex = 9;
            this.BtAddRecord.Text = "Add Rental Record";
            this.BtAddRecord.UseVisualStyleBackColor = true;
            this.BtAddRecord.Click += new System.EventHandler(this.BtAddRecord_Click);
            // 
            // MngRntalRd
            // 
            this.MngRntalRd.AutoSize = true;
            this.MngRntalRd.Font = new System.Drawing.Font("Segoe Print", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngRntalRd.Location = new System.Drawing.Point(-9, 9);
            this.MngRntalRd.Name = "MngRntalRd";
            this.MngRntalRd.Size = new System.Drawing.Size(801, 112);
            this.MngRntalRd.TabIndex = 8;
            this.MngRntalRd.Text = "Manage Rental Records";
            // 
            // gvRecordList
            // 
            this.gvRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecordList.Location = new System.Drawing.Point(8, 137);
            this.gvRecordList.Name = "gvRecordList";
            this.gvRecordList.Size = new System.Drawing.Size(670, 228);
            this.gvRecordList.TabIndex = 7;
            // 
            // ManageRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefreshRecord);
            this.Controls.Add(this.BtEditRecord);
            this.Controls.Add(this.BtDeleteRecord);
            this.Controls.Add(this.BtAddRecord);
            this.Controls.Add(this.MngRntalRd);
            this.Controls.Add(this.gvRecordList);
            this.Name = "ManageRentalRecord";
            this.Text = "Manage Rental Record";
            this.Load += new System.EventHandler(this.ManageRentalRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshRecord;
        private System.Windows.Forms.Button BtEditRecord;
        private System.Windows.Forms.Button BtDeleteRecord;
        private System.Windows.Forms.Button BtAddRecord;
        private System.Windows.Forms.Label MngRntalRd;
        private System.Windows.Forms.DataGridView gvRecordList;
    }
}