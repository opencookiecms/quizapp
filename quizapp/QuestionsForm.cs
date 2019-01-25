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
    public partial class QuestionsForm : Form
    {
        public QuestionsForm()
        {
            InitializeComponent();
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            

        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            try
            {

           
         
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
              
            }
        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            try
            {

                textBox1.Focus();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
         

            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }


        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void buttUpdate_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

      
    }
}
