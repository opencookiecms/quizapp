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
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nextBut = new System.Windows.Forms.Button();
            this.minBut = new System.Windows.Forms.Button();
            this.MaxBut = new System.Windows.Forms.Button();
            this.CloseBut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(470, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Names";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
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
            this.buttSetting.Location = new System.Drawing.Point(1094, 613);
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
            this.panel1.Location = new System.Drawing.Point(55, 541);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 57);
            this.panel1.TabIndex = 2;
            // 
            // countLabel
            // 
            this.countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countLabel.AutoSize = true;
            this.countLabel.BackColor = System.Drawing.Color.Transparent;
            this.countLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.countLabel.Location = new System.Drawing.Point(1073, 48);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(192, 85);
            this.countLabel.TabIndex = 3;
            this.countLabel.Text = "00:30";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.QuestionLabel.Location = new System.Drawing.Point(211, 201);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(805, 47);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "Dimanakah Terletaknya Kekuatan Hang Tuah ?\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(55, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1185, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Correct Answer";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nextBut
            // 
            this.nextBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextBut.BackColor = System.Drawing.Color.SeaGreen;
            this.nextBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBut.Font = new System.Drawing.Font("Nightclub BTN", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nextBut.Location = new System.Drawing.Point(1128, 486);
            this.nextBut.Name = "nextBut";
            this.nextBut.Size = new System.Drawing.Size(112, 49);
            this.nextBut.TabIndex = 6;
            this.nextBut.Text = "Next";
            this.nextBut.UseVisualStyleBackColor = false;
            // 
            // minBut
            // 
            this.minBut.Location = new System.Drawing.Point(1028, 12);
            this.minBut.Name = "minBut";
            this.minBut.Size = new System.Drawing.Size(75, 23);
            this.minBut.TabIndex = 7;
            this.minBut.Text = "button1";
            this.minBut.UseVisualStyleBackColor = true;
            // 
            // MaxBut
            // 
            this.MaxBut.Location = new System.Drawing.Point(1109, 12);
            this.MaxBut.Name = "MaxBut";
            this.MaxBut.Size = new System.Drawing.Size(75, 23);
            this.MaxBut.TabIndex = 8;
            this.MaxBut.Text = "button2";
            this.MaxBut.UseVisualStyleBackColor = true;
            // 
            // CloseBut
            // 
            this.CloseBut.Location = new System.Drawing.Point(1190, 12);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(75, 23);
            this.CloseBut.TabIndex = 9;
            this.CloseBut.Text = "button3";
            this.CloseBut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1277, 669);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.MaxBut);
            this.Controls.Add(this.minBut);
            this.Controls.Add(this.nextBut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.QuestionLabel);
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
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nextBut;
        private System.Windows.Forms.Button minBut;
        private System.Windows.Forms.Button MaxBut;
        private System.Windows.Forms.Button CloseBut;
    }
}

