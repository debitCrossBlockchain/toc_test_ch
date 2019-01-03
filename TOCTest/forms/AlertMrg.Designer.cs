namespace TOCTest.forms
{
    partial class AlertMrg
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
            this.label7 = new System.Windows.Forms.Label();
            this.tbSerNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_btn_query = new System.Windows.Forms.Button();
            this.m_rev_alertMrg = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbUserInfo = new System.Windows.Forms.TextBox();
            this.dateTimePre = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbQueryWay = new System.Windows.Forms.ComboBox();
            this.m_btnDel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_btnImport = new System.Windows.Forms.Button();
            this.m_btnExport = new System.Windows.Forms.Button();
            this.openFileDialogtxt = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 9F);
            this.label7.Location = new System.Drawing.Point(13, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "操作日期：";
            // 
            // tbSerNum
            // 
            this.tbSerNum.Font = new System.Drawing.Font("SimSun", 9F);
            this.tbSerNum.Location = new System.Drawing.Point(99, 149);
            this.tbSerNum.Margin = new System.Windows.Forms.Padding(2);
            this.tbSerNum.Name = "tbSerNum";
            this.tbSerNum.Size = new System.Drawing.Size(165, 25);
            this.tbSerNum.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F);
            this.label1.Location = new System.Drawing.Point(13, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "仪器编号：";
            // 
            // m_btn_query
            // 
            this.m_btn_query.Font = new System.Drawing.Font("SimSun", 9F);
            this.m_btn_query.Location = new System.Drawing.Point(99, 286);
            this.m_btn_query.Margin = new System.Windows.Forms.Padding(2);
            this.m_btn_query.Name = "m_btn_query";
            this.m_btn_query.Size = new System.Drawing.Size(165, 32);
            this.m_btn_query.TabIndex = 25;
            this.m_btn_query.Text = "查询";
            this.m_btn_query.UseVisualStyleBackColor = true;
            this.m_btn_query.Click += new System.EventHandler(this.m_btn_query_Click);
            // 
            // m_rev_alertMrg
            // 
            this.m_rev_alertMrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_rev_alertMrg.Location = new System.Drawing.Point(274, 0);
            this.m_rev_alertMrg.Margin = new System.Windows.Forms.Padding(2);
            this.m_rev_alertMrg.Name = "m_rev_alertMrg";
            this.m_rev_alertMrg.Size = new System.Drawing.Size(853, 425);
            this.m_rev_alertMrg.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbUserInfo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(274, 425);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(853, 126);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // tbUserInfo
            // 
            this.tbUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserInfo.Location = new System.Drawing.Point(2, 20);
            this.tbUserInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserInfo.Multiline = true;
            this.tbUserInfo.Name = "tbUserInfo";
            this.tbUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUserInfo.Size = new System.Drawing.Size(849, 104);
            this.tbUserInfo.TabIndex = 0;
            // 
            // dateTimePre
            // 
            this.dateTimePre.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePre.Font = new System.Drawing.Font("SimSun", 9F);
            this.dateTimePre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePre.Location = new System.Drawing.Point(99, 64);
            this.dateTimePre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateTimePre.Name = "dateTimePre";
            this.dateTimePre.ShowUpDown = true;
            this.dateTimePre.Size = new System.Drawing.Size(165, 25);
            this.dateTimePre.TabIndex = 36;
            this.dateTimePre.Value = new System.DateTime(2016, 11, 19, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F);
            this.label2.Location = new System.Drawing.Point(58, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "至：";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimeEnd.Font = new System.Drawing.Font("SimSun", 9F);
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(99, 105);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.ShowUpDown = true;
            this.dateTimeEnd.Size = new System.Drawing.Size(165, 25);
            this.dateTimeEnd.TabIndex = 38;
            this.dateTimeEnd.Value = new System.DateTime(2016, 11, 19, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F);
            this.label3.Location = new System.Drawing.Point(13, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "查询方式：";
            // 
            // cbQueryWay
            // 
            this.cbQueryWay.Font = new System.Drawing.Font("SimSun", 9F);
            this.cbQueryWay.FormattingEnabled = true;
            this.cbQueryWay.Items.AddRange(new object[] {
            "查询全部",
            "操作日期",
            "仪器编号"});
            this.cbQueryWay.Location = new System.Drawing.Point(99, 192);
            this.cbQueryWay.Margin = new System.Windows.Forms.Padding(2);
            this.cbQueryWay.Name = "cbQueryWay";
            this.cbQueryWay.Size = new System.Drawing.Size(165, 23);
            this.cbQueryWay.TabIndex = 40;
            this.cbQueryWay.Text = "查询全部";
            // 
            // m_btnDel
            // 
            this.m_btnDel.Font = new System.Drawing.Font("SimSun", 9F);
            this.m_btnDel.Location = new System.Drawing.Point(99, 238);
            this.m_btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.m_btnDel.Name = "m_btnDel";
            this.m_btnDel.Size = new System.Drawing.Size(165, 32);
            this.m_btnDel.TabIndex = 41;
            this.m_btnDel.Text = "清空数据";
            this.m_btnDel.UseVisualStyleBackColor = true;
            this.m_btnDel.Click += new System.EventHandler(this.m_btnDel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_btnImport);
            this.panel1.Controls.Add(this.m_btnExport);
            this.panel1.Controls.Add(this.m_btnDel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.m_btn_query);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 551);
            this.panel1.TabIndex = 42;
            // 
            // m_btnImport
            // 
            this.m_btnImport.Font = new System.Drawing.Font("SimSun", 9F);
            this.m_btnImport.Location = new System.Drawing.Point(99, 336);
            this.m_btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.m_btnImport.Name = "m_btnImport";
            this.m_btnImport.Size = new System.Drawing.Size(165, 32);
            this.m_btnImport.TabIndex = 43;
            this.m_btnImport.Text = "导入";
            this.m_btnImport.UseVisualStyleBackColor = true;
            this.m_btnImport.Click += new System.EventHandler(this.m_btnImport_Click);
            // 
            // m_btnExport
            // 
            this.m_btnExport.Font = new System.Drawing.Font("SimSun", 9F);
            this.m_btnExport.Location = new System.Drawing.Point(99, 384);
            this.m_btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.m_btnExport.Name = "m_btnExport";
            this.m_btnExport.Size = new System.Drawing.Size(165, 32);
            this.m_btnExport.TabIndex = 42;
            this.m_btnExport.Text = "导出";
            this.m_btnExport.UseVisualStyleBackColor = true;
            this.m_btnExport.Click += new System.EventHandler(this.m_btnExport_Click);
            // 
            // openFileDialogtxt
            // 
            this.openFileDialogtxt.FileName = "openFileDialogtxt";
            this.openFileDialogtxt.Multiselect = true;
            // 
            // AlertMrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 551);
            this.Controls.Add(this.m_rev_alertMrg);
            this.Controls.Add(this.cbQueryWay);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimePre);
            this.Controls.Add(this.tbSerNum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AlertMrg";
            this.Text = "AlertMrg";
            this.Load += new System.EventHandler(this.AlertMrg_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSerNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_btn_query;
        private Microsoft.Reporting.WinForms.ReportViewer m_rev_alertMrg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbUserInfo;
        private System.Windows.Forms.DateTimePicker dateTimePre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbQueryWay;
        private System.Windows.Forms.Button m_btnDel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button m_btnImport;
        private System.Windows.Forms.Button m_btnExport;
        private System.Windows.Forms.OpenFileDialog openFileDialogtxt;
    }
}