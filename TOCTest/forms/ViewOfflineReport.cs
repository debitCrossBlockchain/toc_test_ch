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
    public partial class ViewOfflineReport : Form
    {
        public ViewOfflineReport()
        {
            InitializeComponent();
        }

        private DataTable DealTOCViewEX(OfflineResultEx objOfflineEx)
        {
            DataTable dtTOC = new DataTable("ds2");
            dtTOC.Columns.Add("deviceName", typeof(String));
            dtTOC.Columns.Add("groupName", typeof(String));
            dtTOC.Columns.Add("tester", typeof(String));
            dtTOC.Columns.Add("sampleQuantity", typeof(String));
            dtTOC.Columns.Add("testTime", typeof(String));
            dtTOC.Columns.Add("testTimes", typeof(String));
            dtTOC.Columns.Add("startBottle", typeof(String));
            dtTOC.Columns.Add("samples", typeof(String));
            dtTOC.Columns.Add("TOC", typeof(String));
            dtTOC.Columns.Add("IC", typeof(String));
            dtTOC.Columns.Add("Conductivity", typeof(String));
            dtTOC.Columns.Add("TOCAve", typeof(String));
            dtTOC.Columns.Add("ICAve", typeof(String));
            dtTOC.Columns.Add("CONAve", typeof(String));
            DataRow dr = dtTOC.NewRow();

            dr["deviceName"] = objOfflineEx.m_strDeviceName;
            dr["groupName"] = objOfflineEx.m_strCodeName;
            dr["tester"] = objOfflineEx.m_strTester;
            dr["sampleQuantity"] = objOfflineEx.m_strSampleWay;
            dr["testTime"] = objOfflineEx.m_strInterval;
            dr["testTimes"] = objOfflineEx.m_strTestTimes;
            dr["startBottle"] = objOfflineEx.m_strStartBottle;
            dr["samples"] = objOfflineEx.m_strSamples;
            dr["TOC"] = objOfflineEx.m_strTOC;
            dr["IC"] = objOfflineEx.m_strIC;
            dr["Conductivity"] = objOfflineEx.m_strCON;
            dr["TOCAve"] = objOfflineEx.m_strAveTOC;
            dr["ICAve"] = objOfflineEx.m_strAveIC;
            dr["CONAve"] = objOfflineEx.m_strAveCon;
            dtTOC.Rows.Add(dr);
            return dtTOC;
        }

        
        private void ViewReport(OfflineResultEx objOfflineEx)
        {
            try
            {
                this.m_reHList.Reset();
                this.m_reHList.LocalReport.ReportEmbeddedResource = "TOCTest.rdlc.rdOfflineReport.rdlc";
                m_reHList.LocalReport.DataSources.Clear();
                m_reHList.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetOfflineArgs", DealTOCViewEX(objOfflineEx)));
                this.m_reHList.RefreshReport();


                //// 将显示模式切换到打印布局模式
                this.m_reHList.SetDisplayMode(DisplayMode.PrintLayout);

                // 将缩放模式设置为百分比
                this.m_reHList.ZoomMode = ZoomMode.Percent;

                // 设为 100% 
                this.m_reHList.ZoomPercent = 35;
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
            }
        }

        private void ViewOfflineReport_Load(object sender, EventArgs e)
        {
            ViewReport(DataViewMrg.ms_objOfflineResultEx);
        }
    }
}
