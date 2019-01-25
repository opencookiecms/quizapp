namespace quizapp
{
    partial class PortForm
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
            this.PortLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttCon = new System.Windows.Forms.Button();
            this.buttDis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(57, 43);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(57, 13);
            this.PortLabel.TabIndex = 0;
            this.PortLabel.Text = "Port Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Boutrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parity Bit";
            // 
            // buttCon
            // 
            this.buttCon.Location = new System.Drawing.Point(81, 132);
            this.buttCon.Name = "buttCon";
            this.buttCon.Size = new System.Drawing.Size(75, 23);
            this.buttCon.TabIndex = 3;
            this.buttCon.Text = "Connect";
            this.buttCon.UseVisualStyleBackColor = true;
            // 
            // buttDis
            // 
            this.buttDis.Location = new System.Drawing.Point(177, 132);
            this.buttDis.Name = "buttDis";
            this.buttDis.Size = new System.Drawing.Size(75, 23);
            this.buttDis.TabIndex = 4;
            this.buttDis.Text = "Disconnect";
            this.buttDis.UseVisualStyleBackColor = true;
            // 
            // PortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 321);
            this.Controls.Add(this.buttDis);
            this.Controls.Add(this.buttCon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortLabel);
            this.Name = "PortForm";
            this.Text = "PortForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttCon;
        private System.Windows.Forms.Button buttDis;
    }
}