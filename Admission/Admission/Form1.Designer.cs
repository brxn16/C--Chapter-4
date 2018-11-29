namespace Admission
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
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txttestScore = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAcceptance = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.lblTestScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(12, 28);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(100, 20);
            this.txtGPA.TabIndex = 0;
            // 
            // txttestScore
            // 
            this.txttestScore.Location = new System.Drawing.Point(12, 76);
            this.txttestScore.Name = "txttestScore";
            this.txttestScore.Size = new System.Drawing.Size(100, 20);
            this.txttestScore.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Acceptance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAcceptance
            // 
            this.lblAcceptance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAcceptance.Location = new System.Drawing.Point(243, 51);
            this.lblAcceptance.Name = "lblAcceptance";
            this.lblAcceptance.Size = new System.Drawing.Size(127, 23);
            this.lblAcceptance.TabIndex = 3;
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(12, 13);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(29, 13);
            this.lblGPA.TabIndex = 4;
            this.lblGPA.Text = "GPA";
            // 
            // lblTestScore
            // 
            this.lblTestScore.AutoSize = true;
            this.lblTestScore.Location = new System.Drawing.Point(12, 60);
            this.lblTestScore.Name = "lblTestScore";
            this.lblTestScore.Size = new System.Drawing.Size(59, 13);
            this.lblTestScore.TabIndex = 5;
            this.lblTestScore.Text = "Test Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 274);
            this.Controls.Add(this.lblTestScore);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.lblAcceptance);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttestScore);
            this.Controls.Add(this.txtGPA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txttestScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAcceptance;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblTestScore;
    }
}

