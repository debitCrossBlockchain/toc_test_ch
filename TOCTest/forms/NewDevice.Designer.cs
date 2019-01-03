namespace TOCTest.forms
{
    partial class NewDevice
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConfirmTheConnected = new System.Windows.Forms.Button();
            this.textBoxDeviceAddress = new System.Windows.Forms.TextBox();
            this.CCancer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DeviceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_tbInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_tbInfo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ConfirmTheConnected);
            this.panel1.Controls.Add(this.textBoxDeviceAddress);
            this.panel1.Controls.Add(this.CCancer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DeviceName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 267);
            this.panel1.TabIndex = 10;
            // 
            // ConfirmTheConnected
            // 
            this.ConfirmTheConnected.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmTheConnected.Location = new System.Drawing.Point(57, 179);
            this.ConfirmTheConnected.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmTheConnected.Name = "ConfirmTheConnected";
            this.ConfirmTheConnected.Size = new System.Drawing.Size(107, 34);
            this.ConfirmTheConnected.TabIndex = 6;
            this.ConfirmTheConnected.Text = "确定";
            this.ConfirmTheConnected.UseVisualStyleBackColor = true;
            this.ConfirmTheConnected.Click += new System.EventHandler(this.ConfirmTheConnected_Click);
            // 
            // textBoxDeviceAddress
            // 
            this.textBoxDeviceAddress.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxDeviceAddress.Location = new System.Drawing.Point(151, 53);
            this.textBoxDeviceAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDeviceAddress.Name = "textBoxDeviceAddress";
            this.textBoxDeviceAddress.Size = new System.Drawing.Size(285, 27);
            this.textBoxDeviceAddress.TabIndex = 7;
            // 
            // CCancer
            // 
            this.CCancer.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CCancer.Location = new System.Drawing.Point(329, 179);
            this.CCancer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CCancer.Name = "CCancer";
            this.CCancer.Size = new System.Drawing.Size(107, 34);
            this.CCancer.TabIndex = 7;
            this.CCancer.Text = "取消";
            this.CCancer.UseVisualStyleBackColor = true;
            this.CCancer.Click += new System.EventHandler(this.CCancer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(52, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "设备号：";
            // 
            // DeviceName
            // 
            this.DeviceName.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeviceName.Location = new System.Drawing.Point(151, 15);
            this.DeviceName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(285, 27);
            this.DeviceName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备名称：";
            // 
            // m_tbInfo
            // 
            this.m_tbInfo.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_tbInfo.Location = new System.Drawing.Point(151, 98);
            this.m_tbInfo.Margin = new System.Windows.Forms.Padding(4);
            this.m_tbInfo.Name = "m_tbInfo";
            this.m_tbInfo.Size = new System.Drawing.Size(285, 27);
            this.m_tbInfo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(52, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "备注：";
            // 
            // NewDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 266);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewDevice";
            this.Text = "NewDevice";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConfirmTheConnected;
        private System.Windows.Forms.TextBox textBoxDeviceAddress;
        private System.Windows.Forms.Button CCancer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DeviceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_tbInfo;
        private System.Windows.Forms.Label label2;
    }
}