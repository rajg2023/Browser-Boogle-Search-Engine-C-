namespace Browser
{
    partial class Browser2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser2));
            this.comboBoxTopSearch = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnTab = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTopSearch
            // 
            this.comboBoxTopSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTopSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTopSearch.FormattingEnabled = true;
            this.comboBoxTopSearch.Location = new System.Drawing.Point(707, 2);
            this.comboBoxTopSearch.Name = "comboBoxTopSearch";
            this.comboBoxTopSearch.Size = new System.Drawing.Size(89, 24);
            this.comboBoxTopSearch.TabIndex = 21;
            this.comboBoxTopSearch.Text = "....";
            this.comboBoxTopSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxTop_SelectedIndexChanged);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(106, 3);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHome.Size = new System.Drawing.Size(32, 23);
            this.btnHome.TabIndex = 20;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRefresh.Location = new System.Drawing.Point(670, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 23);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "@";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnForward
            // 
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(36, 3);
            this.btnForward.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(32, 23);
            this.btnForward.TabIndex = 18;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(70, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(32, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(2, 3);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.Location = new System.Drawing.Point(142, 3);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxUrl.MaxLength = 0;
            this.textBoxUrl.Multiline = true;
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(524, 21);
            this.textBoxUrl.TabIndex = 15;
            this.textBoxUrl.Text = "https://";
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBoxUrl_TextChanged);
            this.textBoxUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUrl_KeyPress);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage);
            this.tabControl.Location = new System.Drawing.Point(2, 82);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(798, 370);
            this.tabControl.TabIndex = 22;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.label2);
            this.tabPage.Controls.Add(this.webBrowser3);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(790, 344);
            this.tabPage.TabIndex = 1;
            this.tabPage.Text = "Boogle";
            this.tabPage.Click += new System.EventHandler(this.tabPage_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "© Copyright 2020 Rajiv Giri @ Giri Consulting";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // webBrowser3
            // 
            this.webBrowser3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser3.Location = new System.Drawing.Point(3, 1);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.ScriptErrorsSuppressed = true;
            this.webBrowser3.Size = new System.Drawing.Size(784, 341);
            this.webBrowser3.TabIndex = 0;
            this.webBrowser3.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser3_DocumentCompleted_2);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Search Engine merged together to make the search easy for everyone :>)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.Font = new System.Drawing.Font("Colonna MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(215, 27);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.MaximumSize = new System.Drawing.Size(1980, 1080);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(359, 35);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BOOGLE SEARCH";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // btnTab
            // 
            this.btnTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTab.AutoSize = true;
            this.btnTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTab.Location = new System.Drawing.Point(727, 78);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(70, 25);
            this.btnTab.TabIndex = 1;
            this.btnTab.Text = "NEW TAB";
            this.btnTab.UseVisualStyleBackColor = true;
            this.btnTab.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // Browser2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.comboBoxTopSearch);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBoxUrl);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Browser2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boogle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Browser2_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTopSearch;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.TextBox textBoxUrl;
        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.Button btnTab;
        public System.Windows.Forms.TabPage tabPage;
        public System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
    }
}