using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=HPC;Initial Catalog=company;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand com = new SqlCommand("exec dbo.sp_client_insert   '" + int.Parse(textBox1.Text) + "' ,  '" + textBox2.Text + "'  ,'" + int.Parse(textBox3.Text) + "'   ", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved ");
            LoadAllRecords();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand com = new SqlCommand("exec dbo.sp_client_update   '" + int.Parse(textBox1.Text) + "' ,  '" + textBox2.Text + "'  ,'" + int.Parse(textBox3.Text) + "'   ", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated ");
            LoadAllRecords();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Are you confirm to delete ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand com = new SqlCommand("exec dbo.sp_client_delete   '" + int.Parse(textBox1.Text) + "'  ", con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted ");
                LoadAllRecords();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("exec dbo.sp_client_search '" + int.Parse(textBox1.Text) + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllRecords();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("exec dbo.sp_client_view", con);
            SqlDataAdapter  da = new SqlDataAdapter(com);
            DataTable dt= new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
