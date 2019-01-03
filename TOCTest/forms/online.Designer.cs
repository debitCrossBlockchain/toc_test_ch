namespace TOCTest.forms
{
    partial class online
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
            this.m_dataGridViewList = new System.Windows.Forms.DataGridView();
            this.m_reHList = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // m_dataGridViewList
            // 
            this.m_dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.m_dataGridViewList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.m_dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dataGridViewList.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_dataGridViewList.Location = new System.Drawing.Point(0, 0);
            this.m_dataGridViewList.Margin = new System.Windows.Forms.Padding(2);
            this.m_dataGridViewList.Name = "m_dataGridViewList";
            this.m_dataGridViewList.RowTemplate.Height = 33;
            this.m_dataGridViewList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_dataGridViewList.Size = new System.Drawing.Size(925, 304);
            this.m_dataGridViewList.TabIndex = 33;
            // 
            // m_reHList
            // 
            this.m_reHList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_reHList.Location = new System.Drawing.Point(0, 304);
            this.m_reHList.Name = "m_reHList";
            this.m_reHList.Size = new System.Drawing.Size(925, 311);
            this.m_reHList.TabIndex = 43;
            // 
            // online
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 615);
            this.Controls.Add(this.m_reHList);
            this.Controls.Add(this.m_dataGridViewList);
            this.Name = "online";
            this.Text = "online";
            this.Load += new System.EventHandler(this.online_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView m_dataGridViewList;
        private Microsoft.Reporting.WinForms.ReportViewer m_reHList;
    }
}