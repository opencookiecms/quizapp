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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void RegBut_Click(object sender, EventArgs e)
        {
            QuestionsForm questionsForm = new QuestionsForm();
            questionsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TotalMark totalMark = new TotalMark();
            totalMark.Show();
        }

        private void SettingForm_Paint(object sender, PaintEventArgs e)
        {
            SettingForm settingForm = new SettingForm();

            System.Drawing.Graphics graphics = e.Graphics;

            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, settingForm.Width, settingForm.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(190, 147, 197), System.Drawing.Color.FromArgb(123, 198, 204), 65f);

            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
