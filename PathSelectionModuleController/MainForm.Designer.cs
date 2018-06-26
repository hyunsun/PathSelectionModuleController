namespace PathSelectionModuleController
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSerialPort = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.clbAutoMainOut = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAutoMain = new System.Windows.Forms.Button();
            this.clbAutoMainIn = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAutoCheck = new System.Windows.Forms.Button();
            this.clbAutoCheck = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbAutoMain = new System.Windows.Forms.RadioButton();
            this.rbAutoCheck = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clbManualMainOut = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rbManualMain = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.rbManualCheck = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnManualMain = new System.Windows.Forms.Button();
            this.clbManualCheck = new System.Windows.Forms.CheckedListBox();
            this.clbManualMainIn = new System.Windows.Forms.CheckedListBox();
            this.btnManualCheck = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerialPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbSerialPort);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbSerialPort);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 513);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "통신";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(42, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "통신상태";
            // 
            // pbSerialPort
            // 
            this.pbSerialPort.Image = global::PathSelectionModuleController.Properties.Resources.black;
            this.pbSerialPort.InitialImage = null;
            this.pbSerialPort.Location = new System.Drawing.Point(59, 204);
            this.pbSerialPort.Name = "pbSerialPort";
            this.pbSerialPort.Size = new System.Drawing.Size(32, 32);
            this.pbSerialPort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSerialPort.TabIndex = 4;
            this.pbSerialPort.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(12, 115);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 37);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "OPEN";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(12, 60);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(130, 31);
            this.cbSerialPort.TabIndex = 1;
            this.cbSerialPort.SelectedIndexChanged += new System.EventHandler(this.cbSerialPort_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(27, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "급전모듈";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "시험치구";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.clbAutoMainOut);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAutoMain);
            this.groupBox2.Controls.Add(this.clbAutoMainIn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnAutoCheck);
            this.groupBox2.Controls.Add(this.clbAutoCheck);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rbAutoMain);
            this.groupBox2.Controls.Add(this.rbAutoCheck);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(174, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 709);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "경로 선택 (자동)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(309, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "선택";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(292, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "자동 출력";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(301, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "주경로";
            // 
            // clbAutoMainOut
            // 
            this.clbAutoMainOut.CheckOnClick = true;
            this.clbAutoMainOut.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clbAutoMainOut.FormattingEnabled = true;
            this.clbAutoMainOut.Items.AddRange(new object[] {
            "1행",
            "2행",
            "3행",
            "4행",
            "5행",
            "6행",
            "7행",
            "8행",
            "9행",
            "10행",
            "11행",
            "12행",
            "13행",
            "14행",
            "15행",
            "16행",
            "17행",
            "18행"});
            this.clbAutoMainOut.Location = new System.Drawing.Point(267, 149);
            this.clbAutoMainOut.Name = "clbAutoMainOut";
            this.clbAutoMainOut.Size = new System.Drawing.Size(123, 504);
            this.clbAutoMainOut.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(175, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "선택";
            // 
            // btnAutoMain
            // 
            this.btnAutoMain.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoMain.Location = new System.Drawing.Point(139, 659);
            this.btnAutoMain.Name = "btnAutoMain";
            this.btnAutoMain.Size = new System.Drawing.Size(251, 37);
            this.btnAutoMain.TabIndex = 21;
            this.btnAutoMain.Text = "START";
            this.btnAutoMain.UseVisualStyleBackColor = true;
            this.btnAutoMain.Click += new System.EventHandler(this.btnAutoMain_Click);
            // 
            // clbAutoMainIn
            // 
            this.clbAutoMainIn.CheckOnClick = true;
            this.clbAutoMainIn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clbAutoMainIn.FormattingEnabled = true;
            this.clbAutoMainIn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.clbAutoMainIn.Location = new System.Drawing.Point(139, 149);
            this.clbAutoMainIn.Name = "clbAutoMainIn";
            this.clbAutoMainIn.Size = new System.Drawing.Size(123, 504);
            this.clbAutoMainIn.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(160, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "경로번호";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(150, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "주경로 입력";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(51, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "선택";
            // 
            // btnAutoCheck
            // 
            this.btnAutoCheck.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoCheck.Location = new System.Drawing.Point(10, 659);
            this.btnAutoCheck.Name = "btnAutoCheck";
            this.btnAutoCheck.Size = new System.Drawing.Size(122, 37);
            this.btnAutoCheck.TabIndex = 16;
            this.btnAutoCheck.Text = "START";
            this.btnAutoCheck.UseVisualStyleBackColor = true;
            this.btnAutoCheck.Click += new System.EventHandler(this.btnAutoCheck_Click);
            // 
            // clbAutoCheck
            // 
            this.clbAutoCheck.CheckOnClick = true;
            this.clbAutoCheck.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clbAutoCheck.FormattingEnabled = true;
            this.clbAutoCheck.Items.AddRange(new object[] {
            "1행",
            "2행",
            "3행",
            "4행",
            "5행",
            "6행",
            "7행",
            "8행",
            "9행",
            "10행",
            "11행",
            "12행",
            "13행",
            "14행",
            "15행",
            "16행",
            "17행",
            "18행"});
            this.clbAutoCheck.Location = new System.Drawing.Point(9, 149);
            this.clbAutoCheck.Name = "clbAutoCheck";
            this.clbAutoCheck.Size = new System.Drawing.Size(123, 504);
            this.clbAutoCheck.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(35, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "자동 출력";
            // 
            // rbAutoMain
            // 
            this.rbAutoMain.AutoSize = true;
            this.rbAutoMain.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbAutoMain.Location = new System.Drawing.Point(220, 32);
            this.rbAutoMain.Name = "rbAutoMain";
            this.rbAutoMain.Size = new System.Drawing.Size(76, 25);
            this.rbAutoMain.TabIndex = 1;
            this.rbAutoMain.TabStop = true;
            this.rbAutoMain.Text = "주경로";
            this.rbAutoMain.UseVisualStyleBackColor = true;
            this.rbAutoMain.CheckedChanged += new System.EventHandler(this.rbAuto_CheckedChanged);
            // 
            // rbAutoCheck
            // 
            this.rbAutoCheck.AutoSize = true;
            this.rbAutoCheck.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbAutoCheck.Location = new System.Drawing.Point(100, 32);
            this.rbAutoCheck.Name = "rbAutoCheck";
            this.rbAutoCheck.Size = new System.Drawing.Size(92, 25);
            this.rbAutoCheck.TabIndex = 0;
            this.rbAutoCheck.TabStop = true;
            this.rbAutoCheck.Text = "점검경로";
            this.rbAutoCheck.UseVisualStyleBackColor = true;
            this.rbAutoCheck.CheckedChanged += new System.EventHandler(this.rbAuto_CheckedChanged);
            this.rbAutoCheck.EnabledChanged += new System.EventHandler(this.rbAuto_EnabledChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(38, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "점검경로";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clbManualMainOut);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.rbManualMain);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.rbManualCheck);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.btnManualMain);
            this.groupBox3.Controls.Add(this.clbManualCheck);
            this.groupBox3.Controls.Add(this.clbManualMainIn);
            this.groupBox3.Controls.Add(this.btnManualCheck);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(580, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 709);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "경로 선택 (수동)";
            // 
            // clbManualMainOut
            // 
            this.clbManualMainOut.CheckOnClick = true;
            this.clbManualMainOut.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clbManualMainOut.FormattingEnabled = true;
            this.clbManualMainOut.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54"});
            this.clbManualMainOut.Location = new System.Drawing.Point(269, 149);
            this.clbManualMainOut.Name = "clbManualMainOut";
            this.clbManualMainOut.Size = new System.Drawing.Size(123, 504);
            this.clbManualMainOut.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(307, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 20);
            this.label13.TabIndex = 39;
            this.label13.Text = "선택";
            // 
            // rbManualMain
            // 
            this.rbManualMain.AutoSize = true;
            this.rbManualMain.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbManualMain.Location = new System.Drawing.Point(220, 32);
            this.rbManualMain.Name = "rbManualMain";
            this.rbManualMain.Size = new System.Drawing.Size(76, 25);
            this.rbManualMain.TabIndex = 3;
            this.rbManualMain.TabStop = true;
            this.rbManualMain.Text = "주경로";
            this.rbManualMain.UseVisualStyleBackColor = true;
            this.rbManualMain.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(293, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 38;
            this.label14.Text = "경로번호";
            // 
            // rbManualCheck
            // 
            this.rbManualCheck.AutoSize = true;
            this.rbManualCheck.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbManualCheck.Location = new System.Drawing.Point(100, 32);
            this.rbManualCheck.Name = "rbManualCheck";
            this.rbManualCheck.Size = new System.Drawing.Size(92, 25);
            this.rbManualCheck.TabIndex = 2;
            this.rbManualCheck.TabStop = true;
            this.rbManualCheck.Text = "점검경로";
            this.rbManualCheck.UseVisualStyleBackColor = true;
            this.rbManualCheck.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            this.rbManualCheck.EnabledChanged += new System.EventHandler(this.rbManual_EnabledChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(284, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 37;
            this.label15.Text = "주경로 출력";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(41, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 20);
            this.label21.TabIndex = 26;
            this.label21.Text = "점검경로";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(176, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "선택";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(41, 103);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 20);
            this.label20.TabIndex = 28;
            this.label20.Text = "경로번호";
            // 
            // btnManualMain
            // 
            this.btnManualMain.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManualMain.Location = new System.Drawing.Point(140, 659);
            this.btnManualMain.Name = "btnManualMain";
            this.btnManualMain.Size = new System.Drawing.Size(252, 37);
            this.btnManualMain.TabIndex = 35;
            this.btnManualMain.Text = "START";
            this.btnManualMain.UseVisualStyleBackColor = true;
            this.btnManualMain.Click += new System.EventHandler(this.btnManualMain_Click);
            // 
            // clbManualCheck
            // 
            this.clbManualCheck.CheckOnClick = true;
            this.clbManualCheck.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clbManualCheck.FormattingEnabled = true;
            this.clbManualCheck.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54"});
            this.clbManualCheck.Location = new System.Drawing.Point(10, 149);
            this.clbManualCheck.Name = "clbManualCheck";
            this.clbManualCheck.Size = new System.Drawing.Size(123, 504);
            this.clbManualCheck.TabIndex = 27;
            // 
            // clbManualMainIn
            // 
            this.clbManualMainIn.CheckOnClick = true;
            this.clbManualMainIn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clbManualMainIn.FormattingEnabled = true;
            this.clbManualMainIn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.clbManualMainIn.Location = new System.Drawing.Point(140, 149);
            this.clbManualMainIn.Name = "clbManualMainIn";
            this.clbManualMainIn.Size = new System.Drawing.Size(123, 504);
            this.clbManualMainIn.TabIndex = 32;
            // 
            // btnManualCheck
            // 
            this.btnManualCheck.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManualCheck.Location = new System.Drawing.Point(10, 659);
            this.btnManualCheck.Name = "btnManualCheck";
            this.btnManualCheck.Size = new System.Drawing.Size(123, 37);
            this.btnManualCheck.TabIndex = 30;
            this.btnManualCheck.Text = "START";
            this.btnManualCheck.UseVisualStyleBackColor = true;
            this.btnManualCheck.Click += new System.EventHandler(this.btnManualCheck_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(161, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "경로번호";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(54, 123);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 20);
            this.label19.TabIndex = 29;
            this.label19.Text = "선택";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(151, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 20);
            this.label18.TabIndex = 31;
            this.label18.Text = "주경로 입력";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 722);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "급전 모듈";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerialPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.PictureBox pbSerialPort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbAutoMain;
        private System.Windows.Forms.RadioButton rbAutoCheck;
        private System.Windows.Forms.RadioButton rbManualMain;
        private System.Windows.Forms.RadioButton rbManualCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAutoCheck;
        private System.Windows.Forms.CheckedListBox clbAutoCheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox clbAutoMainOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAutoMain;
        private System.Windows.Forms.CheckedListBox clbAutoMainIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnManualMain;
        private System.Windows.Forms.CheckedListBox clbManualCheck;
        private System.Windows.Forms.CheckedListBox clbManualMainIn;
        private System.Windows.Forms.Button btnManualCheck;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckedListBox clbManualMainOut;
    }
}

