using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Service_Station
{
    class MainControl
    {
        public static void showControl(Control control,Control Content)
        {
            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.Controls.Add(control);
        }
    }
}
