namespace DailySpecial
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
            this.lblSpecial = new System.Windows.Forms.Label();
            this.lblExample = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.Location = new System.Drawing.Point(268, 38);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(188, 13);
            this.lblSpecial.TabIndex = 0;
            this.lblSpecial.Text = "Enter a day number to see our special ";
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Location = new System.Drawing.Point(296, 79);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(124, 13);
            this.lblExample.TabIndex = 1;
            this.lblExample.Text = "For example, Sunday = 1";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(311, 110);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(88, 20);
            this.txtDay.TabIndex = 2;
            // 
            // btnSpecial
            // 
            this.btnSpecial.Location = new System.Drawing.Point(311, 158);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(88, 23);
            this.btnSpecial.TabIndex = 3;
            this.btnSpecial.Text = "Get Special";
            this.btnSpecial.UseVisualStyleBackColor = true;
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(309, 222);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSpecial);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.lblSpecial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Button btnSpecial;
        private System.Windows.Forms.Label lblOutput;
    }
}

