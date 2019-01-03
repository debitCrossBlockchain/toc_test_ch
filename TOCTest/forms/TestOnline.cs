using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using ADOX;
using System.IO;
using System.Data.OleDb;

namespace TOCTest.forms
{
    public partial class TestOnline : Form
    {
        private DataSet dsHistory = new DataSet();//数据库操作
        private DataSet dsCur = new DataSet();//数据库操作
        public TestOnline()
        {
            InitializeComponent();
            TOCTest.comm.protocol.ValueChanged += OnStatusChanged;
        }

        static List<TOCTest.comm.SystemState> listArray = new List<TOCTest.comm.SystemState>();
        // delegate used for Invoke
        internal delegate void ResultDelegate(TOCTest.comm.SystemState data);
        /// <summary>
        /// Update the connection status
        /// </summary>
        public void OnStatusChanged(TOCTest.comm.SystemState data)
        {
            try
            {
                //Handle multi-threading
                if (InvokeRequired)
                {
                    Invoke(new ResultDelegate(OnStatusChanged), new object[] { data });
                    return;
                }
                listArray.Add(data);
                TestTOC(m_zgcTest, data);
                if (data.m_strRunStatus == "S")
                {
                    if (data.m_strTestType == "1")
                    {
                        TestResult objTestResult = new TestResult();
                        objTestResult.ShowDialog();
                    }

                    if (data.m_strTestType == "3")
                    {
                        ConResult objConResult = new ConResult();
                        objConResult.ShowDialog();
                    }

                    TOCTest.comm.CommPort objCommPort = TOCTest.comm.CommPort.Instance;
                    string str = "FF" + "{0}" +"0x00"+ "0x07" + "0x52"+"0x52" + "00";
                    str = string.Format(str, TOCTest.db.dbMrg.QueryDeviceNum(TOCTest.Main.ms_strDeviceName));
                    byte[] byDate = TOCTest.utils.help.getCheckSum(str);
                    objCommPort.Send(byDate);
                    TOCTest.utils.loghelp.log.Debug(string.Format("读取测试结果值{0}", TOCTest.utils.help.ByteToHexStr(byDate).ToString()));
                }
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
            }
        }


        /// <summary>
        /// 测试曲线
        /// </summary>
        /// <param name="zgc"></param>
        private void TestTOC(ZedGraphControl zgc,TOCTest.comm.SystemState data)
        {
            try
            {
                GraphPane myPane = zgc.GraphPane;
                myPane.CurveList.Clear();
                PointPairList list = new PointPairList();
                PointPairList listIC = new PointPairList();
                PointPairList listCON = new PointPairList();
                string strTestType = TestMrg.ms_strTestType;
                switch(data.m_strTestType)
                {
                    case "2":
                        strTestType = "在线测试";
                        break;
                    case "1":
                        strTestType = "离线测试";
                        break;
                    case "3":
                        strTestType = "系统适应性验证";
                        break;
                    case "C":
                        strTestType = "零点校准";
                        break;
                    default:
                        break;

                }
                // Set the titles and axis labels
                string strTitle = string.Format("站点{0}，{1}", Main.ms_strDeviceName, strTestType);
                myPane.Title.Text = strTitle;
                myPane.XAxis.Title.Text = "时间";
                myPane.YAxis.Title.Text = "浓度";
                myPane.XAxis.Scale.Min = 0.0;
                myPane.XAxis.Scale.Max = 6.0;
                myPane.YAxis.Scale.Min = 0.0;
                myPane.YAxis.Scale.Max = 1100.0;
                myPane.XAxis.Scale.MinorStep = 2;
                myPane.XAxis.Scale.MajorStep = 2;
                myPane.XAxis.Type = AxisType.DateAsOrdinal;
                myPane.XAxis.Scale.Format = "mm:ss";
                myPane.YAxis.Scale.MinorStep = 11;
                myPane.YAxis.Scale.MajorStep = 11;
                LineItem mcurve = myPane.AddCurve("TOC (mg/L)", list, Color.Blue, SymbolType.None);
                LineItem mcureTIC = myPane.AddCurve("IC (mg/L)", listIC, Color.Green, SymbolType.None);
                LineItem mcurveCon = myPane.AddCurve("CON (mg/L)", listCON, Color.Chocolate, SymbolType.None);
                int nTemp = 0;
                foreach (TOCTest.comm.SystemState objList in listArray)
                {
                    list.Add(nTemp, Convert.ToInt32(objList.m_strTOCValue));
                    listIC.Add(nTemp, Convert.ToInt32(objList.m_strTIC_Value));
                    listCON.Add(nTemp, Convert.ToInt32(objList.m_strCON_Value));
                    nTemp++;
                }
                DealTOCView(listArray);
                zgc.Refresh();
            }
            catch (Exception ex)
            {
                TOCTest.utils.loghelp.log.Error(ex.Message, ex);
            }
            
        }

