﻿namespace TOCTest.forms
{
    partial class SystemSet
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
            this.m_btnRead = new System.Windows.Forms.Button();
            this.m_btnWrite = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.m_tbPumpPipe = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.m_tbUvLamp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.m_cbStorMode = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.m_tbUSAlarmup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_tbTOCAlarmup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m_tbLCleartime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.m_tbLForsake = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_tbLTests = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_tbChannlSum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_tbSampVmax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_btnRead
            // 
            this.m_btnRead.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_btnRead.Location = new System.Drawing.Point(444, 469);
            this.m_btnRead.Name = "m_btnRead";
            this.m_btnRead.Size = new System.Drawing.Size(111, 35);
            this.m_btnRead.TabIndex = 37;
            this.m_btnRead.Text = "读取";
            this.m_btnRead.UseVisualStyleBackColor = true;
            this.m_btnRead.Click += new System.EventHandler(this.m_btnRead_Click);
            // 
            // m_btnWrite
            // 
            this.m_btnWrite.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_btnWrite.Location = new System.Drawing.Point(616, 469);
            this.m_btnWrite.Name = "m_btnWrite";
            this.m_btnWrite.Size = new System.Drawing.Size(111, 35);
            this.m_btnWrite.TabIndex = 38;
            this.m_btnWrite.Text = "写入";
            this.m_btnWrite.UseVisualStyleBackColor = true;
            this.m_btnWrite.Click += new System.EventHandler(this.m_btnWrite_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.m_tbPumpPipe);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(769, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 92);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "泵管";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label13.Location = new System.Drawing.Point(264, 45);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 18);
            this.label13.TabIndex = 42;
            this.label13.Text = "%";
            // 
            // m_tbPumpPipe
            // 
            this.m_tbPumpPipe.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbPumpPipe.Location = new System.Drawing.Point(97, 39);
            this.m_tbPumpPipe.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbPumpPipe.Name = "m_tbPumpPipe";
            this.m_tbPumpPipe.Size = new System.Drawing.Size(163, 27);
            this.m_tbPumpPipe.TabIndex = 41;
            this.m_tbPumpPipe.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label14.Location = new System.Drawing.Point(26, 45);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 40;
            this.label14.Text = "使用率：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.m_tbUvLamp);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(769, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 92);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UV灯";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label12.Location = new System.Drawing.Point(264, 45);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 18);
            this.label12.TabIndex = 42;
            this.label12.Text = "天";
            // 
            // m_tbUvLamp
            // 
            this.m_tbUvLamp.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbUvLamp.Location = new System.Drawing.Point(83, 40);
            this.m_tbUvLamp.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbUvLamp.Name = "m_tbUvLamp";
            this.m_tbUvLamp.Size = new System.Drawing.Size(168, 27);
            this.m_tbUvLamp.TabIndex = 41;
            this.m_tbUvLamp.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label11.Location = new System.Drawing.Point(26, 45);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 40;
            this.label11.Text = "运行：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.m_cbStorMode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.m_tbUSAlarmup);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.m_tbTOCAlarmup);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.m_tbLCleartime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.m_tbLForsake);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.m_tbLTests);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m_tbChannlSum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m_tbSampVmax);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 377);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "系统参数";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(635, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 27);
            this.label19.TabIndex = 43;
            this.label19.Text = "us/cm";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(635, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 27);
            this.label18.TabIndex = 42;
            this.label18.Text = "mg/l";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(635, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 27);
            this.label17.TabIndex = 41;
            this.label17.Text = "s";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(284, 235);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 27);
            this.label16.TabIndex = 40;
            this.label16.Text = "次";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(284, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 27);
            this.label15.TabIndex = 39;
            this.label15.Text = "次";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(282, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 27);
            this.label10.TabIndex = 38;
            this.label10.Text = "ml/min";
            // 
            // m_cbStorMode
            // 
            this.m_cbStorMode.FormattingEnabled = true;
            this.m_cbStorMode.Items.AddRange(new object[] {
            "自动",
            "手动"});
            this.m_cbStorMode.Location = new System.Drawing.Point(513, 216);
            this.m_cbStorMode.Name = "m_cbStorMode";
            this.m_cbStorMode.Size = new System.Drawing.Size(74, 23);
            this.m_cbStorMode.TabIndex = 37;
            this.m_cbStorMode.Text = "自动";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label9.Location = new System.Drawing.Point(375, 221);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "数据存储方式：";
            // 
            // m_tbUSAlarmup
            // 
            this.m_tbUSAlarmup.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbUSAlarmup.Location = new System.Drawing.Point(513, 169);
            this.m_tbUSAlarmup.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbUSAlarmup.Name = "m_tbUSAlarmup";
            this.m_tbUSAlarmup.Size = new System.Drawing.Size(117, 27);
            this.m_tbUSAlarmup.TabIndex = 34;
            this.m_tbUSAlarmup.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label8.Location = new System.Drawing.Point(357, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 18);
            this.label8.TabIndex = 33;
            this.label8.Text = "电导率报警上限：";
            // 
            // m_tbTOCAlarmup
            // 
            this.m_tbTOCAlarmup.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbTOCAlarmup.Location = new System.Drawing.Point(513, 120);
            this.m_tbTOCAlarmup.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbTOCAlarmup.Name = "m_tbTOCAlarmup";
            this.m_tbTOCAlarmup.Size = new System.Drawing.Size(117, 27);
            this.m_tbTOCAlarmup.TabIndex = 32;
            this.m_tbTOCAlarmup.Text = "500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label7.Location = new System.Drawing.Point(384, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "TOC报警上限：";
            // 
            // m_tbLCleartime
            // 
            this.m_tbLCleartime.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbLCleartime.Location = new System.Drawing.Point(513, 71);
            this.m_tbLCleartime.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbLCleartime.Name = "m_tbLCleartime";
            this.m_tbLCleartime.Size = new System.Drawing.Size(117, 27);
            this.m_tbLCleartime.TabIndex = 30;
            this.m_tbLCleartime.Text = "30";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label6.Location = new System.Drawing.Point(375, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "离线冲洗时间：";
            // 
            // m_tbLForsake
            // 
            this.m_tbLForsake.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbLForsake.Location = new System.Drawing.Point(162, 227);
            this.m_tbLForsake.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbLForsake.Name = "m_tbLForsake";
            this.m_tbLForsake.Size = new System.Drawing.Size(115, 27);
            this.m_tbLForsake.TabIndex = 28;
            this.m_tbLForsake.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label5.Location = new System.Drawing.Point(24, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "离线抛弃次数：";
            // 
            // m_tbLTests
            // 
            this.m_tbLTests.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbLTests.Location = new System.Drawing.Point(162, 174);
            this.m_tbLTests.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbLTests.Name = "m_tbLTests";
            this.m_tbLTests.Size = new System.Drawing.Size(115, 27);
            this.m_tbLTests.TabIndex = 26;
            this.m_tbLTests.Text = "6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label4.Location = new System.Drawing.Point(60, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "离线次数：";
            // 
            // m_tbChannlSum
            // 
            this.m_tbChannlSum.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbChannlSum.Location = new System.Drawing.Point(162, 121);
            this.m_tbChannlSum.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbChannlSum.Name = "m_tbChannlSum";
            this.m_tbChannlSum.Size = new System.Drawing.Size(168, 27);
            this.m_tbChannlSum.TabIndex = 24;
            this.m_tbChannlSum.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label3.Location = new System.Drawing.Point(42, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "在线通道数：";
            // 
            // m_tbSampVmax
            // 
            this.m_tbSampVmax.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.m_tbSampVmax.Location = new System.Drawing.Point(162, 66);
            this.m_tbSampVmax.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbSampVmax.Name = "m_tbSampVmax";
            this.m_tbSampVmax.Size = new System.Drawing.Size(115, 27);
            this.m_tbSampVmax.TabIndex = 20;
            this.m_tbSampVmax.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "内部样品流速：";
            // 
            // SystemSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 685);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_btnWrite);
            this.Controls.Add(this.m_btnRead);
            this.Name = "SystemSet";
            this.Text = "SystemParam";
            this.Load += new System.EventHandler(this.SystemParam_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_btnRead;
        private System.Windows.Forms.Button m_btnWrite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox m_tbPumpPipe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox m_tbUvLamp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox m_cbStorMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox m_tbUSAlarmup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox m_tbTOCAlarmup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox m_tbLCleartime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_tbLForsake;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_tbLTests;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_tbChannlSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_tbSampVmax;
        private System.Windows.Forms.Label label1;
    }
}