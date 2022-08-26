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
    public partial class RegisterForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8RSCLI6\\SQLEXPRESS;Initial Catalog=SunLyhuor_Ass;Integrated Security=True");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool CheckUserRegister()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Users WHERE userName = @name";
                SqlCommand cm = new SqlCommand(query , con);
                cm.Parameters.AddWithValue("@name" , Username.Text);
                SqlDataReader da;
                da = cm.ExecuteReader();
                if (da.HasRows) return true;
                else return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Username.Text == "") MessageBox.Show("Username is can't empty!");
            else if (Password.Text == "") MessageBox.Show("Pasword is can't empty!");
            else if (Password.Text != VerifyPassword.Text) MessageBox.Show("Password and verify password must be the same!");
            else
            {
                if (this.CheckUserRegister() != true)
                {
                    try
                    {
                        con.Open();
                        string query = "INSERT INTO Users(userName , userPass, roleId) VALUES(@name , @pass,1)";
                        SqlCommand cm = new SqlCommand(query, con);
                        cm.Parameters.AddWithValue("@name", Username.Text);
                        cm.Parameters.AddWithValue("@pass", Password.Text);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Register  has successfully!");
                    }
                    catch
                    {
                        MessageBox.Show("Registed has failed!");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else MessageBox.Show("Username already registed!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            this.Hide();
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Password.Focus();
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) VerifyPassword.Focus();
        }

        private void VerifyPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnRegister.PerformClick();
        }
    }
}
