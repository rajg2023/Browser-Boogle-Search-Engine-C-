using Google.Apis.Customsearch.v1;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Browser
{
    
    public partial class Browser : Form
    {
        
        public object Long { get; private set; }

        public Browser()
        {
            InitializeComponent();

            textBoxUrl.Text = "https://www.boogle.com.usa.fake.url.com/";
            comboxSearchPlatform.Items.Add("SEARCH PLATFORM");
            comboxSearchPlatform.Items.Add("ALL");
            comboxSearchPlatform.Items.Add("GOOGLE");
            comboxSearchPlatform.Items.Add("BING");
            comboxSearchPlatform.Items.Add("DUCKDUCKGO");
            comboxSearchPlatform.Items.Add("YOUTUBE");
            comboxSearchPlatform.Items.Add("WIKIPEDIA");




        }
        private void DisplayHtml(string html)

        {


            if (webBrowser1.Document != null)

            {

                webBrowser1.Document.Write(string.Empty);

            }

            webBrowser1.DocumentText = html;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Browser2 browser2 = new Browser2();
            browser2.tabControl.SelectedTab.Text = browser2.webBrowser3.DocumentTitle;
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Browser_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /******************change the windows form******************/
            Browser browser = new Browser();
            browser.Show();
            this.Hide();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            /******************change the windows form******************/
            Browser browser = new Browser();
            browser.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TimeSpan interval = new TimeSpan(0, 0, 2);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sleep for 2 seconds.");
                Thread.Sleep(interval);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            /******************change the windows form******************/
            Browser browser = new Browser();
            browser.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Browser2 browser2 = new Browser2();
            {
                browser2.Show();
                this.Hide();

            }
            
           

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           // const string apiKey = "AIzaSyAt8AkrmkiLVghrcKA3lFh37R79rSG0NsE";
           // const string cx = "003470263288780838160:ty47piyybua";
            string query = richTextBoxSearch.Text;

          
            Browser2 browser2 = new Browser2();
            WebBrowser web = browser2.tabControl.SelectedTab.Controls[0] as WebBrowser;
            textBoxUrl.Text = richTextBoxSearch.Text;
            String comboBoxItem = null;
            comboBoxItem = comboxSearchPlatform.SelectedItem.ToString();
            
            string urlGoogle = "https://www.google.com/search?q=" + richTextBoxSearch.Text;
            string urlBing = "https://www.bing.com/search?q=" + richTextBoxSearch.Text;
            string urlduckDuckGo = "https://duckduckgo.com/?q="+ richTextBoxSearch.Text;
            string urlyouTube = "https://www.youtube.com/search?q=" + richTextBoxSearch.Text;
            string urlWikipedia = "https://en.wikipedia.org/wiki/" + richTextBoxSearch.Text;
           // string urlAll = "file:///J:/Chrome%20Extension%20App/ChromeExtensionApplication/Browser/GoogleCustomSearch.html";

            if (comboxSearchPlatform.Text.Equals("SEARCH PLATFORM") && comboxSearchPlatform.SelectedIndex.Equals(0) && comboxSearchPlatform.SelectedItem.Equals(null))
            {
                MessageBox.Show("Please select something from search platform and continue AGAIN!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Show();

            }
            //if (richTextBoxSearch.Text != null && comboBoxItem.Equals("SEARCH PLATFORM"))
            //{

            //    //browser2.webBrowser3.Navigate(urlAll);
            //    //browser2.textBoxUrl.Text = urlAll;
            //    //this.Hide();

            //}
           else if (richTextBoxSearch.Text != null && comboBoxItem.Equals("ALL"))
            {
                browser2.Show();
                //  browser2.webBrowser3.Navigate(urlAll);
                //  browser2.textBoxUrl.Text = urlAll;
                this.Hide();

            }

            else if (richTextBoxSearch.Text != null && comboBoxItem.Equals("GOOGLE"))
            {
                browser2.Show();               
                browser2.webBrowser3.Navigate(urlGoogle);
                browser2.textBoxUrl.Text = urlGoogle;
                this.Hide();

            }
            else if ((richTextBoxSearch.Text != null && comboBoxItem.Equals("BING")))
            {
                browser2.Show();
                
                browser2.webBrowser3.Navigate(urlBing);
                browser2.textBoxUrl.Text = urlBing;
                this.Hide();
            }
            else if ((richTextBoxSearch.Text != null && comboBoxItem.Equals("DUCKDUCKGO")))
            {
                browser2.Show();
                
                browser2.webBrowser3.Navigate(urlduckDuckGo);
                browser2.textBoxUrl.Text = urlduckDuckGo;
                this.Hide();
            }
            else if ((richTextBoxSearch.Text != null && comboBoxItem.Equals("YOUTUBE")))
            {
                browser2.Show();
                
                browser2.webBrowser3.Navigate(urlyouTube);
                browser2.textBoxUrl.Text = urlyouTube;
                this.Hide();
            }
            else if ((richTextBoxSearch.Text != null && comboBoxItem.Equals("WIKIPEDIA")))
            {
                browser2.Show();
                browser2.webBrowser3.Navigate(urlWikipedia);
                browser2.textBoxUrl.Text = urlWikipedia;
                this.Hide();
            }

         
            //else if (richTextBoxSearch.Text == "BING")
            //{
            //    browser2.Show();
            //    browser2.webBrowser3.Navigate("https://www.bing.com/search?q=");
            //    this.Hide();

            //}

            //if (richTextBoxSearch.Text != null && comboxSearchPlatform.Items.Equals("BING"))
            //{
            //    browser2.Show();
            //    browser2.webBrowser3.Navigate("www.bing.com/search=" + richTextBoxSearch.Text);
            //    this.Hide();
            //}

        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            //webBrowser1.CanGoForwardChanged +=
            //new EventHandler(webBrowser1_CanGoForwardChanged);
            webBrowser1.GoForward();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnForward, "Go Forward");
        }

        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // webBrowser1.CanGoBackChanged +=
            //new EventHandler(webBrowser1_CanGoBackChanged);
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnBack, "Go Back");
        }

        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnClose, "Stop Loading page");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            //  this.Hide();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnHome, "Go Home");


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnRefresh, "Refresh");
        }

        private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {
            textBoxUrl.Text = "https://www.boogle.com.usa.fake.url.com/";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBoxSearch.Text = "";
            textBoxUrl.Text = " ";

        }

        private void richTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void webBrowser1_DocumentCompleted_2(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboxSearchPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    } 
}
