using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TOCTest.comm;
using TOCTest.utils;
using Microsoft.Reporting.WinForms;

namespace TOCTest.forms
{
    public partial class ViewOnlineReport : Form
    {
        public ViewOnlineReport()
        {
            InitializeComponent();
        }

        public static List<OnlineResult> ms_objOnline = new List<OnlineResult>();

        private void ViewOnlineReport_Load(object sender, EventArgs e)
        {
            ViewReport(DataViewMrg.ms_objOnlineResultEx.m_strTOC, DataViewMrg.ms_objOnlineResultEx.m_strIC, DataViewMrg.ms_objOnlineResultEx.m_strInterval, DataViewMrg.ms_objOnlineResultEx);
      
        }

        private DataTable DealTOCViewEX(OnlineResultEx objOnlineEx)
        {
            DataTable dtTOC = new DataTable("ds2"); 
            dtTOC.Columns.Add("TestNum", typeof(String));
            dtTOC.Columns.Add("TestDate", typeof(String));
            dtTOC.Columns.Add("DeviceName", typeof(String));
            dtTOC.Columns.Add("TestOperate", typeof(String));
            dtTOC.Columns.Add("ChannelSum", typeof(String));
            dtTOC.Columns.Add("TestTimes", typeof(String));
            DataRow dr = dtTOC.NewRow();

            dr["TestNum"] = objOnlineEx.m_strTestNum;
            dr["TestDate"] = objOnlineEx.m_strTestDate;
            dr["DeviceName"] = objOnlineEx.m_strDeviceName;
            dr["TestOperate"] = objOnlineEx.m_strTestOperate;
            dr["ChannelSum"] = objOnlineEx.m_strChannelSum;
            dr["TestTimes"] = objOnlineEx.m_strTestTimes;
            dtTOC.Rows.Add(dr);
            return dtTOC;
        }

        private string getData(string strInfo, Int64 nNum)
        {
            string strValue = "";
            try
            {
                strInfo = strInfo.Substring(0, strInfo.Length - 2);
                string[] strTOCList = strInfo.Split(',');

                if (strTOCList.Length != nNum)
                {
                    string strHex = string.Format("X{0}", nNum * 4);
                    strValue = (0).ToString(strHex);
                    return strValue;
                }

                for (int i = 0; i < strTOCList.Length; i++)
                {
                    strValue = strValue + Convert.ToInt64(strTOCList[i]).ToString("X8");
                }
            }
            catch (Exception)
            {
                string strHex = string.Format("X{0}", 300);
                strValue = (0).ToString(strHex);
                return strValue;
            }
            string strTempHex = string.Format("X{0}", 300 - nNum * 4);
            strValue = strValue + (0).ToString(strTempHex);
            return strValue;
        }

        private void ViewReport(string strTOCValue, string strICValue, string strTime,OnlineResultEx objOnlineEx)
        {
            try
            {
                this.m_reHList.Reset();
                this.m_reHList.LocalReport.ReportEmbeddedResource = "TOCTest.rdlc.rdOnlineReport.rdlc";
                this.m_reHList.LocalReport.DataSources.Clear();
                this.m_reHList.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetOnlineArgs", DealTOCViewEX(objOnlineEx)));
                this.m_reHList.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetViewTOC", DealTOCView(strTOCValue, strICValue, strTime)));
                this.m_reHList.RefreshReport();
                //// 将显示模式切换到打印布局模式
                //this.m_reHList.SetDisplayMode(DisplayMode.PrintLayout);
                // 将缩放模式设置为百分比
                this.m_reHList.ZoomMode = ZoomMode.Percent;

                // 设为 100% 
                this.m_reHList.ZoomPercent = 75;
               
              
             }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
            }
        }

        private DataTable DealTOCView(string strTOCValue, string strICValue, string strTime)
        {
            ms_objOnline.Clear();
            DataTable dtTOC = new DataTable("ds3");
            dtTOC.Columns.Add("TOC", typeof(Int64));
            dtTOC.Columns.Add("TOCView", typeof(String));
            dtTOC.Columns.Add("Time", typeof(DateTime));
            dtTOC.Columns.Add("Unit", typeof(String));
            strTOCValue = strTOCValue.Substring(0, strTOCValue.Length - 1);
            string[] strTOCList = strTOCValue.Split(',');
            string[] strICList = strICValue.Split(',');
            DateTime begin = help.GetDateTime(strTime).AddMinutes(10);

            for (int i = 0; i < strTOCList.Length; i++)
            {
                DataRow dr = dtTOC.NewRow();
                if (strTOCList[i] == "")
                {
                    dr["TOC"] = 0;
                    dr["TOCView"] = "0.000";
                }
                else
                {
                    dr["TOC"] = int.Parse(strTOCList[i]);
                    dr["TOCView"] = help.ConvertString2Double(strTOCList[i].ToString());
                }

                dr["Time"] = begin;
                OnlineResult objOniline = new OnlineResult();
                objOniline.m_strTOC = strTOCList[i];
                objOniline.m_strIC = strICList[i];
                objOniline.m_dtInterval = begin;
                ms_objOnline.Add(objOniline);
                begin = begin.AddMinutes(10);
                dr["Unit"] = " mg/L";
                dtTOC.Rows.Add(dr);
            }
            return dtTOC;
        }

        public void DisposeRes()
        {
            try
            {
                m_reHList.LocalReport.ReleaseSandboxAppDomain();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }
    }
}
