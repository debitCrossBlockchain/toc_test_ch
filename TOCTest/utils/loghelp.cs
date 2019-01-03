using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOCTest.utils
{
    /// <summary>
    /// 用于log日志的文件
    /// </summary>
   public class loghelp
    {
       public static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
