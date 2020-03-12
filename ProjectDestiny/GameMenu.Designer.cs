namespace ProjectDestiny
{
    partial class fmGameMenu
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
            this.btnMenuSP = new System.Windows.Forms.Button();
            this.btnMenuMP = new System.Windows.Forms.Button();
            this.btnMenuOptions = new System.Windows.Forms.Button();
            this.btnMenuQuit = new System.Windows.Forms.Button();
            this.llblAbout = new System.Windows.Forms.LinkLabel();
            this.lblGameMenuVer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMenuSP
            // 
            this.btnMenuSP.Location = new System.Drawing.Point(89, 79);
            this.btnMenuSP.Name = "btnMenuSP";
            this.btnMenuSP.Size = new System.Drawing.Size(175, 39);
            this.btnMenuSP.TabIndex = 0;
            this.btnMenuSP.Text = "Play Game";
            this.btnMenuSP.UseVisualStyleBackColor = true;
            this.btnMenuSP.Click += new System.EventHandler(this.btnMenuSP_Click);
            // 
            // btnMenuMP
            // 
            this.btnMenuMP.Enabled = false;
            this.btnMenuMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMP.Location = new System.Drawing.Point(89, 138);
            this.btnMenuMP.Name = "btnMenuMP";
            this.btnMenuMP.Size = new System.Drawing.Size(175, 39);
            this.btnMenuMP.TabIndex = 1;
            this.btnMenuMP.Text = "Live (Coming Soon)";
            this.btnMenuMP.UseVisualStyleBackColor = true;
            // 
            // btnMenuOptions
            // 
            this.btnMenuOptions.Location = new System.Drawing.Point(89, 201);
            this.btnMenuOptions.Name = "btnMenuOptions";
            this.btnMenuOptions.Size = new System.Drawing.Size(175, 39);
            this.btnMenuOptions.TabIndex = 2;
            this.btnMenuOptions.Text = "Options";
            this.btnMenuOptions.UseVisualStyleBackColor = true;
            this.btnMenuOptions.Click += new System.EventHandler(this.btnMenuOptions_Click);
            // 
            // btnMenuQuit
            // 
            this.btnMenuQuit.Location = new System.Drawing.Point(89, 259);
            this.btnMenuQuit.Name = "btnMenuQuit";
            this.btnMenuQuit.Size = new System.Drawing.Size(175, 39);
            this.btnMenuQuit.TabIndex = 3;
            this.btnMenuQuit.Text = "Quit";
            this.btnMenuQuit.UseVisualStyleBackColor = true;
            this.btnMenuQuit.Click += new System.EventHandler(this.btnMenuQuit_Click);
            // 
            // llblAbout
            // 
            this.llblAbout.AutoSize = true;
            this.llblAbout.Location = new System.Drawing.Point(152, 344);
            this.llblAbout.Name = "llblAbout";
            this.llblAbout.Size = new System.Drawing.Size(51, 13);
            this.llblAbout.TabIndex = 4;
            this.llblAbout.TabStop = true;
            this.llblAbout.Text = "About Us";
            this.llblAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAbout_LinkClicked);
            // 
            // lblGameMenuVer
            // 
            this.lblGameMenuVer.AutoSize = true;
            this.lblGameMenuVer.Location = new System.Drawing.Point(12, 362);
            this.lblGameMenuVer.Name = "lblGameMenuVer";
            this.lblGameMenuVer.Size = new System.Drawing.Size(49, 13);
            this.lblGameMenuVer.TabIndex = 5;
            this.lblGameMenuVer.Text = "#Version";
            // 
            // fmGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 384);
            this.ControlBox = false;
            this.Controls.Add(this.lblGameMenuVer);
            this.Controls.Add(this.llblAbout);
            this.Controls.Add(this.btnMenuQuit);
            this.Controls.Add(this.btnMenuOptions);
            this.Controls.Add(this.btnMenuMP);
            this.Controls.Add(this.btnMenuSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmGameMenu";
            this.Text = "Project Destiny - Menu";
            this.Load += new System.EventHandler(this.fmGameMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenuSP;
        private System.Windows.Forms.Button btnMenuMP;
        private System.Windows.Forms.Button btnMenuOptions;
        private System.Windows.Forms.Button btnMenuQuit;
        private System.Windows.Forms.LinkLabel llblAbout;
        private System.Windows.Forms.Label lblGameMenuVer;
    }
}

