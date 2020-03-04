using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Browser2 : Form
    {
        public Browser2()
        {
            InitializeComponent();
            comboBoxTopSearch.Items.Add("Page Setup");
            comboBoxTopSearch.Items.Add("Save As");
           // comboBoxTopSearch.Items.Add("History");
            comboBoxTopSearch.Items.Add("Print");
            comboBoxTopSearch.Items.Add("Print Preview");
            comboBoxTopSearch.Items.Add("Properties");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser3.GoBack();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnBack, "Go Back");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser3.GoHome();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnHome, "Go Home");
        }

        private void WebBrowser2(object sender, EventArgs e)
        {
           
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser3.GoForward();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnForward, "Go Forward");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            webBrowser3.Stop();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnClose, "Stop loding page");
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Browser browser = new Browser();
            browser.Show();
            this.Hide();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnHome, "Go Home");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser3.Refresh();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnRefresh, "Refresh");
        }

        private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        WebBrowser webTab = null;
        private void btnTab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = textBoxUrl.Text;
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("https://www.google.com");
            textBoxUrl.Text = "https://www.google.com";
            webTab.DocumentCompleted += webTab_DocumentCompleted;
            tabControl.SelectedTab.Text = webTab.DocumentTitle;

            

        }

        private void webTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webTab.DocumentTitle;   
            
        }

        private void Browser2_Load(object sender, EventArgs e)
        {
            webBrowser3.DocumentCompleted += webBrowser3_DocumentCompleted;
            //webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
            Assembly assembly = Assembly.GetExecutingAssembly();
            StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("Browser.GoogleCustomSearch.html"));
            webBrowser3.DocumentText = reader.ReadToEnd();


        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBoxUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                if(web != null)
                {
                    web.Navigate(textBoxUrl.Text);

                }
            }
        }

        private void webBrowser3_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser3_DocumentCompleted_2(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Browser browser = new Browser();
            browser.Show();
            this.Hide();
        }

        private void comboBoxTop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTopSearch.SelectedItem.Equals("Save As")){

                webBrowser3.ShowSaveAsDialog();


            }
            else if (comboBoxTopSearch.SelectedItem.Equals("Print"))
            {
                webBrowser3.ShowPrintDialog();
            }
            else if (comboBoxTopSearch.SelectedItem.Equals("Print Preview"))
            {
                webBrowser3.ShowPrintPreviewDialog();
            }
            else if (comboBoxTopSearch.SelectedItem.Equals("Page Setup"))
            {
                webBrowser3.ShowPageSetupDialog();
            }
            else if (comboBoxTopSearch.SelectedItem.Equals("Properties"))
            {
                webBrowser3.ShowPropertiesDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Browser browser = new Browser();
            browser.Show();
            browser.webBrowser1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
