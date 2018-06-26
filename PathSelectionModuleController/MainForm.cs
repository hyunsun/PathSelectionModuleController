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

                    rbAutoCheck.Enabled = true;
                    rbAutoMain.Enabled = true;

                    rbManualCheck.Enabled = true;
                    rbManualMain.Enabled = true;
                }
                else
                {
                    pbSerialPort.Image = Properties.Resources.red;
                    cbSerialPort.Enabled = true;
                    btnConnect.Text = "OPEN";

                    rbAutoCheck.Enabled = false;
                    rbAutoMain.Enabled = false;

                    rbManualCheck.Enabled = false;
                    rbManualMain.Enabled = false;
                }
            }
            get
            {
                return SerialPort.IsOpen;
            }
        }

        private static string Caption = "급전 모듈";
        private static object RequestLock = new object();
        private static ManualResetEvent ResponseReceivedEvent = new ManualResetEvent(false);
        private static int ResponseTimeout = 300; // 300ms
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

        private void rbAuto_EnabledChanged(object sender, EventArgs e)
        {
            if (!rbAutoCheck.Enabled)
            {
                clbAutoMainIn.Enabled = false;
                clbAutoMainOut.Enabled = false;
                clbAutoCheck.Enabled = false;

                btnAutoMain.Enabled = false;
                btnAutoCheck.Enabled = false;
            }
            else
            {
                rbAutoCheck.Checked = true;
                rbAuto_CheckedChanged(sender, e);
            }
        }

        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutoCheck.Checked)
            {
                clbAutoMainIn.Enabled = false;
                clbAutoMainOut.Enabled = false;
                clbAutoCheck.Enabled = true;

                btnAutoMain.Enabled = false;
                btnAutoCheck.Enabled = true;
            }
            else
            {
                clbAutoMainIn.Enabled = true;
                clbAutoMainOut.Enabled = true;
                clbAutoCheck.Enabled = false;

                btnAutoMain.Enabled = true;
                btnAutoCheck.Enabled = false;
            }
        }

        private void rbManual_EnabledChanged(object sender, EventArgs e)
        {
            if (!rbManualCheck.Enabled)
            {
                clbManualMainIn.Enabled = false;
                clbManualMainOut.Enabled = false;
                clbManualCheck.Enabled = false;

                btnManualMain.Enabled = false;
                btnManualCheck.Enabled = false;
            }
            else
            {
                rbManualCheck.Checked = true;
                rbManual_CheckedChanged(sender, e);
            }
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManualCheck.Checked)
            {
                clbManualMainIn.Enabled = false;
                clbManualMainOut.Enabled = false;
                clbManualCheck.Enabled = true;

                btnManualMain.Enabled = false;
                btnManualCheck.Enabled = true;
            }
            else
            {
                clbManualMainIn.Enabled = true;
                clbManualMainOut.Enabled = true;
                clbManualCheck.Enabled = false;

                btnManualMain.Enabled = true;
                btnManualCheck.Enabled = false;
            }
        }

        private void btnAutoCheck_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[7];
            // get bits from 자동 점검 경로
            foreach(int i in clbAutoCheck.CheckedIndices)
            {
                int byteIndex = i / 8;
                int bitIndex = i % 8;
                byte mask = (byte)(1 << bitIndex);
                data[byteIndex] |= mask;
            }

            SendAutoPathRequest(data);
        }

        private void btnAutoMain_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[7];
            // get bits from 자동 주경로 입력
            foreach (int i in clbAutoMainIn.CheckedIndices)
            {
                int byteIndex = 3 + i / 8;
                int bitIndex = i % 8;
                byte mask = (byte)(1 << bitIndex);
                data[byteIndex] |= mask;
            }

            // get bits from 자동 주경로 출력
            foreach (int i in clbAutoMainOut.CheckedIndices)
            {
                int byteIndex = 4 + i / 8;
                int bitIndex = i % 8;
                byte mask = (byte)(1 << bitIndex);
                data[byteIndex] |= mask;
            }

            SendAutoPathRequest(data);
        }

        private void SendAutoPathRequest(byte[] data)
        {
            string valueError;
            RequestResult reqResult;

            Request request = new Request(CommandType.AutoPathRequest, data);
            bool result = SendRequest(request, out reqResult);
            if (result)
            {
                MessageBox.Show("성공",
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("실패: 값을 설정하지 못했습니다, 다시 시도해 주세요.\n" +
                    reqResult.ErrorMessage,
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // Test code
            //bool result = SendRequestTest(request,
            //    CommandType.AutoPathResponse,
            //    new byte[7] { 0x00, 0x00, 0x00, 0xf0, 0x01, 0x01, 0x03 },
            //    out reqResult);
        }

        private void btnManualCheck_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[15];
            // get bits from 자동 점검 경로
            foreach (int i in clbManualCheck.CheckedIndices)
            {
                int byteIndex = i / 8;
                int bitIndex = i % 8;
                byte mask = (byte)(1 << bitIndex);
                data[byteIndex] |= mask;
            }

            SendManualPathRequest(data);
        }

        private void btnManualMain_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[15];
            // get bits from 자동 주경로 입력
            foreach (int i in clbManualMainIn.CheckedIndices)
            {
                int byteIndex = 7 + i / 8;
                int bitIndex = i % 8;
                byte mask = (byte)(1 << bitIndex);
                data[byteIndex] |= mask;
            }

            // get bits from 자동 주경로 출력
            foreach (int i in clbManualMainOut.CheckedIndices)
            {
                int byteIndex = 8 + i / 8;
                int bitIndex = i % 8;
                byte mask = (byte)(1 << bitIndex);
                data[byteIndex] |= mask;
            }

            SendManualPathRequest(data);
        }

        private void SendManualPathRequest(byte[] data)
        {
            string valueError;
            RequestResult reqResult;

            Request request = new Request(CommandType.ManualPathRequest, data);
            bool result = SendRequest(request, out reqResult);
            if (result)
            {
                MessageBox.Show("성공",
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("실패: 값을 설정하지 못했습니다, 다시 시도해 주세요.\n" +
                    reqResult.ErrorMessage,
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // Test code
            //bool result = SendRequestTest(request,
            //    CommandType.ManualPathResponse,
            //    new byte[15] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            //                   0x03,
            //                   0x01, 0x01, 0xf0, 0x00, 0x00, 0x00, 0x00 },
            //    out reqResult);
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
                    ResponseReceivedEvent.Set();
                    byte[] responseFrame = new byte[ResponseReceived]; // Trim trailing nulls
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
                }
                else if (ResponseFrameStarted &&
                    ResponseReceived < FrameConstants.MessageBufferLength)
                {
                    ResponseFrameBuffer[ResponseReceived++] = read;
                }
            }
        }

        private bool SendRequestTest(Request request,
                             CommandType testResponseCommand,
                             byte[] testResponseData,
                             out RequestResult reqResult)
        {
            bool result = false;

            // build response message
            byte[] responseMessage = new byte[request.Message.Length];
            responseMessage[0] = (byte)testResponseCommand;
            testResponseData.CopyTo(responseMessage, 1);
            ushort checksum = Request.ComputeChecksum(responseMessage);

            // do stuffing
            byte[] original = new byte[responseMessage.Length + 2];
            responseMessage.CopyTo(original, 0);
            BitConverter.GetBytes(checksum).CopyTo(original, responseMessage.Length);
            byte[] stuffed = Request.Stuff(original);

            // process response message
            result = request.GetResult(stuffed, out reqResult);
            return result;
        }
    }
}
