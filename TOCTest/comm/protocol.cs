using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TOCTest.comm
{
    /// <summary>
    /// 通信协议的解析与定义
    /// </summary>
    class protocol
    {
       //begin Observer pattern
       public delegate void EventHandlerValue(SystemState param);
       public static EventHandlerValue ValueChanged = new EventHandlerValue(DelegateValue);
       public static void DelegateValue(SystemState param)
       {
       }

       public delegate void EventHandlerSystemArgs(SystemArgs param);
       public static EventHandlerSystemArgs ValueSystemArgs = new EventHandlerSystemArgs(DelegateSystemArgs);
       public static void DelegateSystemArgs(SystemArgs param)
       {
       }

       public delegate void EventHandlerTestResult(TestResult param);
       public static EventHandlerTestResult ValueTestResult = new EventHandlerTestResult(DelegateTestResult);
       public static void DelegateTestResult(TestResult param)
       {
       }

        public static void DealRead(byte[] readBuffer)
        {
            int mK = 1;
            try
            {
                //SearchDeviceAddress();//查询设备地址
                while ((mK < readBuffer.Length - 1) && (readBuffer[mK] != 0xFF))
                {
                    mK++;
                }
                switch (readBuffer[mK + 4])
                {
                    //C控制命令
                    case 0x43:
                        {
                           
                        }
                        break;
                    //R读取命令
                    case 0x52:
                        {
                            // (3)   读取系统状态  --- ‘S’ ;
                            if(readBuffer[mK+5]==0x53)
                            {
                                SystemState objSystemState = new SystemState();
                                objSystemState.m_strTestType = ((char)readBuffer[mK + 6]).ToString();
                                objSystemState.m_strTOCValue = (readBuffer[mK + 7] << 8 + readBuffer[mK + 8]).ToString();
                                objSystemState.m_strTIC_Value = (readBuffer[mK + 9] << 8 + readBuffer[mK + 10]).ToString();
                                objSystemState.m_strCON_Value = (readBuffer[mK + 11] << 8 + readBuffer[mK + 12]).ToString();
                                objSystemState.m_strSampleNum = (readBuffer[mK + 13] << 8 + readBuffer[mK + 14]).ToString();
                                objSystemState.m_strRunStatus = ((char)readBuffer[mK + 15]).ToString();
                                ValueChanged(objSystemState);
                            }
                            //(5)   读取系统参数  --- ‘P’ ;
                            if (readBuffer[mK + 5] == 0x50)
                            {
                                SystemArgs objSystemArgs = new SystemArgs();
                                objSystemArgs.m_strSampVmax = (readBuffer[mK + 6] << 8 + readBuffer[mK + 7]).ToString();
                                objSystemArgs.m_strSampTimer = (readBuffer[mK + 8] << 8 + readBuffer[mK + 9]).ToString();
                                objSystemArgs.m_strChannlSum = readBuffer[mK + 10].ToString();
                                objSystemArgs.m_strLTests = readBuffer[mK + 11].ToString();
                                objSystemArgs.m_strLForsake = readBuffer[mK + 12].ToString();
                                objSystemArgs.m_strLCleartime = (readBuffer[mK + 13] << 8 + readBuffer[mK + 14]).ToString();
                                objSystemArgs.m_strTOCAlarmup = (readBuffer[mK + 15] << 8 + readBuffer[mK + 16]).ToString();
                                objSystemArgs.m_strUSAlarmup = (readBuffer[mK + 17] << 8 + readBuffer[mK + 18]).ToString();
                                objSystemArgs.m_strStorMode = ((char)readBuffer[mK + 19]).ToString();
                                objSystemArgs.m_strUvLamp = (readBuffer[mK + 20] << 8 + readBuffer[mK + 21]).ToString();
                                objSystemArgs.m_strPumpPipe = (readBuffer[mK + 22] << 8 + readBuffer[mK + 23]).ToString();
                                ValueSystemArgs(objSystemArgs);
                            }
                            //(4)   读取测试结果  --- ‘R’ ;
                            if (readBuffer[mK + 5] == 0x52)
                            {
                                dealTestResult(readBuffer, true);
                            }

                            //(6)   读取历史记录  --- ‘H’ ;
                            if (readBuffer[mK + 5] == 0x48)
                            {
                                dealTestResult(readBuffer, false);
                            }
                            //(8)   读取审计追踪记录  --- ‘A’ ;
                            if (readBuffer[mK + 5] == 0x41)
                            {
                                dealAuditRecord(readBuffer);
                            }
                        }
                        break;
                    //W写入命令
                    case 0x57:
                        {
                            //此处为空白，已经分散到各个控制按钮中
                        }
                        break;
                    default:
                        break;
                }
            }
            catch(Exception ex)
            {
                TOCTest.utils.loghelp.log.Error(ex.Message,ex);
            }
        }

        private static void dealTestResult(byte[] readBuffer,bool bIsFlag)
        {
            TestResult objTestResult = new TestResult();
            int mK = 0;
            objTestResult.m_strTestType = TOCTest.utils.help.Chr(readBuffer[mK + 6]);
            for (int i = 0; i < 16; i++)
            {
                string temp = TOCTest.utils.help.Chr(readBuffer[mK + 7 + i]);
                if (temp != "\0")
                {
                    objTestResult.m_strTestPsernum = objTestResult.m_strTestPsernum + temp;
                }  
            }

            for (int i = 0; i < 16; i++)
            {
                string temp = TOCTest.utils.help.Chr(readBuffer[mK + 23 + i]);
                if (temp != "\0")
                {
                    objTestResult.m_strTestOprationName = objTestResult.m_strTestOprationName + temp;
                }  
            }

            objTestResult.m_strTestStartDt = "20" + readBuffer[mK + 39].ToString("D2") + "-" + readBuffer[mK + 40].ToString("D2") + "-" + readBuffer[mK + 41].ToString("D2") + " " + readBuffer[mK + 42].ToString("D2") + ":" + readBuffer[mK + 43].ToString("D2");
            objTestResult.m_strBottAmount = readBuffer[mK + 44].ToString();
            objTestResult.m_strStartBott = readBuffer[mK + 45].ToString();
            objTestResult.m_strDiluMult = (readBuffer[mK + 46] << 32 + readBuffer[mK + 47] << 16 + readBuffer[mK + 48] << 8 + readBuffer[mK + 49]).ToString();
            objTestResult.m_strTestEndDt = "20" + readBuffer[mK + 50].ToString("D2") + "-" + readBuffer[mK + 51].ToString("D2") + "-" + readBuffer[mK + 52].ToString("D2") + " " + readBuffer[mK + 53].ToString("D2") + ":" + readBuffer[mK + 54].ToString("D2");
            int nTemp0 = readBuffer[mK + 58];
            int nTemp1 = readBuffer[mK + 57] << 8;
            int nTemp2 = readBuffer[mK + 56] << 16;
            int nTemp3 = readBuffer[mK + 55] << 32;
            int nTestimes = nTemp3 + nTemp2 + nTemp1 + nTemp0;
            objTestResult.m_strHTestTestimes = nTestimes.ToString();

            int nTemp = 59;
            if (objTestResult.m_strTestType == "3")
            {
                objTestResult.m_objConResult.m_strRw= (readBuffer[mK + 54] << 8 + readBuffer[mK + 55]).ToString();
                objTestResult.m_objConResult.m_strRs = (readBuffer[mK + 56] << 8 + readBuffer[mK + 57]).ToString();
                objTestResult.m_objConResult.m_strRss = (readBuffer[mK + 58] << 8 + readBuffer[mK + 59]).ToString();
                objTestResult.m_objConResult.m_strResponseRate = (readBuffer[mK + 60] << 8 + readBuffer[mK + 61]).ToString();
            }
            else
            {
                for (int i = 0; i < nTestimes * 2; i = i + 2)
                {
                    objTestResult.m_strTOCValue = objTestResult.m_strTOCValue  + ((readBuffer[nTemp + i +1] << 8) + (readBuffer[nTemp + i])).ToString() + ",";
                }

                nTemp = 59 + 300;
                for (int i = 0; i < nTestimes * 2; i = i + 2)
                {
                    objTestResult.m_strTCValue = objTestResult.m_strTCValue + ((readBuffer[nTemp + i + 1] << 8) + (readBuffer[nTemp + i])).ToString() + ",";
                }

                nTemp = 59 + 600;
                for (int i = 0; i < nTestimes * 2; i = i + 2)
                {
                    objTestResult.m_strConduct = objTestResult.m_strConduct + ((readBuffer[nTemp + i + 1] << 8) + (readBuffer[nTemp + i])).ToString() + ",";
                }
            }
             AddDeviceDB(objTestResult);
             if (bIsFlag)
             {
                 ValueTestResult(objTestResult);
             }
        }

        
        private static void dealAuditRecord(byte[] readBuffer)
        {
            AuditRecord objAuditRecord = new AuditRecord();
            int mK = 0;
            objAuditRecord.m_strUserNum = readBuffer[mK + 6].ToString();
            objAuditRecord.m_strOperationNum = readBuffer[mK + 7].ToString();
            for (int i = 0; i < 16; i++)
            {
                string temp = ((char)readBuffer[mK + 9 +i]).ToString();
                if (temp != "\0")
                {
                    objAuditRecord.m_strUserName = objAuditRecord.m_strUserName + temp;
                }
            }
            objAuditRecord.m_strStartTime = "20" + readBuffer[24].ToString("D2") + "-" + readBuffer[25].ToString("D2") + "-" + readBuffer[26].ToString("D2") + " " + readBuffer[27].ToString("D2") + ":" + readBuffer[28].ToString("D2");
            for (int i = 0; i < 32; i++)
            {
                string temp = ((char)readBuffer[mK + 29 + i]).ToString();
                if (temp != "\0")
                {
                    objAuditRecord.m_strOperationType = objAuditRecord.m_strOperationType + temp;
                }
            }

            for (int i = 0; i < 32; i++)
            {
                 string temp = ((char)readBuffer[mK + 61 + i]).ToString();
                 if (temp != "\0")
                 {
                     objAuditRecord.m_strOperationReason = objAuditRecord.m_strOperationReason + temp;
                 }
            }

            AddAlertDB(objAuditRecord);
        }

        /// <summary>
        /// 增加到报警纪录
        /// </summary>
        /// <param name="objAuditRecord"></param>
        private static void AddAlertDB(AuditRecord objAuditRecord)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\AlertRecord.mdb";
            string strDBInfo = String.Format("insert into t_AlertRecord ([UserNmer],[OperationNumer],[UserName],[StartTime],[OperationType],[OperationReason]) values ('{0}','{1}','{2}','{3}','{4}','{5}')", objAuditRecord.m_strUserNum, objAuditRecord.m_strOperationNum, objAuditRecord.m_strUserName, objAuditRecord.m_strStartTime, objAuditRecord.m_strOperationType,objAuditRecord.m_strOperationReason);
            TOCTest.db.dbMrg.AlterDB(strConnection, strDBInfo);
        }

        /// <summary>
        /// 增加设备
        /// </summary>
        /// <param name="objTestResult"></param>
        private static void AddDeviceDB(TestResult objTestResult)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\HistoryData.mdb";
            string strDBInfo = String.Format("insert into {0} ([Test_type],[Test_Psernum],[Test_OprationName],[Test_StartDt],[Bott_Amount],[Start_Bott],[Dilu_Mult],[Test_EndDt],[Htest_testimes],[TOCValue],[TCValue],[Conduct]) values ('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
                TOCTest.Main.ms_strDeviceName,objTestResult.m_strTestType, objTestResult.m_strTestPsernum, objTestResult.m_strTestOprationName, objTestResult.m_strTestStartDt, objTestResult.m_strBottAmount,
                objTestResult.m_strStartBott, objTestResult.m_strDiluMult, objTestResult.m_strTestEndDt,objTestResult.m_strHTestTestimes, objTestResult.m_strTOCValue, objTestResult.m_strTCValue, objTestResult.m_strConduct);
            TOCTest.db.dbMrg.AlterDB(strConnection, strDBInfo);
        }
    }

    /// <summary>
    /// 系统状态
    /// </summary>
    public struct SystemState
    {
        public string m_strTestType; //测试模态 (Z/L/S/C/)
        public string m_strTOCValue; //TOC的值
        public string m_strTIC_Value;//TICValue值
        public string m_strCON_Value; //电导率
        public string m_strSampleNum;//当前样品数量
        public string m_strRunStatus;//运行状态 (S/R/)
    }

    public struct OnlineResult
    {
        public DateTime m_dtInterval;
        public string m_strTOC;
        public string m_strIC;
    }

    public struct OfflineResult
    {
        public DateTime m_dtInterval;
        public string m_strTOC;
        public string m_strIC;
    }

    public struct TestResult
    {
        public string m_strTestType;         //测试模态 (Z/L/S/C/)
        public string m_strTestPsernum;      //测试序号
        public string m_strTestOprationName; //操作人员
        public string m_strTestStartDt;      //开始日期/时间
        public string m_strBottAmount;       //瓶数 
        public string m_strStartBott;        //起始瓶号
        public string m_strDiluMult;         //稀释倍数
        public string m_strTestEndDt;        //结束日期/时间
        public string m_strHTestTestimes;    //曲线的采样次数
        public string m_strTOCValue;         //TOC值
        public string m_strTCValue;          //TC值
        public string m_strConduct;          //电导率
        public ConResult m_objConResult;     //适应性验证结果
    }

    public struct SystemArgs
    {
        public string m_strSampVmax;       //内部样品流速
        public string m_strSampTimer;      //在线采样周期
        public string m_strChannlSum;      //在线通道数
        public string m_strLTests;         //离线测试次数
        public string m_strLForsake;       //离线抛弃次数
        public string m_strLCleartime;     //离线冲洗时间
        public string m_strTOCAlarmup;     //TOC报警上限
        public string m_strUSAlarmup;      //电导率报警上限
        public string m_strStorMode;       //数据存储方式
        public string m_strUvLamp;         //UV灯
        public string m_strPumpPipe;       //泵管
    }

    public struct AuditRecord
    {
        public string m_strUserNum;          //用户编号
        public string m_strOperationNum;     //操作种类编号
        public string m_strUserName;         //用户名
        public string m_strStartTime;        //开始日期/时间
        public string m_strOperationType;    //操作种类
        public string m_strOperationReason;  //操作原因
    }

    public struct ConResult
    {
        public string m_strRw;  //纯水TOC
        public string m_strRs;  //蔗糖TOC
        public string m_strRss; //苯醌TOC
        public string m_strResponseRate; //响应率
    }

    public struct ConfigHis
    {
          public string m_strCodeType;   // 1--离线检测, 2--在线检测， 3--系统适应性
          public string m_strCodeName;   // 组名
          public string m_strStartTime;   // 起始时间
          public string m_strEndTime;   // 结束时间  {在线测试时，存放离线测试的数据总数(代表了结束时间)；离线测试时，EndTime[0]：样品数量，EndTime[1]：单个样品的保留的测试次数，EndTime[2]：起始瓶号，EndTime[3]：进样方式}
          public string m_strOperator;   // 操作人
          public string m_strChannlesum    ;   // 通道数量
         //------------------------------------------------------------
         public string m_stronlinestflag  ;   // 在线测试的起始/结束标志 ( 0-- 中间标志；1--起始标志；2-- 结束标志)
         public string m_strTOCValue ;
         public string m_strTCValue;
         public string m_strConduct;
         public string m_strAveTOCValue;
         public string m_strAveTCValue;
         public string m_strAveConduct;
         public string m_strLsampleNum;   // 存放离线测试样品数量
         public string m_strNum;   // 单个样品的保留的测试次数
         public string m_strStartBott;        //起始瓶号
         public string m_strSampleWay;  //进样方式
         public string m_strBott_Amount;
         public string m_strSum_Num;

    }
}
