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
    public partial class ExportAlert : Form
    {
        private DataSet ds = new DataSet();//数据库操作
        private DataSet ds1 = new DataSet();
        private List<ConfigHis> m_listConfigHis = new List<ConfigHis>();
        public ExportAlert()
        {
            InitializeComponent();
        }

       

        private void Export_Load(object sender, EventArgs e)
        {
            dealQueryAlert();
        }

        private void dealQueryAlert()
        {
            string strQuery = "Select id as id, UserNmer as UserNmer,OperationNumer as OperationNumer,UserName as UserName,StartTime as StartTime,OperationType as OperationType,OperationReason as OperationReason From {0}";
            if (TOCTest.AlertMrg.ms_bFlag)
            {
                strQuery = string.Format(strQuery, "t_AlertRecord");
            }
            else
            {
                strQuery = string.Format(strQuery, TOCTest.Main.ms_strDeviceName);
            }
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\AlertRecord.mdb";
            OleDbConnection conn = new OleDbConnection(strConnection);

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strQuery, conn);
            try
            {
                conn.Open();
                dataAdapter.Fill(ds1);
                dataGridViewExportInfo.DataSource = ds1.Tables[0].DefaultView;
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

        private void m_btnAlert_Click(object sender, EventArgs e)
        {
            dealQueryAlert();
        }

        private void m_btnExportAlert_Click(object sender, EventArgs e)
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

                        string str = dataGridViewExportInfo.Rows.Count.ToString() + "\r\n";
                        for (int i = 0; i < dataGridViewExportInfo.Rows.Count; i++)
                        {
                            string UserNmer = dataGridViewExportInfo.Rows[i].Cells[1].Value.ToString();
                            string OperationNumer = dataGridViewExportInfo.Rows[i].Cells[2].Value.ToString();
                            string UserName = dataGridViewExportInfo.Rows[i].Cells[3].Value.ToString();
                            string StartTime = dataGridViewExportInfo.Rows[i].Cells[4].Value.ToString();
                            string OperationType = dataGridViewExportInfo.Rows[i].Cells[5].Value.ToString();
                            string OperationReason = dataGridViewExportInfo.Rows[i].Cells[6].Value.ToString();
                            str += (i + 1).ToString() + "," + UserNmer + ","
                                + OperationNumer + "," + UserName + ","
                                + StartTime + "," + OperationType + ","
                                + OperationReason + "\r\n";
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
    }
}
