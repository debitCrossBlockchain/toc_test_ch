namespace TOCTest.forms
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.tBUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mBCancer = new System.Windows.Forms.Button();
            this.mBLogin = new System.Windows.Forms.Button();
            this.tBPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBUserName
            // 
            this.tBUserName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tBUserName.HideSelection = false;
            this.tBUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tBUserName.Location = new System.Drawing.Point(130, 72);
            this.tBUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBUserName.Name = "tBUserName";
            this.tBUserName.Size = new System.Drawing.Size(239, 25);
            this.tBUserName.TabIndex = 11;
            this.tBUserName.Text = "admin";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 10;
            this.label2.Tag = "";
            this.label2.Text = "用户名：";
            // 
            // mBCancer
            // 
            this.mBCancer.BackColor = System.Drawing.Color.Transparent;
            this.mBCancer.Location = new System.Drawing.Point(306, 183);
            this.mBCancer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mBCancer.Name = "mBCancer";
            this.mBCancer.Size = new System.Drawing.Size(97, 25);
            this.mBCancer.TabIndex = 9;
            this.mBCancer.Text = "取消";
            this.mBCancer.UseVisualStyleBackColor = false;
            this.mBCancer.Click += new System.EventHandler(this.mBCancer_Click);
            // 
            // mBLogin
            // 
            this.mBLogin.BackColor = System.Drawing.Color.Transparent;
            this.mBLogin.Location = new System.Drawing.Point(80, 183);
            this.mBLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mBLogin.Name = "mBLogin";
            this.mBLogin.Size = new System.Drawing.Size(97, 25);
            this.mBLogin.TabIndex = 8;
            this.mBLogin.Text = "登录";
            this.mBLogin.UseVisualStyleBackColor = false;
            this.mBLogin.Click += new System.EventHandler(this.mBLogin_Click);
            // 
            // tBPwd
            // 
            this.tBPwd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tBPwd.HideSelection = false;
            this.tBPwd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tBPwd.Location = new System.Drawing.Point(130, 121);
            this.tBPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBPwd.Name = "tBPwd";
            this.tBPwd.PasswordChar = '*';
            this.tBPwd.Size = new System.Drawing.Size(239, 25);
            this.tBPwd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(60, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 6;
            this.label1.Tag = "";
            this.label1.Text = "密码：";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 280);
            this.Controls.Add(this.tBUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mBCancer);
            this.Controls.Add(this.mBLogin);
            this.Controls.Add(this.tBPwd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.login_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mBCancer;
        private System.Windows.Forms.Button mBLogin;
        private System.Windows.Forms.TextBox tBPwd;
        private System.Windows.Forms.Label label1;
    }
}