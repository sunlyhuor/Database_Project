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
    public partial class InsertForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8RSCLI6\\SQLEXPRESS;Initial Catalog=SunLyhuor_Ass;Integrated Security=True");

        string usernameLogin;
        public InsertForm()
        {
            InitializeComponent();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            gName.Focus();
            ProfileName.Text = "User : " + this.GetNameLogin;
            this.Load_data_grid();
            con.Open();
        }

        void Load_data_grid()
        {
            con.Open();
            string Dataget = "SELECT g.gId as id ,  g.gName as Name , g.gAmount as Amount , p.ProName as Province, YEAR(g.gTime) as gYear, MONTH(g.gTime) as gMonth , DAY(g.gTime) as gDay FROM Guest g INNER JOIN UserDetails ud ON ud.gId = g.gId INNER JOIN Users u ON u.userId = ud.userId INNER JOIN  Provinces p ON p.ProId = g.ProId WHERE  u.userName = @name order by g.gId DESC OFFSET 0 ROWS FETCH FIRST 8 ROWS ONLY";
            SqlCommand cm = new SqlCommand(Dataget, con);
            cm.Parameters.AddWithValue("@name", this.GetNameLogin);
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {
                insertDataGridView.Rows.Add(reader["id"], reader["Name"].ToString(), reader["Amount"].ToString(), reader["Province"].ToString() , reader["gDay"].ToString()+"-"+reader["gMonth"].ToString()+"-"+ reader["gYear"].ToString());
            }
            con.Close();
        }

        public string GetNameLogin
        {
            get
            {
                return this.usernameLogin;
            }
            set
            {
                this.usernameLogin = value;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //insert to userdatail
        public void InsertUserDetails()
        {
            con.Open();
            //Get Id from Users Table
            string userQuery = "SELECT userId FROM Users WHERE userName = @username";
            SqlCommand cmmuser = new SqlCommand(userQuery, con);
            cmmuser.Parameters.AddWithValue("@username", this.GetNameLogin);
            SqlDataAdapter dauser = new SqlDataAdapter(cmmuser);
            DataSet dsuser = new DataSet();
            dauser.Fill(dsuser);
            DataTable dtuser = dsuser.Tables[0];
            int userId = Convert.ToInt32(dsuser.Tables[0].Rows[0][0]);
            //Get Id from Guest table
            string qu = "SELECT gId FROM Guest WHERE gName = @name";
            SqlCommand cmm = new SqlCommand(qu, con);
            cmm.Parameters.AddWithValue("@name", gName.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            int gId = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            try
            {
                string query = "INSERT INTO UserDetails(userId , gId) VALUES(@userId , @gId)";
                SqlCommand scm = new SqlCommand(query, con);
                scm.Parameters.AddWithValue("@userId", userId);
                scm.Parameters.AddWithValue("@gId", gId);
                scm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void GProvince_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {

                    int i = 0;
                    string query = "SELECT ProName FROM Provinces";
                    SqlCommand comm = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(comm);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    gProvince.Items.Clear();
                    for (i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        gProvince.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                        con.Close();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var name = gName.Text;
            var province = gProvince.Text;
            var amount = gAmount.Text;
            if (name == "") MessageBox.Show("Name is can't empty!");
            else if (province == "") MessageBox.Show("Province is can't empty!");
            else if (amount == "") MessageBox.Show("Amount is can't empty!");

            else
            {
                con.Open();
                string qu = "SELECT ProId FROM Provinces WHERE ProName = @name";
                SqlCommand cmm = new SqlCommand(qu, con);
                cmm.Parameters.AddWithValue("@name", gProvince.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                int pro = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                try
                {
                    string query = "INSERT INTO Guest(gName , gAmount , ProId , gTime) VALUES(@name , @amount , @pro , @time)";
                    SqlCommand cm = new SqlCommand(query, con);
                    SqlDataReader rd;
                    cm.Parameters.AddWithValue("@name", gName.Text);
                    cm.Parameters.AddWithValue("@pro", pro);
                    cm.Parameters.AddWithValue("@time", DateTime.Now);
                    float at = float.Parse(gAmount.Text);
                    cm.Parameters.AddWithValue("@amount", at);
                    rd = cm.ExecuteReader();
                    MessageBox.Show("Insert Successfuly");
                    con.Close();
                    InsertUserDetails();
                    gAmount.Text = "";
                    gName.Text = "";
                    gProvince.Text = "";
                    gProvince.Items.Clear();
                    insertDataGridView.Rows.Clear();
                    this.Load_data_grid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {

                }
            }
        }

        private void gAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnInsert.PerformClick();
        }

        private void gName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) gProvince.Focus();
        }

        private void gProvince_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) gAmount.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.GetusernameLogin = this.GetNameLogin;
            this.Hide();
            up.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm df = new DeleteForm();
            df.GetusernameLogin = this.GetNameLogin;
            this.Hide();
            df.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Hide();
            lg.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.GetusernameLogin = this.GetNameLogin;
            this.Hide();
            sf.ShowDialog();
        }
    }
    
}
