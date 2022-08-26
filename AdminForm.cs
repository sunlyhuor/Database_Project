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
    public partial class AdminForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8RSCLI6\\SQLEXPRESS;Initial Catalog=SunLyhuor_Ass;Integrated Security=True");
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void ShowUserData()
        {
            con.Open();
            string query = "select u.userName as Name ,COUNT(g.gName) as counts  from Users u INNER join UserDetails ud on u.userId = ud.userId INNER JOIN GUEST g on g.gId = ud.gId INNER JOIN Provinces p on p.ProId = g.ProId GROUP by u.userName;";
            SqlCommand cm = new SqlCommand(query , con);
            var reader = cm.ExecuteReader();
            while(reader.Read())
            {
                userShow.Rows.Add(reader["Name"].ToString() , reader["counts"].ToString());
            }
            con.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ShowUserData();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            AdminFormGuest adg = new AdminFormGuest();
            this.Hide();
            adg.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminEditForm ae = new AdminEditForm();
            ae.ShowDialog();
        }
    }
}