        /// <summary>
        /// 测试参数设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestMrg_Load(object sender, EventArgs e)
        {
            m_tbUserInfo.Text =m_tbUserInfo.Text + DateTime.Now + "---------用户：" + TOCTest.forms.UserInfo.m_strUserName + "已经登陆!\r\n";
            TOCTest.comm.SystemState data = new comm.SystemState();
            TestTOC(m_zgcTest, data);
            queryHistory();
        }

        /// <summary>
        /// 启动测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                TOCTest.comm.CommPort objCommPort = TOCTest.comm.CommPort.Instance;
                objCommPort.Send(TOCTest.forms.TestMrg.ms_byDate);
                this.m_btnStart.Enabled = false;
                this.m_btnStop.Enabled = true;
                Main.ms_objMain.timerPollingInquiryStart();
                m_tbUserInfo.Text = m_tbUserInfo.Text + DateTime.Now + "---------用户：" + TOCTest.forms.UserInfo.m_strUserName + "启动测试!\r\n";
            }
            catch(Exception ex)
            {
                TOCTest.utils.loghelp.log.Error(ex.Message,ex);
            }
        }

        /// <summary>
        /// 停止测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                TOCTest.comm.CommPort objCommPort = TOCTest.comm.CommPort.Instance;
                string str = "FF" + "{0}" +"0x00"+ "0x07" + "0x43"+"0x53" + "00";
                str = string.Format(str, TOCTest.db.dbMrg.QueryDeviceNum(TOCTest.Main.ms_strDeviceName));
                byte[] byDate = TOCTest.utils.help.getCheckSum(str);
                objCommPort.Send(byDate);
                TOCTest.utils.loghelp.log.Debug(string.Format("发送启动测试参数数据{0}", TOCTest.utils.help.ByteToHexStr(byDate).ToString()));
                this.m_btnStart.Enabled = true;
                this.m_btnStop.Enabled = false;
                Main.ms_objMain.timerPollingInquiryStop();
                m_tbUserInfo.Text =m_tbUserInfo.Text + DateTime.Now + "---------用户：" + TOCTest.forms.UserInfo.m_strUserName + "停止测试!\r\n";
            }
            catch (Exception ex)
            {
                TOCTest.utils.loghelp.log.Error(ex.Message, ex);
            }
        }

        private void DealTOCView(List<TOCTest.comm.SystemState> listArray)
        {
            DataTable dtTOC = new DataTable("ds2");
            dtTOC.Columns.Add("Test_type", typeof(String));
            dtTOC.Columns.Add("TOC_value", typeof(String));
            dtTOC.Columns.Add("TIC_value", typeof(String));
            dtTOC.Columns.Add("CON_Value", typeof(String));
            dtTOC.Columns.Add("SampleNum", typeof(String));
            dtTOC.Columns.Add("Status", typeof(String));
            foreach (TOCTest.comm.SystemState objList in listArray)
            {
                DataRow dr = dtTOC.NewRow();
                dr["Test_type"] = objList.m_strTestType;
                dr["TOC_value"] = objList.m_strTOCValue;
                dr["TIC_value"] = objList.m_strTIC_Value;
                dr["CON_Value"] = objList.m_strCON_Value;
                dr["SampleNum"] = objList.m_strSampleNum;
                dr["Status"] = objList.m_strRunStatus;
                dtTOC.Rows.Add(dr);
            }
            //dsCur.Tables[0].Clear();
            //dsCur.Tables.Add(dtTOC);
            m_dataGridViewCur.DataSource = dtTOC.DefaultView;
            m_dataGridViewCur.AllowUserToAddRows = false;
        }

        private void queryHistory()
        {
            string strTreeView = Main.ms_strDeviceName.ToString();
            string strQuery = "Select id as id,Test_StartDt as dtTest,TOCValue as TOC,TCValue as IC From {0}";
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\HistoryData.mdb";
            strQuery = string.Format(strQuery, strTreeView);
            OleDbConnection conn = new OleDbConnection(strConn);
            if (conn.State != ConnectionState.Open) { conn.Open(); }
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strQuery, conn);
            try
            {
                dataAdapter.Fill(dsHistory);
                dsHistory.Tables[0].Clear();
                dataAdapter.Fill(dsHistory);
                m_dataGridViewHistory.DataSource = dsHistory.Tables[0].DefaultView;
                m_dataGridViewHistory.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
                MessageBox.Show("异常：" + ex.ToString(), "提示");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
