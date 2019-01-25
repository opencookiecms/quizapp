using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizapp
{
    public partial class TotalMark : Form
    {
        public TotalMark()
        {
            InitializeComponent();
        }

        private void TotalMark_Load(object sender, EventArgs e)
        {

        }

        private void TotalMark_Paint(object sender, PaintEventArgs e)
        {
            TotalMark totalMark = new TotalMark();

            System.Drawing.Graphics graphics = e.Graphics;

            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, totalMark.Width, totalMark.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(75, 121, 161), System.Drawing.Color.FromArgb(40, 62, 81), 65f);

            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
