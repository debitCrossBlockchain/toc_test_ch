namespace TOCTest.forms
{
    partial class TestOnline
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_btnStop = new System.Windows.Forms.Button();
            this.m_btnStart = new System.Windows.Forms.Button();
            this.m_zgcTest = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_tabData = new System.Windows.Forms.TabControl();
            this.m_tabPageCurn = new System.Windows.Forms.TabPage();
            this.m_dataGridViewCur = new System.Windows.Forms.DataGridView();
            this.m_tabPageHistory = new System.Windows.Forms.TabPage();
            this.m_dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_tbUserInfo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.m_tabData.SuspendLayout();
            this.m_tabPageCurn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridViewCur)).BeginInit();
            this.m_tabPageHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridViewHistory)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 504);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_btnStop);
            this.panel2.Controls.Add(this.m_btnStart);
            this.panel2.Controls.Add(this.m_zgcTest);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 504);
            this.panel2.TabIndex = 20;
            // 
            // m_btnStop
            // 
            this.m_btnStop.Location = new System.Drawing.Point(87, 3);
            this.m_btnStop.Name = "m_btnStop";
            this.m_btnStop.Size = new System.Drawing.Size(76, 26);
            this.m_btnStop.TabIndex = 19;
            this.m_btnStop.Text = "停止";
            this.m_btnStop.UseVisualStyleBackColor = true;
            this.m_btnStop.Click += new System.EventHandler(this.m_btnStop_Click);
            // 
            // m_btnStart
            // 
            this.m_btnStart.Location = new System.Drawing.Point(5, 3);
            this.m_btnStart.Name = "m_btnStart";
            this.m_btnStart.Size = new System.Drawing.Size(76, 26);
            this.m_btnStart.TabIndex = 18;
            this.m_btnStart.Text = "启动";
            this.m_btnStart.UseVisualStyleBackColor = true;
            this.m_btnStart.Click += new System.EventHandler(this.m_btnStart_Click);
            // 
            // m_zgcTest
            // 
            this.m_zgcTest.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.m_zgcTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_zgcTest.Location = new System.Drawing.Point(0, 0);
            this.m_zgcTest.Margin = new System.Windows.Forms.Padding(4);
            this.m_zgcTest.Name = "m_zgcTest";
            this.m_zgcTest.ScrollGrace = 0D;
            this.m_zgcTest.ScrollMaxX = 110D;
            this.m_zgcTest.ScrollMaxY = 110D;
            this.m_zgcTest.ScrollMaxY2 = 0D;
            this.m_zgcTest.ScrollMinX = 0D;
            this.m_zgcTest.ScrollMinY = 0D;
            this.m_zgcTest.ScrollMinY2 = 0D;
            this.m_zgcTest.SelectModifierKeys = System.Windows.Forms.Keys.D0;
            this.m_zgcTest.Size = new System.Drawing.Size(749, 390);
            this.m_zgcTest.TabIndex = 0;
            this.m_zgcTest.ZoomButtons = System.Windows.Forms.MouseButtons.Right;
            this.m_zgcTest.ZoomButtons2 = System.Windows.Forms.MouseButtons.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_tabData);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(749, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(360, 390);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据窗口";
            // 
            // m_tabData
            // 
            this.m_tabData.Controls.Add(this.m_tabPageCurn);
            this.m_tabData.Controls.Add(this.m_tabPageHistory);
            this.m_tabData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tabData.Location = new System.Drawing.Point(2, 20);
            this.m_tabData.Margin = new System.Windows.Forms.Padding(2);
            this.m_tabData.Name = "m_tabData";
            this.m_tabData.SelectedIndex = 0;
            this.m_tabData.Size = new System.Drawing.Size(356, 368);
            this.m_tabData.TabIndex = 0;
            // 
            // m_tabPageCurn
            // 
            this.m_tabPageCurn.Controls.Add(this.m_dataGridViewCur);
            this.m_tabPageCurn.Location = new System.Drawing.Point(4, 25);
            this.m_tabPageCurn.Margin = new System.Windows.Forms.Padding(2);
            this.m_tabPageCurn.Name = "m_tabPageCurn";
            this.m_tabPageCurn.Padding = new System.Windows.Forms.Padding(2);
            this.m_tabPageCurn.Size = new System.Drawing.Size(348, 339);
            this.m_tabPageCurn.TabIndex = 0;
            this.m_tabPageCurn.Text = "当前测试";
            this.m_tabPageCurn.UseVisualStyleBackColor = true;
            // 
            // m_dataGridViewCur
            // 
            this.m_dataGridViewCur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dataGridViewCur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_dataGridViewCur.Location = new System.Drawing.Point(2, 2);
            this.m_dataGridViewCur.Margin = new System.Windows.Forms.Padding(2);
            this.m_dataGridViewCur.Name = "m_dataGridViewCur";
            this.m_dataGridViewCur.RowTemplate.Height = 33;
            this.m_dataGridViewCur.Size = new System.Drawing.Size(344, 335);
            this.m_dataGridViewCur.TabIndex = 1;
            // 
            // m_tabPageHistory
            // 
            this.m_tabPageHistory.Controls.Add(this.m_dataGridViewHistory);
            this.m_tabPageHistory.Location = new System.Drawing.Point(4, 25);
            this.m_tabPageHistory.Margin = new System.Windows.Forms.Padding(2);
            this.m_tabPageHistory.Name = "m_tabPageHistory";
            this.m_tabPageHistory.Padding = new System.Windows.Forms.Padding(2);
            this.m_tabPageHistory.Size = new System.Drawing.Size(348, 339);
            this.m_tabPageHistory.TabIndex = 1;
            this.m_tabPageHistory.Text = "历史纪录";
            this.m_tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // m_dataGridViewHistory
            // 
            this.m_dataGridViewHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.m_dataGridViewHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.m_dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dataGridViewHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_dataGridViewHistory.Location = new System.Drawing.Point(2, 2);
            this.m_dataGridViewHistory.Margin = new System.Windows.Forms.Padding(2);
            this.m_dataGridViewHistory.Name = "m_dataGridViewHistory";
            this.m_dataGridViewHistory.Size = new System.Drawing.Size(344, 335);
            this.m_dataGridViewHistory.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_tbUserInfo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 390);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1109, 114);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // m_tbUserInfo
            // 
            this.m_tbUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tbUserInfo.Location = new System.Drawing.Point(2, 20);
            this.m_tbUserInfo.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbUserInfo.Multiline = true;
            this.m_tbUserInfo.Name = "m_tbUserInfo";
            this.m_tbUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_tbUserInfo.Size = new System.Drawing.Size(1105, 92);
            this.m_tbUserInfo.TabIndex = 0;
            // 
            // TestOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 504);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TestOnline";
            this.Text = "0.";
            this.Load += new System.EventHandler(this.TestMrg_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.m_tabData.ResumeLayout(false);
            this.m_tabPageCurn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridViewCur)).EndInit();
            this.m_tabPageHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridViewHistory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ZedGraph.ZedGraphControl m_zgcTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl m_tabData;
        private System.Windows.Forms.TabPage m_tabPageCurn;
        private System.Windows.Forms.TabPage m_tabPageHistory;
        private System.Windows.Forms.DataGridView m_dataGridViewHistory;
        private System.Windows.Forms.DataGridView m_dataGridViewCur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox m_tbUserInfo;
        private System.Windows.Forms.Button m_btnStart;
        private System.Windows.Forms.Button m_btnStop;
        private System.Windows.Forms.Panel panel2;
    }
}