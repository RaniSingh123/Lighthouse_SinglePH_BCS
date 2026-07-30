
namespace LH_RnD_New
{
    partial class panelModule
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
            this.btnCheckIp = new System.Windows.Forms.Button();
            this.brnSimChk = new System.Windows.Forms.Button();
            this.btnAtChk = new System.Windows.Forms.Button();
            this.btnPdpAct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtIPV6 = new System.Windows.Forms.TextBox();
            this.btnIPV6 = new System.Windows.Forms.Button();
            this.txtIPV4 = new System.Windows.Forms.TextBox();
            this.btnIPV4 = new System.Windows.Forms.Button();
            this.txtModuleBaudRate = new System.Windows.Forms.TextBox();
            this.btnModuleBaudRate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckIp
            // 
            this.btnCheckIp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCheckIp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCheckIp.Font = new System.Drawing.Font("Microsoft New Tai Lue", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIp.ForeColor = System.Drawing.Color.Black;
            this.btnCheckIp.Location = new System.Drawing.Point(135, 221);
            this.btnCheckIp.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckIp.Name = "btnCheckIp";
            this.btnCheckIp.Size = new System.Drawing.Size(120, 30);
            this.btnCheckIp.TabIndex = 8;
            this.btnCheckIp.Text = "CHECK IP";
            this.btnCheckIp.UseVisualStyleBackColor = false;
            this.btnCheckIp.Click += new System.EventHandler(this.btnCheckIp_Click);
            // 
            // brnSimChk
            // 
            this.brnSimChk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.brnSimChk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.brnSimChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnSimChk.ForeColor = System.Drawing.Color.Black;
            this.brnSimChk.Location = new System.Drawing.Point(139, 19);
            this.brnSimChk.Margin = new System.Windows.Forms.Padding(2);
            this.brnSimChk.Name = "brnSimChk";
            this.brnSimChk.Size = new System.Drawing.Size(120, 30);
            this.brnSimChk.TabIndex = 20;
            this.brnSimChk.Text = "SIM CHECK";
            this.brnSimChk.UseVisualStyleBackColor = false;
            this.brnSimChk.Click += new System.EventHandler(this.brnSimChk_Click);
            // 
            // btnAtChk
            // 
            this.btnAtChk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAtChk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtChk.Font = new System.Drawing.Font("Microsoft New Tai Lue", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtChk.ForeColor = System.Drawing.Color.Black;
            this.btnAtChk.Location = new System.Drawing.Point(9, 19);
            this.btnAtChk.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtChk.Name = "btnAtChk";
            this.btnAtChk.Size = new System.Drawing.Size(120, 30);
            this.btnAtChk.TabIndex = 2;
            this.btnAtChk.Text = "AT CHECK";
            this.btnAtChk.UseVisualStyleBackColor = false;
            this.btnAtChk.Click += new System.EventHandler(this.btnAtChk_Click);
            // 
            // btnPdpAct
            // 
            this.btnPdpAct.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPdpAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPdpAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdpAct.ForeColor = System.Drawing.Color.Black;
            this.btnPdpAct.Location = new System.Drawing.Point(11, 221);
            this.btnPdpAct.Margin = new System.Windows.Forms.Padding(2);
            this.btnPdpAct.Name = "btnPdpAct";
            this.btnPdpAct.Size = new System.Drawing.Size(120, 30);
            this.btnPdpAct.TabIndex = 21;
            this.btnPdpAct.Text = "PDP ACT";
            this.btnPdpAct.UseVisualStyleBackColor = false;
            this.btnPdpAct.Click += new System.EventHandler(this.btnPdpAct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(208)))), ((int)(((byte)(247)))));
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
            this.groupBox1.Location = new System.Drawing.Point(11, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(245, 234);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LH COMMAND SOLUTION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(103, 179);
            this.cBoxParityBits.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(111, 25);
            this.cBoxParityBits.TabIndex = 4;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(103, 139);
            this.cBoxStopBits.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(111, 25);
            this.cBoxStopBits.TabIndex = 3;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(103, 104);
            this.cBoxDataBits.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(111, 25);
            this.cBoxDataBits.TabIndex = 2;
            this.cBoxDataBits.Text = "8";
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
            this.cBoxBaudRate.Location = new System.Drawing.Point(103, 64);
            this.cBoxBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(111, 25);
            this.cBoxBaudRate.TabIndex = 1;
            this.cBoxBaudRate.Text = "9600";
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(103, 24);
            this.cBoxComPort.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(111, 25);
            this.cBoxComPort.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(208)))), ((int)(((byte)(247)))));
            this.groupBox5.Controls.Add(this.txtIPV6);
            this.groupBox5.Controls.Add(this.btnIPV6);
            this.groupBox5.Controls.Add(this.txtIPV4);
            this.groupBox5.Controls.Add(this.btnIPV4);
            this.groupBox5.Controls.Add(this.txtModuleBaudRate);
            this.groupBox5.Controls.Add(this.btnModuleBaudRate);
            this.groupBox5.Controls.Add(this.btnCheckIp);
            this.groupBox5.Controls.Add(this.brnSimChk);
            this.groupBox5.Controls.Add(this.btnAtChk);
            this.groupBox5.Controls.Add(this.btnPdpAct);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(272, 165);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 283);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Module";
            // 
            // txtIPV6
            // 
            this.txtIPV6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtIPV6.Location = new System.Drawing.Point(134, 180);
            this.txtIPV6.Margin = new System.Windows.Forms.Padding(2);
            this.txtIPV6.Multiline = true;
            this.txtIPV6.Name = "txtIPV6";
            this.txtIPV6.Size = new System.Drawing.Size(126, 26);
            this.txtIPV6.TabIndex = 28;
            // 
            // btnIPV6
            // 
            this.btnIPV6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIPV6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIPV6.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIPV6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIPV6.ForeColor = System.Drawing.Color.Black;
            this.btnIPV6.Location = new System.Drawing.Point(10, 175);
            this.btnIPV6.Margin = new System.Windows.Forms.Padding(2);
            this.btnIPV6.Name = "btnIPV6";
            this.btnIPV6.Size = new System.Drawing.Size(120, 30);
            this.btnIPV6.TabIndex = 27;
            this.btnIPV6.Text = "APN IPV6";
            this.btnIPV6.UseVisualStyleBackColor = false;
            this.btnIPV6.Click += new System.EventHandler(this.btnIPV6_Click);
            // 
            // txtIPV4
            // 
            this.txtIPV4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtIPV4.Location = new System.Drawing.Point(135, 133);
            this.txtIPV4.Margin = new System.Windows.Forms.Padding(2);
            this.txtIPV4.Multiline = true;
            this.txtIPV4.Name = "txtIPV4";
            this.txtIPV4.Size = new System.Drawing.Size(120, 26);
            this.txtIPV4.TabIndex = 26;
            // 
            // btnIPV4
            // 
            this.btnIPV4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIPV4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIPV4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIPV4.ForeColor = System.Drawing.Color.Black;
            this.btnIPV4.Location = new System.Drawing.Point(11, 133);
            this.btnIPV4.Margin = new System.Windows.Forms.Padding(2);
            this.btnIPV4.Name = "btnIPV4";
            this.btnIPV4.Size = new System.Drawing.Size(120, 30);
            this.btnIPV4.TabIndex = 25;
            this.btnIPV4.Text = "APN IPV4";
            this.btnIPV4.UseVisualStyleBackColor = false;
            this.btnIPV4.Click += new System.EventHandler(this.btnIPV4_Click);
            // 
            // txtModuleBaudRate
            // 
            this.txtModuleBaudRate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtModuleBaudRate.Location = new System.Drawing.Point(134, 63);
            this.txtModuleBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtModuleBaudRate.Multiline = true;
            this.txtModuleBaudRate.Name = "txtModuleBaudRate";
            this.txtModuleBaudRate.Size = new System.Drawing.Size(121, 26);
            this.txtModuleBaudRate.TabIndex = 24;
            // 
            // btnModuleBaudRate
            // 
            this.btnModuleBaudRate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModuleBaudRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModuleBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModuleBaudRate.ForeColor = System.Drawing.Color.Black;
            this.btnModuleBaudRate.Location = new System.Drawing.Point(9, 58);
            this.btnModuleBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.btnModuleBaudRate.Name = "btnModuleBaudRate";
            this.btnModuleBaudRate.Size = new System.Drawing.Size(120, 30);
            this.btnModuleBaudRate.TabIndex = 23;
            this.btnModuleBaudRate.Text = "MODULE BAUD RATE";
            this.btnModuleBaudRate.UseVisualStyleBackColor = false;
            this.btnModuleBaudRate.Click += new System.EventHandler(this.btnModuleBaudRate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(11, 94);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.ForeColor = System.Drawing.Color.LightYellow;
            this.btnOpen.Location = new System.Drawing.Point(9, 29);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(108, 31);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tBox
            // 
            this.tBox.BackColor = System.Drawing.Color.AliceBlue;
            this.tBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tBox.Location = new System.Drawing.Point(273, 26);
            this.tBox.Margin = new System.Windows.Forms.Padding(2);
            this.tBox.Multiline = true;
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(265, 102);
            this.tBox.TabIndex = 51;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Highlight;
            this.progressBar1.ForeColor = System.Drawing.Color.Yellow;
            this.progressBar1.Location = new System.Drawing.Point(9, 86);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(231, 10);
            this.progressBar1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(208)))), ((int)(((byte)(247)))));
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(9, 275);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(247, 117);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClose.Location = new System.Drawing.Point(134, 29);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBar2.Location = new System.Drawing.Point(272, 137);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(265, 10);
            this.progressBar2.TabIndex = 52;
            // 
            // panelModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(549, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panelModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Module";
            this.Load += new System.EventHandler(this.Module_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheckIp;
        private System.Windows.Forms.Button brnSimChk;
        private System.Windows.Forms.Button btnAtChk;
        private System.Windows.Forms.Button btnPdpAct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button btnModuleBaudRate;
        private System.Windows.Forms.TextBox txtModuleBaudRate;
        private System.Windows.Forms.TextBox txtIPV4;
        private System.Windows.Forms.Button btnIPV4;
        private System.Windows.Forms.TextBox txtIPV6;
        private System.Windows.Forms.Button btnIPV6;
    }
}