using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TOCTest.utils
{

    /// <summary>
    /// 帮助文件
    /// </summary>
    public class help
    {
        public static DateTime GetDateTime(string strDateTime)
        {
            if (strDateTime.Length != 17)
            {
                return DateTime.Now;
            }
            string str = strDateTime;
            string strInfo = str.Substring(1, 4) + "/" + str.Substring(6, 2) + "/" + str.Substring(9, 2) + " "
                + str.Substring(12, 2) + ":" + str.Substring(15, 2);
            DateTime begin = DateTime.ParseExact(strInfo, "yyyy/MM/dd HH:mm", null);
            return begin;
        }
        //字符转ASCII码：
        public static int Asc(string character)
        {
            if (character.Length == 1)
            {
                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                int intAsciiCode = (int)asciiEncoding.GetBytes(character)[0];
                return (intAsciiCode);
            }
            else
            {
                throw new Exception("Character is not valid.");
            }
        }

        //ASCII码转字符：
        public static string Chr(int asciiCode)
        {
            if (asciiCode >= 0 && asciiCode <= 255)
            {
                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                byte[] byteArray = new byte[] { (byte)asciiCode };
                string strCharacter = asciiEncoding.GetString(byteArray);
                return (strCharacter);
            }
            else
            {
                throw new Exception("ASCII Code is not valid.");
            }
        }

        public static string ConvertString2Double(string source)
        {
            if (!string.IsNullOrEmpty(source) && (Regex.IsMatch(source, @"^[1-9]\d*|0$") || Regex.IsMatch(source, @"^[1-9]\d*\.\d*|0\.\d*[1-9]\d*$")))
            {
                return Convert.ToDecimal(float.Parse(source) / 1000).ToString("F3");
            }
            else
            {
                return "0.000";
            }
        }

        /// <summary>
        /// 获取校验和
        /// </summary>
        /// <param name="strComd"></param>
        public static byte[] getCheckSum(string strComd)
        {
            byte[] sendData = converStringToByte(strComd);
            int sum = 0;
            foreach (int i in sendData)
            {
                sum += i;
            }
            sendData[sendData.Length - 1] = (byte)(sum % 256);
            return sendData;
        }

        /// <summary>
        /// 将字符串转换为字节
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static byte[] converStringToByte(string strInfo)
        {
            MatchCollection mc = Regex.Matches(strInfo, @"(?i)[\da-f]{2}");
            List<byte> list = new List<byte>();//填充到这个临时列表中
            //依次添加到列表中
            foreach (Match m in mc)
            {
                list.Add(byte.Parse(m.Value, System.Globalization.NumberStyles.HexNumber));
            }
            byte[] byBuffer = new byte[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                byBuffer[i] = (byte)list[i];
            }
            return byBuffer;
        }

        /// <summary>
        /// 将字符串转换为16进制
        /// </summary>
        /// <param name="strInfo"></param>
        /// <returns></returns>
        public static string converStringHex(string strInfo,int length)
        {
            string Test_F = "";
            string Test_Fs = "";
            if (!string.IsNullOrEmpty(strInfo))
            {
                for (int i = 0; i < length - strInfo.Length; i++)
                {
                    Test_F = Test_F + "\0";
                }
                strInfo = strInfo + Test_F;

                for (int i = 0; i < length; i++)
                {
                    if (i < strInfo.Length)
                    {
                        Test_Fs = Test_Fs + (Encoding.ASCII.GetBytes(strInfo)[i]).ToString("X2");
                    }
                    else
                    {
                        Test_Fs = Test_Fs + "00";
                    }
                }
            }
            else
            {
                Test_Fs = (0).ToString("X32");
            }
            return Test_Fs;
        }

        public static string getDBDateTime(string strDTime)
        {
            if (!string.IsNullOrEmpty(strDTime))
            {
                return getDateTime();
            }
            string strMDataTime = "";
            string DT = strDTime.Replace(" ", "");
            DT = DT.Trim();
            DT = DT.Replace("-", "");
            DT = DT.Replace(":", "");
            DT = DT.Replace("", "");
            string mDataTime = DT;

            for (int i = 0; i < mDataTime.Length; )
            {
                strMDataTime = strMDataTime + (Convert.ToInt32(((mDataTime[i].ToString()) + (mDataTime[i + 1].ToString())))).ToString("X2");
                i = i + 2;
            }
            return strMDataTime;
        }

        public static string getDateTime()
        {
            string strDTime = " " + DateTime.Now.Year.ToString("D4") + "-" + DateTime.Now.Month.ToString("D2") + "-" + DateTime.Now.Day.ToString("D2") + " " + DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + "";
            string strMDataTime = "";
            string DT = strDTime.Replace(" ", "");
            DT = DT.Trim();
            DT = DT.Replace("-", "");
            DT = DT.Replace(":", "");
            DT = DT.Replace("", "");
            string mDataTime = DT;

            if (DT.Length >= 10)
            {
                for (int i = 2; i < mDataTime.Length-1; )
                {
                    strMDataTime = strMDataTime + (Convert.ToInt32(((mDataTime[i].ToString()) + (mDataTime[i + 1].ToString())))).ToString("X2");
                    i = i + 2;
                }
            }
            return strMDataTime;
        }

        #region 字符串和Byte之间的转化
        /// <summary>
        /// 数字和字节之间互转
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int IntToBitConverter(int num)
        {
            int temp = 0;
            byte[] bytes = BitConverter.GetBytes(num);//将int32转换为字节数组
            temp = BitConverter.ToInt32(bytes, 0);//将字节数组内容再转成int32类型
            return temp;
        }

        /// <summary>
        /// 将字符串转为16进制字符，允许中文
        /// </summary>
        /// <param name="s"></param>
        /// <param name="encode"></param>
        /// <returns></returns>
        public static string StringToHexString(string s, Encoding encode, string spanString)
        {
            byte[] b = encode.GetBytes(s);//按照指定编码将string编程字节数组
            string result = string.Empty;
            for (int i = 0; i < b.Length; i++)//逐字节变为16进制字符
            {
                result += Convert.ToString(b[i], 16) + spanString;
            }
            return result;
        }
        /// <summary>
        /// 将16进制字符串转为字符串
        /// </summary>
        /// <param name="hs"></param>
        /// <param name="encode"></param>
        /// <returns></returns>
        public static string HexStringToString(string hs, Encoding encode)
        {
            string strTemp = "";
            byte[] b = new byte[hs.Length / 2];
            for (int i = 0; i < hs.Length / 2; i++)
            {
                strTemp = hs.Substring(i * 2, 2);
                b[i] = Convert.ToByte(strTemp, 16);
            }
            //按照指定编码将字节数组变为字符串
            return encode.GetString(b);
        }
        /// <summary>
        /// byte[]转为16进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ByteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }

        /// <summary>
        /// 将16进制的字符串转为byte[]
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] StrToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        #endregion
    }
}
