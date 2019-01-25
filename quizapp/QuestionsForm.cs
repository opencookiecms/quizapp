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
            // TODO: This line of code loads data into the 'quizApp.Quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.Fill(this.quizApp.Quiz);
            // TODO: This line of code loads data into the 'quizApp.Quiz' table. You can move, or remove it, as needed.



        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.quizBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.quizApp);


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

        private void quizBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quizBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quizApp);

        }

      
    }
}
