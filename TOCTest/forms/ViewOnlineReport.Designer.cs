namespace TOCTest.forms
{
    partial class ViewOnlineReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.m_reHList = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // m_reHList
            // 
            this.m_reHList.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "DataSetCoords";
            reportDataSource2.Value = null;
            this.m_reHList.LocalReport.DataSources.Add(reportDataSource1);
            this.m_reHList.LocalReport.DataSources.Add(reportDataSource2);
            this.m_reHList.LocalReport.ReportEmbeddedResource = "SunManage.AllCheck.ReportReportViewer.rdlc";
            this.m_reHList.Location = new System.Drawing.Point(0, 0);
            this.m_reHList.Margin = new System.Windows.Forms.Padding(4);
            this.m_reHList.Name = "m_reHList";
            this.m_reHList.ShowZoomControl = false;
            this.m_reHList.Size = new System.Drawing.Size(742, 577);
            this.m_reHList.TabIndex = 2;
            // 
            // ViewOnlineReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 577);
            this.Controls.Add(this.m_reHList);
            this.Name = "ViewOnlineReport";
            this.Text = "在线测试报表";
            this.Load += new System.EventHandler(this.ViewOnlineReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer m_reHList;
    }
}