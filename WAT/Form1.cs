using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAT
{
    public partial class Form1 : Form
    {
        private Rectangle whiteRectangle;

        public Form1()
        {
            InitializeComponent();
            InitializeWhiteRectangle();
        }

        private void InitializeWhiteRectangle()
        {
            whiteRectangle = new Rectangle
            {
                Size = new Size(200, 150),
                BackColor = Color.White
            };

            whiteRectangle.Location = new Point((ClientSize.Width - whiteRectangle.Width) / 2, (ClientSize.Height - whiteRectangle.Height) / 2);

            Controls.Add(whiteRectangle);
        }
			private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
