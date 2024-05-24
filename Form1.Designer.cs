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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Go_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.forward_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.newTab_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(987, 377);
            this.tabControl1.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(14, 417);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(243, 22);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "https://www.google.com";
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // Go_btn
            // 
            this.Go_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Go_btn.Location = new System.Drawing.Point(263, 411);
            this.Go_btn.Name = "Go_btn";
            this.Go_btn.Size = new System.Drawing.Size(87, 35);
            this.Go_btn.TabIndex = 0;
            this.Go_btn.Text = "Go";
            this.Go_btn.UseVisualStyleBackColor = false;
            this.Go_btn.Click += new System.EventHandler(this.Go_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.back_btn.Location = new System.Drawing.Point(773, 402);
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
            this.forward_btn.Location = new System.Drawing.Point(812, 402);
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
            this.refresh_btn.Location = new System.Drawing.Point(851, 402);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(58, 44);
            this.refresh_btn.TabIndex = 6;
            this.refresh_btn.Text = "🔃";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // newTab_btn
            // 
            this.newTab_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTab_btn.ForeColor = System.Drawing.Color.Fuchsia;
            this.newTab_btn.Location = new System.Drawing.Point(732, 402);
            this.newTab_btn.Name = "newTab_btn";
            this.newTab_btn.Size = new System.Drawing.Size(35, 44);
            this.newTab_btn.TabIndex = 7;
            this.newTab_btn.Text = "+";
            this.newTab_btn.UseVisualStyleBackColor = true;
            this.newTab_btn.Click += new System.EventHandler(this.newTab_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 691);
            this.Controls.Add(this.newTab_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.forward_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.Go_btn);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button Go_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button forward_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button newTab_btn;
    }
}

