namespace TOCTest.forms
{
    partial class DataViewMrg
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
            this.m_btnQuery = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_cbTestMode = new System.Windows.Forms.ComboBox();
            this.m_btnDel = new System.Windows.Forms.Button();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePre = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.m_btnWrite = new System.Windows.Forms.Button();
            this.m_btnRead = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_btnView = new System.Windows.Forms.Button();
            this.m_btnDelS = new System.Windows.Forms.Button();
            this.m_btnExport = new System.Windows.Forms.Button();
            this.m_btnImport = new System.Windows.Forms.Button();
            this.openFileDialogtxt = new System.Windows.Forms.OpenFileDialog();
            this.m_dataGridViewList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // m_btnQuery
            // 
            this.m_btnQuery.Font = new System.Drawing.Font("SimSun", 9F);
            this.m_btnQuery.Location = new System.Drawing.Point(234, 3);
            this.m_btnQuery.Margin = new System.Windows.Forms.Padding(2);
            this.m_btnQuery.Name = "m_btnQuery";
            this.m_btnQuery.Size = new System.Drawing.Size(210, 30);
            this.m_btnQuery.TabIndex = 24;
            this.m_btnQuery.Text = "查询";
            this.m_btnQuery.UseVisualStyleBackColor = true;
            this.m_btnQuery.Click += new System.EventHandler(this.m_btnQuery_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 9F);
            this.label8.Location = new System.Drawing.Point(11, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "测试模式：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 9F);
            this.label7.Location = new System.Drawing.Point(11, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "创建日期：";
            this.label7.Visible = false;
            // 
            // m_cbTestMode
            // 
            this.m_cbTestMode.Font = new System.Drawing.Font("SimSun", 9F);
            this.m_cbTestMode.FormattingEnabled = true;
            this.m_cbTestMode.Items.AddRange(new object[] {
            "在线测试",
            "离线测试",
            "系统使用性",
            "零点校准"});
            this.m_cbTestMode.Location = new System.Drawing.Point(103, 7);
            this.m_cbTestMode.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbTestMode.Name = "m_cbTestMode";
            this.m_cbTestMode.Size = new System.Drawing.Size(111, 23);
            this.m_cbTestMode.TabIndex = 16;
            this.m_cbTestMode.Text = "在线测试";
            // 
            // m_btnDel
            // 
            this.m_btnDel.Font = new System.Drawing.Font("SimSun", 9F);
            this.m_btnDel.Location = new System.Drawing.Point(630, 2);
            this.m_btnDel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.m_btnDel.Name = "m_btnDel";
            this.m_btnDel.Size = new System.Drawing.Size(76, 31);
            this.m_btnDel.TabIndex = 30;
            this.m_btnDel.Text = "清空";
            this.m_btnDel.UseVisualStyleBackColor = true;
            this.m_btnDel.Click += new System.EventHandler(this.m_btnDel_Click);
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimeEnd.Font = new System.Drawing.Font("SimSun", 9F);
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(306, 48);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.ShowUpDown = true;
            this.dateTimeEnd.Size = new System.Drawing.Size(157, 25);
            this.dateTimeEnd.TabIndex = 40;
            this.dateTimeEnd.Value = new System.DateTime(2016, 11, 19, 0, 0, 0, 0);
            this.dateTimeEnd.Visible = false;
            // 
            // dateTimePre
            // 
            this.dateTimePre.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePre.Font = new System.Drawing.Font("SimSun", 9F);
            this.dateTimePre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePre.Location = new System.Drawing.Point(103, 48);
            this.dateTimePre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePre.Name = "dateTimePre";
            this.dateTimePre.ShowUpDown = true;
            this.dateTimePre.Size = new System.Drawing.Size(156, 25);
            this.dateTimePre.TabIndex = 39;
            this.dateTimePre.Value = new System.DateTime(2016, 11, 19, 0, 0, 0, 0);
            this.dateTimePre.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F);
            this.label2.Location = new System.Drawing.Point(267, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "---";
            this.label2.Visible = false;
            // 
            // m_btnWrite
            // 
            this.m_btnWrite.Font = new System.Drawing.Font("SimSun", 9F);
            this.m_btnWrite.Location = new System.Drawing.Point(545, 44);
            this.m_btnWrite.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.m_btnWrite.Name = "m_btnWrite";
            this.m_btnWrite.Size = new System.Drawing.Size(73, 31);
            this.m_btnWrite.TabIndex = 45;
            this.m_btnWrite.Text = "写入";
            this.m_btnWrite.UseVisualStyleBackColor = true;
            this.m_btnWrite.Visible = false;
            this.m_btnWrite.Click += new System.EventHandler(this.m_btnWrite_Click);
            // 
            // m_btnRead
            // 
            this.m_btnRead.Font = new System.Drawing.Font("SimSun", 9F);
            this.m_btnRead.Location = new System.Drawing.Point(630, 45);
            this.m_btnRead.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.m_btnRead.Name = "m_btnRead";
            this.m_btnRead.Size = new System.Drawing.Size(76, 31);
            this.m_btnRead.TabIndex = 44;
            this.m_btnRead.Text = "读取";
            this.m_btnRead.UseVisualStyleBackColor = true;
            this.m_btnRead.Visible = false;
            this.m_btnRead.Click += new System.EventHandler(this.m_btnRead_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_btnView);
            this.panel1.Controls.Add(this.m_btnDelS);
            this.panel1.Controls.Add(this.m_btnExport);
            this.panel1.Controls.Add(this.m_btnImport);
            this.panel1.Controls.Add(this.m_btnQuery);
            this.panel1.Controls.Add(this.m_btnWrite);
            this.panel1.Controls.Add(this.m_btnRead);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.m_cbTestMode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimeEnd);
            this.panel1.Controls.Add(this.dateTimePre);
            this.panel1.Controls.Add(this.m_btnDel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1127, 99);
            this.panel1.MinimumSize = new System.Drawing.Size(1127, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 99);
            this.panel1.TabIndex = 46;
            // 
            // m_btnView
            // 
            this.m_btnView.Font = new System.Drawing.Font("SimSun", 9F);
            this.m_btnView.Location = new System.Drawing.Point(454, 3);
            this.m_btnView.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.m_btnView.Name = "m_btnView";
            this.m_btnView.Size = new System.Drawing.Size(76, 31);
            this.m_btnView.TabIndex = 49;
            this.m_btnView.Text = "打印";
            this.m_btnView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.m_btnView.UseVisualStyleBackColor = true;
            this.m_btnView.Click += new System.EventHandler(this.m_btnView_Click);
            // 
            // m_btnDelS
            // 
            this.m_btnDelS.Font = new System.Drawing.Font("SimSun", 9F);
            this.m_btnDelS.Location = new System.Drawing.Point(718, 44);
            this.m_btnDelS.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.m_btnDelS.Name = "m_btnDelS";
            this.m_btnDelS.Size = new System.Drawing.Size(76, 31);
            this.m_btnDelS.TabIndex = 48;
            this.m_btnDelS.Text = "删除";
            this.m_btnDelS.UseVisualStyleBackColor = true;
            this.m_btnDelS.Visible = false;
            this.m_btnDelS.Click += new System.EventHandler(this.m_btnDelS_Click);
            // 
            // m_btnExport
            // 
            this.m_btnExport.Font = new System.Drawing.Font("SimSun", 9F);
            this.m_btnExport.Location = new System.Drawing.Point(545, 2);
            this.m_btnExport.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.m_btnExport.Name = "m_btnExport";
            this.m_btnExport.Size = new System.Drawing.Size(76, 31);
            this.m_btnExport.TabIndex = 47;
            this.m_btnExport.Text = "导出";
            this.m_btnExport.UseVisualStyleBackColor = true;
            this.m_btnExport.Click += new System.EventHandler(this.m_btnExport_Click);
            // 
            // m_btnImport
            // 
            this.m_btnImport.Font = new System.Drawing.Font("SimSun", 9F);
            this.m_btnImport.Location = new System.Drawing.Point(718, 2);
            this.m_btnImport.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.m_btnImport.Name = "m_btnImport";
            this.m_btnImport.Size = new System.Drawing.Size(76, 31);
            this.m_btnImport.TabIndex = 46;
            this.m_btnImport.Text = "导入";
            this.m_btnImport.UseVisualStyleBackColor = true;
            this.m_btnImport.Click += new System.EventHandler(this.m_btnImport_Click);
            // 
            // openFileDialogtxt
            // 
            this.openFileDialogtxt.FileName = "openFileDialogtxt";
            this.openFileDialogtxt.Multiselect = true;
            // 
            // m_dataGridViewList
            // 
            this.m_dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_dataGridViewList.Location = new System.Drawing.Point(0, 99);
            this.m_dataGridViewList.Margin = new System.Windows.Forms.Padding(2);
            this.m_dataGridViewList.Name = "m_dataGridViewList";
            this.m_dataGridViewList.RowTemplate.Height = 33;
            this.m_dataGridViewList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_dataGridViewList.Size = new System.Drawing.Size(1127, 481);
            this.m_dataGridViewList.TabIndex = 32;
            this.m_dataGridViewList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_dataGridViewList_CellDoubleClick);
            this.m_dataGridViewList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.m_dataGridViewList_RowsAdded);
            // 
            // DataViewMrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1127, 580);
            this.Controls.Add(this.m_dataGridViewList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1127, 580);
            this.Name = "DataViewMrg";
            this.Text = "DataView";
            this.Load += new System.EventHandler(this.DataView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_btnQuery;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox m_cbTestMode;
        private System.Windows.Forms.Button m_btnDel;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimePre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button m_btnWrite;
        private System.Windows.Forms.Button m_btnRead;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button m_btnExport;
        private System.Windows.Forms.Button m_btnImport;
        private System.Windows.Forms.OpenFileDialog openFileDialogtxt;
        private System.Windows.Forms.DataGridView m_dataGridViewList;
        private System.Windows.Forms.Button m_btnDelS;
        private System.Windows.Forms.Button m_btnView;

    }
}