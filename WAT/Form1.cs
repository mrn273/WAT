using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WAT
{
    public partial class WAT : Form
    {
        //Calibration 1
        private int flag = 1;
        private double angle = 0;
        private int x = 0, y = 0;
        private int max_x;
        private int max_y;
        private int f1 = 0;
        private int f2 = 0;
        private int f3 = 0;
        private int f4 = 0;

        //Calibration 2
        private int cnt = 0;


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public WAT()
        {
            InitializeComponent();
            AllocConsole();
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            btnReset.Visible = true;

            if (flag == 1) {
                max_x = move_black.Location.X;
                max_y = move_black.Location.Y;
                move_black.Visible = true;

                angle = 0;
                timer1.Enabled = true;
                timer2.Enabled = true;

                timer1.Start();
                timer2.Start();
            }
            
            if (flag == 2)
            {
                Tablepanel.Visible = false;
                timer3.Enabled = true;
                timer4.Enabled = true;
                Cal2text.Visible = true;
                move_black.Location = new Point(max_x/2, max_y/2);
                move_black.Visible = true;
                move_black.Size = new Size(50, 50);
            }

            if (flag == 3)
            {
                Tablepanel.Visible=false;
                btnCalibration.Text = "End";
                return;
            }
            if (flag == 4)
            {

            }
        }

        //Reset 수정
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                Tablepanel.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = false;
                move_black.Visible = false;

                move_black.Location = new Point(max_x, max_y);
            }
            if (flag == 2)
            {
                Tablepanel.Visible = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                move_black.BackColor = Color.Black;

            }
        }
        private void UpdateLocation()
        {
            f1 = f2 = f3 = f4 = 0;
            x = (int)(max_x / 2 * Math.Cos(angle));
            y = (int)(max_y / 2 * Math.Sin(angle));

            move_black.Location = new Point(max_x / 2 + x, max_y / 2 + y);
           
            angle += 0.02 * Math.PI;

            if (angle == 2*Math.PI)
                angle = 0;

            if (angle == 0)
                f1 = 1;
            else if (angle == 0.5 * Math.PI)
                f2 = 1;
            else if (angle == 1 * Math.PI)
                f3 = 1;
            else if (angle == 1.5 * Math.PI)
                f4 = 1;
        }
        private void move_timer(object sender, EventArgs e)
        {
            UpdateLocation();
        }

        private void timer1_stop(object sender, EventArgs e)
        {
            label1.Text = (angle/Math.PI, f1, f2, f3, f4).ToString();
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
                Tablepanel.Visible = true;
                return;
            }

            if (flag == 2)
            {
                Cal2text.Visible = false;
                btnReset.Visible = false;
                btnCalibration.Text = "Game Start";
                Tablepanel.Visible = true;
                return;
            }

        }

        //Cal1 -> Cal2 로 btn text 변환될 때
        private void change_flag(object sender, EventArgs e)
        {
            flag += 1;
        }

        private void Calibration2_Timer(object sender, EventArgs e)
        {
            
            int red = Convert.ToInt16(cnt%3==0)*255;
            int green = Convert.ToInt16(cnt % 3 == 1) * 255;
            int blue = Convert.ToInt16(cnt % 3 == 2) * 255;

            cnt++;

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
