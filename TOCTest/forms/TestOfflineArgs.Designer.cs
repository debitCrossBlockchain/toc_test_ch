namespace TOCTest.forms
{
    partial class TestOfflineArgs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_rbManual = new System.Windows.Forms.RadioButton();
            this.m_rbAuto = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.m_tbDiluMult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_tbStartBott = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_tbBottAmount = new System.Windows.Forms.TextBox();
            this.m_btnTestOfflineSet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_rbManual);
            this.groupBox1.Controls.Add(this.m_rbAuto);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.groupBox1.Location = new System.Drawing.Point(166, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 84);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "取样方式";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label5.Location = new System.Drawing.Point(170, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "稀释倍数：";
            // 
            // m_tbDiluMult
            // 
            this.m_tbDiluMult.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbDiluMult.Location = new System.Drawing.Point(291, 149);
            this.m_tbDiluMult.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbDiluMult.Name = "m_tbDiluMult";
            this.m_tbDiluMult.Size = new System.Drawing.Size(98, 27);
            this.m_tbDiluMult.TabIndex = 52;
            this.m_tbDiluMult.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label4.Location = new System.Drawing.Point(170, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "起始瓶号：";
            // 
            // m_tbStartBott
            // 
            this.m_tbStartBott.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbStartBott.Location = new System.Drawing.Point(291, 99);
            this.m_tbStartBott.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbStartBott.Name = "m_tbStartBott";
            this.m_tbStartBott.Size = new System.Drawing.Size(98, 27);
            this.m_tbStartBott.TabIndex = 50;
            this.m_tbStartBott.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label3.Location = new System.Drawing.Point(203, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "瓶数：";
            // 
            // m_tbBottAmount
            // 
            this.m_tbBottAmount.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbBottAmount.Location = new System.Drawing.Point(291, 45);
            this.m_tbBottAmount.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbBottAmount.Name = "m_tbBottAmount";
            this.m_tbBottAmount.Size = new System.Drawing.Size(98, 27);
            this.m_tbBottAmount.TabIndex = 48;
            this.m_tbBottAmount.Text = "0";
            // 
            // m_btnTestOfflineSet
            // 
            this.m_btnTestOfflineSet.Location = new System.Drawing.Point(166, 312);
            this.m_btnTestOfflineSet.Name = "m_btnTestOfflineSet";
            this.m_btnTestOfflineSet.Size = new System.Drawing.Size(223, 63);
            this.m_btnTestOfflineSet.TabIndex = 55;
            this.m_btnTestOfflineSet.Text = "设置";
            this.m_btnTestOfflineSet.UseVisualStyleBackColor = true;
            this.m_btnTestOfflineSet.Click += new System.EventHandler(this.m_btnTestOfflineSet_Click);
            // 
            // TestOfflineArgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 434);
            this.Controls.Add(this.m_btnTestOfflineSet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_tbDiluMult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_tbStartBott);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_tbBottAmount);
            this.Name = "TestOfflineArgs";
            this.Text = "TestOfflineArgs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton m_rbManual;
        private System.Windows.Forms.RadioButton m_rbAuto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_tbDiluMult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_tbStartBott;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_tbBottAmount;
        private System.Windows.Forms.Button m_btnTestOfflineSet;
    }
}