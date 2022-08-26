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
    public partial class Update : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8RSCLI6\\SQLEXPRESS;Initial Catalog=SunLyhuor_Ass;Integrated Security=True");
        string radioValue;
        int UpId;
        string usernameLogin;
        public Update()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textSearchBox.Text == "")
            {
                MessageBox.Show("Search box can't empty!");
            }
            else
            {
                if (this.GetRadioValue == "id")
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
                        newName.Text = Newname;
                        newAmount.Text = NewAmount.ToString();
                        update_grid_view.Rows.Add(newid, Newname, NewAmount , ProVinceData);
                        textSearchBox.Text = "";
                        textSearchBox.Focus();
                        oldProvince.Text = ProVinceData;
                        //UsernameOldText.Content = "Old username : " + name;
                        //ProvinceOldText.Content = "Old province : " + ProVinceData;
                    }
                    else
                    {
                        MessageBox.Show(textSearchBox.Text + " not found!");
                        newAmount.Text = "";
                        newName.Text = "";
                        oldProvince.Text = "Old province";
                    }
                    con.Close();
                }
                else if (this.GetRadioValue == "name")
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
                        newName.Text = Newname;
                        newAmount.Text = NewAmount.ToString();
                        update_grid_view.Rows.Add(newid, Newname, NewAmount , ProVinceData);
                        newName.Text = Newname;
                        newAmount.Text = NewAmount.ToString();
                        oldProvince.Text = ProVinceData;
                        textSearchBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(textSearchBox.Text + " not found");
                    }

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please select filter search!");
                }
            }
        }

        private void radioId_CheckedChanged(object sender, EventArgs e)
        {
            this.radioValue = "id";
        }

        private void radioName_CheckedChanged(object sender, EventArgs e)
        {
            this.radioValue = "name";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(this.GetRadioValue == "id")
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void textSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch.PerformClick();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertForm inf = new InsertForm();
            inf.GetNameLogin = this.GetusernameLogin;
            this.Hide();
            inf.ShowDialog();
        }

        private void submitUpdate_Click(object sender, EventArgs e)
        {
            if (newName.Text == "") MessageBox.Show("Username is can't empty!");
            else if (newProvince.Text == "") MessageBox.Show("Province is can't empty!");
            else
            {
                try
                {
                    con.Open();
                    //Get id from province
                    string ProId = "select ProId from Provinces where ProName = @proname";
                    SqlCommand procm = new SqlCommand(ProId, con);
                    procm.Parameters.AddWithValue("@proname", newProvince.Text);
                    SqlDataAdapter proda = new SqlDataAdapter(procm);
                    DataSet prods = new DataSet();
                    proda.Fill(prods);
                    DataTable dt = prods.Tables[0];
                    int proID = Convert.ToInt32(prods.Tables[0].Rows[0][0]);
                    //MessageBox.Show(proID.ToString());
                    //Update Guest and province
                    string Update = "update Guest set gName = @name, ProId = @proid , gAmount = @amount where gId = @id";
                    SqlCommand upcm = new SqlCommand(Update, con);
                    upcm.Parameters.AddWithValue("@name", newName.Text);
                    upcm.Parameters.AddWithValue("@proid", proID);
                    upcm.Parameters.AddWithValue("@amount", newAmount.Text);
                    upcm.Parameters.AddWithValue("@id", this.GetId);
                    upcm.ExecuteNonQuery();
                    con.Close();
                    update_grid_view.Rows.Add(this.GetId, newName.Text, newAmount.Text , newProvince.Text);
                    newName.Text = "";
                    newAmount.Text = "";
                    newProvince.Text = "";
                    //UsernameOldText.Content = "Old password";
                    //ProvinceOldText.Content = "Old province";
                    MessageBox.Show("Updete Successfuly!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }


        private void newProvince_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Application.Exit();
        }

        private void newAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) submitUpdate.PerformClick();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            ProfileName.Text = "User : " + this.GetusernameLogin;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm df = new DeleteForm();
            df.GetusernameLogin = this.GetusernameLogin;
            this.Hide();
            df.ShowDialog();
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

        private void newProvince_MouseUp(object sender, MouseEventArgs e)
        {
            con.Open();
            int i = 0;
            string query = "SELECT ProName FROM Provinces";
            SqlCommand comm = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            newProvince.Items.Clear();
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                newProvince.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                con.Close();
            }
        }
    }
}
