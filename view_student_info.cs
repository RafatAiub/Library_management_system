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
using System.IO;

namespace libraryManagementSystem
{
    public partial class view_student_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EFPTB26\SQLEXPRESS;Initial Catalog=LIBRARY_MANAGEMENT;Integrated Security=True;Pooling=False");
        int i = 0;
        string wanted_path;
        string pwd = Class1.GetRandomPassword(20);
        DialogResult result;
        private object openFileDialog1;

        public view_student_info()
        {
            InitializeComponent();
        }

        private void view_student_info_Load(object sender, EventArgs e)
        {
            

            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from student_info ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            Bitmap img;
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.Width = 500;
            imageCol.HeaderText = "student image";
            imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageCol.Width = 100;
            dataGridView1.Columns.Add(imageCol);
            foreach(DataRow dr in dt.Rows)
            {
                img = new Bitmap(@"..\..\"+dr["student_image"].ToString());
                dataGridView1.Rows[i].Cells[8].Value = img;
                dataGridView1.Rows[i].Height = 100;
                i = i + 1;
            }
                }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EFPTB26\SQLEXPRESS;Initial Catalog=LIBRARY_MANAGEMENT;Integrated Security=True;Pooling=False");
                dataGridView1.Columns.Clear();
                int i = 0;
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *from student_info where student_name like('%"+textBox1.Text+"%') ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.Width = 500;
                imageCol.HeaderText = "student image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                dataGridView1.Columns.Add(imageCol);
                foreach (DataRow dr in dt.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    dataGridView1.Rows[i].Cells[8].Value = img;
                    dataGridView1.Rows[i].Height = 100;
                    i = i + 1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EFPTB26\SQLEXPRESS;Initial Catalog=LIBRARY_MANAGEMENT;Integrated Security=True;Pooling=False");
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
           
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select*from student_info where id=" + i + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                student_name.Text = dr["student_name"].ToString();
                student_email.Text = dr["student_email"].ToString();
                student_department.Text = dr["student_department"].ToString();
                student_sem.Text = dr["student_sem"].ToString();
                student_enrollment_no.Text = dr["student_enrollment_no"].ToString();
                student_contact.Text = dr["student_contact"].ToString();

                    

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string pwd = Class1.GetRandomPassword(20);
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
             result = openFileDialog.ShowDialog();
            openFileDialog1.Filter = "JPEG Files (*.jpeg)| *.jpeg|PNG Files(*.png)*.png|**.png|JPG Files (*.jpg)|.jpg|GIF Files(*.gif)|*.gif";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (result == DialogResult.OK)
            {
                MessageBox.Show("ok");
            }
            else if(result==DialogResult.Cancel)
            {
                MessageBox.Show("cancle");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
