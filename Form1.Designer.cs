namespace SimpleWebBrowser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Go_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.forward_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1015, 494);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1015, 377);
            this.tabControl1.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(161, 383);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(230, 22);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "https://www.google.com";
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // Go_btn
            // 
            this.Go_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Go_btn.Location = new System.Drawing.Point(123, 411);
            this.Go_btn.Name = "Go_btn";
            this.Go_btn.Size = new System.Drawing.Size(268, 44);
            this.Go_btn.TabIndex = 0;
            this.Go_btn.Text = "New Tab";
            this.Go_btn.UseVisualStyleBackColor = false;
            this.Go_btn.Click += new System.EventHandler(this.Go_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.back_btn.Location = new System.Drawing.Point(397, 411);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(33, 44);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = "<";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // forward_btn
            // 
            this.forward_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.forward_btn.Location = new System.Drawing.Point(436, 411);
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.Size = new System.Drawing.Size(33, 44);
            this.forward_btn.TabIndex = 5;
            this.forward_btn.Text = ">";
            this.forward_btn.UseVisualStyleBackColor = false;
            this.forward_btn.Click += new System.EventHandler(this.forward_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.refresh_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.refresh_btn.Location = new System.Drawing.Point(475, 411);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(58, 44);
            this.refresh_btn.TabIndex = 6;
            this.refresh_btn.Text = "🔃";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 494);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.forward_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.Go_btn);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button Go_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button forward_btn;
        private System.Windows.Forms.Button refresh_btn;
    }
}

