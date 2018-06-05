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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-II1J8LHK\SQLEXPRESS;Initial Catalog= Pegadaian Syariah;Integrated Security=True");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 byr = new Form6();
            byr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string quer = "INSERT Elektronik (Nama_barang,jenis,Type,Keluaran,Kondisi,Harga) VALUES ('" + textBox1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            SqlDataAdapter SD = new SqlDataAdapter(quer, con);
            SD.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" INSERT SUCCESS ");
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            String quer = " SELECT * FROM Elektronik ";
            SqlDataAdapter SD = new SqlDataAdapter(quer, con);
            DataTable d = new DataTable();
            SD.Fill(d);
            dataGridView1.DataSource = d;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            String quer = " DELETE FROM Elektronik WHERE Nama_barang = '" + textBox1.Text + "'";
            SqlDataAdapter SD = new SqlDataAdapter(quer, con);
            SD.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" RECORD DELETE ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE Elektronik SET Jenis = '" + comboBox2.Text + "',Type = '" + comboBox1.Text + "',Keluaran = '" + textBox4.Text + "',Kondisi = '" + textBox5.Text + "',Harga = '" + textBox6.Text + "' WHERE Nama_barang = '" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" UPDATE SUCCESS ");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
           
        }

    }
}
