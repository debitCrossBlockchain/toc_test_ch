using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TOCTest.utils;
using TOCTest.comm;
using System.Xml;
using TOCTest.forms;
using TOCTest.data;

namespace TOCTest
{
    public partial class Main : Form
    {
        public static string ms_strDeviceName="设备1号";
        string OpmlFile = @"..\..\conf\TreeView.opml";
        TOCTest.forms.AlertMrg m_objAlertMrg;
        TOCTest.forms.DataViewMrg m_objDataViewMrg;
        bool m_bFlag = false;
        public static Main ms_objMain;
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 通讯设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemCommunication_Click(object sender, EventArgs e)
        {
            RS232 mRs232 = new RS232();
            mRs232.Show();
        }

        /// <summary>
        /// 树形列表按下鼠标右键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RssTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                string str = "连接列表";
                Point ClickPoint = new Point(e.X, e.Y);
                TreeNode CurrentNode = RssTreeView.GetNodeAt(ClickPoint);
                if (CurrentNode.Text != str)
                {
                    RssTreeView.SelectedNode = CurrentNode;//选中这个节点
                    ms_strDeviceName = RssTreeView.SelectedNode.Text;
                }
                if (e.Button == MouseButtons.Right)//判断你点的是不是右键
                {
                    if (CurrentNode != null)//判断你点的是不是一个节点
                    {
                        if (CurrentNode.Text == str)
                        {
                            CurrentNode.ContextMenuStrip = CreateDevice;
                        }
                        else
                        {
                            CurrentNode.ContextMenuStrip = RightMenu;
                        }
                    }
                }
                else
                {
                    if (CurrentNode.Text != str)
                    {
                        UserInfoEx();
                    }
                }
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        private void UserInfoEx()
        {
            Info mobjInfo = new Info();
            mobjInfo.FormBorderStyle = FormBorderStyle.None;
            mobjInfo.TopLevel = false;
            mobjInfo.Dock = DockStyle.Fill;
            this.MyPanel.Controls.Clear();
            this.MyPanel.Controls.Add(mobjInfo);
            mobjInfo.Show();
        }

