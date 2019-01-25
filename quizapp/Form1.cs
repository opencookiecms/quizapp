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
        private int counter = 60;
        string yesanswer = "Correct Answers";
        string wronganswer = "Wrong Answers";
        string playerName = "Unknown";
        public Form1()
                  
        {
            InitializeComponent();
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizApp.Quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.Fill(this.quizApp.Quiz);
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            countLabel.Text = counter.ToString();
            wrongorrightLabel.Visible = false;
           
            timer1.Start();
            //serialPort1.Open();
    
            
        


        }

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
                timer1.Stop();
            countLabel.Text = counter.ToString();

     
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Form1 form1 = new Form1();

            System.Drawing.Graphics graphics = e.Graphics;
       
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, form1.Width, form1.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(243, 144, 79), System.Drawing.Color.FromArgb(59, 67, 113), 65f);

            graphics.FillRectangle(b, gradient_rectangle);
  
        }

        private void buttSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingform = new SettingForm();
            settingform.Show();
        }



        private void nextBut_Click(object sender, EventArgs e)
        {

            quizBindingSource.MoveNext();
            wrongorrightLabel.Visible = false;


        }

        private void correctBut_Click(object sender, EventArgs e)
        {
            label1.Text = playerName;

            q_player_answersTextBox.Text = label1.Text;

            this.Validate();
            this.quizBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quizApp);

            wrongorrightLabel.Visible = true;
            wrongorrightLabel.Text = yesanswer;

            
        }

        private void wrongBut_Click(object sender, EventArgs e)
        {
            wrongorrightLabel.Visible = true;
            wrongorrightLabel.Text = wronganswer;
        }

        private void countLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
