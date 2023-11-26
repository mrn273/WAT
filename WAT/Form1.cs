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

            if (flag == 1) {
                timer1.Enabled = true;
                timer2.Enabled = true;
                max_x = move_black.Location.X;
                max_y = move_black.Location.Y;

                angle = 0;
            }
            
            if (flag == 2)
            {
                timer3.Enabled = true;
                timer4.Enabled = true;
                Cal2text.Visible = true;
                move_black.Location = new Point(max_x/2, max_y/2);
                move_black.Visible = true;
                move_black.Size = new Size(50, 50);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                move_black.Visible = false;

                move_black.Location = new Point(max_x, max_y);
            }
            if (flag == 2)
            {
                timer3.Enabled = false;
                timer4.Enabled = false;
                move_black.BackColor = Color.Black;

            }
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.Visible = false;
            move_black.Visible = false;

            if (flag == 1)
            {
                btnCalibration.Text = "Calibration2";

                //그래프 보여주고 넘어갈건가????
            }

            if (flag == 2)
            {
                ////////////////////////여기서부터 시작핫겜
            }

        }

        //Cal1 -> Cal2 로 btn text 변환될 때
        private void change_flag(object sender, EventArgs e)
        {
            flag = 2;
        }

        private void Calibration2_Timer(object sender, EventArgs e)
        {
            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);

            move_black.BackColor = Color.FromArgb(red, green, blue);
        }

        private void Calibration2_stop_timer(object sender, EventArgs e)
        {
            btnNext.Visible = true;
            move_black.Visible = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
        }
    }
}
