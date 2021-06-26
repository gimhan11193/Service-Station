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
    public partial class Typeservice : UserControl
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\~gima~\Documents\DGView.mdf;Integrated Security=True;Connect Timeout=30");
        public Typeservice()
        {
            InitializeComponent();
        }
        public void  populateGrid()
        {
            Con.Open();
            string query = "select * from Service_tbl";
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
            string query = "select * from Service_tbl where Vehicle Model = '"+textBox1+"'";
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
            string query = "select * from Service_tbl where Service Type = '" + comboBox1.SelectedItem.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

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
