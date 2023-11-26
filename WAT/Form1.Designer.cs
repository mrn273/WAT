using System;

namespace WAT
{
    partial class WAT
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
 
        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Panel panel2;
            this.Cal2text = new System.Windows.Forms.Label();
            this.move_black = new System.Windows.Forms.PictureBox();
            this.btnCalibration = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            panel2 = new System.Windows.Forms.Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.move_black)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            panel2.BackColor = System.Drawing.SystemColors.Window;
            panel2.Controls.Add(this.Cal2text);
            panel2.Controls.Add(this.move_black);
            panel2.Location = new System.Drawing.Point(8, 33);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(683, 319);
            panel2.TabIndex = 2;
            // 
            // Cal2text
            // 
            this.Cal2text.AutoSize = true;
            this.Cal2text.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cal2text.Location = new System.Drawing.Point(34, 33);
            this.Cal2text.Name = "Cal2text";
            this.Cal2text.Size = new System.Drawing.Size(1075, 64);
            this.Cal2text.TabIndex = 1;
            this.Cal2text.Text = "사각형의 색이 바뀌면 윙크를 하세요";
            this.Cal2text.Visible = false;
            // 
            // move_black
            // 
            this.move_black.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.move_black.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.move_black.Location = new System.Drawing.Point(663, 299);
            this.move_black.Margin = new System.Windows.Forms.Padding(2);
            this.move_black.Name = "move_black";
            this.move_black.Size = new System.Drawing.Size(20, 20);
            this.move_black.TabIndex = 0;
            this.move_black.TabStop = false;
            this.move_black.Visible = false;
            // 
            // btnCalibration
            // 
            this.btnCalibration.AutoSize = true;
            this.btnCalibration.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnCalibration.Location = new System.Drawing.Point(8, 8);
            this.btnCalibration.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCalibration.Size = new System.Drawing.Size(102, 22);
            this.btnCalibration.TabIndex = 0;
            this.btnCalibration.Text = "Calibration 1";
            this.btnCalibration.UseVisualStyleBackColor = true;
            this.btnCalibration.UseWaitCursor = true;
            this.btnCalibration.TextChanged += new System.EventHandler(this.change_flag);
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(114, 8);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 20);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.move_timer);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer1_stop);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(592, 8);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 20);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 5000;
            this.timer3.Tick += new System.EventHandler(this.Calibration2_Timer);
            // 
            // timer4
            // 
            this.timer4.Interval = 34000;
            this.timer4.Tick += new System.EventHandler(this.Calibration2_stop_timer);
            // 
            // WAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(panel2);
            this.Controls.Add(this.btnCalibration);
            this.HelpButton = true;
            this.Name = "WAT";
            this.Text = "WAT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.move_black)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalibration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox move_black;
        private System.Windows.Forms.Timer timer1;

        //Calibration 1
        private int flag = 1;
        private double angle = 0;
        private int x = 0, y = 0;
        private int max_x;
        private int max_y;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label Cal2text;

        //Calibration 2
        private Random random = new Random();
        private System.Windows.Forms.Timer timer4;
    }
}

