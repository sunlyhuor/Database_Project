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
    public partial class DeleteForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8RSCLI6\\SQLEXPRESS;Initial Catalog=SunLyhuor_Ass;Integrated Security=True");
        string usernameLogin;
        int UpId;
        int GuestId;
        string radioValue;
        string userName;
        string userAmount;
        string userProvince;

        public DeleteForm()
        {
            InitializeComponent();
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

        public string Getusername
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
            }
        }

        public string GetAmount
        {
            get
            {
                return this.userAmount;
            }
            set
            {
                this.userAmount = value;
            }
        }

        public string GetProvince
        {
            get
            {
                return this.userProvince;
            }
            set
            {
                this.userProvince = value;
            }
        }
        public int GetguestId
        {
            get
            {
                return this.GuestId;
            }
            set
            {
                this.GuestId = value;
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
        public string GetusernameLogin
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.GetusernameLogin = this.usernameLogin;
            this.Hide();
            up.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertForm inf = new InsertForm();
            inf.GetNameLogin = this.GetusernameLogin;
            this.Hide();
            inf.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textSearchBox.Text == "") MessageBox.Show("Search box can't empty!");
            else
            {
                if (this.GetRadioValue == "name")
                {
                    con.Open();
                    string name = textSearchBox.Text;
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
                        this.GetAmount = NewAmount.ToString();
                        this.Getusername = Newname.ToString();
                        this.GetProvince = ProVinceData.ToString();
                        ShowName.Text ="Guest name      :" +Newname.ToString();
                        showAmount.Text = "Guest amount     :" +  NewAmount.ToString();
                        ShowProvince.Text = "Guest Province     :" + ProVinceData;
                        showId.Text = "Guest Id     :" + newid;
                        textSearchBox.Text = "";
                        submitDelete.Focus();
                    }
                    else
                    {
                        MessageBox.Show(textSearchBox.Text + " not found");
                        textSearchBox.Focus();
                    }

                    con.Close();
                }
                else if(this.GetRadioValue == "id")
                {
                    con.Open();
                    int id = Convert.ToInt32(textSearchBox.Text);
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
                        this.GetAmount = NewAmount.ToString();
                        this.Getusername = Newname.ToString();
                        this.GetProvince = ProVinceData.ToString();
                        ShowName.Text = "Guest name      :" + Newname.ToString();
                        showAmount.Text = "Guest amount     :" + NewAmount.ToString();
                        ShowProvince.Text = "Guest Province     :" + ProVinceData;
                        showId.Text = "Guest Id     :" + this.GetId;
                        textSearchBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(textSearchBox.Text + " not found!");
                        textSearchBox.Focus();
                    }
                    con.Close();
                }
                else
            {
                textSearchBox.Focus();
                MessageBox.Show("Choose filter serach!");
            }
            }
        }
         

        private void radioId_CheckedChanged(object sender, EventArgs e)
        {
            this.GetRadioValue = "id";
            if (textSearchBox.Text != "") textSearchBox.Text = "";
        }

        private void radioName_CheckedChanged(object sender, EventArgs e)
        {
            this.GetRadioValue = "name";
        }


        private void textSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(this.GetRadioValue == "id")
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))  e.Handled = true;
        }

        private void textSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch.PerformClick();
        }

        private void submitDelete_Click(object sender, EventArgs e)
        {
            if (showAmount.Text == "Guest Amount : ") MessageBox.Show("have no data to delete!");
            else
            {
                if (MessageBox.Show("Are you sure!", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        string DeteteQuery = "DELETE from Guest WHERE gId = @id";
                        SqlCommand cm = new SqlCommand(DeteteQuery, con);
                        cm.Parameters.AddWithValue("@id", this.GetId);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Delete " + this.GetId + "successfuly!");
                        con.Close();
                        deleteHistory.Rows.Add(this.GetId , this.Getusername , this.GetAmount , this.GetProvince);
                        showAmount.Text = "Guest amount     :";
                        showId.Text = "Guest id     :";
                        ShowName.Text = "Guest Name     :";
                        ShowProvince.Text = "Guest province    :";
                        textSearchBox.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Delete failed!");
                    }

                }
                else
                {
                    MessageBox.Show("Delete has canceled");
                    textSearchBox.Focus();
                }
            }
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            ProfileName.Text = "User : " + this.GetusernameLogin;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Hide();
            lg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.GetusernameLogin = this.GetusernameLogin;
            this.Hide();
            sf.ShowDialog();
        }
    }
}
