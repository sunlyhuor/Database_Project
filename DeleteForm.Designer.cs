namespace WindowsFormsApp1
{
    partial class DeleteForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.radioId = new System.Windows.Forms.RadioButton();
            this.ProfileName = new System.Windows.Forms.Label();
            this.deleteGroup = new System.Windows.Forms.GroupBox();
            this.ShowProvince = new System.Windows.Forms.Label();
            this.showAmount = new System.Windows.Forms.Label();
            this.ShowName = new System.Windows.Forms.Label();
            this.showId = new System.Windows.Forms.Label();
            this.submitDelete = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.deleteHistory = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guest_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(552, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 51);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDelete.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(409, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 51);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(268, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 51);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(122, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 51);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(816, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 55);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(5, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Filter Search By";
            // 
            // textSearchBox
            // 
            this.textSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textSearchBox.Location = new System.Drawing.Point(8, 130);
            this.textSearchBox.Name = "textSearchBox";
            this.textSearchBox.Size = new System.Drawing.Size(243, 36);
            this.textSearchBox.TabIndex = 25;
            this.textSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearchBox_KeyDown);
            this.textSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearchBox_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(257, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 39);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radioName
            // 
            this.radioName.AutoSize = true;
            this.radioName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioName.Location = new System.Drawing.Point(254, 82);
            this.radioName.Name = "radioName";
            this.radioName.Size = new System.Drawing.Size(74, 24);
            this.radioName.TabIndex = 23;
            this.radioName.TabStop = true;
            this.radioName.Text = "Name";
            this.radioName.UseVisualStyleBackColor = true;
            this.radioName.CheckedChanged += new System.EventHandler(this.radioName_CheckedChanged);
            // 
            // radioId
            // 
            this.radioId.AutoSize = true;
            this.radioId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioId.Location = new System.Drawing.Point(204, 83);
            this.radioId.Name = "radioId";
            this.radioId.Size = new System.Drawing.Size(43, 24);
            this.radioId.TabIndex = 22;
            this.radioId.TabStop = true;
            this.radioId.Text = "Id";
            this.radioId.UseVisualStyleBackColor = true;
            this.radioId.CheckedChanged += new System.EventHandler(this.radioId_CheckedChanged);
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ProfileName.Location = new System.Drawing.Point(12, 9);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(107, 29);
            this.ProfileName.TabIndex = 29;
            this.ProfileName.Text = "Admin : ";
            // 
            // deleteGroup
            // 
            this.deleteGroup.Controls.Add(this.ShowProvince);
            this.deleteGroup.Controls.Add(this.showAmount);
            this.deleteGroup.Controls.Add(this.ShowName);
            this.deleteGroup.Controls.Add(this.showId);
            this.deleteGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteGroup.Location = new System.Drawing.Point(499, 83);
            this.deleteGroup.Name = "deleteGroup";
            this.deleteGroup.Size = new System.Drawing.Size(371, 208);
            this.deleteGroup.TabIndex = 30;
            this.deleteGroup.TabStop = false;
            this.deleteGroup.Text = "Delete Form";
            // 
            // ShowProvince
            // 
            this.ShowProvince.AutoSize = true;
            this.ShowProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ShowProvince.Location = new System.Drawing.Point(40, 166);
            this.ShowProvince.Name = "ShowProvince";
            this.ShowProvince.Size = new System.Drawing.Size(161, 25);
            this.ShowProvince.TabIndex = 34;
            this.ShowProvince.Text = "Guest Province : ";
            // 
            // showAmount
            // 
            this.showAmount.AutoSize = true;
            this.showAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.showAmount.Location = new System.Drawing.Point(39, 130);
            this.showAmount.Name = "showAmount";
            this.showAmount.Size = new System.Drawing.Size(153, 25);
            this.showAmount.TabIndex = 33;
            this.showAmount.Text = "Guest Amount : ";
            // 
            // ShowName
            // 
            this.ShowName.AutoSize = true;
            this.ShowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ShowName.Location = new System.Drawing.Point(39, 87);
            this.ShowName.Name = "ShowName";
            this.ShowName.Size = new System.Drawing.Size(134, 25);
            this.ShowName.TabIndex = 32;
            this.ShowName.Text = "Guest name : ";
            // 
            // showId
            // 
            this.showId.AutoSize = true;
            this.showId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.showId.Location = new System.Drawing.Point(39, 43);
            this.showId.Name = "showId";
            this.showId.Size = new System.Drawing.Size(131, 25);
            this.showId.TabIndex = 31;
            this.showId.Text = "Guest Id       : ";
            // 
            // submitDelete
            // 
            this.submitDelete.BackColor = System.Drawing.Color.Red;
            this.submitDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.submitDelete.ForeColor = System.Drawing.Color.White;
            this.submitDelete.Location = new System.Drawing.Point(639, 289);
            this.submitDelete.Name = "submitDelete";
            this.submitDelete.Size = new System.Drawing.Size(111, 44);
            this.submitDelete.TabIndex = 35;
            this.submitDelete.Text = "Delete";
            this.submitDelete.UseVisualStyleBackColor = false;
            this.submitDelete.Click += new System.EventHandler(this.submitDelete_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(695, 390);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 51);
            this.btnLogout.TabIndex = 36;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // deleteHistory
            // 
            this.deleteHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Guest_name,
            this.Amount,
            this.Province});
            this.deleteHistory.Location = new System.Drawing.Point(17, 183);
            this.deleteHistory.Name = "deleteHistory";
            this.deleteHistory.RowTemplate.Height = 24;
            this.deleteHistory.Size = new System.Drawing.Size(476, 169);
            this.deleteHistory.TabIndex = 37;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Guest_name
            // 
            this.Guest_name.HeaderText = "Name";
            this.Guest_name.Name = "Guest_name";
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Province
            // 
            this.Province.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Province.HeaderText = "Address";
            this.Province.Name = "Province";
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.ControlBox = false;
            this.Controls.Add(this.deleteHistory);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.submitDelete);
            this.Controls.Add(this.deleteGroup);
            this.Controls.Add(this.ProfileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearchBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.radioName);
            this.Controls.Add(this.radioId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button2);
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteForm";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.deleteGroup.ResumeLayout(false);
            this.deleteGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radioName;
        private System.Windows.Forms.RadioButton radioId;
        private System.Windows.Forms.Label ProfileName;
        private System.Windows.Forms.GroupBox deleteGroup;
        private System.Windows.Forms.Label showId;
        private System.Windows.Forms.Label ShowName;
        private System.Windows.Forms.Label showAmount;
        private System.Windows.Forms.Label ShowProvince;
        private System.Windows.Forms.Button submitDelete;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView deleteHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guest_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Province;
    }
}