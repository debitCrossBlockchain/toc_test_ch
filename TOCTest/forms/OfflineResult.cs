using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TOCTest.forms;
namespace TOCTest.forms
{
    public partial class OfflineResult : Form
    {
        public OfflineResult()
        {
            InitializeComponent();
        }

        private void OfflineResult_Load(object sender, EventArgs e)
        {
            m_tbTestTime.Text = DataViewMrg.ms_objOfflineResultEx.m_strInterval;
            m_tbGroupName.Text = DataViewMrg.ms_objOfflineResultEx.m_strCodeName;
            m_tbClass.Text = DataViewMrg.ms_objOfflineResultEx.m_strCodeType;
            m_tbTestWay.Text = DataViewMrg.ms_objOfflineResultEx.m_strSampleWay;
            int toc_length = DataViewMrg.ms_objOfflineResultEx.m_strAveTOC.Length-1;
            m_tbAveTOC.Text = DataViewMrg.ms_objOfflineResultEx.m_strAveTOC.Substring(0, toc_length);
            int ic_length = DataViewMrg.ms_objOfflineResultEx.m_strAveIC.Length - 1;
            m_tbAveIC.Text = DataViewMrg.ms_objOfflineResultEx.m_strAveIC.Substring(0, ic_length);
            DataTable dtTOC = new DataTable("ds2");
            dtTOC.Columns.Add("TOC(ug/L)", typeof(String));
            dtTOC.Columns.Add("IC(ug/L)", typeof(String));

            string[] strTOCList = DataViewMrg.ms_objOfflineResultEx.m_strTOC.Split(',');
            string[] strICList = DataViewMrg.ms_objOfflineResultEx.m_strIC.Split(',');
            for (int i = 0; i < strTOCList.Length; i++)
            {
                DataRow dr = dtTOC.NewRow();

                dr["TOC(ug/L)"] = strTOCList[i];
                dr["IC(ug/L)"] = strICList[i];
                dtTOC.Rows.Add(dr);
            }

            m_dataGridViewList.DataSource = dtTOC.DefaultView;
            m_dataGridViewList.AllowUserToAddRows = false;
        }
    }
}
