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

namespace libraryManagementSystem
{
    
    public partial class login : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EFPTB26\SQLEXPRESS;Initial Catalog=LIBRARY_MANAGEMENT;Integrated Security=True;Pooling=False");
        int count = 0;
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from libery_person where username='"+textBox1.Text+"'and password='"+textBox2.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            if(count==0)
            {
                MessageBox.Show("username password does not match");
            }
            else
            {
                this.Hide();
                mdi_user mu = new mdi_user();
                mu.Show();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
        }
    }
}
