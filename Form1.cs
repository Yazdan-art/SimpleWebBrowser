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
        public Form1()
        {
            InitializeComponent();
            //InitializeChromium();
        }
        //private void InitializeChromium()
        //{
        //    CefSettings settings = new CefSettings();
        //    Cef.Initialize(settings);
        //    chromium = new ChromiumWebBrowser("https://www.google.com");
        //    this.Controls.Add(chromium);
        //    chromium.Dock = DockStyle.Fill;
        //}
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Update the address bar with the current URL
            txtAddress.Text = webBrowser1.Url.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            // Switch to the first tab
            tabControl1.SelectedIndex = 0;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            // Do nothing
        }

        private void Go_btn_Click(object sender, EventArgs e)
        {
            // Navigate to the URL entered in the TextBox
            //webBrowser1.Navigate(txtAddress.Text);

            // Create a new TabPage
            var tabPage = new TabPage();
            tabPage.Text = "New Tab";

            // Add the TabPage to the TabControl
            tabControl1.TabPages.Add(tabPage);

            // Add the WebBrowser control to the TabPage
            var webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            tabPage.Controls.Add(webBrowser);

            // Navigate to a URL
            webBrowser.Navigate(txtAddress.Text);

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            // Navigate back to the previous page
            webBrowser1.GoBack();
        }

        private void forward_btn_Click(object sender, EventArgs e)
        {
            // Navigate forward to the next page
            webBrowser1.GoForward();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            // Refresh the current page
            webBrowser1.Refresh();
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {
     // Switch to the third tab
            tabControl1.SelectedIndex = 1;
        }

    }
}