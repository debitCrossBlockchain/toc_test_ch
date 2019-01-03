namespace TOCTest.data
{
    partial class ExportDataView
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
            this.m_btnExportDataView = new System.Windows.Forms.Button();
            this.m_btnDataView = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewExportInfo = new System.Windows.Forms.DataGridView();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExportInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_btnExportDataView
            // 
            this.m_btnExportDataView.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnExportDataView.Location = new System.Drawing.Point(168, 14);
            this.m_btnExportDataView.Margin = new System.Windows.Forms.Padding(2);
            this.m_btnExportDataView.Name = "m_btnExportDataView";
            this.m_btnExportDataView.Size = new System.Drawing.Size(137, 26);
            this.m_btnExportDataView.TabIndex = 3;
            this.m_btnExportDataView.Text = "导出历史数据";
            this.m_btnExportDataView.UseVisualStyleBackColor = true;
            this.m_btnExportDataView.Click += new System.EventHandler(this.m_btnExportDataView_Click);
            // 
            // m_btnDataView
            // 
            this.m_btnDataView.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnDataView.Location = new System.Drawing.Point(16, 14);
            this.m_btnDataView.Margin = new System.Windows.Forms.Padding(2);
            this.m_btnDataView.Name = "m_btnDataView";
            this.m_btnDataView.Size = new System.Drawing.Size(147, 26);
            this.m_btnDataView.TabIndex = 2;
            this.m_btnDataView.Text = "刷新历史数据";
            this.m_btnDataView.UseVisualStyleBackColor = true;
            this.m_btnDataView.Click += new System.EventHandler(this.m_btnDataView_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewExportInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 372);
            this.panel2.TabIndex = 5;
            // 
            // dataGridViewExportInfo
            // 
            this.dataGridViewExportInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewExportInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExportInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExportInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewExportInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewExportInfo.Name = "dataGridViewExportInfo";
            this.dataGridViewExportInfo.RowTemplate.Height = 23;
            this.dataGridViewExportInfo.Size = new System.Drawing.Size(860, 372);
            this.dataGridViewExportInfo.TabIndex = 0;
            // 
            // saveFileDialogExport
            // 
            this.saveFileDialogExport.RestoreDirectory = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_btnExportDataView);
            this.panel1.Controls.Add(this.m_btnDataView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 372);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 51);
            this.panel1.TabIndex = 4;
            // 
            // ExportDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ExportDataView";
            this.Text = "ExportDataView";
            this.Load += new System.EventHandler(this.ExportDataView_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExportInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_btnExportDataView;
        private System.Windows.Forms.Button m_btnDataView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewExportInfo;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
        private System.Windows.Forms.Panel panel1;
    }
}