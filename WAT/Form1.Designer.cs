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
            this.move_black = new System.Windows.Forms.PictureBox();
            this.btnCalibration = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnNext = new System.Windows.Forms.Button();
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
            panel2.Controls.Add(this.move_black);
            panel2.Location = new System.Drawing.Point(12, 50);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(976, 478);
            panel2.TabIndex = 2;
            // 
            // move_black
            // 
            this.move_black.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.move_black.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.move_black.Location = new System.Drawing.Point(956, 455);
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
            this.btnCalibration.Location = new System.Drawing.Point(12, 12);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCalibration.Size = new System.Drawing.Size(145, 30);
            this.btnCalibration.TabIndex = 0;
            this.btnCalibration.Text = "Calibration 1";
            this.btnCalibration.UseVisualStyleBackColor = true;
            this.btnCalibration.UseWaitCursor = true;
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(163, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 30);
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
            this.btnNext.Location = new System.Drawing.Point(846, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(145, 30);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            // 
            // WAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(panel2);
            this.Controls.Add(this.btnCalibration);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WAT";
            this.Text = "WAT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            panel2.ResumeLayout(false);
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
        private double angle = 0;
        private int x = 0, y = 0;
        private int max_x;
        private int max_y;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnNext;
    }
}

