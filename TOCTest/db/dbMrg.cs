using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ADOX;//引用创建Access数据库的库
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Security.Cryptography;
using TOCTest.utils;
using System.Windows.Forms;

namespace TOCTest.db
{
    public class dbMrg
    {
       public static string ms_strTestParam = "..\\..\\mdb\\TestParam.mdb";
       public static string ms_strUserInfo = "..\\..\\mdb\\UserInfo.mdb";
       public static string ms_strHistoryData = "..\\..\\mdb\\HistoryData.mdb";
       public static string ms_strAlertRecord = "..\\..\\mdb\\AlertRecord.mdb";
       public static string ms_strSystemParameter = "..\\..\\mdb\\SystemParameter.mdb";
        /// <summary>
        /// 创建数据库表
        /// </summary>
        /// <param name="strConnection"></param>
        /// <param name="strTableName"></param>
        /// <param name="listColumns"></param>
        public static void CreatDBTable(string strConnection, string strTableName, List<string> listColumns)
        {
            ADOX.Catalog catalog = new Catalog();
            ADODB.Connection cn = new ADODB.Connection();
            strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=" + strConnection;
            OleDbConnection conn = new OleDbConnection(strConnection);
            try
            {
                conn.Open();
                cn.Open(strConnection, null, null, -1);
                catalog.ActiveConnection = cn;
                if (string.IsNullOrEmpty(strTableName))
                {
                    loghelp.log.Error("表名不能为空!");
                    return;
                }

                bool flag = db.dbutils.GetTables(conn, strTableName);
                if (!flag)//判断表名是否存在
                {
                    ADOX.Table table = new ADOX.Table();

                    table.Name = strTableName;

                    ADOX.Column column = new ADOX.Column();
                    column.ParentCatalog = catalog;
                    column.Name = "id";
                    column.Type = ADOX.DataTypeEnum.adInteger;
                    column.DefinedSize = 50;
                    column.Properties["AutoIncrement"].Value = true;
                    table.Columns.Append(column, DataTypeEnum.adInteger, 50);
                    table.Keys.Append("FirstTablePrimaryKey", KeyTypeEnum.adKeyPrimary, column, null, null);
                    foreach (string strColumns in listColumns)
                    {
                        table.Columns.Append(strColumns, DataTypeEnum.adVarWChar, 50);
                        table.Columns[strColumns].Attributes = ColumnAttributesEnum.adColNullable;
                    }
                    catalog.Tables.Append(table);

                    //此处一定要关闭连接，否则添加数据时候会出错
                    table = null;
                    catalog = null;
                }
            }
            catch (Exception ex)
            {
                loghelp.log.Fatal(ex.Message, ex);
            }
            finally
            {
                conn.Close();
                cn.Close();
            }
        }

        /// <summary>
        /// 创建db所在的目录和数据库
        /// </summary>
        /// <param name="strDBName"></param>
        private static void CreateDB(string strDBName)
        {
            try
            {
                if (!File.Exists(strDBName)) //判断是否存在数据库，不存在，则创建
                {
                    ADOX.Catalog catalog = new Catalog();
                    string strTemp = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strDBName + ";Jet OLEDB:Engine Type=5";
                    catalog.Create(strTemp);
                }
            }
            catch (Exception ex)
            {
                loghelp.log.Error(ex.Message, ex);
            }
        }

        /// <summary>
        /// 创建目录
        /// </summary>
        /// <param name="strDir"></param>
        private static void CreateDir(string strDir)
        {
            try
            {
                if (Directory.Exists(strDir) == false)//如果不存在就创建file文件夹
                {
                    Directory.CreateDirectory(strDir);
                }
            }
            catch (Exception ex)
            {
                loghelp.log.Error(ex.Message, ex);
            }
        }

