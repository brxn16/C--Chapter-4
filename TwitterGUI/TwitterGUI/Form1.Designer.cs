namespace TwitterGUI
{
    partial class FormTwitter
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
            this.txtTwitterMasg = new System.Windows.Forms.TextBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.lblPostedMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTwitterMasg
            // 
            this.txtTwitterMasg.Location = new System.Drawing.Point(24, 12);
            this.txtTwitterMasg.Multiline = true;
            this.txtTwitterMasg.Name = "txtTwitterMasg";
            this.txtTwitterMasg.Size = new System.Drawing.Size(224, 93);
            this.txtTwitterMasg.TabIndex = 0;
            // 
            // lblCounter
            // 
            this.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCounter.Location = new System.Drawing.Point(74, 121);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(100, 23);
            this.lblCounter.TabIndex = 1;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPost.Location = new System.Drawing.Point(88, 164);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // lblPostedMsg
            // 
            this.lblPostedMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPostedMsg.Location = new System.Drawing.Point(74, 218);
            this.lblPostedMsg.Name = "lblPostedMsg";
            this.lblPostedMsg.Size = new System.Drawing.Size(100, 23);
            this.lblPostedMsg.TabIndex = 3;
            // 
            // FormTwitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 264);
            this.Controls.Add(this.lblPostedMsg);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.txtTwitterMasg);
            this.Name = "FormTwitter";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTwitterMasg;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label lblPostedMsg;
    }
}

