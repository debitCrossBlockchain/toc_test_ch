using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Collections;
using TOCTest.comm;


namespace TOCTest.data
{
    public partial class ExportDataView : Form
    {
        private DataSet ds = new DataSet();//数据库操作
        private DataSet ds1 = new DataSet();
        private List<ConfigHis> m_listConfigHis = new List<ConfigHis>();
        public ExportDataView()
        {
            InitializeComponent();
        }

        string dealOnline(string Index, ConfigHis objConfigHis)
        {
            char[] parsChar = { ',' };
            int nTemp = Convert.ToInt32(objConfigHis.m_strLsampleNum);
            string strReult = "";
            strReult = strReult + Index + ',' + objConfigHis.m_strCodeType + ',' +objConfigHis.m_strCodeName + ','+ objConfigHis.m_strStartTime + ','
                 + objConfigHis.m_strLsampleNum + ','+objConfigHis.m_strOperator + ',';
            for (int i = 0; i < nTemp; i = i + 1)
            {
                strReult = strReult + objConfigHis.m_strTOCValue.Split(parsChar)[(i)].ToString() + "," + objConfigHis.m_strTCValue.Split(parsChar)[(i)].ToString() + "," + objConfigHis.m_strConduct.Split(parsChar)[(i)].ToString() + ",";
            }
            strReult = strReult + "\r\n";
            return strReult;
        }

        string dealOffline(string Index, ConfigHis objConfigHis)
        {
            char[] parsChar = { ',' };
            int nTemp = Convert.ToInt32(objConfigHis.m_strSum_Num);
            string strReult = "";
            strReult = strReult + Index + ',' + objConfigHis.m_strCodeType + ',' + objConfigHis.m_strCodeName + ','
                + objConfigHis.m_strStartTime + ',' + objConfigHis.m_strLsampleNum + ','+ objConfigHis.m_strNum + ','
                + objConfigHis.m_strStartBott + ',' + objConfigHis.m_strSampleWay + ',' + objConfigHis.m_strSum_Num + ',' + objConfigHis.m_strOperator + ',';
            for (int i = 0; i < nTemp * 2; i = i + 1)
            {
                strReult = strReult + objConfigHis.m_strTOCValue.Split(parsChar)[(i)].ToString() + "," + objConfigHis.m_strTCValue.Split(parsChar)[(i)].ToString() + "," + objConfigHis.m_strConduct.Split(parsChar)[(i)].ToString() + ",";
            }
            strReult = strReult + objConfigHis.m_strAveTOCValue + ',' + objConfigHis.m_strAveTCValue + ',' + objConfigHis.m_strAveConduct + ',' + "\r\n";
            return strReult;
        }

        string dealCon(string Index, ConfigHis objConfigHis)
        {
            char[] parsChar = { ',' };
            int nTemp = Convert.ToInt32(objConfigHis.m_strSum_Num);
            string strReult = "";
            strReult = strReult + Index + ',' + objConfigHis.m_strCodeType + ',' + objConfigHis.m_strCodeName + ','
                + objConfigHis.m_strStartTime + ',' + objConfigHis.m_strLsampleNum + ',' + objConfigHis.m_strNum + ','
                + objConfigHis.m_strStartBott + ',' + objConfigHis.m_strSampleWay + ',' + objConfigHis.m_strSum_Num + ',' + objConfigHis.m_strOperator + ',';
           
            strReult = strReult + objConfigHis.m_strTOCValue + objConfigHis.m_strTCValue + objConfigHis.m_strConduct + "\r\n";
            return strReult;
        }

        private void dealQueryHistory()
        {
            string strQuery = "Select id as id, CodeType as CodeType,CodeName as CodeName ,Test_StartDt as Test_StartDt,Test_EndDt as Test_EndDt,Test_OprationName as Test_OprationName,Channlesum as Channlesum,OnlinestFlag as OnlinestFlag,AveTOCValue as AveTOCValue,AveTCValue as AveTCValue,AveConduct as AveConduct,LsampleNum as LsampleNum,Htest_testimes as Htest_testimes,Start_Bott as Start_Bott,SampleWay as SampleWay,TOCValue as TOCValue,TCValue as TCValue,Conduct as Conduct,Htest_sum as Htest_sum From {0}";
            strQuery = string.Format(strQuery, Main.ms_strDeviceName);
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\HistoryData.mdb";
            OleDbConnection conn = new OleDbConnection(strConnection);

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strQuery, conn);
            try
            {
                conn.Open();
                dataAdapter.Fill(ds);
                ds.Tables[0].Clear();
                dataAdapter.Fill(ds);
                dataGridViewExportInfo.DataSource = ds.Tables[0].DefaultView;
                dataGridViewExportInfo.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
            finally
            {
                conn.Close();
            }
        }

