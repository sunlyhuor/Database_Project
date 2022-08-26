namespace WindowsFormsApp1
{
    partial class SearchForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ProfileName = new System.Windows.Forms.Label();
            this.guestList = new System.Windows.Forms.GroupBox();
            this.showGuestData = new System.Windows.Forms.DataGridView();
            this.Guest_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guest_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guest_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guest_province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showHistory = new System.Windows.Forms.DataGridView();
            this.h_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textSearchbox = new System.Windows.Forms.TextBox();
            this.submitSearch = new System.Windows.Forms.Button();
            this.guestList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showGuestData)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(663, 390);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 51);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSearch.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(523, 390);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 51);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(380, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 51);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(239, 390);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 51);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(93, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 51);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(815, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 55);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ProfileName.Location = new System.Drawing.Point(22, 9);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(107, 29);
            this.ProfileName.TabIndex = 16;
            this.ProfileName.Text = "Admin : ";
            // 
            // guestList
            // 
            this.guestList.Controls.Add(this.showGuestData);
            this.guestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestList.Location = new System.Drawing.Point(12, 241);
            this.guestList.Name = "guestList";
            this.guestList.Size = new System.Drawing.Size(858, 144);
            this.guestList.TabIndex = 17;
            this.guestList.TabStop = false;
            this.guestList.Text = "Guest";
            // 
            // showGuestData
            // 
            this.showGuestData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showGuestData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Guest_id,
            this.Guest_name,
            this.Guest_Amount,
            this.guest_province});
            this.showGuestData.Location = new System.Drawing.Point(30, 21);
            this.showGuestData.Name = "showGuestData";
            this.showGuestData.RowTemplate.Height = 24;
            this.showGuestData.Size = new System.Drawing.Size(814, 101);
            this.showGuestData.TabIndex = 0;
            // 
            // Guest_id
            // 
            this.Guest_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Guest_id.HeaderText = "Id";
            this.Guest_id.Name = "Guest_id";
            // 
            // Guest_name
            // 
            this.Guest_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Guest_name.HeaderText = "Name";
            this.Guest_name.Name = "Guest_name";
            // 
            // Guest_Amount
            // 
            this.Guest_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Guest_Amount.HeaderText = "Amount";
            this.Guest_Amount.Name = "Guest_Amount";
            // 
            // guest_province
            // 
            this.guest_province.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.guest_province.HeaderText = "Province";
            this.guest_province.Name = "guest_province";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showHistory);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 136);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search resualt";
            // 
            // showHistory
            // 
            this.showHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.h_Id,
            this.h_Name,
            this.h_Amount,
            this.h_Province});
            this.showHistory.Location = new System.Drawing.Point(14, 21);
            this.showHistory.Name = "showHistory";
            this.showHistory.RowTemplate.Height = 24;
            this.showHistory.Size = new System.Drawing.Size(815, 111);
            this.showHistory.TabIndex = 19;
            // 
            // h_Id
            // 
            this.h_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.h_Id.HeaderText = "Id";
            this.h_Id.Name = "h_Id";
            // 
            // h_Name
            // 
            this.h_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.h_Name.HeaderText = "Name";
            this.h_Name.Name = "h_Name";
            // 
            // h_Amount
            // 
            this.h_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.h_Amount.HeaderText = "Amount";
            this.h_Amount.Name = "h_Amount";
            // 
            // h_Province
            // 
            this.h_Province.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.h_Province.HeaderText = "Province";
            this.h_Province.Name = "h_Province";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search filter by";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(166, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 21);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Id";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(205, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 21);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Name";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // textSearchbox
            // 
            this.textSearchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchbox.Location = new System.Drawing.Point(271, 58);
            this.textSearchbox.Name = "textSearchbox";
            this.textSearchbox.Size = new System.Drawing.Size(251, 32);
            this.textSearchbox.TabIndex = 22;
            this.textSearchbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearchbox_KeyDown);
            // 
            // submitSearch
            // 
            this.submitSearch.BackColor = System.Drawing.Color.Red;
            this.submitSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitSearch.Location = new System.Drawing.Point(524, 56);
            this.submitSearch.Name = "submitSearch";
            this.submitSearch.Size = new System.Drawing.Size(100, 35);
            this.submitSearch.TabIndex = 23;
            this.submitSearch.Text = "Serach";
            this.submitSearch.UseVisualStyleBackColor = false;
            this.submitSearch.Click += new System.EventHandler(this.submitSearch_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.ControlBox = false;
            this.Controls.Add(this.submitSearch);
            this.Controls.Add(this.textSearchbox);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.guestList);
            this.Controls.Add(this.ProfileName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.guestList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showGuestData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label ProfileName;
        private System.Windows.Forms.GroupBox guestList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView showGuestData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guest_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guest_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guest_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn guest_province;
        private System.Windows.Forms.DataGridView showHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textSearchbox;
        private System.Windows.Forms.Button submitSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_Province;
    }
}