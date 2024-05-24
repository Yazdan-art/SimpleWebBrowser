using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CefSharp.WinForms;


namespace SimpleWebBrowser
{
    public partial class Form1 : Form
    {
        WebBrowser webBrowser;
        public Form1()
        {
            InitializeComponent();
            newTab_btn.PerformClick(); // Open a new tab by default
        }
   
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtAddress.Text = webBrowser.Url.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            // Do nothing
        }

        private void Go_btn_Click(object sender, EventArgs e)
        {
           
            // Navigate to the URL entered in the TextBox
            webBrowser.Navigate(txtAddress.Text);

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void forward_btn_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void newTab_btn_Click(object sender, EventArgs e)
        {
            var tabPage = new TabPage();
            tabPage.Text = "New Tab";
            webBrowser = new WebBrowser();
            tabControl1.TabPages.Add(tabPage);
            webBrowser.Dock = DockStyle.Fill;
            tabPage.Controls.Add(webBrowser);


        }
    }
}