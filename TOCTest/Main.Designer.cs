namespace TOCTest
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MyPanel = new System.Windows.Forms.Panel();
            this.ToolStripMenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCommunication = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSystem = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.RssTreeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolDelDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateDevice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolDataViewMrg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTest = new System.Windows.Forms.ToolStripMenuItem();
            this.m_toolMenuSystemParam = new System.Windows.Forms.ToolStripMenuItem();
            this.m_toolMenuAlertMrg_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.timerMainStatus = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mStatusStrip = new System.Windows.Forms.StatusStrip();
            this.timerPollingInquiry = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.m_toolbtnSite = new System.Windows.Forms.ToolStripButton();
            this.m_toolbtnUserMrg = new System.Windows.Forms.ToolStripButton();
            this.m_toolbtnAlertMrg = new System.Windows.Forms.ToolStripButton();
            this.m_toolbtnSystemParam = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.m_toolbtnDataView = new System.Windows.Forms.ToolStripButton();
            this.m_toolbtnTest = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripSystem.SuspendLayout();
            this.panel2.SuspendLayout();
            this.CreateDevice.SuspendLayout();
            this.RightMenu.SuspendLayout();
            this.mStatusStrip.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyPanel
            // 
            this.MyPanel.BackColor = System.Drawing.Color.White;
            this.MyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyPanel.Location = new System.Drawing.Point(179, 0);
            this.MyPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MyPanel.MaximumSize = new System.Drawing.Size(1326, 713);
            this.MyPanel.Name = "MyPanel";
            this.MyPanel.Size = new System.Drawing.Size(1141, 588);
            this.MyPanel.TabIndex = 27;
            // 
            // ToolStripMenuItemQuit
            // 
            this.ToolStripMenuItemQuit.Name = "ToolStripMenuItemQuit";
            this.ToolStripMenuItemQuit.Size = new System.Drawing.Size(106, 22);
            this.ToolStripMenuItemQuit.Text = "退出";
            this.ToolStripMenuItemQuit.Click += new System.EventHandler(this.ToolStripMenuItemQuit_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCommunication});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // ToolStripMenuItemCommunication
            // 
            this.ToolStripMenuItemCommunication.Name = "ToolStripMenuItemCommunication";
            this.ToolStripMenuItemCommunication.Size = new System.Drawing.Size(106, 22);
            this.ToolStripMenuItemCommunication.Text = "通讯";
            this.ToolStripMenuItemCommunication.Click += new System.EventHandler(this.ToolStripMenuItemCommunication_Click);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemQuit});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // menuStripSystem
            // 
            this.menuStripSystem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStripSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStripSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStripSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStripSystem.Location = new System.Drawing.Point(0, 0);
            this.menuStripSystem.MaximumSize = new System.Drawing.Size(1600, 726);
            this.menuStripSystem.Name = "menuStripSystem";
            this.menuStripSystem.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStripSystem.Size = new System.Drawing.Size(1316, 29);
            this.menuStripSystem.TabIndex = 6;
            this.menuStripSystem.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAbout});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemAbout.Text = "关于";
            this.ToolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAbout_Click);
            // 
            // RssTreeView
            // 
            this.RssTreeView.BackColor = System.Drawing.SystemColors.Window;
            this.RssTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.RssTreeView.Font = new System.Drawing.Font("SimSun", 9F);
            this.RssTreeView.ForeColor = System.Drawing.SystemColors.MenuText;
            this.RssTreeView.HideSelection = false;
            this.RssTreeView.HotTracking = true;
            this.RssTreeView.ImageIndex = 5;
            this.RssTreeView.ImageList = this.imageList;
            this.RssTreeView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.RssTreeView.LineColor = System.Drawing.Color.Red;
            this.RssTreeView.Location = new System.Drawing.Point(0, 0);
            this.RssTreeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RssTreeView.MaximumSize = new System.Drawing.Size(179, 601);
            this.RssTreeView.MinimumSize = new System.Drawing.Size(179, 501);
            this.RssTreeView.Name = "RssTreeView";
            this.RssTreeView.SelectedImageIndex = 2;
            this.RssTreeView.Size = new System.Drawing.Size(179, 588);
            this.RssTreeView.TabIndex = 26;
            this.RssTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RssTreeView_MouseDown);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "auto.bmp");
            this.imageList.Images.SetKeyName(1, "BACKUP.BMP");
            this.imageList.Images.SetKeyName(2, "BFLY1.BMP");
            this.imageList.Images.SetKeyName(3, "bt.bmp");
            this.imageList.Images.SetKeyName(4, "Bubbles.bmp");
            this.imageList.Images.SetKeyName(5, "INSTALL.BMP");
            this.imageList.Images.SetKeyName(6, "JMMES.BMP");
            this.imageList.Images.SetKeyName(7, "SBubblepoint.BMP");
            this.imageList.Images.SetKeyName(8, "SETUP.BMP");
            this.imageList.Images.SetKeyName(9, "WRENCH.BMP");
            this.imageList.Images.SetKeyName(10, "Delete.png");
            this.imageList.Images.SetKeyName(11, "Edit.png");
            this.imageList.Images.SetKeyName(12, "NewBuild.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MyPanel);
            this.panel2.Controls.Add(this.RssTreeView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1320, 588);
            this.panel2.TabIndex = 32;
            // 
            // toolDelDevice
            // 
            this.toolDelDevice.Name = "toolDelDevice";
            this.toolDelDevice.Size = new System.Drawing.Size(138, 24);
            this.toolDelDevice.Text = "删除";
            this.toolDelDevice.Click += new System.EventHandler(this.toolDelDevice_Click);
            // 
            // CreateDevice
            // 
            this.CreateDevice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.CreateDevice.Name = "contextMenuStrip1";
            this.CreateDevice.Size = new System.Drawing.Size(109, 28);
            this.CreateDevice.Click += new System.EventHandler(this.CreateMouseLeft);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 24);
            this.toolStripMenuItem1.Text = "新建";
            // 
            // RightMenu
            // 
            this.RightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDelDevice,
            this.toolDataViewMrg,
            this.toolTest,
            this.m_toolMenuSystemParam,
            this.m_toolMenuAlertMrg_Click});
            this.RightMenu.Name = "CreateEdit";
            this.RightMenu.ShowCheckMargin = true;
            this.RightMenu.ShowImageMargin = false;
            this.RightMenu.Size = new System.Drawing.Size(139, 124);
            this.RightMenu.Click += new System.EventHandler(this.toolDataView_Click);
            // 
            // toolDataViewMrg
            // 
            this.toolDataViewMrg.Name = "toolDataViewMrg";
            this.toolDataViewMrg.Size = new System.Drawing.Size(138, 24);
            this.toolDataViewMrg.Text = "数据查看";
            this.toolDataViewMrg.Click += new System.EventHandler(this.toolDataView_Click);
            // 
            // toolTest
            // 
            this.toolTest.Name = "toolTest";
            this.toolTest.Size = new System.Drawing.Size(138, 24);
            this.toolTest.Text = "测试";
            this.toolTest.Click += new System.EventHandler(this.toolTest_Click);
            // 
            // m_toolMenuSystemParam
            // 
            this.m_toolMenuSystemParam.Name = "m_toolMenuSystemParam";
            this.m_toolMenuSystemParam.Size = new System.Drawing.Size(138, 24);
            this.m_toolMenuSystemParam.Text = "系统参数";
            this.m_toolMenuSystemParam.Click += new System.EventHandler(this.m_toolMenuSystemParam_Click);
            // 
            // m_toolMenuAlertMrg_Click
            // 
            this.m_toolMenuAlertMrg_Click.Name = "m_toolMenuAlertMrg_Click";
            this.m_toolMenuAlertMrg_Click.Size = new System.Drawing.Size(138, 24);
            this.m_toolMenuAlertMrg_Click.Text = "审计";
            this.m_toolMenuAlertMrg_Click.Click += new System.EventHandler(this.m_toolMenuAlertMrg_Click_Click);
            // 
            // timerMainStatus
            // 
            this.timerMainStatus.Tick += new System.EventHandler(this.timerMainStatus_Tick);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // MainToolStripStatusLabel
            // 
            this.MainToolStripStatusLabel.Name = "MainToolStripStatusLabel";
            this.MainToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // mStatusStrip
            // 
            this.mStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripStatusLabel,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.mStatusStrip.Location = new System.Drawing.Point(0, 672);
            this.mStatusStrip.Name = "mStatusStrip";
            this.mStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.mStatusStrip.Size = new System.Drawing.Size(1320, 22);
            this.mStatusStrip.TabIndex = 31;
            // 
            // timerPollingInquiry
            // 
            this.timerPollingInquiry.Interval = 120000;
            this.timerPollingInquiry.Tick += new System.EventHandler(this.timerPollingInquiry_Tick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.menuStripSystem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1320, 33);
            this.panel3.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 694);
            this.panel1.TabIndex = 33;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_toolbtnSite,
            this.m_toolbtnUserMrg,
            this.m_toolbtnAlertMrg,
            this.m_toolbtnSystemParam,
            this.toolStripSeparator2,
            this.m_toolbtnDataView,
            this.m_toolbtnTest,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1320, 73);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // m_toolbtnSite
            // 
            this.m_toolbtnSite.AutoSize = false;
            this.m_toolbtnSite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_toolbtnSite.BackgroundImage")));
            this.m_toolbtnSite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_toolbtnSite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_toolbtnSite.Name = "m_toolbtnSite";
            this.m_toolbtnSite.Size = new System.Drawing.Size(60, 50);
            this.m_toolbtnSite.Text = "站点管理";
            this.m_toolbtnSite.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.m_toolbtnSite.ToolTipText = "站点管理";
            this.m_toolbtnSite.Click += new System.EventHandler(this.m_toolbtnSite_Click);
            // 
            // m_toolbtnUserMrg
            // 
            this.m_toolbtnUserMrg.AutoSize = false;
            this.m_toolbtnUserMrg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_toolbtnUserMrg.BackgroundImage")));
            this.m_toolbtnUserMrg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_toolbtnUserMrg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_toolbtnUserMrg.Name = "m_toolbtnUserMrg";
            this.m_toolbtnUserMrg.Size = new System.Drawing.Size(60, 50);
            this.m_toolbtnUserMrg.Text = "用户管理";
            this.m_toolbtnUserMrg.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.m_toolbtnUserMrg.ToolTipText = "用户管理";
            this.m_toolbtnUserMrg.Click += new System.EventHandler(this.m_toolbtnUserMrg_Click);
            // 
            // m_toolbtnAlertMrg
            // 
            this.m_toolbtnAlertMrg.AutoSize = false;
            this.m_toolbtnAlertMrg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_toolbtnAlertMrg.BackgroundImage")));
            this.m_toolbtnAlertMrg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_toolbtnAlertMrg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_toolbtnAlertMrg.Name = "m_toolbtnAlertMrg";
            this.m_toolbtnAlertMrg.Size = new System.Drawing.Size(60, 50);
            this.m_toolbtnAlertMrg.Text = "审计追踪";
            this.m_toolbtnAlertMrg.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.m_toolbtnAlertMrg.ToolTipText = "审计追踪";
            this.m_toolbtnAlertMrg.Click += new System.EventHandler(this.m_toolbtnAlertMrg_Click);
            // 
            // m_toolbtnSystemParam
            // 
            this.m_toolbtnSystemParam.AutoSize = false;
            this.m_toolbtnSystemParam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_toolbtnSystemParam.BackgroundImage")));
            this.m_toolbtnSystemParam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_toolbtnSystemParam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_toolbtnSystemParam.Name = "m_toolbtnSystemParam";
            this.m_toolbtnSystemParam.Size = new System.Drawing.Size(60, 50);
            this.m_toolbtnSystemParam.Text = "系统参数";
            this.m_toolbtnSystemParam.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.m_toolbtnSystemParam.ToolTipText = "系统参数";
            this.m_toolbtnSystemParam.Click += new System.EventHandler(this.m_toolbtnSystemParam_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // m_toolbtnDataView
            // 
            this.m_toolbtnDataView.AutoSize = false;
            this.m_toolbtnDataView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_toolbtnDataView.BackgroundImage")));
            this.m_toolbtnDataView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_toolbtnDataView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_toolbtnDataView.Name = "m_toolbtnDataView";
            this.m_toolbtnDataView.Size = new System.Drawing.Size(60, 50);
            this.m_toolbtnDataView.Text = "数据查看";
            this.m_toolbtnDataView.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.m_toolbtnDataView.Click += new System.EventHandler(this.m_toolbtnDataView_Click);
            // 
            // m_toolbtnTest
            // 
            this.m_toolbtnTest.AutoSize = false;
            this.m_toolbtnTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_toolbtnTest.BackgroundImage")));
            this.m_toolbtnTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_toolbtnTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_toolbtnTest.Name = "m_toolbtnTest";
            this.m_toolbtnTest.Size = new System.Drawing.Size(60, 50);
            this.m_toolbtnTest.Text = "测 试";
            this.m_toolbtnTest.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.m_toolbtnTest.ToolTipText = "测试";
            this.m_toolbtnTest.Click += new System.EventHandler(this.m_toolbtnTest_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 73);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 694);
            this.Controls.Add(this.mStatusStrip);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(1326, 729);
            this.MinimumSize = new System.Drawing.Size(1326, 729);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStripSystem.ResumeLayout(false);
            this.menuStripSystem.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.CreateDevice.ResumeLayout(false);
            this.RightMenu.ResumeLayout(false);
            this.mStatusStrip.ResumeLayout(false);
            this.mStatusStrip.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MyPanel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuit;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCommunication;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripSystem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.TreeView RssTreeView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem toolDelDevice;
        private System.Windows.Forms.ContextMenuStrip CreateDevice;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip RightMenu;
        private System.Windows.Forms.ToolStripMenuItem toolDataViewMrg;
        private System.Windows.Forms.Timer timerMainStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel MainToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mStatusStrip;
        private System.Windows.Forms.Timer timerPollingInquiry;
        private System.Windows.Forms.ToolStripMenuItem toolTest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton m_toolbtnTest;
        private System.Windows.Forms.ToolStripButton m_toolbtnUserMrg;
        private System.Windows.Forms.ToolStripButton m_toolbtnAlertMrg;
        private System.Windows.Forms.ToolStripButton m_toolbtnSystemParam;
        private System.Windows.Forms.ToolStripButton m_toolbtnSite;
        private System.Windows.Forms.ToolStripButton m_toolbtnDataView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem m_toolMenuSystemParam;
        private System.Windows.Forms.ToolStripMenuItem m_toolMenuAlertMrg_Click;

    }
}

