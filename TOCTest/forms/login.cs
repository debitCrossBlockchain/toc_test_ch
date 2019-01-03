using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using TOCTest.db;
using TOCTest.utils;

namespace TOCTest.forms
{
    public partial class login : Form
    {
        bool m_bformMove = false;//窗体是否移动
        Point m_formPoint;//记录窗体的位置
        public login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBUserName.Text) || string.IsNullOrEmpty(tBPwd.Text))
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            if (!string.IsNullOrEmpty(tBUserName.Text) && !string.IsNullOrEmpty(tBPwd.Text))
            {
                string UserName = tBUserName.Text.ToString();
                byte[] result = Encoding.Default.GetBytes(tBPwd.Text.Trim());    //mPwd为输入密码
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(result);
                string Pwd = BitConverter.ToString(output).Replace("-", "");  //Pwd为输出加密文本
                if (!string.IsNullOrEmpty(UserName))
                {
                    try
                    {
                        string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\UserInfo.mdb";
                        string strDBInfo = "Select * From {0} where [userName]='" + UserName + "'";
                        strDBInfo = string.Format(strDBInfo, "t_UserInfo");
                        List<string> listInfo = new List<string>();
                        listInfo = db.dbMrg.QueryDB(strConnection, strDBInfo, 4);
                        if (listInfo.Count>0)
                        {
                            if (Pwd == listInfo[2])
                            {
                                UserInfo objUserInfo = UserInfo.Instance;
                                objUserInfo.SetInfo(UserName, listInfo[3]);
                                this.Close();
                                db.dbMrg.AddAlertInfo("01", "01", UserName, DateTime.Now.ToString(), "01", "用户登录成功");  
                                Main objMain = new Main();
                                objMain.ShowDialog();
                            }
                        }  
                    }
                    catch (Exception ex)
                    {
                        utils.loghelp.log.Error(ex.Message, ex);
                        MessageBox.Show("异常：" + ex.ToString(), "提示");
                    }
                }
            }
        }

        /// <summary>
        /// 用户取消登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBCancer_Click(object sender, EventArgs e)
        {
            try
            {
                db.dbMrg.AddAlertInfo("01", "01", tBUserName.Text, DateTime.Now.ToString(), "01", "用户登录，用户取消登录");
                this.Close();
                System.Environment.Exit(0);
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }


        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_Load(object sender, EventArgs e)
        {
            db.dbMrg.CreateDB();
            db.dbMrg.CreateUserTable();
            db.dbMrg.CreateAlertTable();
            db.dbMrg.CreateDeviceTable();
            bool bExist= db.dbMrg.QueryExistDB("Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\UserInfo.mdb", "Select * From t_UserInfo where [userName]='" + "admin" + "'");
            if (!bExist)
            {
                db.dbMrg.AddUserInfo("admin", "nbc123456nbc", "1", "001");
            }
        }

        /// <summary>
        /// 鼠标按下的处理事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                m_formPoint = new Point();
                int xOffset;
                int yOffset;
                if (e.Button == MouseButtons.Left)
                {
                    xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                    yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
                    m_formPoint = new Point(xOffset, yOffset);
                    m_bformMove = true;//开始移动
                }
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message,ex);
            }
        }

        /// <summary>
        /// 鼠标移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (m_bformMove == true)
                {
                    Point mousePos = Control.MousePosition;
                    mousePos.Offset(m_formPoint.X, m_formPoint.Y);
                    Location = mousePos;
                }
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
            }
        }

        /// <summary>
        /// 鼠标左键放下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)//按下的是鼠标左键
                {
                    m_bformMove = false;//停止移动
                }
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
            }
        }
    }
}
