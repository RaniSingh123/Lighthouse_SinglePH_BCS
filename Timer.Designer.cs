
namespace LH_RnD_New
{
    partial class panelTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.tBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRelayOffTimer = new System.Windows.Forms.Button();
            this.btnRelayOnTimer = new System.Windows.Forms.Button();
            this.btnSetDefaultCalTimer = new System.Windows.Forms.Button();
            this.btnCalNeutralTimer = new System.Windows.Forms.Button();
            this.btnSetCalLockTimer = new System.Windows.Forms.Button();
            this.btnSetCalUnlockTimer = new System.Windows.Forms.Button();
            this.btnCommUnlockTimer = new System.Windows.Forms.Button();
            this.btnCalPhaseTimer = new System.Windows.Forms.Button();
            this.btnTimeSetTimer = new System.Windows.Forms.Button();
            this.btnMemTmrErs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(155, 209);
            this.cBoxParityBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(147, 28);
            this.cBoxParityBits.TabIndex = 4;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(155, 119);
            this.cBoxDataBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(147, 28);
            this.cBoxDataBits.TabIndex = 2;
            this.cBoxDataBits.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(155, 162);
            this.cBoxStopBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(147, 28);
            this.cBoxStopBits.TabIndex = 3;
            this.cBoxStopBits.Text = "One";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.cBoxComPort);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(15, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(329, 249);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LH COMMAND SOLUTION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "38400",
            "19200",
            "115200"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(155, 70);
            this.cBoxBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(147, 28);
            this.cBoxBaudRate.TabIndex = 1;
            this.cBoxBaudRate.Text = "9600";
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(155, 21);
            this.cBoxComPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(147, 28);
            this.cBoxComPort.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Highlight;
            this.progressBar1.ForeColor = System.Drawing.Color.Yellow;
            this.progressBar1.Location = new System.Drawing.Point(13, 68);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(328, 12);
            this.progressBar1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClose.Location = new System.Drawing.Point(188, 18);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tBox
            // 
            this.tBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tBox.Location = new System.Drawing.Point(364, 46);
            this.tBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox.Multiline = true;
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(352, 130);
            this.tBox.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(364, 199);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(353, 95);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.ForeColor = System.Drawing.Color.LightYellow;
            this.btnOpen.Location = new System.Drawing.Point(12, 18);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(153, 37);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar2.Location = new System.Drawing.Point(363, 178);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(353, 12);
            this.progressBar2.TabIndex = 47;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.groupBox5.Controls.Add(this.btnRelayOffTimer);
            this.groupBox5.Controls.Add(this.btnRelayOnTimer);
            this.groupBox5.Controls.Add(this.btnSetDefaultCalTimer);
            this.groupBox5.Controls.Add(this.btnCalNeutralTimer);
            this.groupBox5.Controls.Add(this.btnSetCalLockTimer);
            this.groupBox5.Controls.Add(this.btnSetCalUnlockTimer);
            this.groupBox5.Controls.Add(this.btnCommUnlockTimer);
            this.groupBox5.Controls.Add(this.btnCalPhaseTimer);
            this.groupBox5.Controls.Add(this.btnTimeSetTimer);
            this.groupBox5.Controls.Add(this.btnMemTmrErs);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(13, 305);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(703, 183);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TIMER";
            // 
            // btnRelayOffTimer
            // 
            this.btnRelayOffTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.btnRelayOffTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelayOffTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelayOffTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelayOffTimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRelayOffTimer.Location = new System.Drawing.Point(511, 69);
            this.btnRelayOffTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRelayOffTimer.Name = "btnRelayOffTimer";
            this.btnRelayOffTimer.Size = new System.Drawing.Size(153, 37);
            this.btnRelayOffTimer.TabIndex = 28;
            this.btnRelayOffTimer.Text = "RELAY OFF";
            this.btnRelayOffTimer.UseVisualStyleBackColor = false;
            this.btnRelayOffTimer.Click += new System.EventHandler(this.btnRelayOffTimer_Click);
            // 
            // btnRelayOnTimer
            // 
            this.btnRelayOnTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.btnRelayOnTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelayOnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelayOnTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelayOnTimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRelayOnTimer.Location = new System.Drawing.Point(180, 113);
            this.btnRelayOnTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRelayOnTimer.Name = "btnRelayOnTimer";
            this.btnRelayOnTimer.Size = new System.Drawing.Size(153, 37);
            this.btnRelayOnTimer.TabIndex = 27;
            this.btnRelayOnTimer.Text = "RELAY ON";
            this.btnRelayOnTimer.UseVisualStyleBackColor = false;
            this.btnRelayOnTimer.Click += new System.EventHandler(this.btnRelayOnTimer_Click);
            // 
            // btnSetDefaultCalTimer
            // 
            this.btnSetDefaultCalTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.btnSetDefaultCalTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetDefaultCalTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetDefaultCalTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDefaultCalTimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetDefaultCalTimer.Location = new System.Drawing.Point(345, 69);
            this.btnSetDefaultCalTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetDefaultCalTimer.Name = "btnSetDefaultCalTimer";
            this.btnSetDefaultCalTimer.Size = new System.Drawing.Size(153, 37);
            this.btnSetDefaultCalTimer.TabIndex = 23;
            this.btnSetDefaultCalTimer.Text = "SET DEFAULT CAL";
            this.btnSetDefaultCalTimer.UseVisualStyleBackColor = false;
            this.btnSetDefaultCalTimer.Click += new System.EventHandler(this.btnSetDefaultCalTimer_Click);
            // 
            // btnCalNeutralTimer
            // 
            this.btnCalNeutralTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.btnCalNeutralTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalNeutralTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalNeutralTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalNeutralTimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalNeutralTimer.Location = new System.Drawing.Point(180, 69);
            this.btnCalNeutralTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalNeutralTimer.Name = "btnCalNeutralTimer";
            this.btnCalNeutralTimer.Size = new System.Drawing.Size(153, 37);
            this.btnCalNeutralTimer.TabIndex = 22;
            this.btnCalNeutralTimer.Text = "CAL NEUTRAL";
            this.btnCalNeutralTimer.UseVisualStyleBackColor = false;
            this.btnCalNeutralTimer.Click += new System.EventHandler(this.btnCalNeutralTimer_Click);
            // 
            // btnSetCalLockTimer
            // 
            this.btnSetCalLockTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.btnSetCalLockTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetCalLockTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetCalLockTimer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCalLockTimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetCalLockTimer.Location = new System.Drawing.Point(13, 69);
            this.btnSetCalLockTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetCalLockTimer.Name = "btnSetCalLockTimer";
            this.btnSetCalLockTimer.Size = new System.Drawing.Size(153, 37);
            this.btnSetCalLockTimer.TabIndex = 8;
            this.btnSetCalLockTimer.Text = "SET CAL LOCK";
            this.btnSetCalLockTimer.UseVisualStyleBackColor = false;
            this.btnSetCalLockTimer.Click += new System.EventHandler(this.btnSetCalLockTimer_Click);
            // 
            // btnSetCalUnlockTimer
            // 
            this.btnSetCalUnlockTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.btnSetCalUnlockTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetCalUnlockTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetCalUnlockTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCalUnlockTimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetCalUnlockTimer.Location = new System.Drawing.Point(345, 26);
            this.btnSetCalUnlockTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetCalUnlockTimer.Name = "btnSetCalUnlockTimer";
            this.btnSetCalUnlockTimer.Size = new System.Drawing.Size(153, 37);
            this.btnSetCalUnlockTimer.TabIndex = 20;
            this.btnSetCalUnlockTimer.Text = "SET CAL UNLOCK";
            this.btnSetCalUnlockTimer.UseVisualStyleBackColor = false;
            this.btnSetCalUnlockTimer.Click += new System.EventHandler(this.btnSetCalUnlockTimer_Click);
            // 
            // btnCommUnlockTimer
            // 
            this.btnCommUnlockTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.btnCommUnlockTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCommUnlockTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCommUnlockTimer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommUnlockTimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCommUnlockTimer.Location = new System.Drawing.Point(13, 26);
            this.btnCommUnlockTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCommUnlockTimer.Name = "btnCommUnlockTimer";
            this.btnCommUnlockTimer.Size = new System.Drawing.Size(153, 37);
            this.btnCommUnlockTimer.TabIndex = 2;
            this.btnCommUnlockTimer.Text = " UNLOCK TIMER";
            this.btnCommUnlockTimer.UseVisualStyleBackColor = false;
            this.btnCommUnlockTimer.Click += new System.EventHandler(this.btnCommUnlockTimer_Click);
            // 
            // btnCalPhaseTimer
            // 
            this.btnCalPhaseTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.btnCalPhaseTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalPhaseTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalPhaseTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalPhaseTimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalPhaseTimer.Location = new System.Drawing.Point(511, 23);
            this.btnCalPhaseTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalPhaseTimer.Name = "btnCalPhaseTimer";
            this.btnCalPhaseTimer.Size = new System.Drawing.Size(153, 37);
            this.btnCalPhaseTimer.TabIndex = 21;
            this.btnCalPhaseTimer.Text = "CAL PHASE";
            this.btnCalPhaseTimer.UseVisualStyleBackColor = false;
            this.btnCalPhaseTimer.Click += new System.EventHandler(this.btnCalPhaseTimer_Click);
            // 
            // btnTimeSetTimer
            // 
            this.btnTimeSetTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.btnTimeSetTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimeSetTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimeSetTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeSetTimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimeSetTimer.Location = new System.Drawing.Point(180, 26);
            this.btnTimeSetTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimeSetTimer.Name = "btnTimeSetTimer";
            this.btnTimeSetTimer.Size = new System.Drawing.Size(153, 37);
            this.btnTimeSetTimer.TabIndex = 19;
            this.btnTimeSetTimer.Text = "TIME SET TIMER";
            this.btnTimeSetTimer.UseVisualStyleBackColor = false;
            this.btnTimeSetTimer.Click += new System.EventHandler(this.btnTimeSetTimer_Click);
            // 
            // btnMemTmrErs
            // 
            this.btnMemTmrErs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.btnMemTmrErs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMemTmrErs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMemTmrErs.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemTmrErs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMemTmrErs.Location = new System.Drawing.Point(13, 113);
            this.btnMemTmrErs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMemTmrErs.Name = "btnMemTmrErs";
            this.btnMemTmrErs.Size = new System.Drawing.Size(153, 37);
            this.btnMemTmrErs.TabIndex = 18;
            this.btnMemTmrErs.Text = "MEM ERASE";
            this.btnMemTmrErs.UseVisualStyleBackColor = false;
            this.btnMemTmrErs.Click += new System.EventHandler(this.btnMemTmrErs_Click);
            // 
            // panelTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(186)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(732, 505);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "panelTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.panelTimer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
           

        #endregion

        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRelayOffTimer;
        private System.Windows.Forms.Button btnRelayOnTimer;
        private System.Windows.Forms.Button btnSetDefaultCalTimer;
        private System.Windows.Forms.Button btnCalNeutralTimer;
        private System.Windows.Forms.Button btnSetCalLockTimer;
        private System.Windows.Forms.Button btnSetCalUnlockTimer;
        private System.Windows.Forms.Button btnCommUnlockTimer;
        private System.Windows.Forms.Button btnCalPhaseTimer;
        private System.Windows.Forms.Button btnTimeSetTimer;
        private System.Windows.Forms.Button btnMemTmrErs;
    }
}