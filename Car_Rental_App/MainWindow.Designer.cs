
namespace Car_Rental_App
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageVehichaleListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVehichaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiLoginText = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.editPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVehichaleListingToolStripMenuItem,
            this.manageRentalRecordToolStripMenuItem,
            this.manageUserToolStripMenuItem,
            this.editPasswordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageVehichaleListingToolStripMenuItem
            // 
            this.manageVehichaleListingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editVehichaleToolStripMenuItem});
            this.manageVehichaleListingToolStripMenuItem.Name = "manageVehichaleListingToolStripMenuItem";
            this.manageVehichaleListingToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.manageVehichaleListingToolStripMenuItem.Text = "Manage Vehichale Listing";
            this.manageVehichaleListingToolStripMenuItem.Click += new System.EventHandler(this.manageVehichaleListingToolStripMenuItem_Click);
            // 
            // editVehichaleToolStripMenuItem
            // 
            this.editVehichaleToolStripMenuItem.Name = "editVehichaleToolStripMenuItem";
            this.editVehichaleToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editVehichaleToolStripMenuItem.Text = "Edit Vehichale";
            this.editVehichaleToolStripMenuItem.Click += new System.EventHandler(this.editVehichaleToolStripMenuItem_Click);
            // 
            // manageRentalRecordToolStripMenuItem
            // 
            this.manageRentalRecordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentalRecordToolStripMenuItem,
            this.viewArchiveToolStripMenuItem,
            this.editRentalRecordToolStripMenuItem});
            this.manageRentalRecordToolStripMenuItem.Name = "manageRentalRecordToolStripMenuItem";
            this.manageRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.manageRentalRecordToolStripMenuItem.Text = "Manage Rental Record";
            // 
            // addRentalRecordToolStripMenuItem
            // 
            this.addRentalRecordToolStripMenuItem.Name = "addRentalRecordToolStripMenuItem";
            this.addRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addRentalRecordToolStripMenuItem.Text = "Add Rental Record";
            this.addRentalRecordToolStripMenuItem.Click += new System.EventHandler(this.addRentalRecordToolStripMenuItem_Click);
            // 
            // viewArchiveToolStripMenuItem
            // 
            this.viewArchiveToolStripMenuItem.Name = "viewArchiveToolStripMenuItem";
            this.viewArchiveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewArchiveToolStripMenuItem.Text = "View Archive";
            this.viewArchiveToolStripMenuItem.Click += new System.EventHandler(this.viewArchiveToolStripMenuItem_Click);
            // 
            // editRentalRecordToolStripMenuItem
            // 
            this.editRentalRecordToolStripMenuItem.Name = "editRentalRecordToolStripMenuItem";
            this.editRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editRentalRecordToolStripMenuItem.Text = "Edit Rental Record";
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.manageUserToolStripMenuItem.Text = "Manage Users";
            this.manageUserToolStripMenuItem.Click += new System.EventHandler(this.manageUserToolStripMenuItem_Click);
            // 
            // tsiLoginText
            // 
            this.tsiLoginText.Location = new System.Drawing.Point(0, 465);
            this.tsiLoginText.Name = "tsiLoginText";
            this.tsiLoginText.Size = new System.Drawing.Size(877, 22);
            this.tsiLoginText.TabIndex = 4;
            this.tsiLoginText.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 23);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // editPasswordToolStripMenuItem
            // 
            this.editPasswordToolStripMenuItem.Name = "editPasswordToolStripMenuItem";
            this.editPasswordToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.editPasswordToolStripMenuItem.Text = "Edit Password";
            this.editPasswordToolStripMenuItem.Click += new System.EventHandler(this.editPasswordToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 487);
            this.Controls.Add(this.tsiLoginText);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Car Rental Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageVehichaleListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRentalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVehichaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.StatusStrip tsiLoginText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem editPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}