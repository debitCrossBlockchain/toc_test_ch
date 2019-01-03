using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Data.OleDb;

namespace TOCTest.forms
{
    public partial class AlertMrg : Form
    {
        private OleDbConnection mConnection;
        string m_strConn = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\AlertRecord.mdb";
        private DataSet dset = new DataSet();//数据库操作
        public AlertMrg()
        {
            InitializeComponent();
        }

        private void query()
        {
            try
            {
                this.m_rev_alertMrg.Reset();
                this.m_rev_alertMrg.LocalReport.ReportEmbeddedResource = "TOCTest.rdlc.rdAlertMrg.rdlc";
                m_rev_alertMrg.LocalReport.DataSources.Clear();
                m_rev_alertMrg.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetAlertMrg", ds()));
                this.m_rev_alertMrg.RefreshReport();
                // 设为 100% 
                this.m_rev_alertMrg.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                TOCTest.utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        private void m_btn_query_Click(object sender, EventArgs e)
        {
            read();
            query();
        }

        private void read()
        {
            try
            {
                TOCTest.comm.CommPort objCommPort = TOCTest.comm.CommPort.Instance;
                string str = "FF" + "{0}" +"0x00"+ "0x07" + "0x52" +"0x41"+ "00";
                str = string.Format(str, TOCTest.db.dbMrg.QueryDeviceNum(TOCTest.Main.ms_strDeviceName));
                byte[] byDate = TOCTest.utils.help.getCheckSum(str);
                objCommPort.Send(byDate);
                TOCTest.utils.loghelp.log.Debug(string.Format("发送读取审计数据{0}", TOCTest.utils.help.ByteToHexStr(byDate).ToString()));
            }
            catch (Exception ex)
            {
                TOCTest.utils.loghelp.log.Error(ex.Message, ex);
            }
        }

        /// <summary>
        /// 画曲线
        /// </summary>
        /// <returns></returns>
        private DataTable ds()
        {
            string mQuery = "Select * From {0}" + " order by id desc";
            switch (cbQueryWay.SelectedIndex)
            {
                case 0:
                    {
                       
                            mQuery = "Select * From {0} "  + " order by id desc";
                        
                    }
                    break;
                case 1:
                    {
                        string strLow = dateTimePre.Value.ToString().Replace(" ", "").Replace("/", "").Replace(":", "");
                        string strHight = dateTimeEnd.Value.ToString().Replace(" ", "").Replace("/", "").Replace(":", "");
                        mQuery = "Select * From {0} " + "where StartTime" + " between " + "'" + strLow + "'" + " and " + "'" + strHight + "'";
                        //MessageBox.Show(mQuery);
                    }
                    break;
                case 2:
                    {
                        mQuery = "Select * From {0} " + "where [OperationNumer] ='" + tbSerNum.Text + "'" + " order by id desc";
                    }
                    break;
                default:
                    break;

            }

            DataTable mDataTable = new DataTable("ds2");
            if (TOCTest.AlertMrg.ms_bFlag)
            {
                mQuery = string.Format(mQuery, "t_AlertRecord");
            }
            else
            {
                mQuery = string.Format(mQuery, TOCTest.Main.ms_strDeviceName);
            }
            mConnection = new OleDbConnection(m_strConn);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(mQuery, mConnection);
            //如果需要再次查询，需清空dataset里面的数据  
            try
            {
                if (mConnection.State != ConnectionState.Open) { mConnection.Open(); }
                dataAdapter.Fill(dset);
                dset.Tables[0].Clear();
                dataAdapter.Fill(dset);
                mDataTable = dset.Tables[0];
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
            finally
            {
                mConnection.Close();
            }
            return mDataTable;
        }

        public  void DisposeRes()
        {
            try
            {
                m_rev_alertMrg.LocalReport.ReleaseSandboxAppDomain();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        private void AlertMrg_Load(object sender, EventArgs e)
        {
            if (TOCTest.forms.UserInfo.Instance.getUserLevel() != "1")
            {
                m_btnDel.Visible = false;
                m_btnImport.Visible = false;
                m_btnExport.Visible = false;
            }
            tbUserInfo.Text =DateTime.Now+ "---------用户：" + TOCTest.forms.UserInfo.m_strUserName + "已经登陆！";
            query();
            db.dbMrg.AddAlertInfo("01", "01", "admin", DateTime.Now.ToString(), "01", "---------用户：" + TOCTest.forms.UserInfo.m_strUserName + "已经登陆！");
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnDel_Click(object sender, EventArgs e)
        {
            string strQuery = "delete * From {0}";
            if (TOCTest.AlertMrg.ms_bFlag)
            {
                strQuery = string.Format(strQuery, "t_AlertRecord");
            }
            else
            {
                strQuery = string.Format(strQuery, TOCTest.Main.ms_strDeviceName);
            }
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\AlertRecord.mdb";
            OleDbConnection conn = new OleDbConnection(strConn);
            OleDbCommand da = new OleDbCommand(strQuery, conn);

            try
            {
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                if ((MessageBox.Show("你确定清空所有的记录吗?", "警告！", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                {
                    da.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                TOCTest.utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
            finally
            {
                conn.Close();
            }
            query();
        }

        private void m_btnImport_Click(object sender, EventArgs e)
        {
            openFileDialogtxt.InitialDirectory = @"../../";
            openFileDialogtxt.Filter = "文件|*.*";
            openFileDialogtxt.FilterIndex = 2;
            openFileDialogtxt.RestoreDirectory = false;
            openFileDialogtxt.Title = "打开";
            openFileDialogtxt.FileName = "";
            openFileDialogtxt.Multiselect = true;

            if (openFileDialogtxt.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogtxt.FileName.ToString();
                StreamReader objReader = new StreamReader(filePath, System.Text.Encoding.GetEncoding("GB2312"));
                char[] parsChar = { ',' };
                string sLine = "";
                string firstLine = objReader.ReadLine();
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null && !sLine.Equals(""))
                    {
                        try
                        {
                            string UserNmer = sLine.Split(parsChar)[1].ToString();
                            string OperationNumer = sLine.Split(parsChar)[2].ToString();
                            string UserName = sLine.Split(parsChar)[3].ToString();
                            string StartTime = sLine.Split(parsChar)[4].ToString();
                            string OperationType = sLine.Split(parsChar)[5].ToString();
                            string OperationReason = sLine.Split(parsChar)[6].ToString();
                            if (TOCTest.AlertMrg.ms_bFlag)
                            {
                                TOCTest.db.dbMrg.AddAlertInfo(UserNmer, OperationNumer, UserName, StartTime, OperationType, OperationReason);
                            }
                            else
                            {
                                TOCTest.db.dbMrg.AddAlertInfo(TOCTest.Main.ms_strDeviceName,UserNmer, OperationNumer, UserName, StartTime, OperationType, OperationReason);
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            utils.loghelp.log.Error(ex.Message, ex);
                        }
                    }
                }

                MessageBox.Show("增加成功！", "提示");
                objReader.Close();
                query();
            }
        }

        private void m_btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                UserInfo objUserInfo = UserInfo.Instance;
                db.dbMrg.AddAlertInfo("01", "01", objUserInfo.getUserName(), DateTime.Now.ToString(), "01", "导出数据!");
                TOCTest.data.ExportAlert objExport = new TOCTest.data.ExportAlert();
                objExport.ShowDialog();
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

    }
}
