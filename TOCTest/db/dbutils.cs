using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ADOX;//引用创建Access数据库的库
using System.IO;
using System.Data.OleDb;
using System.Data;
using TOCTest.utils;

namespace TOCTest.db
{
    public class dbutils
    {
        /// <summary>
        /// 判断数据库历史数据是否为空
        /// </summary>
        public static bool GetTables(OleDbConnection conn, string TableName)
        {
            int result = 0;
            DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                                                              new object[] { null, null, null, "TABLE" });
            try
            {
                if (schemaTable != null)
                {
                    for (Int32 row = 0; row < schemaTable.Rows.Count; row++)
                    {
                        string col_name = schemaTable.Rows[row]["TABLE_NAME"].ToString();
                        if (col_name == TableName)
                        {
                            result++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                loghelp.log.Error("dbutils.GetTables" + ex.Message, ex);
            }
            if (result == 0)
                return false;
            return true;
        }
    }
}
