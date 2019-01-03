using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using TOCTest.utils;
using TOCTest.forms;
using TOCTest.db;

namespace TOCTest.forms
{
    public partial class UserMrg : Form
    {
        private OleDbConnection mConnection;
        string m_strConn = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\UserInfo.mdb";
        private DataSet ds = new DataSet();//数据库操作
        public static string ms_strUserInfoIndex;
        public UserMrg()
        {
            InitializeComponent();
        }

        private void buttonHistoricalAdd_Click(object sender, EventArgs e)
        {
            ms_strUserInfoIndex = dataGridViewUserInfo.Rows[dataGridViewUserInfo.CurrentRow.Index].Cells[0].Value.ToString();
            User objUser = new User();
            objUser.ShowDialog();
            objUser.Insert();
        }

        private void buttonHistoricalEdit_Click(object sender, EventArgs e)
        {
            ms_strUserInfoIndex = dataGridViewUserInfo.Rows[dataGridViewUserInfo.CurrentRow.Index].Cells[0].Value.ToString();
            User objUser = new User();
            objUser.ShowDialog();
            objUser.Alert(ms_strUserInfoIndex);  
        }

        private void buttonHistoricalDelete_Click(object sender, EventArgs e)
        {
            if (CheckAuthority())
            {
                MessageBox.Show("用户权限有问题，请仔细检查用户权限！");
                return;
            }

            if (dataGridViewUserInfo.SelectedRows.Count <= 0)
            {
                return;
            }
            string mDeleteUserInfoIndex = dataGridViewUserInfo.Rows[dataGridViewUserInfo.CurrentRow.Index].Cells[0].Value.ToString();
            string mQuery = "delete * From {0} where [userName]='" + mDeleteUserInfoIndex + "'";
            mQuery = string.Format(mQuery, "t_UserInfo");
            mConnection = new OleDbConnection(m_strConn);
            OleDbCommand da = new OleDbCommand(mQuery, mConnection);
            try
            {
                mConnection.Open();
                if ((MessageBox.Show("你确定删除当前用户吗?", "警告！", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                {
                    //删除数据
                    //首先删除数据集 中的该条记录
                    int i = dataGridViewUserInfo.CurrentCell.RowIndex;//得到当前记录号
                    if (i >= 0)
                    {
                        ds.Tables[0].Rows[i].Delete();
                    }
                }
                da.ExecuteNonQuery();
                db.dbMrg.AddAlertInfo("01", "01", mDeleteUserInfoIndex, DateTime.Now.ToString(), "01", "用户管理删除了用户名为：" + mDeleteUserInfoIndex);
                utils.loghelp.log.Debug("删除了用户名为：" + mDeleteUserInfoIndex + ",时间为:" + DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
            finally
            {
                mConnection.Close();
            }
        }

        private void buttonSearchALLHis_Click(object sender, EventArgs e)
        {
            Query();
        }

        private bool CheckAuthority()
        {
            bool bIsFlag = false;
            UserInfo objUserInfo = UserInfo.Instance;
            int nLevel = Convert.ToInt32(objUserInfo.getUserLevel());
            int nDBLevel = Convert.ToInt32(dataGridViewUserInfo.Rows[dataGridViewUserInfo.CurrentRow.Index].Cells[1].Value.ToString());
            if (nLevel > nDBLevel)
            {
                bIsFlag = true;
            }
            return bIsFlag;
        }

        private void UserMrg_Load(object sender, EventArgs e)
        {
            UserInfo objUserInfo = UserInfo.Instance;
            int nLevel = Convert.ToInt32(objUserInfo.getUserLevel());
            if (nLevel >= 4)
            {
                this.Enabled = false;
                MessageBox.Show("用户权限不足!");
                return;
            }
            Query();
        }

        private void Query()
        {
            string mQuery = "Select [userName] as 用户名,[userLevel] as 级别,[userSernum] as 序号 From {0}";
            mQuery = string.Format(mQuery, "t_UserInfo");
            mConnection = new OleDbConnection(m_strConn);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(mQuery, mConnection);
            //如果需要再次查询，需清空dataset里面的数据  
            try
            {
                if (mConnection.State != ConnectionState.Open) { mConnection.Open(); }
                dataAdapter.Fill(ds);
                ds.Tables[0].Clear();
                dataAdapter.Fill(ds);
                dataGridViewUserInfo.DataSource = ds.Tables[0].DefaultView;
                dataGridViewUserInfo.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.ToString(), "提示");
                utils.loghelp.log.Error(ex.Message, ex);
            }
            finally
            {
                mConnection.Close();
            }
        }

        private void dataGridViewUserInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ms_strUserInfoIndex = dataGridViewUserInfo.Rows[dataGridViewUserInfo.CurrentRow.Index].Cells[0].Value.ToString();
            User objUser = new User();
            objUser.ShowDialog();
            objUser.Alert(ms_strUserInfoIndex);  
        }
    }
}
