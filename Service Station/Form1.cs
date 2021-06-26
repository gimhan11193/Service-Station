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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_homePage_Click(object sender, EventArgs e)
        {
            HomepgLogin ust = new HomepgLogin();
            MainControl.showControl(ust, Content);
        }

        private void btn_TypeofService_Click(object sender, EventArgs e)
        {
            Typeservice ust = new Typeservice();
            MainControl.showControl(ust, Content);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login ust = new Login();
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
