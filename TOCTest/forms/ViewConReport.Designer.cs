namespace TOCTest.forms
{
    partial class ViewConReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.m_reHList = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // m_reHList
            // 
            this.m_reHList.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet";
            reportDataSource3.Value = null;
            reportDataSource4.Name = "DataSetCoords";
            reportDataSource4.Value = null;
            this.m_reHList.LocalReport.DataSources.Add(reportDataSource3);
            this.m_reHList.LocalReport.DataSources.Add(reportDataSource4);
            this.m_reHList.LocalReport.ReportEmbeddedResource = "SunManage.AllCheck.ReportReportViewer.rdlc";
            this.m_reHList.Location = new System.Drawing.Point(0, 0);
            this.m_reHList.Margin = new System.Windows.Forms.Padding(4);
            this.m_reHList.Name = "m_reHList";
            this.m_reHList.ShowZoomControl = false;
            this.m_reHList.Size = new System.Drawing.Size(692, 528);
            this.m_reHList.TabIndex = 4;
            // 
            // ViewConReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 528);
            this.Controls.Add(this.m_reHList);
            this.Name = "ViewConReport";
            this.Text = "系统适应性验证";
            this.Load += new System.EventHandler(this.ViewConReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer m_reHList;
    }
}