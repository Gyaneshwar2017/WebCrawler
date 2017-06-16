namespace WebCrawler
{
    partial class frmWebControl
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
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLoadWebSite = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnGetData);
            this.pnlButton.Controls.Add(this.btnLogin);
            this.pnlButton.Controls.Add(this.btnLoadWebSite);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButton.Location = new System.Drawing.Point(0, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(848, 59);
            this.pnlButton.TabIndex = 1;
            // 
            // btnGetData
            // 
            this.btnGetData.Enabled = false;
            this.btnGetData.Location = new System.Drawing.Point(348, 12);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(142, 32);
            this.btnGetData.TabIndex = 2;
            this.btnGetData.Text = "3. Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(185, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(142, 32);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "2. Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLoadWebSite
            // 
            this.btnLoadWebSite.Location = new System.Drawing.Point(23, 12);
            this.btnLoadWebSite.Name = "btnLoadWebSite";
            this.btnLoadWebSite.Size = new System.Drawing.Size(142, 32);
            this.btnLoadWebSite.TabIndex = 0;
            this.btnLoadWebSite.Text = "1. Load Website";
            this.btnLoadWebSite.UseVisualStyleBackColor = true;
            this.btnLoadWebSite.Click += new System.EventHandler(this.btnLoadWebSite_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 59);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(848, 427);
            this.webBrowser1.TabIndex = 2;
            // 
            // frmWebControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 486);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pnlButton);
            this.Name = "frmWebControl";
            this.Text = "frmWebControl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmWebControl_Load);
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLoadWebSite;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}