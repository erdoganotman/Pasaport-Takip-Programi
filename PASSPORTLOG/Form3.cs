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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn2=new SqlConnection("Data Source=LAPTOP-UID9DVVD;Initial Catalog=user;Integrated Security=True");
            conn2.Open();
            SqlCommand add = new SqlCommand("Insert into musteri1(m_adi,m_soyadi,m_dogumtarihi,m_tc,m_pasaportno,m_pbaslangic,m_pbitis,m_makam,m_seyahat,m_randevu,m_ulke,m_gsm,m_adres) values (@m1,@m2,@m3,@m4,@m5,@m6,@m7,@m8,@m9,@m10,@m11,@m12,@m13)",conn2);
            add.Parameters.AddWithValue("@m1", textBox1.Text);
            add.Parameters.AddWithValue("@m2", textBox2.Text);
            add.Parameters.AddWithValue("@m3",dateTimePicker1.Value);
            add.Parameters.AddWithValue("@m4",textBox3.Text);
            add.Parameters.AddWithValue("@m5",textBox4.Text);
            add.Parameters.AddWithValue("@m6", dateTimePicker2.Value);
            add.Parameters.AddWithValue("@m7", dateTimePicker3.Value);
            add.Parameters.AddWithValue("@m8", textBox5.Text);
            add.Parameters.AddWithValue("@m9", dateTimePicker4.Value);
            add.Parameters.AddWithValue("@m10", dateTimePicker5.Value);
            add.Parameters.AddWithValue("@m11", textBox6.Text);
            add.Parameters.AddWithValue("@m12", textBox7.Text);
            add.Parameters.AddWithValue("@m13", richTextBox1.Text);
            
            add.ExecuteNonQuery();
            conn2.Close();
            MessageBox.Show("Kayıt Başarılıyla Oluşturuldu.");
            foreach (Control c in Controls)
            {

                if (c is TextBox)
                {
                    c.Text = "";
                }
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
    }
}
