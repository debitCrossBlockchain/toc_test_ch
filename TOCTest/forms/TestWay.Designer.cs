namespace TOCTest.forms
{
    partial class TestWay
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
            this.m_btnTestOnline = new System.Windows.Forms.Button();
            this.m_btnOffline = new System.Windows.Forms.Button();
            this.m_btnSystemSuitabilityVerification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_btnTestOnline
            // 
            this.m_btnTestOnline.Location = new System.Drawing.Point(231, 67);
            this.m_btnTestOnline.Name = "m_btnTestOnline";
            this.m_btnTestOnline.Size = new System.Drawing.Size(178, 63);
            this.m_btnTestOnline.TabIndex = 0;
            this.m_btnTestOnline.Text = "在线测试";
            this.m_btnTestOnline.UseVisualStyleBackColor = true;
            this.m_btnTestOnline.Click += new System.EventHandler(this.m_btnTestOnline_Click);
            // 
            // m_btnOffline
            // 
            this.m_btnOffline.Location = new System.Drawing.Point(231, 172);
            this.m_btnOffline.Name = "m_btnOffline";
            this.m_btnOffline.Size = new System.Drawing.Size(178, 63);
            this.m_btnOffline.TabIndex = 1;
            this.m_btnOffline.Text = "离线测试";
            this.m_btnOffline.UseVisualStyleBackColor = true;
            this.m_btnOffline.Click += new System.EventHandler(this.m_btnOffline_Click);
            // 
            // m_btnSystemSuitabilityVerification
            // 
            this.m_btnSystemSuitabilityVerification.Location = new System.Drawing.Point(231, 280);
            this.m_btnSystemSuitabilityVerification.Name = "m_btnSystemSuitabilityVerification";
            this.m_btnSystemSuitabilityVerification.Size = new System.Drawing.Size(178, 63);
            this.m_btnSystemSuitabilityVerification.TabIndex = 2;
            this.m_btnSystemSuitabilityVerification.Text = "系统适应性验证";
            this.m_btnSystemSuitabilityVerification.UseVisualStyleBackColor = true;
            this.m_btnSystemSuitabilityVerification.Click += new System.EventHandler(this.m_btnSystemSuitabilityVerification_Click);
            // 
            // TestWay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 446);
            this.Controls.Add(this.m_btnSystemSuitabilityVerification);
            this.Controls.Add(this.m_btnOffline);
            this.Controls.Add(this.m_btnTestOnline);
            this.Name = "TestWay";
            this.Text = "TestWay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_btnTestOnline;
        private System.Windows.Forms.Button m_btnOffline;
        private System.Windows.Forms.Button m_btnSystemSuitabilityVerification;
    }
}