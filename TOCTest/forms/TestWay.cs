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
    public partial class TestWay : Form
    {
        public TestWay()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 在线测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnTestOnline_Click(object sender, EventArgs e)
        {
            try
            {
                string strTime = TOCTest.utils.help.getDateTime();
                string Test_Ps = TOCTest.utils.help.converStringHex(strTime, 16);
                string Test_OpearName = TOCTest.utils.help.converStringHex(UserInfo.Instance.getUserName(), 16);
                string Test_DT = strTime;
                string Test_Bott_Amount = (0).ToString("X2");
                string Test_Start_Bott = (0).ToString("X2");
                string Test_Dilu_Mult = (0).ToString("X2");
                string str = "FF" + "{0}" + "0x00"+"0x2F" + "0x02" + Test_Ps + Test_OpearName + Test_DT + Test_Bott_Amount + Test_Start_Bott + Test_Dilu_Mult + "00";
                str = string.Format(str, TOCTest.db.dbMrg.QueryDeviceNum(TOCTest.Main.ms_strDeviceName));
                byte[] byDate = TOCTest.utils.help.getCheckSum(str);
                TOCTest.utils.loghelp.log.Debug(string.Format("发送启动测试参数数据{0}", TOCTest.utils.help.ByteToHexStr(byDate).ToString()));
                Main.ms_objMain.Test();
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        /// <summary>
        /// 系统适应性验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnSystemSuitabilityVerification_Click(object sender, EventArgs e)
        {
            try
            {
                Main.ms_objMain.TestOfflineArgs();
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        /// <summary>
        /// 离线测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnOffline_Click(object sender, EventArgs e)
        {
            try
            {
                Main.ms_objMain.TestOfflineArgs();
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }
    }
}
