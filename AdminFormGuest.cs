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
    public partial class AdminFormGuest : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8RSCLI6\\SQLEXPRESS;Initial Catalog=SunLyhuor_Ass;Integrated Security=True");
        public AdminFormGuest()
        {
            InitializeComponent();
        }

        private void AdminFormGuest_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        void Load_Data()
        {
            con.Open();
            string query = "select g.gId as Id, g.gName as Name , g.gAmount as Amount, p.ProName as Province , u.userName as 'user' , YEAR(g.gTime) as gYear, MONTH(g.gTime) as gMonth , DAY(g.gTime) as gDay from Users u INNER join UserDetails ud on u.userId = ud.userId INNER JOIN GUEST g on g.gId = ud.gId INNER JOIN Provinces p on p.ProId = g.ProId;";
            SqlCommand cmm = new SqlCommand(query , con);
            var reader = cmm.ExecuteReader();
            while (reader.Read())
            {
                ShowData.Rows.Add(reader["Id"] , reader["Name"].ToString() , reader["Amount"].ToString() , reader["Province"].ToString() , reader["user"].ToString(), reader["gDay"].ToString() + "-" + reader["gMonth"].ToString() + "-" + reader["gYear"].ToString());
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm ad = new AdminForm();
            ad.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
