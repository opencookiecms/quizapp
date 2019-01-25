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
            // TODO: This line of code loads data into the 'quizDataDataSet.quiztable' table. You can move, or remove it, as needed.
            this.quiztableTableAdapter.Fill(this.quizDataDataSet.quiztable);
            // TODO: This line of code loads data into the 'quizDataSet.quiztable' table. You can move, or remove it, as needed.
        
            quiztableBindingSource.DataSource = this.quizDataDataSet.quiztable;
            // TODO: This line of code loads data into the 'quizDataset.quiztable' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'quiz1DataSet.quiztable' table. You can move, or remove it, as needed.


        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            try
            {

                quiztableBindingSource.EndEdit();
                quiztableTableAdapter.Update(this.quizDataDataSet.quiztable);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quiztableBindingSource.ResetBindings(false);
              
            }
        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            try
            {

                textBox1.Focus();
                this.quizDataDataSet.quiztable.AddquiztableRow(this.quizDataDataSet.quiztable.NewquiztableRow());
                quiztableBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quiztableBindingSource.ResetBindings(false);

            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox5.Text))
                {
                    if (string.IsNullOrEmpty(textBox5.Text))
                        dataGridView1.DataSource = quiztableBindingSource;
                    else
                    {
                        var query = from o in this.quizDataDataSet.quiztable
                                    where o.question.Contains(textBox5.Text) || o.playeranswer.Contains(textBox5.Text)
                                    select o;
                        dataGridView1.DataSource = query.ToList();
                    }
                }
                
            }
        }


        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure what to delete this question", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    quiztableBindingSource.RemoveCurrent();
            }
        }

        private void buttUpdate_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

      
    }
}
