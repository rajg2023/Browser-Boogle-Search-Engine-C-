namespace Browser
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.comboxSearchPlatform = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.richTextBoxSearch = new System.Windows.Forms.RichTextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(785, 501);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_2);
            // 
            // comboxSearchPlatform
            // 
            this.comboxSearchPlatform.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboxSearchPlatform.BackColor = System.Drawing.Color.Blue;
            this.comboxSearchPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxSearchPlatform.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboxSearchPlatform.FormattingEnabled = true;
            this.comboxSearchPlatform.Location = new System.Drawing.Point(485, 322);
            this.comboxSearchPlatform.Name = "comboxSearchPlatform";
            this.comboxSearchPlatform.Size = new System.Drawing.Size(190, 28);
            this.comboxSearchPlatform.TabIndex = 28;
            this.comboxSearchPlatform.Text = "SEARCH PLATFORM";
            this.comboxSearchPlatform.SelectedIndexChanged += new System.EventHandler(this.comboxSearchPlatform_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search Engine merged together to make the search easy for everyone :>)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(106, 2);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHome.Size = new System.Drawing.Size(32, 23);
            this.btnHome.TabIndex = 25;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRefresh.Location = new System.Drawing.Point(732, 1);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 23);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "@";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnForward
            // 
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(36, 2);
            this.btnForward.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(32, 23);
            this.btnForward.TabIndex = 23;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(70, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(32, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(2, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 23);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // richTextBoxSearch
            // 
            this.richTextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSearch.Location = new System.Drawing.Point(103, 256);
            this.richTextBoxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBoxSearch.Name = "richTextBoxSearch";
            this.richTextBoxSearch.Size = new System.Drawing.Size(570, 31);
            this.richTextBoxSearch.TabIndex = 20;
            this.richTextBoxSearch.Text = "";
            this.richTextBoxSearch.TextChanged += new System.EventHandler(this.richTextBoxSearch_TextChanged);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.Location = new System.Drawing.Point(142, 2);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxUrl.MaxLength = 0;
            this.textBoxUrl.Multiline = true;
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(586, 21);
            this.textBoxUrl.TabIndex = 19;
            this.textBoxUrl.Text = "https://";
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBoxUrl_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.Font = new System.Drawing.Font("Colonna MT", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(56, 122);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.MaximumSize = new System.Drawing.Size(1980, 1080);
            this.linkLabel1.MinimumSize = new System.Drawing.Size(100, 100);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(693, 120);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BOOGLE SEARCH";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(291, 320);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(168, 35);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(100, 320);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(168, 35);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "© Copyright 2020 Rajiv Giri @ Giri Consulting";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboxSearchPlatform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.richTextBoxSearch);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.webBrowser1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boogle ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Browser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox comboxSearchPlatform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox richTextBoxSearch;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
    }
}

