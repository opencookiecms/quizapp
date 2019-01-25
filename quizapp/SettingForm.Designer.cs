namespace quizapp
{
    partial class SettingForm
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
            this.userBut = new System.Windows.Forms.Button();
            this.RegBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttMin = new System.Windows.Forms.Button();
            this.buttMax = new System.Windows.Forms.Button();
            this.buttClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userBut
            // 
            this.userBut.BackColor = System.Drawing.Color.LightSeaGreen;
            this.userBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBut.Font = new System.Drawing.Font("Nightclub BTN", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userBut.Location = new System.Drawing.Point(528, 100);
            this.userBut.Name = "userBut";
            this.userBut.Size = new System.Drawing.Size(228, 183);
            this.userBut.TabIndex = 0;
            this.userBut.Text = "Players";
            this.userBut.UseVisualStyleBackColor = false;
            // 
            // RegBut
            // 
            this.RegBut.BackColor = System.Drawing.Color.Crimson;
            this.RegBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBut.Font = new System.Drawing.Font("Nightclub BTN", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegBut.Location = new System.Drawing.Point(36, 100);
            this.RegBut.Name = "RegBut";
            this.RegBut.Size = new System.Drawing.Size(228, 183);
            this.RegBut.TabIndex = 1;
            this.RegBut.Text = "Questionare ";
            this.RegBut.UseVisualStyleBackColor = false;
            this.RegBut.Click += new System.EventHandler(this.RegBut_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nightclub BTN", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(771, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 183);
            this.button1.TabIndex = 2;
            this.button1.Text = "Marks";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nightclub BTN", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(280, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 183);
            this.button2.TabIndex = 3;
            this.button2.Text = "Winner";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttMin
            // 
            this.buttMin.Location = new System.Drawing.Point(775, 12);
            this.buttMin.Name = "buttMin";
            this.buttMin.Size = new System.Drawing.Size(75, 23);
            this.buttMin.TabIndex = 4;
            this.buttMin.Text = "button3";
            this.buttMin.UseVisualStyleBackColor = true;
            // 
            // buttMax
            // 
            this.buttMax.Location = new System.Drawing.Point(856, 12);
            this.buttMax.Name = "buttMax";
            this.buttMax.Size = new System.Drawing.Size(75, 23);
            this.buttMax.TabIndex = 4;
            this.buttMax.Text = "button3";
            this.buttMax.UseVisualStyleBackColor = true;
            // 
            // buttClose
            // 
            this.buttClose.Location = new System.Drawing.Point(937, 12);
            this.buttClose.Name = "buttClose";
            this.buttClose.Size = new System.Drawing.Size(75, 23);
            this.buttClose.TabIndex = 4;
            this.buttClose.Text = "button3";
            this.buttClose.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1031, 359);
            this.Controls.Add(this.buttClose);
            this.Controls.Add(this.buttMax);
            this.Controls.Add(this.buttMin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RegBut);
            this.Controls.Add(this.userBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userBut;
        private System.Windows.Forms.Button RegBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttMin;
        private System.Windows.Forms.Button buttMax;
        private System.Windows.Forms.Button buttClose;
    }
}