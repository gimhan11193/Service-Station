using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service_Station;
namespace Service_Station
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_homePage_Click(object sender, EventArgs e)
        {
            Uc_CustomerDetails ust = new Uc_CustomerDetails();
            MainControl.showControl(ust, Content);
        }

        private void btn_TypeofService_Click(object sender, EventArgs e)
        {
            Typeservice ust = new Typeservice();
            MainControl.showControl(ust, Content);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Uc_ServiceAccountsDetails ust = new Uc_ServiceAccountsDetails();
            MainControl.showControl(ust, Content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uc_OtherService ust = new Uc_OtherService();
            MainControl.showControl(ust, Content);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}