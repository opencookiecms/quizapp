namespace quizapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttSetting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.countLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wrongorrightLabel = new System.Windows.Forms.Label();
            this.nextBut = new System.Windows.Forms.Button();
            this.minBut = new System.Windows.Forms.Button();
            this.MaxBut = new System.Windows.Forms.Button();
            this.CloseBut = new System.Windows.Forms.Button();
            this.quizApp = new quizapp.QuizApp();
            this.quizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizTableAdapter = new quizapp.QuizAppTableAdapters.QuizTableAdapter();
            this.tableAdapterManager = new quizapp.QuizAppTableAdapters.TableAdapterManager();
            this.q_titleLabel1 = new System.Windows.Forms.Label();
            this.correctBut = new System.Windows.Forms.Button();
            this.wrongBut = new System.Windows.Forms.Button();
            this.q_titleTextBox = new System.Windows.Forms.TextBox();
            this.q_player_answersTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(470, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Names";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttSetting
            // 
            this.buttSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttSetting.BackColor = System.Drawing.Color.Orange;
            this.buttSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttSetting.Font = new System.Drawing.Font("Nightclub BTN", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttSetting.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttSetting.Location = new System.Drawing.Point(1110, 661);
            this.buttSetting.Name = "buttSetting";
            this.buttSetting.Size = new System.Drawing.Size(146, 44);
            this.buttSetting.TabIndex = 1;
            this.buttSetting.Text = "Setting";
            this.buttSetting.UseVisualStyleBackColor = false;
            this.buttSetting.Click += new System.EventHandler(this.buttSetting_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(55, 598);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 57);
            this.panel1.TabIndex = 2;
            // 
            // countLabel
            // 
            this.countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countLabel.AutoSize = true;
            this.countLabel.BackColor = System.Drawing.Color.Transparent;
            this.countLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.countLabel.Location = new System.Drawing.Point(58, 9);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(192, 85);
            this.countLabel.TabIndex = 3;
            this.countLabel.Text = "00:30";
            this.countLabel.Click += new System.EventHandler(this.countLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.wrongorrightLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(55, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1201, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Answer";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // wrongorrightLabel
            // 
            this.wrongorrightLabel.AutoSize = true;
            this.wrongorrightLabel.Font = new System.Drawing.Font("Nightclub BTN", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongorrightLabel.Location = new System.Drawing.Point(502, 29);
            this.wrongorrightLabel.Name = "wrongorrightLabel";
            this.wrongorrightLabel.Size = new System.Drawing.Size(152, 54);
            this.wrongorrightLabel.TabIndex = 0;
            this.wrongorrightLabel.Text = "onXon";
            this.wrongorrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextBut
            // 
            this.nextBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextBut.BackColor = System.Drawing.Color.SeaGreen;
            this.nextBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBut.Font = new System.Drawing.Font("Nightclub BTN", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nextBut.Location = new System.Drawing.Point(1144, 543);
            this.nextBut.Name = "nextBut";
            this.nextBut.Size = new System.Drawing.Size(112, 49);
            this.nextBut.TabIndex = 6;
            this.nextBut.Text = "Next";
            this.nextBut.UseVisualStyleBackColor = false;
            this.nextBut.Click += new System.EventHandler(this.nextBut_Click);
            // 
            // minBut
            // 
            this.minBut.BackColor = System.Drawing.SystemColors.Highlight;
            this.minBut.FlatAppearance.BorderSize = 0;
            this.minBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBut.Font = new System.Drawing.Font("Nightclub BTN", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minBut.Location = new System.Drawing.Point(1038, 12);
            this.minBut.Name = "minBut";
            this.minBut.Size = new System.Drawing.Size(75, 39);
            this.minBut.TabIndex = 7;
            this.minBut.Text = "-";
            this.minBut.UseVisualStyleBackColor = false;
            // 
            // MaxBut
            // 
            this.MaxBut.BackColor = System.Drawing.Color.Gold;
            this.MaxBut.FlatAppearance.BorderSize = 0;
            this.MaxBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBut.Font = new System.Drawing.Font("Nightclub BTN", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaxBut.Location = new System.Drawing.Point(1114, 12);
            this.MaxBut.Name = "MaxBut";
            this.MaxBut.Size = new System.Drawing.Size(75, 39);
            this.MaxBut.TabIndex = 8;
            this.MaxBut.Text = "[]";
            this.MaxBut.UseVisualStyleBackColor = false;
            // 
            // CloseBut
            // 
            this.CloseBut.BackColor = System.Drawing.Color.Crimson;
            this.CloseBut.FlatAppearance.BorderSize = 0;
            this.CloseBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBut.Font = new System.Drawing.Font("Nightclub BTN", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseBut.Location = new System.Drawing.Point(1190, 12);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(75, 39);
            this.CloseBut.TabIndex = 9;
            this.CloseBut.Text = "X";
            this.CloseBut.UseVisualStyleBackColor = false;
            // 
            // quizApp
            // 
            this.quizApp.DataSetName = "QuizApp";
            this.quizApp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quizBindingSource
            // 
            this.quizBindingSource.DataMember = "Quiz";
            this.quizBindingSource.DataSource = this.quizApp;
            // 
            // quizTableAdapter
            // 
            this.quizTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QuizTableAdapter = this.quizTableAdapter;
            this.tableAdapterManager.TimesQTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = quizapp.QuizAppTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // q_titleLabel1
            // 
            this.q_titleLabel1.BackColor = System.Drawing.Color.Transparent;
            this.q_titleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizBindingSource, "q_title", true));
            this.q_titleLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.q_titleLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_titleLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.q_titleLabel1.Location = new System.Drawing.Point(49, 114);
            this.q_titleLabel1.Name = "q_titleLabel1";
            this.q_titleLabel1.Size = new System.Drawing.Size(1201, 271);
            this.q_titleLabel1.TabIndex = 10;
            this.q_titleLabel1.Text = "Questions";
            this.q_titleLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctBut
            // 
            this.correctBut.Location = new System.Drawing.Point(532, 534);
            this.correctBut.Name = "correctBut";
            this.correctBut.Size = new System.Drawing.Size(92, 48);
            this.correctBut.TabIndex = 11;
            this.correctBut.Text = "button1";
            this.correctBut.UseVisualStyleBackColor = true;
            this.correctBut.Click += new System.EventHandler(this.correctBut_Click);
            // 
            // wrongBut
            // 
            this.wrongBut.Location = new System.Drawing.Point(640, 533);
            this.wrongBut.Name = "wrongBut";
            this.wrongBut.Size = new System.Drawing.Size(97, 49);
            this.wrongBut.TabIndex = 12;
            this.wrongBut.Text = "button2";
            this.wrongBut.UseVisualStyleBackColor = true;
            this.wrongBut.Click += new System.EventHandler(this.wrongBut_Click);
            // 
            // q_titleTextBox
            // 
            this.q_titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizBindingSource, "q_title", true));
            this.q_titleTextBox.Location = new System.Drawing.Point(55, 685);
            this.q_titleTextBox.Name = "q_titleTextBox";
            this.q_titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.q_titleTextBox.TabIndex = 13;
            // 
            // q_player_answersTextBox
            // 
            this.q_player_answersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizBindingSource, "q_player_answers", true));
            this.q_player_answersTextBox.Location = new System.Drawing.Point(174, 685);
            this.q_player_answersTextBox.Name = "q_player_answersTextBox";
            this.q_player_answersTextBox.Size = new System.Drawing.Size(100, 20);
            this.q_player_answersTextBox.TabIndex = 14;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(293, 685);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1293, 717);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.q_player_answersTextBox);
            this.Controls.Add(this.q_titleTextBox);
            this.Controls.Add(this.wrongBut);
            this.Controls.Add(this.correctBut);
            this.Controls.Add(this.q_titleLabel1);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.MaxBut);
            this.Controls.Add(this.minBut);
            this.Controls.Add(this.nextBut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "vb";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nextBut;
        private System.Windows.Forms.Button minBut;
        private System.Windows.Forms.Button MaxBut;
        private System.Windows.Forms.Button CloseBut;
        private QuizApp quizApp;
        private System.Windows.Forms.BindingSource quizBindingSource;
        private QuizAppTableAdapters.QuizTableAdapter quizTableAdapter;
        private QuizAppTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label q_titleLabel1;
        private System.Windows.Forms.Button correctBut;
        private System.Windows.Forms.Button wrongBut;
        private System.Windows.Forms.TextBox q_titleTextBox;
        private System.Windows.Forms.TextBox q_player_answersTextBox;
        private System.Windows.Forms.Label wrongorrightLabel;
        private System.Windows.Forms.TextBox iDTextBox;
    }
}

