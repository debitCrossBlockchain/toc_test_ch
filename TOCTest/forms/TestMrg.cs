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
    public partial class TestMrg : Form
    {
        public static byte[] ms_byDate;
        public static string ms_strTestType;

        public TestMrg()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 参数设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnStartParm_Click(object sender, EventArgs e)
        {
            //测试参数的选择
            try
            {
                string Test_type = "";
                switch (m_cbTestMode.SelectedIndex)
                {
                    case 0:
                        {
                            Test_type = "0x02";
                            ms_strTestType = "在线测试";
                            break;
                        }
                    case 1:
                        {
                            Test_type = "0x01";
                            ms_strTestType = "离线测试";
                            break;
                        }
                    case 2:
                        {
                           Test_type = "0x03";
                           ms_strTestType = "系统适应性验证";
                            break;
                        }
                    case 3:
                        {
                            Test_type = "C";
                            ms_strTestType = "零点校准";
                            break;
                        }
                    default:
                        break;
                }
                string Test_Ps = TOCTest.utils.help.converStringHex(m_tbTestPsernum.Text,16);
                string Test_OpearName = TOCTest.utils.help.converStringHex(m_tbOprationName.Text,16);
                string Test_DT = TOCTest.utils.help.getDateTime();
                string Test_Bott_Amount = Convert.ToInt64(m_tbBottAmount.Text).ToString("X2");
                string Test_Start_Bott = Convert.ToInt64(m_tbStartBott.Text).ToString("X2");
                string Test_Dilu_Mult = Convert.ToInt64(m_tbDiluMult.Text).ToString("X2");
                string str = "FF" + "{0}" +"0x00"+ "0x33"+"0x43"+Test_type + Test_Ps + Test_OpearName + Test_DT + Test_Bott_Amount + Test_Start_Bott + Test_Dilu_Mult + "00";
                str = string.Format(str,TOCTest.db.dbMrg.QueryDeviceNum(TOCTest.Main.ms_strDeviceName));
                byte[] byDate = TOCTest.utils.help.getCheckSum(str);
                ms_byDate = byDate;
                TOCTest.utils.loghelp.log.Debug(string.Format("发送启动测试参数数据{0}",TOCTest.utils.help.ByteToHexStr(byDate).ToString()));
                Main.ms_objMain.Test();
            }
            catch (Exception ex)
            {
                TOCTest.utils.loghelp.log.Error(ex.Message,ex);
            }
        }
    }
}