        /// <summary>
        /// 修改和更新数据库
        /// </summary>
        /// <param name="strConnection"></param>
        /// <param name="strDBInfo"></param>
        public static void AlterDB(string strConnection, string strDBInfo)
        {
            OleDbConnection conn = new OleDbConnection(strConnection);
            OleDbCommand da = new OleDbCommand(strDBInfo, conn);
            try
            {
                da.CommandType = CommandType.Text;
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                da.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                loghelp.log.Error(ex.Message, ex);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 查询特定条件的所有值
        /// </summary>
        /// <param name="strConnection"></param>
        /// <param name="strDBInfo"></param>
        /// <returns></returns>
        public static List<string> QueryDB(string strConnection, string strDBInfo,int nLenth)
        {
            OleDbConnection conn = new OleDbConnection(strConnection);
            OleDbCommand da = new OleDbCommand(strDBInfo, conn);
             List<string> listDBInfo = new List<string>();
            try
            {
                da.CommandType = CommandType.Text;
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                OleDbDataReader reader = da.ExecuteReader();
                if(reader.Read())
                {
                    for(int i=0;i<nLenth;i++)
                    {
                        listDBInfo.Add(reader[i].ToString());
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                loghelp.log.Error( ex.Message, ex);
            }
            finally
            {
                conn.Close();
            }
            return listDBInfo;
        }

        /// <summary>
        /// 查询特定条件的字段是否存在
        /// </summary>
        /// <param name="strConnection"></param>
        /// <param name="strDBInfo"></param>
        /// <returns>true 为存在</returns>
        public static bool QueryExistDB(string strConnection, string strDBInfo)
        {
            OleDbConnection conn = new OleDbConnection(strConnection);
            OleDbCommand da = new OleDbCommand(strDBInfo, conn);
            bool bExist = false;
            try
            {
                da.CommandType = CommandType.Text;
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                if (da.ExecuteScalar() != null)
                {
                    bExist = true;//表示存在
                }
                else
                {
                    bExist = false;
                }
            }
            catch (Exception ex)
            {
                loghelp.log.Error(ex.Message, ex);
            }
            finally
            {
                conn.Close();
            }
            return bExist;
        }

        /// <summary>
        /// 创建数据库
        /// </summary>
        public static void CreateDB()
        {
            CreateDir("..\\..\\mdb");
            CreateDB(ms_strTestParam);
            CreateDB(ms_strUserInfo);
            CreateDB(ms_strHistoryData);
            CreateDB(ms_strAlertRecord);
            CreateDB(ms_strSystemParameter);
        }

        /// <summary>
        /// 创建用户表
        /// </summary>
        public static void CreateUserTable()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\UserInfo.mdb";
            List<string> listColumns = new List<string>();
            listColumns.Add("userName");
            listColumns.Add("userPwd");
            listColumns.Add("userLevel");
            listColumns.Add("userSernum ");
            CreatDBTable(strConnection,"t_UserInfo",listColumns);
        }

        /// <summary>
        /// 创建报警表
        /// </summary>
        public static void CreateAlertTable()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\AlertRecord.mdb";
            List<string> listColumns = new List<string>();
            listColumns.Add("UserNmer");
            listColumns.Add("OperationNumer");
            listColumns.Add("UserName");
            listColumns.Add("StartTime");
            listColumns.Add("OperationType");
            listColumns.Add("OperationReason");
            CreatDBTable(strConnection, "t_AlertRecord", listColumns);
        }

        public static void CreateAlertTable(string strTableName)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\AlertRecord.mdb";
            List<string> listColumns = new List<string>();
            listColumns.Add("UserNmer");
            listColumns.Add("OperationNumer");
            listColumns.Add("UserName");
            listColumns.Add("StartTime");
            listColumns.Add("OperationType");
            listColumns.Add("OperationReason");
            CreatDBTable(strConnection, strTableName, listColumns);
        }

        public static void CreateSystemArgsTable(string strDeviceName)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\SystemParameter.mdb";
            List<string> listColumns = new List<string>();
            listColumns.Add("name");
            listColumns.Add("SampVmax");
            listColumns.Add("SampTimer");
            listColumns.Add("ChannlSum");
            listColumns.Add("LTests");
            listColumns.Add("LForsake");
            listColumns.Add("LCleartime");
            listColumns.Add("TOCAlarmup");
            listColumns.Add("USAlarmup");
            listColumns.Add("StorMode");
            listColumns.Add("UvLamp");
            listColumns.Add("PumpPipe");
            CreatDBTable(strConnection, strDeviceName, listColumns);
        }

