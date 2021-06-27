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
    public partial class NewLog : Form
    {
        public NewLog()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_uname.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("fill the username field ");
                if (txt_pass.Text.TrimStart() == string.Empty)
                {
                    MessageBox.Show("fill the password field ");
                }

            }
            if (txt_uname.Text == "gima" && txt_pass.Text =="123") {
                MessageBox.Show("added");

                Form1 obj = new Form1();
                obj.Show();
                this.Hide();
            }



        }

        private void NewLog_Load(object sender, EventArgs e)
        {

        }
    }
}
