
namespace Car_Rental_App
{
    partial class ManageUsers
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
            this.btnRefreshUser = new System.Windows.Forms.Button();
            this.BtEditUsers = new System.Windows.Forms.Button();
            this.BtDeactivateUseer = new System.Windows.Forms.Button();
            this.BtAddUser = new System.Windows.Forms.Button();
            this.MngRntalRd = new System.Windows.Forms.Label();
            this.gvUserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefreshUser
            // 
            this.btnRefreshUser.Location = new System.Drawing.Point(12, 83);
            this.btnRefreshUser.Name = "btnRefreshUser";
            this.btnRefreshUser.Size = new System.Drawing.Size(108, 38);
            this.btnRefreshUser.TabIndex = 18;
            this.btnRefreshUser.Text = "Refresh";
            this.btnRefreshUser.UseVisualStyleBackColor = true;
            this.btnRefreshUser.Click += new System.EventHandler(this.btnRefreshUser_Click);
            // 
            // BtEditUsers
            // 
            this.BtEditUsers.Location = new System.Drawing.Point(391, 397);
            this.BtEditUsers.Name = "BtEditUsers";
            this.BtEditUsers.Size = new System.Drawing.Size(108, 38);
            this.BtEditUsers.TabIndex = 17;
            this.BtEditUsers.Text = "Reset Password";
            this.BtEditUsers.UseVisualStyleBackColor = true;
            this.BtEditUsers.Click += new System.EventHandler(this.BtEditUsers_Click);
            // 
            // BtDeactivateUseer
            // 
            this.BtDeactivateUseer.Location = new System.Drawing.Point(673, 397);
            this.BtDeactivateUseer.Name = "BtDeactivateUseer";
            this.BtDeactivateUseer.Size = new System.Drawing.Size(138, 38);
            this.BtDeactivateUseer.TabIndex = 16;
            this.BtDeactivateUseer.Text = "Deactivate / Activate User";
            this.BtDeactivateUseer.UseVisualStyleBackColor = true;
            this.BtDeactivateUseer.Click += new System.EventHandler(this.BtDeactivateUseer_Click);
            // 
            // BtAddUser
            // 
            this.BtAddUser.Location = new System.Drawing.Point(141, 397);
            this.BtAddUser.Name = "BtAddUser";
            this.BtAddUser.Size = new System.Drawing.Size(108, 38);
            this.BtAddUser.TabIndex = 15;
            this.BtAddUser.Text = "Add New User";
            this.BtAddUser.UseVisualStyleBackColor = true;
            this.BtAddUser.Click += new System.EventHandler(this.BtAddUser_Click);
            // 
            // MngRntalRd
            // 
            this.MngRntalRd.AutoSize = true;
            this.MngRntalRd.Font = new System.Drawing.Font("Segoe Print", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngRntalRd.Location = new System.Drawing.Point(216, 9);
            this.MngRntalRd.Name = "MngRntalRd";
            this.MngRntalRd.Size = new System.Drawing.Size(487, 112);
            this.MngRntalRd.TabIndex = 14;
            this.MngRntalRd.Text = "Manage Users";
            // 
            // gvUserList
            // 
            this.gvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserList.Location = new System.Drawing.Point(141, 142);
            this.gvUserList.Name = "gvUserList";
            this.gvUserList.Size = new System.Drawing.Size(670, 228);
            this.gvUserList.TabIndex = 13;
            this.gvUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUserList_CellContentClick);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 492);
            this.Controls.Add(this.btnRefreshUser);
            this.Controls.Add(this.BtEditUsers);
            this.Controls.Add(this.BtDeactivateUseer);
            this.Controls.Add(this.BtAddUser);
            this.Controls.Add(this.MngRntalRd);
            this.Controls.Add(this.gvUserList);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshUser;
        private System.Windows.Forms.Button BtEditUsers;
        private System.Windows.Forms.Button BtDeactivateUseer;
        private System.Windows.Forms.Button BtAddUser;
        private System.Windows.Forms.Label MngRntalRd;
        private System.Windows.Forms.DataGridView gvUserList;
    }
}