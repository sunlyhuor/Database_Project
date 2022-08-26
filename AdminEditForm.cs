using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class AdminEditForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8RSCLI6\\SQLEXPRESS;Initial Catalog=SunLyhuor_Ass;Integrated Security=True");
        int id;
        public AdminEditForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int UserId
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            this.Hide();
            af.ShowDialog();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFormGuest ag = new AdminFormGuest();
            ag.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Hide();
            lg.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(textSearchBox.Text == "") MessageBox.Show("Text box can't empty!");
            else
            {
                try
                {
                    con.Open();
                    string query = "SELECT userId as id, userName as name, userPass as pass FROM Users WHERE userName = @name";
                    SqlCommand cm = new SqlCommand(query , con);
                    cm.Parameters.AddWithValue("@name" , textSearchBox.Text);
                    var reader = cm.ExecuteReader();
                    reader.Read();
                    Username.Text = reader["name"].ToString();
                    Password.Text = reader["pass"].ToString();
                    this.UserId = Convert.ToInt32(reader["id"]);
                    textSearchBox.Text = "";
                    MessageBox.Show(this.UserId.ToString());
                    btnEditSubmit.Focus();
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Not found!");
                }
            }
        }

        private void textSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch.PerformClick();
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Password.Focus();
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnEditSubmit.PerformClick();
        }

        private void btnEditSubmit_Click(object sender, EventArgs e)
        {
            if (Username.Text == "") MessageBox.Show("Username can't empty!");
            else if (Password.Text == "") MessageBox.Show("Password can't empty!");
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Users SET userName = @name, userPass = @pass WHERE userId = @id";
                    SqlCommand cm = new SqlCommand(query, con);
                    cm.Parameters.AddWithValue("@name", Username.Text);
                    cm.Parameters.AddWithValue("@pass", Password.Text);
                    cm.Parameters.AddWithValue("@id", this.UserId);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Update successfully");
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
