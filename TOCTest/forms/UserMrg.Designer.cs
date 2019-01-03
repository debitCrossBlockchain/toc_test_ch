namespace TOCTest.forms
{
    partial class UserMrg
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
            this.buttonHistoricalAdd = new System.Windows.Forms.Button();
            this.buttonHistoricalEdit = new System.Windows.Forms.Button();
            this.buttonHistoricalDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSearchALLHis = new System.Windows.Forms.Button();
            this.dataGridViewUserInfo = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHistoricalAdd
            // 
            this.buttonHistoricalAdd.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.buttonHistoricalAdd.Location = new System.Drawing.Point(8, 422);
            this.buttonHistoricalAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHistoricalAdd.Name = "buttonHistoricalAdd";
            this.buttonHistoricalAdd.Size = new System.Drawing.Size(103, 27);
            this.buttonHistoricalAdd.TabIndex = 9;
            this.buttonHistoricalAdd.Text = "增加";
            this.buttonHistoricalAdd.UseVisualStyleBackColor = true;
            this.buttonHistoricalAdd.Click += new System.EventHandler(this.buttonHistoricalAdd_Click);
            // 
            // buttonHistoricalEdit
            // 
            this.buttonHistoricalEdit.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.buttonHistoricalEdit.Location = new System.Drawing.Point(120, 422);
            this.buttonHistoricalEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHistoricalEdit.Name = "buttonHistoricalEdit";
            this.buttonHistoricalEdit.Size = new System.Drawing.Size(103, 27);
            this.buttonHistoricalEdit.TabIndex = 10;
            this.buttonHistoricalEdit.Text = "编辑";
            this.buttonHistoricalEdit.UseVisualStyleBackColor = true;
            this.buttonHistoricalEdit.Click += new System.EventHandler(this.buttonHistoricalEdit_Click);
            // 
            // buttonHistoricalDelete
            // 
            this.buttonHistoricalDelete.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.buttonHistoricalDelete.Location = new System.Drawing.Point(230, 422);
            this.buttonHistoricalDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHistoricalDelete.Name = "buttonHistoricalDelete";
            this.buttonHistoricalDelete.Size = new System.Drawing.Size(103, 27);
            this.buttonHistoricalDelete.TabIndex = 11;
            this.buttonHistoricalDelete.Text = "删除";
            this.buttonHistoricalDelete.UseVisualStyleBackColor = true;
            this.buttonHistoricalDelete.Click += new System.EventHandler(this.buttonHistoricalDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewUserInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 381);
            this.panel2.TabIndex = 73;
            // 
            // buttonSearchALLHis
            // 
            this.buttonSearchALLHis.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.buttonSearchALLHis.Location = new System.Drawing.Point(341, 422);
            this.buttonSearchALLHis.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchALLHis.Name = "buttonSearchALLHis";
            this.buttonSearchALLHis.Size = new System.Drawing.Size(103, 27);
            this.buttonSearchALLHis.TabIndex = 14;
            this.buttonSearchALLHis.Text = "刷新";
            this.buttonSearchALLHis.UseVisualStyleBackColor = true;
            this.buttonSearchALLHis.Click += new System.EventHandler(this.buttonSearchALLHis_Click);
            // 
            // dataGridViewUserInfo
            // 
            this.dataGridViewUserInfo.AllowUserToOrderColumns = true;
            this.dataGridViewUserInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUserInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUserInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUserInfo.Name = "dataGridViewUserInfo";
            this.dataGridViewUserInfo.RowTemplate.Height = 23;
            this.dataGridViewUserInfo.Size = new System.Drawing.Size(1109, 381);
            this.dataGridViewUserInfo.TabIndex = 4;
            this.dataGridViewUserInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserInfo_CellDoubleClick);
            // 
            // UserMrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 504);
            this.Controls.Add(this.buttonSearchALLHis);
            this.Controls.Add(this.buttonHistoricalEdit);
            this.Controls.Add(this.buttonHistoricalAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonHistoricalDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserMrg";
            this.Text = "UserInfo";
            this.Load += new System.EventHandler(this.UserMrg_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHistoricalAdd;
        private System.Windows.Forms.Button buttonHistoricalEdit;
        private System.Windows.Forms.Button buttonHistoricalDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewUserInfo;
        private System.Windows.Forms.Button buttonSearchALLHis;

    }
}