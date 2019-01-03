using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOCTest.forms
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        public static string getDeviceName()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\TestParam.mdb";
            string strDBInfo = "Select * From {0} where [name]='" + Main.ms_strDeviceName.ToString() + "'";
            strDBInfo = string.Format(strDBInfo, "t_Device");
            List<string> listInfo = new List<string>();
            listInfo = db.dbMrg.QueryDB(strConnection, strDBInfo, 4);
            if (listInfo.Count > 0)
            {
                return listInfo[1];
            }
            else
            {
                return "设备1号";
            }

        }
        private void Info_Load(object sender, EventArgs e)
        {
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\TestParam.mdb";
                string strDBInfo = "Select * From {0} where [name]='" + Main.ms_strDeviceName.ToString() + "'";
                strDBInfo = string.Format(strDBInfo, "t_Device");
                List<string> listInfo = new List<string>();
                listInfo = db.dbMrg.QueryDB(strConnection, strDBInfo, 4);
                if (listInfo.Count > 0)
                {
                    m_tbDeviceName.Text = listInfo[1];
                    m_tbDeviceNo.Text = listInfo[2];
                    m_tbInfo.Text = listInfo[3];
                }
            }
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\SystemParameter.mdb";
                string strDBInfo = "Select * From {0} where [name]='" + Main.ms_strDeviceName.ToString() + "'";
                strDBInfo = string.Format(strDBInfo, Main.ms_strDeviceName.ToString());
                List<string> listInfo = new List<string>();
                listInfo = db.dbMrg.QueryDB(strConnection, strDBInfo, 13);
                if (listInfo.Count > 0)
                {
                    m_tbSampVmax.Text = listInfo[2];
                    m_tbSampTimer.Text = listInfo[3];
                    m_tbChannlSum.Text = listInfo[4];
                    m_tbLTests.Text = listInfo[5];
                    m_tbLForsake.Text = listInfo[6];
                    m_tbLCleartime.Text = listInfo[7];
                    m_tbTOCAlarmup.Text = listInfo[8];
                    m_tbUSAlarmup.Text = listInfo[9];
                    m_tbStorMode.Text = listInfo[10];
                    m_tbUvLamp.Text = listInfo[11];
                    m_tbPumpPipe.Text = listInfo[12];
                }
            }

        }
    }
}
