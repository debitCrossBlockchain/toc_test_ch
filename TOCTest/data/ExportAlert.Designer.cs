namespace TOCTest.data
{
    partial class ExportAlert
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewExportInfo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_btnExportAlert = new System.Windows.Forms.Button();
            this.m_btnAlert = new System.Windows.Forms.Button();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExportInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewExportInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 372);
            this.panel2.TabIndex = 3;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.m_btnExportAlert);
            this.panel1.Controls.Add(this.m_btnAlert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 372);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 51);
            this.panel1.TabIndex = 2;
            // 
            // m_btnExportAlert
            // 
            this.m_btnExportAlert.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnExportAlert.Location = new System.Drawing.Point(168, 14);
            this.m_btnExportAlert.Margin = new System.Windows.Forms.Padding(2);
            this.m_btnExportAlert.Name = "m_btnExportAlert";
            this.m_btnExportAlert.Size = new System.Drawing.Size(137, 26);
            this.m_btnExportAlert.TabIndex = 3;
            this.m_btnExportAlert.Text = "导出报警数据";
            this.m_btnExportAlert.UseVisualStyleBackColor = true;
            this.m_btnExportAlert.Click += new System.EventHandler(this.m_btnExportAlert_Click);
            // 
            // m_btnAlert
            // 
            this.m_btnAlert.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnAlert.Location = new System.Drawing.Point(16, 14);
            this.m_btnAlert.Margin = new System.Windows.Forms.Padding(2);
            this.m_btnAlert.Name = "m_btnAlert";
            this.m_btnAlert.Size = new System.Drawing.Size(147, 26);
            this.m_btnAlert.TabIndex = 2;
            this.m_btnAlert.Text = "刷新报警数据";
            this.m_btnAlert.UseVisualStyleBackColor = true;
            this.m_btnAlert.Click += new System.EventHandler(this.m_btnAlert_Click);
            // 
            // saveFileDialogExport
            // 
            this.saveFileDialogExport.RestoreDirectory = true;
            // 
            // ExportAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExportAlert";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.Export_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExportInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewExportInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
        private System.Windows.Forms.Button m_btnExportAlert;
        private System.Windows.Forms.Button m_btnAlert;
    }
}