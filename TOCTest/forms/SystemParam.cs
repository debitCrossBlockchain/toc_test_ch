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
    public partial class SystemParam : Form
    {
        public SystemParam()
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
                string str = "FF" + "{0}" + "0x05" + "0x05" + "00";
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
                string str = "FF" + "{0}" + "0x13" + "0x08";
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
                str = str + m_strSampVmax + m_strSampTimer + m_strChannlSum + m_strLTests + m_strLForsake + m_strLCleartime + m_strTOCAlarmup + m_strUSAlarmup + m_strStorMode+"00";
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
            }
            catch (Exception ex)
            {
                TOCTest.utils.loghelp.log.Error(ex.Message, ex);
            }
        }
    }
}