        // 动态生成Tree树目录(加载RSS频道列表)
        private void LoadRssTreeList(string url)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(url);
                XmlNode body = doc.SelectSingleNode("//body");
                XmlNodeList FeedList = body.ChildNodes;//得到body的所有子元素
                foreach (XmlNode feed in FeedList)//分别对子元素依次循环操作
                {
                    TreeNode tree = new TreeNode();  // 创建一个树型节点对象
                    AddRssFeedSonListTree(feed, tree);//判断当前节点有子节点吗
                    tree.Text = feed.Attributes["title"].Value.ToString();// 设置树型节点的名称
                    RssTreeView.Nodes.Add(tree);//把当前创建的这个树型节点加到TreeView控件中
                }
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }

        }

        // 递归完成对当前节点的遍历功能
        private void AddRssFeedSonListTree(XmlNode node, TreeNode PreTN)
        {
            try
            {
                if (node.HasChildNodes)//测试当前节点有没有子元素
                {
                    for (int i = 0; i < node.ChildNodes.Count; i++)//循环所有子元素
                    {
                        TreeNode tn = new TreeNode();
                        tn.Text = node.ChildNodes[i].Attributes["title"].Value.ToString();
                        PreTN.Nodes.Add(tn);
                        AddRssFeedSonListTree(node.ChildNodes[i], tn);//递归开始
                    }
                }
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        private void OprationSelectRss(string oprationmode, string title, string url)
        {
            try
            {
                // 获得当前所被选中的节点的完整路径
                string old = RssTreeView.SelectedNode.FullPath.ToString();
                //MessageBox.Show(old);
                string xpathstr = old.Replace("\\", "/");
                //MessageBox.Show(xpathstr);
                string[] SARRAY = System.Text.RegularExpressions.Regex.Split(xpathstr, "/");
                OpXMLFile.OprationOpmlFile(OpmlFile, SARRAY, oprationmode, title, url);
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ms_objMain = this;
            timerMainStatus.Enabled = true;
            timerMainStatus.Start();
           
            this.RssTreeView.Enabled = false;
            this.RssTreeView.Visible = false;
            RssTreeView.Nodes.Clear();
            LoadRssTreeList(OpmlFile);
            UserInfoEx();
        }

        /// <summary>
        /// 测试过程
        /// </summary>
        private void TestProcess()
        {
            try
            {
                TestWay mobjTestMrg = new TestWay();
                mobjTestMrg.FormBorderStyle = FormBorderStyle.None;
                mobjTestMrg.TopLevel = false;
                mobjTestMrg.Dock = DockStyle.Fill;
                this.MyPanel.Controls.Clear();
                this.MyPanel.Controls.Add(mobjTestMrg);
                mobjTestMrg.Show();
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        public void Test()
        {
            try
            {
                TestOnline mobjTestMrg = new TestOnline();
                mobjTestMrg.FormBorderStyle = FormBorderStyle.None;
                mobjTestMrg.TopLevel = false;
                mobjTestMrg.Dock = DockStyle.Fill;
                MyPanel.Controls.Clear();
                MyPanel.Controls.Add(mobjTestMrg);
                mobjTestMrg.Show();
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        public void TestOfflineArgs()
        {
            try
            {
                TestOfflineArgs mobjTestMrg = new TestOfflineArgs();
                mobjTestMrg.FormBorderStyle = FormBorderStyle.None;
                mobjTestMrg.TopLevel = false;
                mobjTestMrg.Dock = DockStyle.Fill;
                MyPanel.Controls.Clear();
                MyPanel.Controls.Add(mobjTestMrg);
                mobjTestMrg.Show();
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        /// <summary>
        /// 测试过程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolTest_Click(object sender, EventArgs e)
        {
            TestProcess();
        }
        #region 节点管理
        /// <summary>
        /// 新建设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            AddDevice();
        }

        /// <summary>
        /// 新建设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateMouseLeft(object sender, EventArgs e)
        {
            try
            {
                NewDevice objNewDevice = new NewDevice();
                objNewDevice.ShowDialog();
                string title = objNewDevice.m_DeviceNameId;
                if (!string.IsNullOrEmpty(title))
                {
                    TreeNode r = new TreeNode();
                    r.Text = title;
                    r.ImageKey = imageList.Images[2].ToString();
                    r.SelectedImageKey = imageList.Images[5].ToString();
                    OprationSelectRss("AddML", title, null);
                    RssTreeView.SelectedNode.Nodes.Add(r);
                    RssTreeView.SelectedNode = r;
                    RssTreeView.Refresh();
                }
                db.dbMrg.CreatHDateTable(title);
                db.dbMrg.CreateAlertTable(title);
                db.dbMrg.CreateSystemArgsTable(title);
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\SystemParameter.mdb";
                string strDBInfo = String.Format("insert into {0} ([name],[SampVmax],[SampTimer],[ChannlSum],[LTests],[LForsake],[LCleartime],[TOCAlarmup],[USAlarmup],[StorMode],[UvLamp],[PumpPipe])values ('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
                    title,title ,"5", "240", "1", "6", "3", "30", "500", "1000", "1", "0", "0");
                TOCTest.db.dbMrg.AlterDB(strConnection, strDBInfo);
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        /// <summary>
        /// 新建设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolNewDevice_Click(object sender, EventArgs e)
        {
            AddDevice();
        }

        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolDelDevice_Click(object sender, EventArgs e)
        {
            DelDevice();
        }

        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemDelet_Click(object sender, EventArgs e)
        {
            DelDevice();
        }

        private void AddDevice()
        {
            try
            {
                UserInfo objUserInfo = UserInfo.Instance;
                db.dbMrg.AddAlertInfo("01", "01", objUserInfo.getUserName(), DateTime.Now.ToString(), "01", "增加节点!");
                NewDevice objNewDevice = new NewDevice();
                objNewDevice.ShowDialog();
                string title = objNewDevice.m_DeviceNameId;
                if (!string.IsNullOrEmpty(title))
                {
                    TreeNode r = new TreeNode();
                    r.Text = title;
                    r.ImageKey = imageList.Images[2].ToString();
                    r.SelectedImageKey = imageList.Images[2].ToString();
                    OprationSelectRss("AddM", title, null);
                    RssTreeView.SelectedNode.Parent.Nodes.Add(r);
                    RssTreeView.SelectedNode = r;
                    RssTreeView.Refresh();
                }
                db.dbMrg.CreatHDateTable(title);
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        private void DelDevice()
        {
            UserInfo objUserInfo = UserInfo.Instance;
            db.dbMrg.AddAlertInfo("01", "01", objUserInfo.getUserName(), DateTime.Now.ToString(), "01", "删除节点!");
            DialogResult dr = MessageBox.Show("你确定要删除[" + RssTreeView.SelectedNode.Text + "]节点吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dr)
            {
                db.dbMrg.DeleteDBTable("Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\HistoryData.mdb", RssTreeView.SelectedNode.Text);
                db.dbMrg.DeleteDBTable("Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\AlertRecord.mdb", RssTreeView.SelectedNode.Text);
                db.dbMrg.DeleteDBTable("Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\SystemParameter.mdb", RssTreeView.SelectedNode.Text);
                db.dbMrg.DelDeviceTable(RssTreeView.SelectedNode.Text);
                OprationSelectRss("Del", null, null);
                RssTreeView.Nodes.Remove(RssTreeView.SelectedNode);
                RssTreeView.Refresh();
            }
            ms_strDeviceName = string.Format("{0}", this.RssTreeView.SelectedNode.Text);
        }

        /// <summary>
        /// 退出软件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("你确定是否要退出应用程序！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dr)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }
        #endregion

        private void dataView()
        {
            try
            {
                UserInfo objUserInfo = UserInfo.Instance;
                db.dbMrg.AddAlertInfo("01", "01", objUserInfo.getUserName(), DateTime.Now.ToString(), "01", "数据操作!");
                DataViewMrg mobjDataViewMrg = new DataViewMrg();
                m_objDataViewMrg = mobjDataViewMrg;
                mobjDataViewMrg.FormBorderStyle = FormBorderStyle.None;
                mobjDataViewMrg.TopLevel = false;
                mobjDataViewMrg.Dock = DockStyle.Fill;
                this.MyPanel.Controls.Clear();
                this.MyPanel.Controls.Add(mobjDataViewMrg);
                mobjDataViewMrg.Show();
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

      

        /// <summary>
        /// 查看数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolDataView_Click(object sender, EventArgs e)
        {
            dataView();
        }

        private void alertMrg()
        {
            try
            {
                UserInfo objUserInfo = UserInfo.Instance;
                db.dbMrg.AddAlertInfo("01", "01", objUserInfo.getUserName(), DateTime.Now.ToString(), "01", "报警日志!");
                TOCTest.forms.AlertMrg objAlertMrg = new TOCTest.forms.AlertMrg();
                m_objAlertMrg = objAlertMrg;
                objAlertMrg.FormBorderStyle = FormBorderStyle.None;
                objAlertMrg.TopLevel = false;
                objAlertMrg.Dock = DockStyle.Fill;
                this.MyPanel.Controls.Clear();
                this.MyPanel.Controls.Add(objAlertMrg);
                objAlertMrg.Show();
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        private void userMrg()
        {
            try
            {
                UserInfo objUserInfo = UserInfo.Instance;
                db.dbMrg.AddAlertInfo("01", "01", objUserInfo.getUserName(), DateTime.Now.ToString(), "01", "用户管理!");
                UserMrg objUserMrg = new UserMrg();
                objUserMrg.FormBorderStyle = FormBorderStyle.None;
                objUserMrg.TopLevel = false;
                objUserMrg.Dock = DockStyle.Fill;
                this.MyPanel.Controls.Clear();
                this.MyPanel.Controls.Add(objUserMrg);
                objUserMrg.Show();
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        private void systemArgs()
        {
            try
            {
                UserInfo objUserInfo = UserInfo.Instance;
                db.dbMrg.AddAlertInfo("01", "01", objUserInfo.getUserName(), DateTime.Now.ToString(), "01", "操作并设置系统参数!");
                SystemSet objSystemParam = new SystemSet();
                objSystemParam.FormBorderStyle = FormBorderStyle.None;
                objSystemParam.TopLevel = false;
                objSystemParam.Dock = DockStyle.Fill;
                this.MyPanel.Controls.Clear();
                this.MyPanel.Controls.Add(objSystemParam);
                objSystemParam.Show();
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
        }

        /// <summary>
        /// 日志报警
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolAlertMrg_Click(object sender, EventArgs e)
        {
            alertMrg();
        }

        /// <summary>
        /// 客户管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolCustomerMrg_Click(object sender, EventArgs e)
        {
            userMrg();
        }


        /// <summary>
        /// 窗体关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                CommPort com = CommPort.Instance;
                if (com.IsOpen == true)
                {
                    com.Close();
                }

                UserInfo objUserInfo = UserInfo.Instance;
                db.dbMrg.AddAlertInfo("01", "01", objUserInfo.getUserName(), DateTime.Now.ToString(), "01", "关闭窗口");
                if (m_objAlertMrg != null)
                {
                    m_objAlertMrg.DisposeRes();
                }
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
            finally
            {
                System.Environment.Exit(0);
            }
        }

        private void ToolStripSystemArgs_Click(object sender, EventArgs e)
        {
            systemArgs();
        }

       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMainStatus_Tick(object sender, EventArgs e)
        {
            this.MainToolStripStatusLabel.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss dddd");
        }

       

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (m_bFlag)
            {
                this.RssTreeView.Enabled = false;
                this.RssTreeView.Visible = false;
                m_bFlag = false;
            }
            else
            {
                this.RssTreeView.Enabled = true;
                this.RssTreeView.Visible = true;
                m_bFlag = true;
            }
        }

        private void m_toolbtnDataView_Click(object sender, EventArgs e)
        {
            dataView();
        }

        private void m_toolbtnTest_Click(object sender, EventArgs e)
        {
            TestProcess();
        }

        private void m_toolbtnUserMrg_Click(object sender, EventArgs e)
        {
            userMrg();
        }

        private void m_toolbtnAlertMrg_Click(object sender, EventArgs e)
        {
            AlertMrg.ms_bFlag = true;
            alertMrg();
        }

        private void m_toolbtnSite_Click(object sender, EventArgs e)
        {
            if (m_bFlag)
            {
                this.RssTreeView.Enabled = false;
                this.RssTreeView.Visible = false;
                m_bFlag = false;
            }
            else
            {
                this.RssTreeView.Enabled = true;
                this.RssTreeView.Visible = true;
                m_bFlag = true;
            }
        }

       

        private void m_toolbtnSystemParam_Click(object sender, EventArgs e)
        {
            systemArgs();
        }

        private void timerPollingInquiry_Tick(object sender, EventArgs e)
        {
            try
            {
                TOCTest.comm.CommPort objCommPort = TOCTest.comm.CommPort.Instance;
                string str = "FF" + "{0}" + "0x05" + "0x03" + "00";
                str = string.Format(str, TOCTest.db.dbMrg.QueryDeviceNum(TOCTest.Main.ms_strDeviceName));
                byte[] byDate = TOCTest.utils.help.getCheckSum(str);
                objCommPort.Send(byDate);
                TOCTest.utils.loghelp.log.Debug(string.Format("读取测试值{0}", TOCTest.utils.help.ByteToHexStr(byDate).ToString()));
             }
            catch (Exception ex)
            {
                TOCTest.utils.loghelp.log.Error(ex.Message, ex);
            }
        }

        public void timerPollingInquiryStart()
        {
            timerPollingInquiry.Enabled = true;
            timerPollingInquiry.Start();
        }

        public void timerPollingInquiryStop()
        {
            timerPollingInquiry.Enabled = false;
            timerPollingInquiry.Stop();
        }

        private void m_toolMenuSystemParam_Click(object sender, EventArgs e)
        {
            systemArgs();
        }

        private void m_toolMenuAlertMrg_Click_Click(object sender, EventArgs e)
        {
            AlertMrg.ms_bFlag = false;
            alertMrg();
        }
    }
}
