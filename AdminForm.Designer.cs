namespace WindowsFormsApp1
{
    partial class AdminForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.provincesTableAdapter1 = new WindowsFormsApp1.SunLyhuor_AssDataSetTableAdapters.ProvincesTableAdapter();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.userShow = new System.Windows.Forms.DataGridView();
            this.gName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(819, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 55);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // provincesTableAdapter1
            // 
            this.provincesTableAdapter1.ClearBeforeFill = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(622, 397);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 51);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuest.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuest.Location = new System.Drawing.Point(338, 397);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(123, 51);
            this.btnGuest.TabIndex = 18;
            this.btnGuest.Text = "Guest";
            this.btnGuest.UseVisualStyleBackColor = false;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUser.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUser.Location = new System.Drawing.Point(195, 397);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(123, 51);
            this.btnUser.TabIndex = 17;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // userShow
            // 
            this.userShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gName,
            this.gCount});
            this.userShow.Location = new System.Drawing.Point(3, 58);
            this.userShow.Name = "userShow";
            this.userShow.RowTemplate.Height = 24;
            this.userShow.Size = new System.Drawing.Size(875, 301);
            this.userShow.TabIndex = 20;
            // 
            // gName
            // 
            this.gName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gName.HeaderText = "Name";
            this.gName.Name = "gName";
            // 
            // gCount
            // 
            this.gCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gCount.HeaderText = "Count";
            this.gCount.Name = "gCount";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEdit.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(483, 397);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 51);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.ControlBox = false;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.userShow);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnClose);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private SunLyhuor_AssDataSetTableAdapters.ProvincesTableAdapter provincesTableAdapter1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.DataGridView userShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn gName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCount;
        private System.Windows.Forms.Button btnEdit;
    }
}