namespace TOCTest.forms
{
    partial class TestMrg
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
            this.m_cbTestMode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_tbTestPsernum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_tbOprationName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_tbBottAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_tbStartBott = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_tbDiluMult = new System.Windows.Forms.TextBox();
            this.m_btnStartParm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_rbAuto = new System.Windows.Forms.RadioButton();
            this.m_rbManual = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cbTestMode
            // 
            this.m_cbTestMode.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_cbTestMode.FormattingEnabled = true;
            this.m_cbTestMode.Items.AddRange(new object[] {
            "在线测试",
            "离线测试",
            "系统使用性",
            "零点校准"});
            this.m_cbTestMode.Location = new System.Drawing.Point(131, 20);
            this.m_cbTestMode.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbTestMode.Name = "m_cbTestMode";
            this.m_cbTestMode.Size = new System.Drawing.Size(111, 25);
            this.m_cbTestMode.TabIndex = 18;
            this.m_cbTestMode.Text = "在线测试";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label8.Location = new System.Drawing.Point(14, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "测试模式：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "测试序号：";
            // 
            // m_tbTestPsernum
            // 
            this.m_tbTestPsernum.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbTestPsernum.Location = new System.Drawing.Point(132, 69);
            this.m_tbTestPsernum.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbTestPsernum.Name = "m_tbTestPsernum";
            this.m_tbTestPsernum.Size = new System.Drawing.Size(98, 27);
            this.m_tbTestPsernum.TabIndex = 32;
            this.m_tbTestPsernum.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label2.Location = new System.Drawing.Point(15, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "操作人员：";
            // 
            // m_tbOprationName
            // 
            this.m_tbOprationName.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbOprationName.Location = new System.Drawing.Point(132, 126);
            this.m_tbOprationName.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbOprationName.Name = "m_tbOprationName";
            this.m_tbOprationName.Size = new System.Drawing.Size(98, 27);
            this.m_tbOprationName.TabIndex = 34;
            this.m_tbOprationName.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label3.Location = new System.Drawing.Point(44, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "瓶数：";
            // 
            // m_tbBottAmount
            // 
            this.m_tbBottAmount.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbBottAmount.Location = new System.Drawing.Point(132, 183);
            this.m_tbBottAmount.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbBottAmount.Name = "m_tbBottAmount";
            this.m_tbBottAmount.Size = new System.Drawing.Size(98, 27);
            this.m_tbBottAmount.TabIndex = 36;
            this.m_tbBottAmount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label4.Location = new System.Drawing.Point(11, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "起始瓶号：";
            // 
            // m_tbStartBott
            // 
            this.m_tbStartBott.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbStartBott.Location = new System.Drawing.Point(132, 237);
            this.m_tbStartBott.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbStartBott.Name = "m_tbStartBott";
            this.m_tbStartBott.Size = new System.Drawing.Size(98, 27);
            this.m_tbStartBott.TabIndex = 38;
            this.m_tbStartBott.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label5.Location = new System.Drawing.Point(11, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "稀释倍数：";
            // 
            // m_tbDiluMult
            // 
            this.m_tbDiluMult.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbDiluMult.Location = new System.Drawing.Point(132, 287);
            this.m_tbDiluMult.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbDiluMult.Name = "m_tbDiluMult";
            this.m_tbDiluMult.Size = new System.Drawing.Size(98, 27);
            this.m_tbDiluMult.TabIndex = 40;
            this.m_tbDiluMult.Text = "0";
            // 
            // m_btnStartParm
            // 
            this.m_btnStartParm.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_btnStartParm.Location = new System.Drawing.Point(33, 344);
            this.m_btnStartParm.Name = "m_btnStartParm";
            this.m_btnStartParm.Size = new System.Drawing.Size(80, 26);
            this.m_btnStartParm.TabIndex = 42;
            this.m_btnStartParm.Text = "启动";
            this.m_btnStartParm.UseVisualStyleBackColor = true;
            this.m_btnStartParm.Click += new System.EventHandler(this.m_btnStartParm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_rbManual);
            this.groupBox1.Controls.Add(this.m_rbAuto);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.groupBox1.Location = new System.Drawing.Point(336, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 84);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "取样方式";
            // 
            // m_rbAuto
            // 
            this.m_rbAuto.AutoSize = true;
            this.m_rbAuto.Location = new System.Drawing.Point(14, 39);
            this.m_rbAuto.Name = "m_rbAuto";
            this.m_rbAuto.Size = new System.Drawing.Size(65, 22);
            this.m_rbAuto.TabIndex = 44;
            this.m_rbAuto.TabStop = true;
            this.m_rbAuto.Text = "自动";
            this.m_rbAuto.UseVisualStyleBackColor = true;
            // 
            // m_rbManual
            // 
            this.m_rbManual.AutoSize = true;
            this.m_rbManual.Location = new System.Drawing.Point(142, 39);
            this.m_rbManual.Name = "m_rbManual";
            this.m_rbManual.Size = new System.Drawing.Size(65, 22);
            this.m_rbManual.TabIndex = 45;
            this.m_rbManual.TabStop = true;
            this.m_rbManual.Text = "手动";
            this.m_rbManual.UseVisualStyleBackColor = true;
            // 
            // TestMrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_btnStartParm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_tbDiluMult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_tbStartBott);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_tbBottAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_tbOprationName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_tbTestPsernum);
            this.Controls.Add(this.m_cbTestMode);
            this.Controls.Add(this.label8);
            this.Name = "TestMrg";
            this.Text = "TestParameter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox m_cbTestMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_tbTestPsernum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_tbOprationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_tbBottAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_tbStartBott;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_tbDiluMult;
        private System.Windows.Forms.Button m_btnStartParm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton m_rbManual;
        private System.Windows.Forms.RadioButton m_rbAuto;
    }
}