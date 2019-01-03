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
    public partial class TestOfflineArgs : Form
    {
        public TestOfflineArgs()
        {
            InitializeComponent();
        }

        private void m_btnTestOfflineSet_Click(object sender, EventArgs e)
        {
            //测试参数的选择
            try
            {

                string strTime = TOCTest.utils.help.getDateTime();
                string Test_Ps = TOCTest.utils.help.converStringHex(strTime, 16);
                string Test_OpearName = TOCTest.utils.help.converStringHex(UserInfo.Instance.getUserName(), 16);
                string Test_DT = strTime;
                string Test_Bott_Amount = Convert.ToInt64(m_tbBottAmount.Text).ToString("X2");
                string Test_Start_Bott = Convert.ToInt64(m_tbStartBott.Text).ToString("X2");
                string Test_Dilu_Mult = Convert.ToInt64(m_tbDiluMult.Text).ToString("X2");
                string str = "FF" + "{0}" + "0x00" + "0x33" + "0x43" + "0x01" + Test_Ps + Test_OpearName + Test_DT + Test_Bott_Amount + Test_Start_Bott + Test_Dilu_Mult + "00";
                str = string.Format(str, TOCTest.db.dbMrg.QueryDeviceNum(TOCTest.Main.ms_strDeviceName));
                byte[] byDate = TOCTest.utils.help.getCheckSum(str);
                TOCTest.utils.loghelp.log.Debug(string.Format("发送启动测试参数数据{0}", TOCTest.utils.help.ByteToHexStr(byDate).ToString()));
                Main.ms_objMain.Test();
            }
            catch (Exception ex)
            {
                TOCTest.utils.loghelp.log.Error(ex.Message, ex);
            }
        }
    }
}
