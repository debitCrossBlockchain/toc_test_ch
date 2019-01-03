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
    public partial class ViewConReport : Form
    {
        public ViewConReport()
        {
            InitializeComponent();
        }

        private void ViewConReport_Load(object sender, EventArgs e)
        {
            ViewReport(DataViewMrg.ms_objConResultEx);
        }

        private DataTable DealTOCViewEX(ConResultEx objConEx)
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
            dtTOC.Columns.Add("ResponseRate", typeof(String));
            dtTOC.Columns.Add("Rw", typeof(String));
            dtTOC.Columns.Add("Rs", typeof(String));
            dtTOC.Columns.Add("Rss", typeof(String));
            dtTOC.Columns.Add("RwTOC", typeof(String));
            DataRow dr = dtTOC.NewRow();

            dr["deviceName"] = objConEx.m_strDeviceName;
            dr["groupName"] = objConEx.m_strCodeName;
            dr["tester"] = objConEx.m_strTester;
            dr["sampleQuantity"] = objConEx.m_strSampleWay;
            dr["testTime"] = objConEx.m_strInterval;
            dr["testTimes"] = objConEx.m_strTestTimes;
            dr["startBottle"] = objConEx.m_strStartBottle;
            dr["samples"] = objConEx.m_strSamples;
            dr["ResponseRate"] = objConEx.m_strResponseRate;
            dr["Rw"] = objConEx.m_strRw;
            dr["Rs"] = objConEx.m_strRs;
            dr["Rss"] = objConEx.m_strRss;
            dr["RwTOC"] = objConEx.m_strRwTOC;
            dtTOC.Rows.Add(dr);
            return dtTOC;
        }


        private void ViewReport(ConResultEx objConEx)
        {
            try
            {
                this.m_reHList.Reset();
                this.m_reHList.LocalReport.ReportEmbeddedResource = "TOCTest.rdlc.rdCON.rdlc";
                m_reHList.LocalReport.DataSources.Clear();
                m_reHList.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetConArgs", DealTOCViewEX(objConEx)));
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

      
    }
}
