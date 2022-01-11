using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace libraryManagementSystem
{
    public partial class add_student_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EFPTB26\SQLEXPRESS;Initial Catalog=LIBRARY_MANAGEMENT;Integrated Security=True;Pooling=False");
        
        string wanted_path;
        string pwd = Class1.GetRandomPassword(20);
        

        public add_student_info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pwd = Class1.GetRandomPassword(20);
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "JPEG Files (*.jpeg)| *.jpeg|PNG Files(*.png)*.png|**.png|JPG Files (*.jpg)|.jpg|GIF Files(*.gif)|*.gif";
            if (result == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string img_path;
                File.Copy(openFileDialog1.FileName, wanted_path + "\\student_images\\" + pwd + ".jpg");
                img_path = "student_images\\" + pwd + ".jpg";
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into student_info values('" + textBox1.Text + "','" + img_path.ToString() + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("record inserted successfully");
                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
