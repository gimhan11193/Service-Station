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

namespace Service_Station
{
    public partial class Uc_OtherService : UserControl
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\~gima~\Documents\DGView.mdf;Integrated Security=True;Connect Timeout=30");
        public Uc_OtherService()
        {
            InitializeComponent();
        }
        public void populateGrid()
        {
            Con.Open();
            string query = "Select * from Service_tbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void VehicleFilter()
        {
            Con.Open();
            string query = "Select * from OtherService_tbl where VehicleType = '" + comboBox2.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void ServiceFilter()
        {
            Con.Open();
            string query = "Select * from OtherService_tbl where ServiceType = '" + comboBox1.SelectedItem.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Uc_OtherService_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Select * from OtherService_tbl where ServiceType = '" + comboBox1.SelectedItem.ToString() + "' AND VehicleType = '" + comboBox2.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populateGrid();
            comboBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceFilter();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehicleFilter();
        }
    }
    
}
