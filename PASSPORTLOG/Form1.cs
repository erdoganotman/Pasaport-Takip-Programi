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

namespace PASSPORTLOG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-UID9DVVD;Initial Catalog=user;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM userid where user_id='" + textBox1.Text + "'AND user_pass='" + textBox2.Text + "'", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                Form2 frm2=new Form2();
                frm2.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Giriş Başarısız");


            if (checkBox1.Checked)
            {
                
                
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programı Satın Almak İçin Lütfen Bizimle İletişime Geçiniz");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }
    }
}
