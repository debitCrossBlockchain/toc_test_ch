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

namespace TOCTest.forms
{
    public partial class online : Form
    {
        public static List<OnlineResult> ms_objOnline = new List<OnlineResult>();
        public online()
        {
            InitializeComponent();
        }

        private void online_Load(object sender, EventArgs e)
        {
            ViewReport(DataViewMrg.ms_objOnlineResultEx.m_strTOC, DataViewMrg.ms_objOnlineResultEx.m_strIC,DataViewMrg.ms_objOnlineResultEx.m_strInterval);
            DataTable dtTOCline = new DataTable("ds2");
            dtTOCline.Columns.Add("DateTime", typeof(String));
            dtTOCline.Columns.Add("TOC(mg/L)", typeof(String));
            dtTOCline.Columns.Add("IC(mg/L)", typeof(String));
            foreach (OnlineResult obj in ms_objOnline)
            {
                DataRow dr = dtTOCline.NewRow();

                dr["TOC(mg/L)"] = obj.m_strTOC;
                dr["IC(mg/L)"] = obj.m_strIC;
                dr["DateTime"] = obj.m_dtInterval.ToString();
                dtTOCline.Rows.Add(dr);
            }
            m_dataGridViewList.DataSource = dtTOCline.DefaultView;
            m_dataGridViewList.AllowUserToAddRows = false;
        }


        private DataTable DealTOCView(string strTOCValue, string strICValue, string strTime)
        {
            ms_objOnline.Clear();
            DataTable dtTOC = new DataTable("ds2");
            dtTOC.Columns.Add("TOC", typeof(Int32));
            dtTOC.Columns.Add("Time", typeof(DateTime));
            strTOCValue = strTOCValue.Substring(0, strTOCValue.Length - 1);
            string[] strTOCList = strTOCValue.Split(',');
            string[] strICList = strICValue.Split(',');
            DateTime begin = help.GetDateTime(strTime);

            for (int i = 0; i < strTOCList.Length; i++)
            {
                DataRow dr = dtTOC.NewRow();
                if (strTOCList[i] == "")
                {
                    dr["TOC"] = 0;
                }
                else
                {
                    dr["TOC"] = Convert.ToInt64(strTOCList[i]);
                }

                dr["Time"] = begin;
                OnlineResult objOniline = new OnlineResult();
                objOniline.m_strTOC = strTOCList[i];
                objOniline.m_strIC = strICList[i];
                objOniline.m_dtInterval = begin;
                ms_objOnline.Add(objOniline);
                begin = begin.AddMinutes(10);
                dtTOC.Rows.Add(dr);
            }
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

        private void ViewReport(string strTOCValue, string strICValue, string strTime)
        {
            this.m_reHList.Reset();
            this.m_reHList.LocalReport.ReportEmbeddedResource = "TOCTest.rdlc.rdDataViewMrg.rdlc";
            m_reHList.LocalReport.DataSources.Clear();
            m_reHList.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetViewTOC", DealTOCView(strTOCValue, strICValue, strTime)));
            this.m_reHList.RefreshReport();
            // 设为 100% 
            this.m_reHList.ZoomPercent = 75;
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
