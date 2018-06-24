using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace PathSelectionModuleController
{
    public partial class MainForm : Form
    {
        private SerialPort _SerialPort;
        private SerialPort SerialPort
        {
            get
            {
                if (_SerialPort == null)
                {
                    _SerialPort = new SerialPort();
                    _SerialPort.BaudRate = 115200;
                    _SerialPort.DataBits = 8;
                    _SerialPort.Parity = Parity.None;
                    _SerialPort.Handshake = Handshake.None;
                    _SerialPort.StopBits = StopBits.One;
                }
                return _SerialPort;
            }
        }
        private Boolean IsOpen
        {
            set
            {
                if (value)
                {             
                    pbSerialPort.Image = Properties.Resources.green;
                    cbSerialPort.Enabled = false;
                    btnConnect.Text = "CLOSE";
                }
                else
                {
                    pbSerialPort.Image = Properties.Resources.red;
                    cbSerialPort.Enabled = true;
                    btnConnect.Text = "OPEN";
                }
            }
            get
            {
                return SerialPort.IsOpen;
            }
        }

        private static List<CheckBox> ManualCheckPathes = new List<CheckBox>();
        private static List<CheckBox> ManualMainPathes  = new List<CheckBox>();
        private static List<CheckBox> AutoCheckPathes = new List<CheckBox>();
        private static List<CheckBox> AutoMainPathes  = new List<CheckBox>();

        private static string Caption = "급전 모듈";
        private static object RequestLock = new object();
        private static ManualResetEvent ResponseReceivedEvent = new ManualResetEvent(false);
        private static int ResponseTimeout = 300; // 1 seconds
        private byte[] ResponseFrameBuffer = new byte[FrameConstants.MessageBufferLength];
        private int ResponseReceived = 0;
        private bool ResponseFrameStarted = false;
        private bool ResponseFrameEnded = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitSerialPortGroup();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsOpen)
            {
                SerialPort.Close();
            }
        }

        private void InitSerialPortGroup()
        {
            cbSerialPort.Items.Clear();
            cbSerialPort.Items.Add("Select port");
            foreach (string portName in SerialPort.GetPortNames())
            {
                cbSerialPort.Items.Add(portName);
            }
            cbSerialPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSerialPort.SelectedIndex = 0;
        }

        private void InitPathes()
        {

        }
   
        // Event handlers for serial port connection group      
        private void cbSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialPort.PortName = cbSerialPort.Text;
            IsOpen = SerialPort.IsOpen; // should be always false here
            if (cbSerialPort.SelectedIndex == 0)
            {
                pbSerialPort.Image = Properties.Resources.black;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cbSerialPort.SelectedIndex == 0)
            {
                return;
            }

            if (!IsOpen)
            {
                try
                {
                    SerialPort.Open();
                }
                catch (Exception ex)
                {                   
                    MessageBox.Show("연결에 실패했습니다, 다시 시도해 주세요.\n" +
                        ex.Message,
                        Caption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                SerialPort.Close();
            }

            IsOpen = SerialPort.IsOpen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                SerialPort.Close();
            }
            this.Close();
        }

        private bool SendRequest(Request request, out RequestResult reqResult)
        {
            lock (RequestLock)
            {
                bool result = false;
                ResponseReceivedEvent.Reset();

                // Restore variables to default to handle the new request
                ResponseFrameBuffer = new byte[FrameConstants.MessageBufferLength];
                ResponseReceived = 0;
                ResponseFrameStarted = false;
                ResponseFrameEnded = false;

                SerialPort.DiscardOutBuffer();
                SerialPort.DiscardInBuffer();
                SerialPort.DataReceived += Port_DataReceived;

                SerialPort.Write(request.FrameBuffer, 0, request.FrameLength);

                // Block main form until it gets response
                ResponseReceivedEvent.WaitOne(ResponseTimeout);
                SerialPort.DataReceived -= Port_DataReceived;

                // Handle response if valid resonse received or
                // just return false when timed out
                if (ResponseFrameEnded)
                {
                    // Trim trailing NULLs
                    byte[] responseFrame = new byte[ResponseReceived];
                    Array.Copy(ResponseFrameBuffer, responseFrame, ResponseReceived);
                    result = request.GetResult(responseFrame, out reqResult);
                }
                else
                {
                    reqResult = new RequestResult();
                    reqResult.ErrorMessage = "오류: 응답을 받지 못했습니다";
                }
                return result;
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (SerialPort.BytesToRead > 0 && !ResponseFrameEnded)
            {
                byte read = (byte)SerialPort.ReadByte();
                if (read == FrameConstants.StartCode)
                {
                    ResponseFrameStarted = true;
                }
                else if (read == FrameConstants.EndCode)
                {
                    // Release main form when receiving response complete
                    ResponseFrameEnded = true;
                    ResponseReceivedEvent.Set();
                }
                else if (ResponseFrameStarted &&
                    ResponseReceived < FrameConstants.MessageBufferLength)
                {
                    ResponseFrameBuffer[ResponseReceived++] = read;
                }
            }
        }

        private void rbtnAutoCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnAutoMain_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnManualCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnManualMain_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
