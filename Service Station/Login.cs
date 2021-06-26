using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Station
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        contactClass c = new contactClass();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.VehicleModel = textBox2.Text;
            c.CompanyName = textBox3.Text;
            c.OwnerName = textBox4.Text;
            c.ContactNo = textBox5.Text;
            c.Amount = textBox7.Text;
            c.ServiceType = comboBox1.Text;

            bool success = c.Insert(c);
            if (success==true)
            {
                MessageBox.Show("New Details Successfully Inserted");
            }
            else
            {
                MessageBox.Show("Failed to add New Details.Try Again.");
            }
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;

        }
    }
}
