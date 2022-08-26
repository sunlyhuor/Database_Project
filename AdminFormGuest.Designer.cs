namespace WindowsFormsApp1
{
    partial class AdminFormGuest
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
            this.ShowData = new System.Windows.Forms.DataGridView();
            this.gId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowData
            // 
            this.ShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gId,
            this.gName,
            this.gAmount,
            this.gProvince,
            this.byUser,
            this.gTime});
            this.ShowData.Location = new System.Drawing.Point(9, 61);
            this.ShowData.Name = "ShowData";
            this.ShowData.RowTemplate.Height = 24;
            this.ShowData.Size = new System.Drawing.Size(866, 232);
            this.ShowData.TabIndex = 0;
            // 
            // gId
            // 
            this.gId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gId.HeaderText = "Id";
            this.gId.Name = "gId";
            // 
            // gName
            // 
            this.gName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gName.HeaderText = "Name";
            this.gName.Name = "gName";
            // 
            // gAmount
            // 
            this.gAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gAmount.HeaderText = "Amount";
            this.gAmount.Name = "gAmount";
            // 
            // gProvince
            // 
            this.gProvince.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gProvince.HeaderText = "Address";
            this.gProvince.Name = "gProvince";
            // 
            // byUser
            // 
            this.byUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.byUser.HeaderText = "By user";
            this.byUser.Name = "byUser";
            // 
            // gTime
            // 
            this.gTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gTime.HeaderText = "Date";
            this.gTime.Name = "gTime";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(589, 393);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 51);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGuest.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuest.Location = new System.Drawing.Point(319, 393);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(123, 51);
            this.btnGuest.TabIndex = 21;
            this.btnGuest.Text = "Guest";
            this.btnGuest.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUser.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUser.Location = new System.Drawing.Point(181, 393);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(123, 51);
            this.btnUser.TabIndex = 20;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(816, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 55);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEdit.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(452, 393);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 51);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // AdminFormGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.ControlBox = false;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.ShowData);
            this.Name = "AdminFormGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminFormGuest";
            this.Load += new System.EventHandler(this.AdminFormGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ShowData;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn gId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn byUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTime;
        private System.Windows.Forms.Button btnEdit;
    }
}