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
    public partial class ConResult : Form
    {
    
        public ConResult()
        {
            InitializeComponent();
        }

        // delegate used for Invoke
        internal delegate void ResultDelegate(TOCTest.comm.TestResult data);
        /// <summary>
        /// Update the connection status
        /// </summary>
        public void OnStatusChanged(TOCTest.comm.TestResult data)
        {
            try
            {
                //Handle multi-threading
                if (InvokeRequired)
                {
                    Invoke(new ResultDelegate(OnStatusChanged), new object[] { data });
                    return;
                }
                m_tbRw.Text = data.m_objConResult.m_strRw;
                m_tbRs.Text = data.m_objConResult.m_strRs;
                m_tbRss.Text = data.m_objConResult.m_strRss;
                m_tbResponseRate.Text = data.m_objConResult.m_strResponseRate;
            }
            catch (Exception ex)
            {
                utils.loghelp.log.Error(ex.Message, ex);
            }
        }

    }
}
