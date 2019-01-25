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
            this.SuspendLayout();
            // 
            // userBut
            // 
            this.userBut.Location = new System.Drawing.Point(394, 104);
            this.userBut.Name = "userBut";
            this.userBut.Size = new System.Drawing.Size(75, 23);
            this.userBut.TabIndex = 0;
            this.userBut.Text = "Players";
            this.userBut.UseVisualStyleBackColor = true;
            // 
            // RegBut
            // 
            this.RegBut.Location = new System.Drawing.Point(581, 103);
            this.RegBut.Name = "RegBut";
            this.RegBut.Size = new System.Drawing.Size(75, 23);
            this.RegBut.TabIndex = 1;
            this.RegBut.Text = "Questionare ";
            this.RegBut.UseVisualStyleBackColor = true;
            this.RegBut.Click += new System.EventHandler(this.RegBut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Marks";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Winner";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 683);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RegBut);
            this.Controls.Add(this.userBut);
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
    }
}