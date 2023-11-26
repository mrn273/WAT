using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WAT
{
    public partial class WAT : Form
    {
        public WAT()
        {
            InitializeComponent();
        }
        private void btnCalibration_Click(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            timer1.Enabled = true;
            timer2.Enabled = true;
            max_x = move_black.Location.X;
            max_y = move_black.Location.Y;
            
            angle = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            move_black.Visible = false;

            move_black.Location = new Point(max_x, max_y);
        }

        private void move_timer(object sender, EventArgs e)
        {
            move_black.Visible = true;

            x = (int)(max_x / 2 * Math.Cos(angle));
            y= (int)(max_y / 2 * Math.Sin(angle));

            move_black.Location = new Point(max_x/2 + x, max_y/2 + y);

            angle += 0.05;
            if (angle == 360)
                angle = 0;
        }

        private void timer1_stop(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnNext.Visible = true;
            timer2.Enabled = false;
        }
    }
}
