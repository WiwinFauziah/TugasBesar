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
    public partial class Form5 : Form
    {
        public Form5()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string quey = "INSERT Perhiasan (Jenis,Type,Berat,Kondisi,Harga) VALUES ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlDataAdapter SA = new SqlDataAdapter(quey, con);
            SA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" INSERT SUCCESS ");
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            String quey = " SELECT * FROM Perhiasan ";
            SqlDataAdapter SA = new SqlDataAdapter(quey, con);
            DataTable t = new DataTable();
            SA.Fill(t);
            dataGridView1.DataSource = t;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            String quey = " DELETE FROM Perhiasan WHERE Jenis = '" + comboBox1.Text + "'";
            SqlDataAdapter SA = new SqlDataAdapter(quey, con);
            SA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" RECORD DELETE ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string quey = "UPDATE Perhiasan SET Type = '" + comboBox2.Text + "',Berat = '" + textBox2.Text + "',Kondisi = '" + textBox3.Text + "',Harga = '" + textBox4.Text + "' Where Jenis = '" + comboBox1.Text + "'";
            SqlDataAdapter SA = new SqlDataAdapter(quey, con);
            SA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" UPDATE SUCCES");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
