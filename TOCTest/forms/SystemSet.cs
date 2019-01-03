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
    public partial class SystemSet : Form
    {
        public SystemSet()
        {
            InitializeComponent();
            TOCTest.comm.protocol.ValueSystemArgs += OnStatusChanged;
        }

        // delegate used for Invoke
        internal delegate void SystemArgsDelegate(TOCTest.comm.SystemArgs data);
        /// <summary>
        /// Update the connection status
        /// </summary>
        public void OnStatusChanged(TOCTest.comm.SystemArgs data)
        {
            try
            {
                //Handle multi-threading
                if (InvokeRequired)
                {
                    Invoke(new SystemArgsDelegate(OnStatusChanged), new object[] { data });
                    return;
                }

                m_tbSampVmax.Text = data.m_strSampVmax;
                m_tbSampTimer.Text = data.m_strSampTimer;
                m_tbChannlSum.Text = data.m_strChannlSum;
                m_tbLTests.Text = data.m_strLTests;
                m_tbLForsake.Text = data.m_strLForsake;
                m_tbLCleartime.Text = data.m_strLCleartime;
                m_tbTOCAlarmup.Text = data.m_strTOCAlarmup;
                m_tbUSAlarmup.Text = data.m_strUSAlarmup;
                m_tbStorMode.Text = data.m_strStorMode;
                m_tbUvLamp.Text = data.m_strUvLamp;
                m_tbPumpPipe.Text = data.m_strPumpPipe;
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
            }
        }


        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                TOCTest.comm.CommPort objCommPort = TOCTest.comm.CommPort.Instance;
                string str = "FF" + "{0}" + "0x00" + "0x07" + "0x52" + "0x50" + "00";
                str = string.Format(str, TOCTest.db.dbMrg.QueryDeviceNum(TOCTest.Main.ms_strDeviceName));
                byte[] byDate = TOCTest.utils.help.getCheckSum(str);
                objCommPort.Send(byDate);
                TOCTest.utils.loghelp.log.Debug(string.Format("发送启动测试参数数据{0}", TOCTest.utils.help.ByteToHexStr(byDate).ToString()));
            }
            catch (Exception ex)
            {
                TOCTest.utils.loghelp.log.Error(ex.Message, ex);
            }
        }

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                TOCTest.comm.CommPort objCommPort = TOCTest.comm.CommPort.Instance;
                string str = "FF" + "{0}" + "0x00" + "0x19" + "0x57" + "0x50";
                string m_strSampVmax = Convert.ToInt64(m_tbSampVmax.Text).ToString("X4");       //内部样品流速
                string m_strSampTimer = Convert.ToInt64(m_tbSampTimer.Text).ToString("X4");      //在线采样周期
                string m_strChannlSum = Convert.ToInt64(m_tbChannlSum.Text).ToString("X2");     //在线通道数
                string m_strLTests = Convert.ToInt64(m_tbLTests.Text).ToString("X2");           //离线测试次数
                string m_strLForsake = Convert.ToInt64(m_tbLForsake.Text).ToString("X2");       //离线抛弃次数
                string m_strLCleartime = Convert.ToInt64(m_tbLCleartime.Text).ToString("X4");     //离线冲洗时间
                string m_strTOCAlarmup = Convert.ToInt64(m_tbTOCAlarmup.Text).ToString("X4");     //TOC报警上限
                string m_strUSAlarmup = Convert.ToInt64(m_tbUSAlarmup.Text).ToString("X4");      //电导率报警上限
                int nStorMode = TOCTest.utils.help.Asc(m_tbStorMode.Text);
                string m_strStorMode = nStorMode.ToString("X2"); ;       //数据存储方式
                string m_strUvLamp = Convert.ToInt64(m_tbUvLamp.Text).ToString("X4");
                string m_strPumpPipe = Convert.ToInt64(m_tbPumpPipe.Text).ToString("X4");
                str = str + m_strSampVmax + m_strSampTimer + m_strChannlSum + m_strLTests + m_strLForsake + m_strLCleartime + m_strTOCAlarmup + m_strUSAlarmup + m_strStorMode + m_strUvLamp + m_strPumpPipe + "00";
                str = string.Format(str, TOCTest.db.dbMrg.QueryDeviceNum(TOCTest.Main.ms_strDeviceName));
                byte[] byDate = TOCTest.utils.help.getCheckSum(str);
                objCommPort.Send(byDate);
                string strDBInfo = "Select * From {0} where [name]='" + Main.ms_strDeviceName.ToString() + "'";
                strDBInfo = string.Format(strDBInfo, Main.ms_strDeviceName.ToString());
                bool bExist = db.dbMrg.QueryExistDB("Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\SystemParameter.mdb", strDBInfo);
                if (!bExist)
                {
                    string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\SystemParameter.mdb";
                    string strInfo = String.Format("insert into {0} ([name],[SampVmax],[SampTimer],[ChannlSum],[LTests],[LForsake],[LCleartime],[TOCAlarmup],[USAlarmup],[StorMode],[UvLamp],[PumpPipe])values ('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
                        Main.ms_strDeviceName, Main.ms_strDeviceName, m_tbSampVmax.Text, m_tbSampTimer.Text, m_tbChannlSum.Text,
                        m_tbLTests.Text, m_tbLForsake.Text, m_tbLCleartime.Text, m_tbTOCAlarmup.Text, m_tbUSAlarmup.Text,
                        m_tbStorMode.Text, m_tbUvLamp.Text, m_tbPumpPipe.Text);
                    TOCTest.db.dbMrg.AlterDB(strConnection, strInfo);
                }
                else
                {
                    string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\SystemParameter.mdb";
                    string strInfo = "update {0} set [name]='" + "{1}" + "',[SampVmax]='" + "{2}" + "',[SampTimer]='" + "{3}" + "',[ChannlSum]='" + "{4}"
                        + "',[LTests]='" + "{5}" + "',[LForsake]='" + "{6}" + "',[LCleartime]='" + "{7}" + "',[TOCAlarmup]='" + "{8}"
                        + "',[USAlarmup]='" + "{9}" + "',[StorMode]='" + "{10}" + "',[UvLamp]='" + "{11}" + "',[PumpPipe]='" + "{12}"
                        + "' where [name]='" + Main.ms_strDeviceName + "'";
                    strInfo = string.Format(strInfo, Main.ms_strDeviceName, Main.ms_strDeviceName, m_tbSampVmax.Text, m_tbSampTimer.Text, m_tbChannlSum.Text,
                        m_tbLTests.Text, m_tbLForsake.Text, m_tbLCleartime.Text, m_tbTOCAlarmup.Text, m_tbUSAlarmup.Text,
                        m_tbStorMode.Text, m_tbUvLamp.Text, m_tbPumpPipe.Text);
                    TOCTest.db.dbMrg.AlterDB(strConnection, strInfo);
                }

                TOCTest.utils.loghelp.log.Debug(string.Format("发送启动测试参数数据{0}", TOCTest.utils.help.ByteToHexStr(byDate).ToString()));
            }
            catch (Exception ex)
            {
                TOCTest.utils.loghelp.log.Error(ex.Message, ex);
            }
        }

        private void SystemParam_Load(object sender, EventArgs e)
        {
            try
            {
                UserInfo objUserInfo = UserInfo.Instance;
                int nLevel = Convert.ToInt32(objUserInfo.getUserLevel());
                if (nLevel >= 4)
                {
                    this.Enabled = false;
                    MessageBox.Show("用户权限不足!");
                    return;
                }
                {
                    string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\SystemParameter.mdb";
                    string strDBInfo = "Select * From {0} where [name]='" + Main.ms_strDeviceName.ToString() + "'";
                    strDBInfo = string.Format(strDBInfo, Main.ms_strDeviceName.ToString());
                    List<string> listInfo = new List<string>();
                    listInfo = db.dbMrg.QueryDB(strConnection, strDBInfo, 13);
                    if (listInfo.Count > 0)
                    {
                        m_tbSampVmax.Text = listInfo[2];
                        m_tbSampTimer.Text = listInfo[3];
                        m_tbChannlSum.Text = listInfo[4];
                        m_tbLTests.Text = listInfo[5];
                        m_tbLForsake.Text = listInfo[6];
                        m_tbLCleartime.Text = listInfo[7];
                        m_tbTOCAlarmup.Text = listInfo[8];
                        m_tbUSAlarmup.Text = listInfo[9];
                        m_tbStorMode.Text = listInfo[10];
                        m_tbUvLamp.Text = listInfo[11];
                        m_tbPumpPipe.Text = listInfo[12];
                    }
                }
            }
            catch (Exception ex)
            {
                TOCTest.utils.loghelp.log.Error(ex.Message, ex);
            }
        }
    }
}
