using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TOCTest.forms
{
    public partial class User : Form
    {
        string m_strConn = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\UserInfo.mdb";
        private OleDbConnection mConnection;
        public User()
        {
            InitializeComponent();
        }

        public void Insert()
        {
            try
            {
                if (CheckAuthority())
                {
                    MessageBox.Show("用户权限有问题，请仔细检查用户权限！");
                    return;
                }

                if (tBUserName.Text.ToString() == "" || tBPwd.Text == "" || textBoxUserSernum.Text == "")
                {
                    MessageBox.Show("用户名或密码等信息不为空！");
                    return;
                }

                bool bExist = db.dbMrg.QueryExistDB(m_strConn, "Select * From t_UserInfo where [userName]='" + tBUserName.Text + "'");
                if (bExist)
                {
                    MessageBox.Show("用户已经存在不能添加！");
                    return;
                }

                UserInfo objUserInfo = UserInfo.Instance;
                db.dbMrg.AddUserInfo(tBUserName.Text, tBPwd.Text, (comboBoxLevel.SelectedIndex + 1).ToString(), textBoxUserSernum.Text);
                db.dbMrg.AddAlertInfo("01", "01", objUserInfo.getUserName(), DateTime.Now.ToString(), "01", "用户管理增加了用户名为：" + tBUserName.Text);
                utils.loghelp.log.Debug("增加了用户名为：" + tBUserName.Text+",时间为:"+DateTime.Now.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        public void Alert(string strIndex)
        {
            try
            {
                UserInfo objUserInfo = UserInfo.Instance;
                int nLevel = Convert.ToInt32(objUserInfo.getUserLevel());
                int ncbLevel = comboBoxLevel.SelectedIndex + 1;
                if (nLevel > ncbLevel)
                {
                    MessageBox.Show("用户权限有问题，请仔细检查用户权限！");
                    return;
                }

                if (tBUserName.Text.ToString() == "" || tBPwd.Text == "" || textBoxUserSernum.Text == "")
                {
                    MessageBox.Show("用户名或密码等信息不为空！");
                    return;
                }
                string strQuery = "update {0} set [userName]='" + "{1}" + "',[userPwd]='" + "{2}" + "',[userLevel]='" + "{3}" + "',[userSernum]='" + "{4}" + "'where [userName]='" + tBUserName.Text.Trim() + "'";
                strQuery = string.Format(strQuery, "t_UserInfo", tBUserName.Text.ToString(), tBPwd.Text, (comboBoxLevel.SelectedIndex + 1).ToString(), textBoxUserSernum.Text);
                bool bExist = db.dbMrg.QueryExistDB(m_strConn, "Select * From t_UserInfo where [userName]='" + strIndex + "'");
                if (bExist)
                {
                    db.dbMrg.AlterDB(m_strConn, strQuery);
                    db.dbMrg.AddAlertInfo("01", "01", objUserInfo.getUserName(), DateTime.Now.ToString(), "01", "修改了用户名为：" + tBUserName.Text);
                    utils.loghelp.log.Debug("修改了用户名为：" + tBUserName.Text + ",时间为:" + DateTime.Now.ToString());
                }
                else
                {
                    utils.loghelp.log.Debug("用户不存在！");
                    MessageBox.Show("用户不存在!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        private bool CheckAuthority()
        {
            bool bIsFlag = false;
            UserInfo objUserInfo = UserInfo.Instance;
            int nLevel = Convert.ToInt32(objUserInfo.getUserLevel());
            int ncbLevel = comboBoxLevel.SelectedIndex + 1;
            if ((nLevel >= ncbLevel) || (ncbLevel > 4))
            {
                bIsFlag = true;
            }
            return bIsFlag;
        }


        private void m_btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_Load(object sender, EventArgs e)
        {
            try
            {
                string strIndex = UserMrg.ms_strUserInfoIndex;
                if (!string.IsNullOrEmpty(strIndex))
                {
                    string mQuery = "Select [userName],[userLevel],[userSernum] From {0} where [userName]='" + strIndex + "'";
                    mQuery = string.Format(mQuery, "t_UserInfo");
                    mConnection = new OleDbConnection(m_strConn);
                    mConnection.Open();
                    OleDbCommand cmd = new OleDbCommand(mQuery, mConnection);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        tBUserName.Text = reader[0].ToString();
                        tBPwd.Text = reader[1].ToString();
                        textBoxUserSernum.Text = reader[2].ToString();
                    }
                    reader.Close();
                    mConnection.Close();

                }
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
            }
        }
    }
}
