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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-II1J8LHK\SQLEXPRESS;Initial Catalog= Pegadaian Syariah;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)
        {
            Form8 menu = new Form8();
            menu.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            String query = " SELECT * FROM Kendaraan ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            con.Open();
            String quer = " SELECT * FROM Elektronik ";
            SqlDataAdapter SD = new SqlDataAdapter(quer, con);
            DataTable d = new DataTable();
            SD.Fill(d);
            dataGridView2.DataSource = d;
            con.Close();

            con.Open();
            String quey = " SELECT * FROM Perhiasan ";
            SqlDataAdapter SA = new SqlDataAdapter(quey, con);
            DataTable t = new DataTable();
            SA.Fill(t);
            dataGridView3.DataSource = t;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 menu = new Form8();
            menu.Show();
            this.Hide();
        }
    }
}
