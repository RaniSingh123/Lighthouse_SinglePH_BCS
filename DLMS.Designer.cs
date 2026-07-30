
namespace LH_RnD_New
{
    partial class panelDLMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelDLMS));
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRelayOff = new System.Windows.Forms.Button();
            this.btnRelayConnect = new System.Windows.Forms.Button();
            this.cTxtSetSrNoDlms = new System.Windows.Forms.TextBox();
            this.btnSetSrNoDlms = new System.Windows.Forms.Button();
            this.btnGetSrNoDlms = new System.Windows.Forms.Button();
            this.btnSetDefaultCalDlms = new System.Windows.Forms.Button();
            this.btnCalNeutralDlms = new System.Windows.Forms.Button();
            this.btnCalPhaseDlms = new System.Windows.Forms.Button();
            this.btnSetCalUnlockDlms = new System.Windows.Forms.Button();
            this.btnMemEraseDlms = new System.Windows.Forms.Button();
            this.btnUnlockDlms = new System.Windows.Forms.Button();
            this.btnSetTimeDlms = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.tBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.Highlight;
            this.progressBar2.ForeColor = System.Drawing.SystemColors.Info;
            this.progressBar2.Location = new System.Drawing.Point(273, 132);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(265, 10);
            this.progressBar2.TabIndex = 37;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.btnRelayOff);
            this.groupBox3.Controls.Add(this.btnRelayConnect);
            this.groupBox3.Controls.Add(this.cTxtSetSrNoDlms);
            this.groupBox3.Controls.Add(this.btnSetSrNoDlms);
            this.groupBox3.Controls.Add(this.btnGetSrNoDlms);
            this.groupBox3.Controls.Add(this.btnSetDefaultCalDlms);
            this.groupBox3.Controls.Add(this.btnCalNeutralDlms);
            this.groupBox3.Controls.Add(this.btnCalPhaseDlms);
            this.groupBox3.Controls.Add(this.btnSetCalUnlockDlms);
            this.groupBox3.Controls.Add(this.btnMemEraseDlms);
            this.groupBox3.Controls.Add(this.btnUnlockDlms);
            this.groupBox3.Controls.Add(this.btnSetTimeDlms);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 166);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DLMS";
            // 
            // btnRelayOff
            // 
            this.btnRelayOff.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRelayOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelayOff.ForeColor = System.Drawing.Color.White;
            this.btnRelayOff.Location = new System.Drawing.Point(139, 93);
            this.btnRelayOff.Margin = new System.Windows.Forms.Padding(2);
            this.btnRelayOff.Name = "btnRelayOff";
            this.btnRelayOff.Size = new System.Drawing.Size(120, 31);
            this.btnRelayOff.TabIndex = 28;
            this.btnRelayOff.Text = "RELAY DISCONNECT";
            this.btnRelayOff.UseVisualStyleBackColor = false;
            this.btnRelayOff.Click += new System.EventHandler(this.btnRelayOff_Click);
            // 
            // btnRelayConnect
            // 
            this.btnRelayConnect.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRelayConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelayConnect.ForeColor = System.Drawing.Color.White;
            this.btnRelayConnect.Location = new System.Drawing.Point(6, 95);
            this.btnRelayConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnRelayConnect.Name = "btnRelayConnect";
            this.btnRelayConnect.Size = new System.Drawing.Size(120, 31);
            this.btnRelayConnect.TabIndex = 27;
            this.btnRelayConnect.Text = "RELAY CONNECT";
            this.btnRelayConnect.UseVisualStyleBackColor = false;
            this.btnRelayConnect.Click += new System.EventHandler(this.btnRelayConnect_Click);
            // 
            // cTxtSetSrNoDlms
            // 
            this.cTxtSetSrNoDlms.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cTxtSetSrNoDlms.Location = new System.Drawing.Point(139, 130);
            this.cTxtSetSrNoDlms.Multiline = true;
            this.cTxtSetSrNoDlms.Name = "cTxtSetSrNoDlms";
            this.cTxtSetSrNoDlms.Size = new System.Drawing.Size(380, 28);
            this.cTxtSetSrNoDlms.TabIndex = 26;
            // 
            // btnSetSrNoDlms
            // 
            this.btnSetSrNoDlms.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSetSrNoDlms.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetSrNoDlms.ForeColor = System.Drawing.Color.White;
            this.btnSetSrNoDlms.Location = new System.Drawing.Point(5, 130);
            this.btnSetSrNoDlms.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetSrNoDlms.Name = "btnSetSrNoDlms";
            this.btnSetSrNoDlms.Size = new System.Drawing.Size(120, 31);
            this.btnSetSrNoDlms.TabIndex = 25;
            this.btnSetSrNoDlms.Text = "SET SR NO";
            this.btnSetSrNoDlms.UseVisualStyleBackColor = false;
            this.btnSetSrNoDlms.Click += new System.EventHandler(this.btnSetSrNoDlms_Click);
            // 
            // btnGetSrNoDlms
            // 
            this.btnGetSrNoDlms.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGetSrNoDlms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnGetSrNoDlms.FlatAppearance.BorderSize = 0;
            this.btnGetSrNoDlms.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnGetSrNoDlms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnGetSrNoDlms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnGetSrNoDlms.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetSrNoDlms.ForeColor = System.Drawing.Color.White;
            this.btnGetSrNoDlms.Location = new System.Drawing.Point(398, 60);
            this.btnGetSrNoDlms.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetSrNoDlms.Name = "btnGetSrNoDlms";
            this.btnGetSrNoDlms.Size = new System.Drawing.Size(120, 31);
            this.btnGetSrNoDlms.TabIndex = 24;
            this.btnGetSrNoDlms.Text = "GET SR NO";
            this.btnGetSrNoDlms.UseVisualStyleBackColor = false;
            this.btnGetSrNoDlms.Click += new System.EventHandler(this.btnGetSrNoDlms_Click);
            // 
            // btnSetDefaultCalDlms
            // 
            this.btnSetDefaultCalDlms.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSetDefaultCalDlms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnSetDefaultCalDlms.FlatAppearance.BorderSize = 0;
            this.btnSetDefaultCalDlms.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnSetDefaultCalDlms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnSetDefaultCalDlms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnSetDefaultCalDlms.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDefaultCalDlms.ForeColor = System.Drawing.Color.White;
            this.btnSetDefaultCalDlms.Location = new System.Drawing.Point(270, 60);
            this.btnSetDefaultCalDlms.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetDefaultCalDlms.Name = "btnSetDefaultCalDlms";
            this.btnSetDefaultCalDlms.Size = new System.Drawing.Size(120, 31);
            this.btnSetDefaultCalDlms.TabIndex = 23;
            this.btnSetDefaultCalDlms.Text = "SET DEFAULT CAL";
            this.btnSetDefaultCalDlms.UseVisualStyleBackColor = false;
            this.btnSetDefaultCalDlms.Click += new System.EventHandler(this.btnSetDefaultCalDlms_Click);
            // 
            // btnCalNeutralDlms
            // 
            this.btnCalNeutralDlms.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalNeutralDlms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnCalNeutralDlms.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnCalNeutralDlms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnCalNeutralDlms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnCalNeutralDlms.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalNeutralDlms.ForeColor = System.Drawing.Color.White;
            this.btnCalNeutralDlms.Location = new System.Drawing.Point(139, 59);
            this.btnCalNeutralDlms.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalNeutralDlms.Name = "btnCalNeutralDlms";
            this.btnCalNeutralDlms.Size = new System.Drawing.Size(120, 31);
            this.btnCalNeutralDlms.TabIndex = 22;
            this.btnCalNeutralDlms.Text = "CAL NEUTRAL";
            this.btnCalNeutralDlms.UseVisualStyleBackColor = false;
            this.btnCalNeutralDlms.Click += new System.EventHandler(this.btnCalNeutralDlms_Click);
            // 
            // btnCalPhaseDlms
            // 
            this.btnCalPhaseDlms.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalPhaseDlms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnCalPhaseDlms.FlatAppearance.BorderSize = 0;
            this.btnCalPhaseDlms.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnCalPhaseDlms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnCalPhaseDlms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnCalPhaseDlms.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalPhaseDlms.ForeColor = System.Drawing.Color.White;
            this.btnCalPhaseDlms.Location = new System.Drawing.Point(6, 60);
            this.btnCalPhaseDlms.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalPhaseDlms.Name = "btnCalPhaseDlms";
            this.btnCalPhaseDlms.Size = new System.Drawing.Size(120, 31);
            this.btnCalPhaseDlms.TabIndex = 21;
            this.btnCalPhaseDlms.Text = "CAL PHASE";
            this.btnCalPhaseDlms.UseVisualStyleBackColor = false;
            this.btnCalPhaseDlms.Click += new System.EventHandler(this.btnCalPhaseDlms_Click);
            // 
            // btnSetCalUnlockDlms
            // 
            this.btnSetCalUnlockDlms.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSetCalUnlockDlms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnSetCalUnlockDlms.FlatAppearance.BorderSize = 0;
            this.btnSetCalUnlockDlms.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnSetCalUnlockDlms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnSetCalUnlockDlms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnSetCalUnlockDlms.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCalUnlockDlms.ForeColor = System.Drawing.Color.White;
            this.btnSetCalUnlockDlms.Location = new System.Drawing.Point(396, 20);
            this.btnSetCalUnlockDlms.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetCalUnlockDlms.Name = "btnSetCalUnlockDlms";
            this.btnSetCalUnlockDlms.Size = new System.Drawing.Size(120, 31);
            this.btnSetCalUnlockDlms.TabIndex = 20;
            this.btnSetCalUnlockDlms.Text = "SET CAL UNLOCK";
            this.btnSetCalUnlockDlms.UseVisualStyleBackColor = false;
            this.btnSetCalUnlockDlms.Click += new System.EventHandler(this.btnSetCalUnlockDlms_Click);
            // 
            // btnMemEraseDlms
            // 
            this.btnMemEraseDlms.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMemEraseDlms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnMemEraseDlms.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnMemEraseDlms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnMemEraseDlms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnMemEraseDlms.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemEraseDlms.ForeColor = System.Drawing.Color.White;
            this.btnMemEraseDlms.Location = new System.Drawing.Point(5, 20);
            this.btnMemEraseDlms.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemEraseDlms.Name = "btnMemEraseDlms";
            this.btnMemEraseDlms.Size = new System.Drawing.Size(120, 31);
            this.btnMemEraseDlms.TabIndex = 18;
            this.btnMemEraseDlms.Text = "MEM ERASE";
            this.btnMemEraseDlms.UseVisualStyleBackColor = false;
            this.btnMemEraseDlms.Click += new System.EventHandler(this.btnMemEraseDlms_Click);
            // 
            // btnUnlockDlms
            // 
            this.btnUnlockDlms.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUnlockDlms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnUnlockDlms.FlatAppearance.BorderSize = 0;
            this.btnUnlockDlms.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnUnlockDlms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnUnlockDlms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnUnlockDlms.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlockDlms.ForeColor = System.Drawing.Color.White;
            this.btnUnlockDlms.Location = new System.Drawing.Point(269, 21);
            this.btnUnlockDlms.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnlockDlms.Name = "btnUnlockDlms";
            this.btnUnlockDlms.Size = new System.Drawing.Size(120, 31);
            this.btnUnlockDlms.TabIndex = 15;
            this.btnUnlockDlms.Text = "UNLOCK DLMS";
            this.btnUnlockDlms.UseVisualStyleBackColor = false;
            this.btnUnlockDlms.Click += new System.EventHandler(this.btnUnlockDlms_Click);
            // 
            // btnSetTimeDlms
            // 
            this.btnSetTimeDlms.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSetTimeDlms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnSetTimeDlms.FlatAppearance.BorderSize = 0;
            this.btnSetTimeDlms.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnSetTimeDlms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnSetTimeDlms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btnSetTimeDlms.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTimeDlms.ForeColor = System.Drawing.Color.White;
            this.btnSetTimeDlms.Location = new System.Drawing.Point(139, 20);
            this.btnSetTimeDlms.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetTimeDlms.Name = "btnSetTimeDlms";
            this.btnSetTimeDlms.Size = new System.Drawing.Size(120, 31);
            this.btnSetTimeDlms.TabIndex = 17;
            this.btnSetTimeDlms.Text = "SET TIME DLMS";
            this.btnSetTimeDlms.UseVisualStyleBackColor = false;
            this.btnSetTimeDlms.Click += new System.EventHandler(this.btnSetTimeDlms_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
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
            this.cBoxParityBits.Location = new System.Drawing.Point(98, 178);
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
            this.cBoxStopBits.Location = new System.Drawing.Point(98, 142);
            this.cBoxStopBits.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(111, 25);
            this.cBoxStopBits.TabIndex = 3;
            this.cBoxStopBits.Text = "One";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Highlight;
            this.progressBar1.ForeColor = System.Drawing.Color.Yellow;
            this.progressBar1.Location = new System.Drawing.Point(9, 66);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(246, 10);
            this.progressBar1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClose.Location = new System.Drawing.Point(141, 17);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOpen.ForeColor = System.Drawing.Color.LightYellow;
            this.btnOpen.Location = new System.Drawing.Point(8, 17);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(120, 31);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(98, 106);
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
            this.cBoxBaudRate.Location = new System.Drawing.Point(98, 70);
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
            this.cBoxComPort.Location = new System.Drawing.Point(98, 37);
            this.cBoxComPort.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(111, 25);
            this.cBoxComPort.TabIndex = 0;
            // 
            // tBox
            // 
            this.tBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tBox.Location = new System.Drawing.Point(273, 23);
            this.tBox.Margin = new System.Windows.Forms.Padding(2);
            this.tBox.Multiline = true;
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(265, 105);
            this.tBox.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(273, 165);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(265, 94);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.groupBox1.Location = new System.Drawing.Point(11, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(245, 236);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LH COMMAND SOLUTION";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(735, 571);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // panelDLMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(549, 498);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panelDLMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLMS";
            this.Load += new System.EventHandler(this.DLMS_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox cTxtSetSrNoDlms;
        private System.Windows.Forms.Button btnSetSrNoDlms;
        private System.Windows.Forms.Button btnGetSrNoDlms;
        private System.Windows.Forms.Button btnSetDefaultCalDlms;
        private System.Windows.Forms.Button btnCalNeutralDlms;
        private System.Windows.Forms.Button btnCalPhaseDlms;
        private System.Windows.Forms.Button btnSetCalUnlockDlms;
        private System.Windows.Forms.Button btnMemEraseDlms;
        private System.Windows.Forms.Button btnUnlockDlms;
        private System.Windows.Forms.Button btnSetTimeDlms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnRelayOff;
        private System.Windows.Forms.Button btnRelayConnect;
    }
}