namespace HurricaneGUI
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
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblSpeedEntered = new System.Windows.Forms.Label();
            this.btnHurricane = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(51, 52);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtSpeed.TabIndex = 0;
            // 
            // lblSpeedEntered
            // 
            this.lblSpeedEntered.AutoSize = true;
            this.lblSpeedEntered.Location = new System.Drawing.Point(48, 36);
            this.lblSpeedEntered.Name = "lblSpeedEntered";
            this.lblSpeedEntered.Size = new System.Drawing.Size(94, 13);
            this.lblSpeedEntered.TabIndex = 1;
            this.lblSpeedEntered.Text = "Enter Wind Speed";
            // 
            // btnHurricane
            // 
            this.btnHurricane.Location = new System.Drawing.Point(197, 50);
            this.btnHurricane.Name = "btnHurricane";
            this.btnHurricane.Size = new System.Drawing.Size(75, 23);
            this.btnHurricane.TabIndex = 2;
            this.btnHurricane.Text = "Calculate";
            this.btnHurricane.UseVisualStyleBackColor = true;
            this.btnHurricane.Click += new System.EventHandler(this.btnHurricane_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategory.Location = new System.Drawing.Point(308, 50);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 23);
            this.lblCategory.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 194);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnHurricane);
            this.Controls.Add(this.lblSpeedEntered);
            this.Controls.Add(this.txtSpeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label lblSpeedEntered;
        private System.Windows.Forms.Button btnHurricane;
        private System.Windows.Forms.Label lblCategory;
    }
}