        /// <summary>
        /// 增加用户表信息
        /// </summary>
        /// <param name="strUserName"></param>
        /// <param name="strUserPwd"></param>
        /// <param name="strUserLevel"></param>
        /// <param name="strUserSernum"></param>
        public static void AddUserInfo(string strUserName, string strUserPwd, string strUserLevel, string strUserSernum)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\UserInfo.mdb";
            bool bExist = db.dbMrg.QueryExistDB(strConnection, "Select * From t_UserInfo where [userName]='" + strUserName + "'");
            if (!bExist)
            {
                byte[] result = Encoding.Default.GetBytes(strUserPwd);    //mPwd为输入密码
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(result);
                strUserPwd = BitConverter.ToString(output).Replace("-", "");  //Pwd为输出加密文本
                string strDBInfo = String.Format("insert into t_UserInfo ([userName],[userPwd],[userLevel],[userSernum]) values ('{0}','{1}','{2}','{3}')", strUserName, strUserPwd, strUserLevel, strUserSernum);
                AlterDB(strConnection, strDBInfo);
            }
            if (bExist)
            {
                MessageBox.Show("用户已存在!");
            }
        }

        /// <summary>
        /// 增加报警记录
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="strRemarks"></param>
        /// <param name="strInstrumenNumber"></param>
        /// <param name="strOperator"></param>
        public static void AddAlertInfo(string strUserNmer, string strOperationNumer, string strUserName, string strStartTime, string strOperationType, string strOperationReason)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\AlertRecord.mdb";
            string strTimeDate =DateTime.Now.ToString();
            string strDBInfo = String.Format("insert into t_AlertRecord ([UserNmer],[OperationNumer],[UserName],[StartTime],[OperationType],[OperationReason]) values ('{0}','{1}','{2}','{3}','{4}','{5}')", strUserNmer, strOperationNumer, strUserName, strStartTime, strOperationType, strOperationReason);
            AlterDB(strConnection,strDBInfo);
        }

        public static void AddAlertInfo(string strTableName,string strUserNmer, string strOperationNumer, string strUserName, string strStartTime, string strOperationType, string strOperationReason)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\AlertRecord.mdb";
            string strTimeDate = DateTime.Now.ToString();
            string strDBInfo = String.Format("insert into {0} ([UserNmer],[OperationNumer],[UserName],[StartTime],[OperationType],[OperationReason]) values ('{1}','{2}','{3}','{4}','{5}','{6}')", strTableName,strUserNmer, strOperationNumer, strUserName, strStartTime, strOperationType, strOperationReason);
            AlterDB(strConnection, strDBInfo);
        }



        
        public static void CreatHDateTable(string strTableName)
        {
            List<string> listColumns = new List<string>();
            
            listColumns.Add("Test_Psernum");
            listColumns.Add("Bott_Amount");
            listColumns.Add("Dilu_Mult");

            listColumns.Add("CodeType");
            listColumns.Add("CodeName");
            listColumns.Add("Test_StartDt");
            listColumns.Add("Test_EndDt");
            listColumns.Add("Test_OprationName");
            listColumns.Add("Channlesum");
            listColumns.Add("OnlinestFlag");
            listColumns.Add("AveTOCValue");
            listColumns.Add("AveTCValue");
            listColumns.Add("AveConduct");
            listColumns.Add("LsampleNum");
            listColumns.Add("Htest_testimes");
            listColumns.Add("Start_Bott");
            listColumns.Add("SampleWay");
            listColumns.Add("Htest_sum");

            string strConnection = "..\\..\\mdb\\HistoryData.mdb";
            ADOX.Catalog catalog = new Catalog();
            ADODB.Connection cn = new ADODB.Connection();
            strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=" + strConnection;
            OleDbConnection conn = new OleDbConnection(strConnection);
            try
            {
                conn.Open();
                cn.Open(strConnection, null, null, -1);
                catalog.ActiveConnection = cn;
                if (string.IsNullOrEmpty(strTableName))
                {
                    loghelp.log.Error("表名不能为空!");
                    return;
                }

                bool flag = db.dbutils.GetTables(conn, strTableName);
                if (!flag)//判断表名是否存在
                {
                    ADOX.Table table = new ADOX.Table();

                    table.Name = strTableName;

                    ADOX.Column column = new ADOX.Column();
                    column.ParentCatalog = catalog;
                    column.Name = "id";
                    column.Type = ADOX.DataTypeEnum.adInteger;
                    column.DefinedSize = 50;
                    column.Properties["AutoIncrement"].Value = true;
                    table.Columns.Append(column, DataTypeEnum.adInteger, 50);
                    table.Keys.Append("FirstTablePrimaryKey", KeyTypeEnum.adKeyPrimary, column, null, null);
                    foreach (string strColumns in listColumns)
                    {
                        table.Columns.Append(strColumns, DataTypeEnum.adVarWChar, 50);
                        table.Columns[strColumns].Attributes = ColumnAttributesEnum.adColNullable;
                    }
                    table.Columns.Append("TOCValue", DataTypeEnum.adLongVarWChar, 1000);
                    table.Columns["TOCValue"].Attributes = ColumnAttributesEnum.adColNullable;
                    table.Columns.Append("TCValue", DataTypeEnum.adLongVarWChar, 1000);
                    table.Columns["TCValue"].Attributes = ColumnAttributesEnum.adColNullable;
                    table.Columns.Append("Conduct", DataTypeEnum.adLongVarWChar, 1000);
                    table.Columns["Conduct"].Attributes = ColumnAttributesEnum.adColNullable;
                    catalog.Tables.Append(table);

                    //此处一定要关闭连接，否则添加数据时候会出错
                    table = null;
                    catalog = null;
                }
            }
            catch (Exception ex)
            {
                loghelp.log.Fatal(ex.Message, ex);
            }
            finally
            {
                conn.Close();
                cn.Close();
            }
        }

        /// <summary>
        /// 创建设备表
        /// </summary>
        public static void CreateDeviceTable()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\TestParam.mdb";
            List<string> listColumns = new List<string>();
            listColumns.Add("name");
            listColumns.Add("deviceID");
            listColumns.Add("info");
            CreatDBTable(strConnection, "t_Device", listColumns);
        }

        /// <summary>
        /// 增加设备
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="strDeviceID"></param>
        public static void AddDeviceTable(string strName, string strDeviceID,string strInfo)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\TestParam.mdb";
            bool bExist = db.dbMrg.QueryExistDB(strConnection, "Select * From t_Device where [name]='" + strName + "'");
            if (!bExist)
            {
                string strDBInfo = String.Format("insert into t_Device([name],[deviceID],[info]) values ('{0}','{1}','{2}')", strName, strDeviceID,strInfo);
                AlterDB(strConnection, strDBInfo);
            }
        }

        public static string QueryDeviceNum(string strName)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\TestParam.mdb";
            string strDBInfo = "Select deviceID From t_Device where [name]='" + strName + "'";
            OleDbConnection conn = new OleDbConnection(strConnection);
            OleDbCommand da = new OleDbCommand(strDBInfo, conn);
            int nDeviceNum = 0;
            try
            {
                da.CommandType = CommandType.Text;
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                OleDbDataReader reader = da.ExecuteReader();
                if (reader.Read())
                {
                    nDeviceNum = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                loghelp.log.Error(ex.Message, ex);
            }
            finally
            {
                conn.Close();
            }
            return nDeviceNum.ToString("X2");
        }


        /// <summary>
        /// 删除设备记录
        /// </summary>
        /// <param name="strName"></param>
        public static void DelDeviceTable(string strName)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\mdb\\TestParam.mdb";
            bool bExist = db.dbMrg.QueryExistDB(strConnection, "Select * From t_Device where [name]='" + strName + "'");
            if (bExist)
            {
                string strDBInfo = String.Format("delete * From t_Device where [name]= {0}", "'"+strName+"'");
                AlterDB(strConnection, strDBInfo);
            }
        }

        /// <summary>
        /// 删除表
        /// </summary>
        /// <param name="strConnection"></param>
        /// <param name="strTableName"></param>
        public static void DeleteDBTable(string strConnection, string strTableName)
        {
            ADOX.Catalog catalog = new Catalog();
            ADODB.Connection cn = new ADODB.Connection();

            try
            {
                OleDbConnection conn = new OleDbConnection(strConnection);
                conn.Open();
                cn.Open(strConnection, null, null, -1);
                catalog.ActiveConnection = cn;

                bool flag = dbutils.GetTables(conn, strTableName);
                if (flag)//判断表名是否存在
                {
                    catalog.Tables.Delete(strTableName);
                }

                //此处一定要关闭连接，否则添加数据时候会出错
                catalog = null;
                Application.DoEvents();
                cn.Close();
            }
            catch (Exception ex)
            {
                loghelp.log.Fatal(ex.Message, ex);
            }
        }

    }
}
