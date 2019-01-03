using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOCTest.forms
{
    public class UserInfo
    {
         //begin Singleton pattern
        static readonly UserInfo instance = new UserInfo();
        public static string m_strUserName;
        public static string m_strUserLevel;

        /// <summary>
        /// 构造函数
        /// </summary>
        UserInfo()
        {
            m_strUserName = "";
            m_strUserLevel = "";
        }

        /// 实例化
        /// </summary>
        public static UserInfo Instance
        {
            get
            {
                return instance;
            }
        }
        public string getUserName()
        {
            return m_strUserName;
        }

        public string getUserLevel()
        {
            return m_strUserLevel;
        }

        /// <summary>
        /// 设置用户信息
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="strLevel"></param>
        public void SetInfo(string strName, string strLevel)
        {
            m_strUserName = strName;
            m_strUserLevel = strLevel;
        }
    }
}
