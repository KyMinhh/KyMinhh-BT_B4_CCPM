namespace MyProject
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
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(290, 232);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(85, 20);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "UserName";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(390, 224);
            this.txtusername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(112, 26);
            this.txtusername.TabIndex = 1;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(390, 282);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(112, 26);
            this.txtmatkhau.TabIndex = 3;
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Location = new System.Drawing.Point(290, 290);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(77, 20);
            this.lblmatkhau.TabIndex = 2;
            this.lblmatkhau.Text = "Mật Khẩu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.lblmatkhau);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label lblmatkhau;
    }
}