        private void m_btnDataView_Click(object sender, EventArgs e)
        {
            dealQueryHistory();
        }

        private void m_btnExportDataView_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewExportInfo.Rows.Count > 0)
                {

                    saveFileDialogExport.InitialDirectory = @"..\..\";
                    saveFileDialogExport.Filter = "文件|*.*";
                    saveFileDialogExport.FilterIndex = 2;
                    saveFileDialogExport.ShowHelp = true;
                    saveFileDialogExport.Title = "保存";
                    saveFileDialogExport.FileName = DateTime.Now.ToString("yyyy-MM-dd ");
                    saveFileDialogExport.RestoreDirectory = true;
                    if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
                    {
                        string strSaveName = saveFileDialogExport.FileName.ToString();
                        m_listConfigHis.Clear();
                        string str = DateTime.Now.ToString("yyyy-MM-dd hh:mm") + "\r\n" + dataGridViewExportInfo.Rows.Count.ToString() + "\r\n";
                        for (int i = 0; i < dataGridViewExportInfo.Rows.Count; i++)
                        {
                            ConfigHis objConfigHis = new ConfigHis();
                            objConfigHis.m_strCodeType = dataGridViewExportInfo.Rows[i].Cells[1].Value.ToString();
                            objConfigHis.m_strCodeName = dataGridViewExportInfo.Rows[i].Cells[2].Value.ToString();
                            objConfigHis.m_strStartTime = dataGridViewExportInfo.Rows[i].Cells[3].Value.ToString();
                            objConfigHis.m_strEndTime = dataGridViewExportInfo.Rows[i].Cells[4].Value.ToString();
                            objConfigHis.m_strOperator = dataGridViewExportInfo.Rows[i].Cells[5].Value.ToString();
                            objConfigHis.m_strChannlesum = dataGridViewExportInfo.Rows[i].Cells[6].Value.ToString();
                            objConfigHis.m_stronlinestflag = dataGridViewExportInfo.Rows[i].Cells[7].Value.ToString();
                            objConfigHis.m_strAveTOCValue = dataGridViewExportInfo.Rows[i].Cells[8].Value.ToString();
                            objConfigHis.m_strAveTCValue = dataGridViewExportInfo.Rows[i].Cells[9].Value.ToString();
                            objConfigHis.m_strAveConduct = dataGridViewExportInfo.Rows[i].Cells[10].Value.ToString();
                            objConfigHis.m_strLsampleNum = dataGridViewExportInfo.Rows[i].Cells[11].Value.ToString();
                            objConfigHis.m_strNum = dataGridViewExportInfo.Rows[i].Cells[12].Value.ToString();
                            objConfigHis.m_strStartBott = dataGridViewExportInfo.Rows[i].Cells[13].Value.ToString();
                            objConfigHis.m_strSampleWay = dataGridViewExportInfo.Rows[i].Cells[14].Value.ToString();
                            objConfigHis.m_strTOCValue = dataGridViewExportInfo.Rows[i].Cells[15].Value.ToString();
                            objConfigHis.m_strTCValue = dataGridViewExportInfo.Rows[i].Cells[16].Value.ToString();
                            objConfigHis.m_strConduct = dataGridViewExportInfo.Rows[i].Cells[17].Value.ToString();
                            objConfigHis.m_strSum_Num = dataGridViewExportInfo.Rows[i].Cells[18].Value.ToString();
                            m_listConfigHis.Add(objConfigHis);
                        }
                        int j = 1;
                        foreach (ConfigHis obj in m_listConfigHis)
                        {
                            string Index = j.ToString();
                            string Test_type = obj.m_strCodeType;
                            switch (Test_type)
                            {
                                case "1":
                                    str = str + dealOffline(Index, obj);
                                    break;
                                case "2":
                                    str = str + dealOnline(Index, obj);
                                    break;
                                case "3":
                                    str = str + dealCon(Index, obj);
                                    break;
                                default:
                                    break;
                            }
                            j++;
                        }
                        File.WriteAllText(strSaveName, str, System.Text.Encoding.GetEncoding("GB2312"));
                        MessageBox.Show("已导出文件！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        private void ExportDataView_Load(object sender, EventArgs e)
        {
            dealQueryHistory();
        }
    }
}
