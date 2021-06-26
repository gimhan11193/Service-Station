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
    public partial class Uc_ServiceType : UserControl
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\~gima~\Documents\DGView.mdf;Integrated Security=True;Connect Timeout=30");
        public Uc_ServiceType()
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
        public void TextboxFilter()
        {
            Con.Open();
            string query = "Select * from Service_tbl where Vehicle Model = '"+textBox1.Text+"'";
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
            string query = "Select * from Service_tbl where Service Type = '" + comboBox1.SelectedItem.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Uc_ServiceType_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populateGrid();
            textBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceFilter();
        }
    }
}
