using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8RSCLI6\\SQLEXPRESS;Initial Catalog=SunLyhuor_Ass;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Username.Text == "") MessageBox.Show("Username is can't null");
            else if (Password.Text == "") MessageBox.Show("Password is can't null");
            else
            {
                try
                {
                    con.Open();
                    string query = "SELECT userName as userName , userPass ,roleId as role FROM Users WHERE userPass = @pass AND userName = @name";
                    SqlCommand cm = new SqlCommand(query , con);
                    cm.Parameters.AddWithValue("@name", Username.Text);
                    cm.Parameters.AddWithValue("@pass", Password.Text);
                    //SqlDataReader rd;
                    //rd = cm.ExecuteReader();
                    var reader = cm.ExecuteReader();
                    reader.Read();
                    int id = Convert.ToInt32(reader["role"]);
                    if (reader.HasRows)
                    {
                        if(id == 1)
                        {
                            MessageBox.Show("Success");
                            InsertForm Inf = new InsertForm();
                            Inf.GetNameLogin = reader["userName"].ToString();
                            this.Hide();
                            Inf.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Login successfully");
                            AdminForm ad = new AdminForm();
                            this.Hide();
                            ad.ShowDialog();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Login Failed");
                    }
                }catch
                {
                    MessageBox.Show("Login failed");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin.PerformClick();
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Password.Focus();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Username.Focus();
        }

        private void btnRegitser_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            this.Hide();
            rf.ShowDialog();
        }
    }
}
