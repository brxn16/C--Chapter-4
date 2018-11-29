namespace WindowsFormsApp1
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
            this.lblDirections = new System.Windows.Forms.Label();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.btnFarenheit = new System.Windows.Forms.Button();
            this.lblConvert = new System.Windows.Forms.Label();
            this.lblTemp1 = new System.Windows.Forms.Label();
            this.lblTemp3 = new System.Windows.Forms.Label();
            this.lblTemp2 = new System.Windows.Forms.Label();
            this.txt8am = new System.Windows.Forms.TextBox();
            this.txt12pm = new System.Windows.Forms.TextBox();
            this.txt5pm = new System.Windows.Forms.TextBox();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.lblPlainAverage = new System.Windows.Forms.Label();
            this.lblAverageCelsius = new System.Windows.Forms.Label();
            this.lblAverageFaren = new System.Windows.Forms.Label();
            this.lblHotorCold1 = new System.Windows.Forms.Label();
            this.lblHotorCold2 = new System.Windows.Forms.Label();
            this.lblHotorCold3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.Location = new System.Drawing.Point(42, 38);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(206, 24);
            this.lblDirections.TabIndex = 0;
            this.lblDirections.Text = "Enter the temperatures ";
            // 
            // btnCelsius
            // 
            this.btnCelsius.Location = new System.Drawing.Point(259, 307);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(75, 23);
            this.btnCelsius.TabIndex = 1;
            this.btnCelsius.Text = "Celsius";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // btnFarenheit
            // 
            this.btnFarenheit.Location = new System.Drawing.Point(384, 307);
            this.btnFarenheit.Name = "btnFarenheit";
            this.btnFarenheit.Size = new System.Drawing.Size(75, 23);
            this.btnFarenheit.TabIndex = 2;
            this.btnFarenheit.Text = "Farenheit";
            this.btnFarenheit.UseVisualStyleBackColor = true;
            this.btnFarenheit.Click += new System.EventHandler(this.btnFarenheit_Click);
            // 
            // lblConvert
            // 
            this.lblConvert.AutoSize = true;
            this.lblConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvert.Location = new System.Drawing.Point(536, 38);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(230, 25);
            this.lblConvert.TabIndex = 3;
            this.lblConvert.Text = "Temperatures Converted";
            // 
            // lblTemp1
            // 
            this.lblTemp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTemp1.Location = new System.Drawing.Point(541, 100);
            this.lblTemp1.Name = "lblTemp1";
            this.lblTemp1.Size = new System.Drawing.Size(100, 20);
            this.lblTemp1.TabIndex = 4;
            // 
            // lblTemp3
            // 
            this.lblTemp3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTemp3.Location = new System.Drawing.Point(541, 211);
            this.lblTemp3.Name = "lblTemp3";
            this.lblTemp3.Size = new System.Drawing.Size(100, 20);
            this.lblTemp3.TabIndex = 5;
            // 
            // lblTemp2
            // 
            this.lblTemp2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTemp2.Location = new System.Drawing.Point(541, 154);
            this.lblTemp2.Name = "lblTemp2";
            this.lblTemp2.Size = new System.Drawing.Size(100, 20);
            this.lblTemp2.TabIndex = 6;
            // 
            // txt8am
            // 
            this.txt8am.Location = new System.Drawing.Point(45, 100);
            this.txt8am.Name = "txt8am";
            this.txt8am.Size = new System.Drawing.Size(100, 20);
            this.txt8am.TabIndex = 7;
            // 
            // txt12pm
            // 
            this.txt12pm.Location = new System.Drawing.Point(45, 154);
            this.txt12pm.Name = "txt12pm";
            this.txt12pm.Size = new System.Drawing.Size(100, 20);
            this.txt12pm.TabIndex = 8;
            // 
            // txt5pm
            // 
            this.txt5pm.Location = new System.Drawing.Point(45, 211);
            this.txt5pm.Name = "txt5pm";
            this.txt5pm.Size = new System.Drawing.Size(100, 20);
            this.txt5pm.TabIndex = 9;
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Location = new System.Drawing.Point(42, 84);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(30, 13);
            this.lblTime1.TabIndex = 10;
            this.lblTime1.Text = "5 am";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Location = new System.Drawing.Point(42, 138);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(36, 13);
            this.lblTime2.TabIndex = 11;
            this.lblTime2.Text = "12 pm";
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.Location = new System.Drawing.Point(45, 192);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(30, 13);
            this.lblTime3.TabIndex = 12;
            this.lblTime3.Text = "5 pm";
            // 
            // lblPlainAverage
            // 
            this.lblPlainAverage.AutoSize = true;
            this.lblPlainAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlainAverage.Location = new System.Drawing.Point(335, 339);
            this.lblPlainAverage.Name = "lblPlainAverage";
            this.lblPlainAverage.Size = new System.Drawing.Size(61, 17);
            this.lblPlainAverage.TabIndex = 13;
            this.lblPlainAverage.Text = "Average";
            // 
            // lblAverageCelsius
            // 
            this.lblAverageCelsius.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageCelsius.Location = new System.Drawing.Point(234, 365);
            this.lblAverageCelsius.Name = "lblAverageCelsius";
            this.lblAverageCelsius.Size = new System.Drawing.Size(100, 22);
            this.lblAverageCelsius.TabIndex = 14;
            // 
            // lblAverageFaren
            // 
            this.lblAverageFaren.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageFaren.Location = new System.Drawing.Point(384, 365);
            this.lblAverageFaren.Name = "lblAverageFaren";
            this.lblAverageFaren.Size = new System.Drawing.Size(100, 22);
            this.lblAverageFaren.TabIndex = 15;
            // 
            // lblHotorCold1
            // 
            this.lblHotorCold1.AutoSize = true;
            this.lblHotorCold1.Location = new System.Drawing.Point(648, 106);
            this.lblHotorCold1.Name = "lblHotorCold1";
            this.lblHotorCold1.Size = new System.Drawing.Size(0, 13);
            this.lblHotorCold1.TabIndex = 16;
            // 
            // lblHotorCold2
            // 
            this.lblHotorCold2.AutoSize = true;
            this.lblHotorCold2.Location = new System.Drawing.Point(648, 160);
            this.lblHotorCold2.Name = "lblHotorCold2";
            this.lblHotorCold2.Size = new System.Drawing.Size(0, 13);
            this.lblHotorCold2.TabIndex = 17;
            // 
            // lblHotorCold3
            // 
            this.lblHotorCold3.AutoSize = true;
            this.lblHotorCold3.Location = new System.Drawing.Point(648, 217);
            this.lblHotorCold3.Name = "lblHotorCold3";
            this.lblHotorCold3.Size = new System.Drawing.Size(0, 13);
            this.lblHotorCold3.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHotorCold3);
            this.Controls.Add(this.lblHotorCold2);
            this.Controls.Add(this.lblHotorCold1);
            this.Controls.Add(this.lblAverageFaren);
            this.Controls.Add(this.lblAverageCelsius);
            this.Controls.Add(this.lblPlainAverage);
            this.Controls.Add(this.lblTime3);
            this.Controls.Add(this.lblTime2);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.txt5pm);
            this.Controls.Add(this.txt12pm);
            this.Controls.Add(this.txt8am);
            this.Controls.Add(this.lblTemp2);
            this.Controls.Add(this.lblTemp3);
            this.Controls.Add(this.lblTemp1);
            this.Controls.Add(this.lblConvert);
            this.Controls.Add(this.btnFarenheit);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.lblDirections);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Button btnCelsius;
        private System.Windows.Forms.Button btnFarenheit;
        private System.Windows.Forms.Label lblConvert;
        private System.Windows.Forms.Label lblTemp1;
        private System.Windows.Forms.Label lblTemp3;
        private System.Windows.Forms.Label lblTemp2;
        private System.Windows.Forms.TextBox txt8am;
        private System.Windows.Forms.TextBox txt12pm;
        private System.Windows.Forms.TextBox txt5pm;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.Label lblPlainAverage;
        private System.Windows.Forms.Label lblAverageCelsius;
        private System.Windows.Forms.Label lblAverageFaren;
        private System.Windows.Forms.Label lblHotorCold1;
        private System.Windows.Forms.Label lblHotorCold2;
        private System.Windows.Forms.Label lblHotorCold3;
    }
}

