using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Service_Station
{
    public partial class HomepgLogin : UserControl
    {
        public HomepgLogin()
        {
            InitializeComponent();
        }

        private void HomepgLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Typeservice ss = new Typeservice();
            ss.Show();

        }
    }
}
