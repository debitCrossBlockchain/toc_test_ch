using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Collections;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;


namespace TOCTest.comm
{
    /// <summary> CommPort class creates a singleton instance
    /// of SerialPort (System.IO.Ports) </summary>
    /// <remarks> When ready, you open the port.
    ///   <code>
    ///   CommPort com = CommPort.Instance;
    ///   com.StatusChanged += OnStatusChanged;
    ///   com.DataReceived += OnDataReceived;
    ///   com.Open();
    ///   </code>
    ///   Notice that delegates are used to handle status and data events.
    ///   When settings are changed, you close and reopen the port.
    ///   <code>
    ///   CommPort com = CommPort.Instance;
    ///   com.Close();
    ///   com.PortName = "COM4";
    ///   com.Open();
    ///   </code>
    /// </remarks>
    public sealed class CommPort
    {
        /// <summary>
        /// 串口操作
        /// </summary>

        SerialPort _serialPort;
        Thread _readThread;
        volatile bool _keepReading;
        Thread _dealRead;
        volatile bool _keepDeal;
        Thread _dealReadA;

        public int count;
        int mK = 0;
        int mKN = 0;
        private List<byte> readBuffer = new List<byte>(94096);

        //begin Singleton pattern
        static readonly CommPort instance = new CommPort();


        /// <summary>
        /// 构造函数
        /// </summary>
        CommPort()
        {
            _serialPort = new SerialPort();
            _readThread = null;
            _keepReading = false;
            _dealRead = null;
            _keepDeal = false;
        }


        /// 实例化
        /// </summary>
        public static CommPort Instance
        {
            get
            {
                return instance;
            }
        }
        //end Singleton pattern

        //begin Observer pattern
        public delegate void EventHandler(string param);
        public EventHandler StatusChanged;
        public EventHandler DataReceived;

        //end Observer pattern

        private void StartReading()
        {
            if (!_keepReading)
            {
                _keepReading = true;
                _readThread = new Thread(ReadPort);
                _readThread.Start();
            }
        }

        private void StopReading()
        {
            if (_keepReading)
            {
                _keepReading = false;
                _readThread.Join();	//block until exits
                _readThread = null;
            }
        }

        private void StartDealReading()
        {


            if (!_keepDeal)
            {
                _keepReading = true;
                _dealRead = new Thread(AnalysisPackage);
                _dealRead.Start();
            }
        }

        private void StopDealReading()
        {
            if (_keepDeal)
            {
                _keepDeal = false;
                _dealRead.Join();	//block until exits
                _dealRead = null;
            }
        }

        /// <summary>
        /// 分析数据包的完整性
        /// </summary>
        public void AnalysisPackage()
        {

            try
            {
                Int64 mSumReadBuffer = 0x00;
                if (readBuffer.Count >= 6)
                {
                    mKN = 0;

                    while ((mKN < readBuffer.Count - 1) && (readBuffer[mKN] != 0xFF))
                    {

                        mKN++;
                    }
                    readBuffer.RemoveRange(0, mKN);
                    mKN = 0;

                    if ((readBuffer[mKN] == 0xFF) && (readBuffer.Count > 0))
                    {
                        if (readBuffer.Count - mKN >= 6)//DeviceAddress = readBuffer[1];//用于各个界面进行比较
                        {
                            int len = readBuffer[mKN + 2] << 8 + readBuffer[mKN + 3];
                            if (readBuffer.Count - mKN >= len)//DeviceAddress = readBuffer[1];//用于各个界面进行比较
                            {
                                for (int i = mKN; i < len + mKN - 1; i++)
                                {
                                    mSumReadBuffer = mSumReadBuffer + readBuffer[i];
                                }
                                mSumReadBuffer = mSumReadBuffer & 0xFF;

                                if (readBuffer[len + mK - 1] == mSumReadBuffer)
                                {
                                    byte[] mBuf = new byte[len];
                                    readBuffer.CopyTo(mKN, mBuf, 0, len);

                                    _dealReadA = new Thread(delegate()
                                    {
                                       TOCTest.comm.protocol.DealRead(mBuf);
                                    });
                                    _dealReadA.Start();
                                    readBuffer.RemoveRange(mKN, len);
                                }
                                else
                                {
                                    int mkk = 0;
                                    while ((mkk + 1 < readBuffer.Count - 1) && (readBuffer[mkk + 1] != 0xFF))
                                    {
                                        mkk++;
                                    }
                                    readBuffer.RemoveRange(0, mkk + 1);
                                }
                            }
                        }
                    }
                }

            }
            catch (TimeoutException) { }
        }

