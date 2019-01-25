using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing.Drawing2D;

namespace quizapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //serialPort1.Open();


        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          // string PORTREAD = serialPort1.ReadLine();
            //label1.Text = PORTREAD;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Form1 form1 = new Form1();

            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangl = new System.Drawing.Rectangle(0, 0, panel1.Width, panel1.Height);
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, form1.Width, form1.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(255, 0, 0), System.Drawing.Color.FromArgb(57, 128, 227), 65f);
            System.Drawing.Brush c = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(255, 0, 0), System.Drawing.Color.FromArgb(57, 128, 227), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
            graphics.FillRectangle(c, gradient_rectangl);
        }

        private void buttSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingform = new SettingForm();
            settingform.Show();
        }
    }
}
