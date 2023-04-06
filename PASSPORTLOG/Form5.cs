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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-UID9DVVD;Initial Catalog=user;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand update=new SqlCommand("Update musteri1 set m_adi=@d2,m_soyadi=@d3,m_dogumtarihi=@d4,m_pasaportno=@d5,m_pbaslangic=@d6,m_pbitis=@d7,m_makam=@d8,m_seyahat=@d9,m_randevu=@d10,m_ulke=@d11,m_gsm=@d12,m_adres=@d13 where m_tc=@d1",conn);
            update.Parameters.AddWithValue("@d1",textBox3.Text);
            update.Parameters.AddWithValue("@d2", textBox1.Text);
            update.Parameters.AddWithValue("@d3", textBox2.Text);
            update.Parameters.AddWithValue("@d4", dateTimePicker1.Value);
            update.Parameters.AddWithValue("@d5", textBox4.Text);
            update.Parameters.AddWithValue("@d6", dateTimePicker2.Value);
            update.Parameters.AddWithValue("@d7", dateTimePicker3.Value);
            update.Parameters.AddWithValue("@d8", textBox5.Text);
            update.Parameters.AddWithValue("@d9", dateTimePicker4.Value);
            update.Parameters.AddWithValue("@d10", dateTimePicker5.Value);
            update.Parameters.AddWithValue("@d11", textBox6.Text);
            update.Parameters.AddWithValue("@d12", textBox7.Text);
            update.Parameters.AddWithValue("@d13", richTextBox1.Text);
            update.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Başarıyla Güncellenmiştir."); ;
            foreach (Control c in Controls)
            {

                if (c is TextBox)
                {
                    c.Text = "";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            conn.Open();
            SqlCommand delete = new SqlCommand("Delete from musteri1 where m_tc=@m1", conn);
            delete.Parameters.AddWithValue("@m1", textBox3.Text);
            delete.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Başarıyla Silindi");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'userDataSet.musteri1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteri1TableAdapter.Fill(this.userDataSet.musteri1);

        }
    }
}