        /// <summary> Get the data and pass it on. </summary>
        private void ReadPort()
        {
            while (_keepReading)
            {
                //_readThread.Priority = ThreadPriority.AboveNormal;
                Thread.Sleep(30);
                if (_serialPort.IsOpen)
                {
                    int n = _serialPort.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致  

                    try
                    {
                        byte[] Buffer = new byte[n]; //声明一个临时数组存储当前来的串口数据      
                        // If there are bytes available on the serial port,
                        // Read returns up to "count" bytes, but will not block (wait)
                        // for the remaining bytes. If there are no bytes available
                        // on the serial port, Read will block until at least one byte
                        // is available on the port, up until the ReadTimeout milliseconds
                        // have elapsed, at which time a TimeoutException will be thrown.
                        //Thread.Sleep(20);
                        _serialPort.Read(Buffer, 0, n);
                        if (_keepDeal == false)
                        {
                            readBuffer.AddRange(Buffer);
                        }
                        if (_keepDeal != false)
                        {
                            lock (_dealRead)
                            {
                                readBuffer.AddRange(Buffer);
                            }
                        }
                        //_serialPort.DiscardInBuffer();
                        if (readBuffer.Count >= 5)
                        {
                            StartDealReading();
                            //_dealRead.Priority = ThreadPriority.BelowNormal;
                        }
                    }
                    catch (TimeoutException) { }
                }
                else
                {
                    TimeSpan waitTime = new TimeSpan(0, 0, 0, 0, 50);
                    Thread.Sleep(waitTime);
                }
            }
        }

        /// <summary> Open the serial port with current settings. </summary>
        public void Open()
        {
            Close();
            try
            {
                _serialPort.PortName = Settings.Port.PortName;
                _serialPort.BaudRate = Settings.Port.BaudRate;
                _serialPort.Parity = Settings.Port.Parity;
                _serialPort.DataBits = Settings.Port.DataBits;
                _serialPort.StopBits = Settings.Port.StopBits;
                _serialPort.Handshake = Settings.Port.Handshake;

                // Set the read/write timeouts
                _serialPort.ReadTimeout = 50;
                _serialPort.WriteTimeout = 50;
                _serialPort.Open();
                StartReading();
            }
            catch (IOException)
            {
                StatusChanged(String.Format("{0} 不存在", Settings.Port.PortName));
            }
            catch (UnauthorizedAccessException)
            {
                StatusChanged(String.Format("{0} 已经在使用", Settings.Port.PortName));
            }
            catch (Exception ex)
            {
                StatusChanged(String.Format("{0}", ex.ToString()));
            }

            // Update the status
            if (_serialPort.IsOpen)
            {
                string p = _serialPort.Parity.ToString().Substring(0, 1);   //First char
                string h = _serialPort.Handshake.ToString();
                if (_serialPort.Handshake == Handshake.None)
                    h = "no handshake"; // more descriptive than "None"

                StatusChanged(String.Format("{0}: {1} bps, {2}{3}{4}, {5}",
                    _serialPort.PortName, _serialPort.BaudRate,
                    _serialPort.DataBits, p, (int)_serialPort.StopBits, h));
            }
            else
            {
                StatusChanged(String.Format("{0} 已经在使用", Settings.Port.PortName));
            }
        }

        /// <summary> Close the serial port. </summary>
        public void Close()
        {
            StopReading();
            _serialPort.Close();
            StatusChanged("连接已经关闭");
        }

        /// <summary> Get the status of the serial port. </summary>
        public bool IsOpen
        {
            get
            {
                return _serialPort.IsOpen;
            }
        }

        /// <summary> Get a list of the available ports. Already opened ports
        /// are not returend. </summary>
        public string[] GetAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }

        /// <summary>Send data to the serial port after appending line ending. </summary>
        /// <param name="data">An string containing the data to send. </param>
        public void Send(byte[] data)
        {
            if (IsOpen)
            {
                _serialPort.Write(data, 0, data.Length);//+ lineEnding
            }
        }
    }
}

