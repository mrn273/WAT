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
            move_black.Visible = true;
            angle = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            move_black.Visible = false;
        }

        private void move_timer(object sender, EventArgs e)
        {
            //x = (int)(X_radius * Math.Cos(angle));
            //y = (int)(Y_radius * Math.Sin(angle));
            int max_x = move_black.Location.X;
            int max_y = move_black.Location.Y;

            int x = (int)(max_x/2);
            int y = (int)(max_y/2);

            move_black.Location = new Point(x, y);

            angle += 0.1;
            if (angle == 360)
                angle = 0;
        }
    }
}
