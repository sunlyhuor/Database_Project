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
    public partial class SearchForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8RSCLI6\\SQLEXPRESS;Initial Catalog=SunLyhuor_Ass;Integrated Security=True");
        string userLogin;
        string radioValue;
        int UpId;
        public SearchForm()
        {
            InitializeComponent();
        }

        public string GetusernameLogin
        {
            get
            {
                return this.userLogin;
            }
            set
            {
                this.userLogin = value;
            }
        }

        public string GetRadioValue
        {
            get
            {
                return this.radioValue;
            }
            set
            {
                this.radioValue = value;
            }
        }

        public int GetId
        {
            get
            {
                return this.UpId;
            }
            set
            {
                this.UpId = value;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            InsertForm inf = new InsertForm();
            inf.GetNameLogin = this.GetusernameLogin;
            this.Hide();
            inf.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.GetusernameLogin = this.GetusernameLogin;
            this.Hide();
            up.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm df = new DeleteForm();
            df.GetusernameLogin = this.GetusernameLogin;
            this.Hide();
            df.ShowDialog();
        }

    
        private void SearchForm_Load(object sender, EventArgs e)
        {
            ProfileName.Text = "User : " + this.GetusernameLogin;
            this.Load_data_grid();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Hide();
            lg.ShowDialog();
        }

        void Load_data_grid()
        {
            con.Open();
            string Dataget = "SELECT g.gId as id ,  g.gName as Name , g.gAmount as Amount , p.ProName as Province FROM Guest g INNER JOIN UserDetails ud ON ud.gId = g.gId INNER JOIN Users u ON u.userId = ud.userId INNER JOIN  Provinces p ON p.ProId = g.ProId WHERE  u.userName = @name order by g.gId DESC OFFSET 0 ROWS FETCH FIRST 8 ROWS ONLY";
            SqlCommand cm = new SqlCommand(Dataget, con);
            cm.Parameters.AddWithValue("@name" , this.GetusernameLogin);
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {
                showGuestData.Rows.Add(reader["id"], reader["Name"].ToString(), reader["Amount"].ToString(), reader["Province"].ToString());
            }
            con.Close();
        }

        private void textSearchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) submitSearch.PerformClick();
        }

        private void submitSearch_Click(object sender, EventArgs e)
        {
            if (textSearchbox.Text == "") MessageBox.Show("Search box can't empty!");
            else
            {
                if (this.GetRadioValue == "name")
                {
                    con.Open();
                    string name = textSearchbox.Text;
                    string query = "select g.gId , g.gName , g.gAmount , p.ProName from Users u INNER join UserDetails ud on u.userId = ud.userId INNER JOIN GUEST g on g.gId = ud.gId INNER JOIN Provinces p on p.ProId = g.ProId where u.userName = @username and g.gName = @name";
                    SqlCommand sm = new SqlCommand(query, con);
                    sm.Parameters.AddWithValue("@name", name);
                    sm.Parameters.AddWithValue("@username", this.GetusernameLogin);
                    SqlDataAdapter da = new SqlDataAdapter(sm);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        this.GetId = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                        string ProVinceData = ds.Tables[0].Rows[0][3].ToString();
                        string Newname = ds.Tables[0].Rows[0][1].ToString();
                        double NewAmount = Convert.ToDouble(ds.Tables[0].Rows[0][2]);
                        int newid = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                        showHistory.Rows.Add(this.GetId , Newname , NewAmount , ProVinceData);
                        textSearchbox.Focus();
                        //this.GetAmount = NewAmount.ToString();
                        //this.Getusername = Newname.ToString();
                        //this.GetProvince = ProVinceData.ToString();
                        //ShowName.Text = "Guest name      :" + Newname.ToString();
                        //showAmount.Text = "Guest amount     :" + NewAmount.ToString();
                        //ShowProvince.Text = "Guest Province     :" + ProVinceData;
                        //showId.Text = "Guest Id     :" + newid;
                        //textSearchBox.Text = "";
                        //submitDelete.Focus();
                    }
                    else
                    {
                        MessageBox.Show(textSearchbox.Text + " not found");
                        textSearchbox.Focus();
                    }

                    con.Close();
                }
                else if (this.GetRadioValue == "id")
                {
                    con.Open();
                    int id = Convert.ToInt32(textSearchbox.Text);
                    string query = "select g.gId , g.gName , g.gAmount , p.ProName from Users u INNER join UserDetails ud on u.userId = ud.userId INNER JOIN GUEST g on g.gId = ud.gId INNER JOIN Provinces p on p.ProId = g.ProId where u.userName = @name and g.gId = @id";
                    SqlCommand sm = new SqlCommand(query, con);
                    sm.Parameters.AddWithValue("@name", this.GetusernameLogin);
                    sm.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter da = new SqlDataAdapter(sm);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        this.GetId = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                        string ProVinceData = ds.Tables[0].Rows[0][3].ToString();
                        string Newname = ds.Tables[0].Rows[0][1].ToString();
                        double NewAmount = Convert.ToDouble(ds.Tables[0].Rows[0][2]);
                        int newid = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                        showHistory.Rows.Add(this.GetId, Newname, NewAmount, ProVinceData);
                        textSearchbox.Focus();
                        //this.GetAmount = NewAmount.ToString();
                        //this.Getusername = Newname.ToString();
                        //this.GetProvince = ProVinceData.ToString();
                        //ShowName.Text = "Guest name      :" + Newname.ToString();
                        //showAmount.Text = "Guest amount     :" + NewAmount.ToString();
                        //ShowProvince.Text = "Guest Province     :" + ProVinceData;
                        //showId.Text = "Guest Id     :" + this.GetId;
                        //textSearchBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(textSearchbox.Text + " not found!");
                        textSearchbox.Focus();
                    }
                    con.Close();
                }
                else
                {
                    textSearchbox.Focus();
                    MessageBox.Show("Choose filter serach!");
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.GetRadioValue = "name";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.GetRadioValue = "id";
        }
    }
}
