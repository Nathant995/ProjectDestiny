namespace ProjectDestiny
{
    partial class Options
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
            this.btnOptionsBack = new System.Windows.Forms.Button();
            this.btnOptionsLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOptionsBack
            // 
            this.btnOptionsBack.Location = new System.Drawing.Point(12, 12);
            this.btnOptionsBack.Name = "btnOptionsBack";
            this.btnOptionsBack.Size = new System.Drawing.Size(28, 23);
            this.btnOptionsBack.TabIndex = 0;
            this.btnOptionsBack.Text = "<<";
            this.btnOptionsBack.UseVisualStyleBackColor = true;
            this.btnOptionsBack.Click += new System.EventHandler(this.btnOptionsBack_Click);
            // 
            // btnOptionsLogin
            // 
            this.btnOptionsLogin.Enabled = false;
            this.btnOptionsLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionsLogin.Location = new System.Drawing.Point(46, 12);
            this.btnOptionsLogin.Name = "btnOptionsLogin";
            this.btnOptionsLogin.Size = new System.Drawing.Size(43, 23);
            this.btnOptionsLogin.TabIndex = 1;
            this.btnOptionsLogin.Text = "Login";
            this.btnOptionsLogin.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 384);
            this.Controls.Add(this.btnOptionsLogin);
            this.Controls.Add(this.btnOptionsBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.Text = "Options";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOptionsBack;
        private System.Windows.Forms.Button btnOptionsLogin;
    }
}