using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;
using System.Data.SqlClient;

namespace PASSPORTLOG
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer();
        
        private void müşteriBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3=new Form3();
            frm3.Show();
        }

        private void müşteriBilgileriniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5=new Form5();
            frm5.Show();   
        }

        private void kayıtBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4=new Form4();
            frm4.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'userDataSet1.musteri1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.musteri1TableAdapter1.Fill(this.userDataSet1.musteri1);
            // TODO: Bu kod satırı 'userDataSet.musteri1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            
            numericUpDown1.Value = DateTime.Now.Hour;
            numericUpDown2.Value = DateTime.Now.Minute;
            label2.Visible = false;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            string EURO_Alis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            string EURO_Satis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

            string USD_Alis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            string USD_Satis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            label3.Text = "Euro Alış" + "    "+EURO_Alis;
            label4.Text = "Euro Satış"+"    "+EURO_Satis;
            label5.Text = "USD Alış"+ "    " + USD_Alis;
            label6.Text = "USD Satış"+ "    " + USD_Satis;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt=DateTime.Now;
            
            if(numericUpDown1.Value==dt.Hour && numericUpDown2.Value==dt.Minute)
            {

                label2.Text = "RANDEVU SAATİNİZ GELDİ";
                timer1.Stop();
                
                player.SoundLocation = @"C:\Users\erdog\OneDrive\Masaüstü\Program\Alarm.wav";
                player.PlayLooping();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Visible = Enabled;
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            button1.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
            timer1.Stop();
            label2.Visible = false;
            numericUpDown1.Enabled = Enabled;
            numericUpDown2.Enabled = Enabled;
            button1.Enabled = Enabled;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int a = 0;
            double h,c;
            a = Convert.ToInt32(textBox1.Text);
            c = a * 0.18;
            h = a + c;
            label8.Text = "KDV Dahil Ücret" + "  " + h.ToString()+"KDV Fiyatı"+"  "+c.ToString();
        }
    }
}
