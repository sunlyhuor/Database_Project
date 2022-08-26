namespace WindowsFormsApp1
{
    partial class Update
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
            this.radioId = new System.Windows.Forms.RadioButton();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.newName = new System.Windows.Forms.TextBox();
            this.newAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.update_grid_view = new System.Windows.Forms.DataGridView();
            this.Guest_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guest_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guest_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.submitUpdate = new System.Windows.Forms.Button();
            this.newProvince = new System.Windows.Forms.ComboBox();
            this.oldProvince = new System.Windows.Forms.Label();
            this.ProfileName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.update_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // radioId
            // 
            this.radioId.AutoSize = true;
            this.radioId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioId.Location = new System.Drawing.Point(659, 57);
            this.radioId.Name = "radioId";
            this.radioId.Size = new System.Drawing.Size(43, 24);
            this.radioId.TabIndex = 0;
            this.radioId.TabStop = true;
            this.radioId.Text = "Id";
            this.radioId.UseVisualStyleBackColor = true;
            this.radioId.CheckedChanged += new System.EventHandler(this.radioId_CheckedChanged);
            // 
            // radioName
            // 
            this.radioName.AutoSize = true;
            this.radioName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioName.Location = new System.Drawing.Point(709, 56);
            this.radioName.Name = "radioName";
            this.radioName.Size = new System.Drawing.Size(74, 24);
            this.radioName.TabIndex = 1;
            this.radioName.TabStop = true;
            this.radioName.Text = "Name";
            this.radioName.UseVisualStyleBackColor = true;
            this.radioName.CheckedChanged += new System.EventHandler(this.radioName_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(712, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearchBox
            // 
            this.textSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textSearchBox.Location = new System.Drawing.Point(465, 104);
            this.textSearchBox.Name = "textSearchBox";
            this.textSearchBox.Size = new System.Drawing.Size(243, 36);
            this.textSearchBox.TabIndex = 3;
            this.textSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearchBox_KeyDown);
            this.textSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearchBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(460, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter Search By";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(816, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 55);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // newName
            // 
            this.newName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.newName.Location = new System.Drawing.Point(37, 67);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(242, 36);
            this.newName.TabIndex = 6;
            // 
            // newAmount
            // 
            this.newAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.newAmount.Location = new System.Drawing.Point(37, 139);
            this.newAmount.Name = "newAmount";
            this.newAmount.Size = new System.Drawing.Size(242, 36);
            this.newAmount.TabIndex = 7;
            this.newAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newAmount_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(34, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Guest name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(34, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Guest amount";
            // 
            // update_grid_view
            // 
            this.update_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.update_grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Guest_Id,
            this.Guest_Name,
            this.Guest_Amount,
            this.Provine});
            this.update_grid_view.Location = new System.Drawing.Point(37, 223);
            this.update_grid_view.Name = "update_grid_view";
            this.update_grid_view.RowTemplate.Height = 24;
            this.update_grid_view.Size = new System.Drawing.Size(819, 162);
            this.update_grid_view.TabIndex = 10;
            // 
            // Guest_Id
            // 
            this.Guest_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Guest_Id.HeaderText = "Guest_Id";
            this.Guest_Id.Name = "Guest_Id";
            // 
            // Guest_Name
            // 
            this.Guest_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Guest_Name.HeaderText = "Guest_Name";
            this.Guest_Name.Name = "Guest_Name";
            // 
            // Guest_Amount
            // 
            this.Guest_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Guest_Amount.HeaderText = "Amount";
            this.Guest_Amount.Name = "Guest_Amount";
            // 
            // Provine
            // 
            this.Provine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Provine.HeaderText = "Province";
            this.Provine.Name = "Provine";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(551, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 51);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(408, 392);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 51);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUpdate.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(267, 392);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 51);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(121, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(798, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Histrory";
            // 
            // submitUpdate
            // 
            this.submitUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.submitUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitUpdate.Location = new System.Drawing.Point(110, 181);
            this.submitUpdate.Name = "submitUpdate";
            this.submitUpdate.Size = new System.Drawing.Size(97, 36);
            this.submitUpdate.TabIndex = 16;
            this.submitUpdate.Text = "Submit";
            this.submitUpdate.UseVisualStyleBackColor = false;
            this.submitUpdate.Click += new System.EventHandler(this.submitUpdate_Click);
            // 
            // newProvince
            // 
            this.newProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.newProvince.FormattingEnabled = true;
            this.newProvince.Location = new System.Drawing.Point(285, 67);
            this.newProvince.Name = "newProvince";
            this.newProvince.Size = new System.Drawing.Size(133, 37);
            this.newProvince.TabIndex = 17;
            this.newProvince.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newProvince_MouseDown);
            this.newProvince.MouseUp += new System.Windows.Forms.MouseEventHandler(this.newProvince_MouseUp);
            // 
            // oldProvince
            // 
            this.oldProvince.AutoSize = true;
            this.oldProvince.Location = new System.Drawing.Point(282, 47);
            this.oldProvince.Name = "oldProvince";
            this.oldProvince.Size = new System.Drawing.Size(88, 17);
            this.oldProvince.TabIndex = 18;
            this.oldProvince.Text = "Old province";
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ProfileName.Location = new System.Drawing.Point(33, 4);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(75, 26);
            this.ProfileName.TabIndex = 19;
            this.ProfileName.Text = "Admin";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(692, 390);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 51);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.ProfileName);
            this.Controls.Add(this.oldProvince);
            this.Controls.Add(this.newProvince);
            this.Controls.Add(this.submitUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.update_grid_view);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newAmount);
            this.Controls.Add(this.newName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearchBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.radioName);
            this.Controls.Add(this.radioId);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.update_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioId;
        private System.Windows.Forms.RadioButton radioName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.TextBox newAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView update_grid_view;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitUpdate;
        private System.Windows.Forms.ComboBox newProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guest_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guest_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guest_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provine;
        private System.Windows.Forms.Label oldProvince;
        private System.Windows.Forms.Label ProfileName;
        private System.Windows.Forms.Button btnLogout;
    }
}