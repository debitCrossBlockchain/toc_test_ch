using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOCTest.forms
{
    public partial class NewDevice : Form
    {

        private string DeviceNameId;

        public string m_DeviceNameId
        {
            get { return DeviceNameId; }
            set { DeviceNameId = value; }
        }

        public NewDevice()
        {
            InitializeComponent();
        }

        private void ConfirmTheConnected_Click(object sender, EventArgs e)
        {
            DeviceNameId = this.DeviceName.Text;
            if (!(string.IsNullOrEmpty(this.textBoxDeviceAddress.Text)) && !(string.IsNullOrEmpty(this.DeviceName.Text)))
            {
                TOCTest.db.dbMrg.AddDeviceTable(DeviceName.Text, textBoxDeviceAddress.Text, m_tbInfo.Text);  
            }
            this.Close();
        }


        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CCancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
