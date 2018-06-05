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

namespace Tubes_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-II1J8LHK\SQLEXPRESS;Initial Catalog= Pegadaian Syariah;Integrated Security=True");
        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string quer = "INSERT Data_diri (NIK,Nama,Jenis_Kelamin,Tempat_tanggal_lahir,Alamat,Pekerjaan,Kewarganegaraan) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + comboBox3.Text + "','" + comboBox2.Text + "')";
            SqlDataAdapter SD = new SqlDataAdapter(quer, con);
            SD.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" INSERT SUCCESS ");

            Form7 Jenis = new Form7();
            Jenis.Show();
            this.Hide();
        }
    }
}
 