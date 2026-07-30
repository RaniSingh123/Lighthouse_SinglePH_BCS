using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.Threading;

namespace LH_RnD_New
{
    public partial class panelTimer : Form
    {
        public panelTimer()
        {
            InitializeComponent();
        }
        string dataOUT;
        string dataIN;
        string dataTimeStr;
        char[] dateTime = new char[20];
      
        private void DLMS_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);
        }
        private void panelTimer_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                progressBar2.Value = 0;
                tBox.Text = null;
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpunlock}";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(1000);
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }



        private void ShowData(object sender, EventArgs e)
        {
            //int timeOutdelay = 10000;
            //timer = new System.Threading.Timer(TimeoutCallback, null, timeOutdelay, Timeout.Infinite);
            tBox.Text = dataIN;
            progressBar2.Value = 100;

        }

        #region timer
        //*********************************** start timer buttons****************************************//
        private void btnMemTmrErs_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpmerF";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnTimeSetTimer_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                // cBoxEbRate.Text
                dataTimeStr = DateTime.Now.ToString("yyMMddHHmmss");
                byte[] ba = Encoding.Default.GetBytes(dataTimeStr);
                /// dateTime = DateTime.Now.Ticks.("yyMMddHHmmss");
                ///
                //var hexstring = BitConverter.ToString(ba);
                dateTime[0] = 'n';
                dateTime[1] = 'x';
                dateTime[2] = 'p';
                dateTime[3] = 's';
                dateTime[4] = 'r';
                dateTime[5] = 't';
                dateTime[6] = 'c';
                dateTime[7] = (char)((ba[0] - 48) * 10 + (ba[1] - 48));
                dateTime[8] = (char)((ba[2] - 48) * 10 + (ba[3] - 48));
                dateTime[9] = (char)((ba[4] - 48) * 10 + (ba[5] - 48));
                dateTime[10] = (char)((ba[6] - 48) * 10 + (ba[7] - 48));
                dateTime[11] = (char)((ba[8] - 48) * 10 + (ba[9] - 48));
                dateTime[12] = (char)((ba[10] - 48) * 10 + (ba[11] - 48));
                dateTime[13] = 'F';
                // dataOUT = Convert.ToString(dateTime) ;
                // serialPort1.WriteLine(dataOUT);
                serialPort1.Write(dateTime, 0, 14);
                progressBar2.Value = 0;
            }
        }

        private void btnCommUnlockTimer_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpunlockF";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnSetDefaultCalTimer_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpdcalF";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnCalPhaseTimer_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpcalpF";
                serialPort1.WriteLine(dataOUT);
            }
        }

        private void btnCalNeutralTimer_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpcalnF";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnSetCalUnlockTimer_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpscall0F";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnSetCalLockTimer_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpscall1F";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnRelayOnTimer_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxprlyctr0F";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnRelayOffTimer_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxprlyctr1F";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        //***********************************timer buttons****************************************//
        #endregion timer

        private void btnTimeSetTimer_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                // cBoxEbRate.Text
                dataTimeStr = DateTime.Now.ToString("yyMMddHHmmss");
                byte[] ba = Encoding.Default.GetBytes(dataTimeStr);
                /// dateTime = DateTime.Now.Ticks.("yyMMddHHmmss");
                ///
                //var hexstring = BitConverter.ToString(ba);
                dateTime[0] = 'n';
                dateTime[1] = 'x';
                dateTime[2] = 'p';
                dateTime[3] = 's';
                dateTime[4] = 'r';
                dateTime[5] = 't';
                dateTime[6] = 'c';
                dateTime[7] = (char)((ba[0] - 48) * 10 + (ba[1] - 48));
                dateTime[8] = (char)((ba[2] - 48) * 10 + (ba[3] - 48));
                dateTime[9] = (char)((ba[4] - 48) * 10 + (ba[5] - 48));
                dateTime[10] = (char)((ba[6] - 48) * 10 + (ba[7] - 48));
                dateTime[11] = (char)((ba[8] - 48) * 10 + (ba[9] - 48));
                dateTime[12] = (char)((ba[10] - 48) * 10 + (ba[11] - 48));
                dateTime[13] = 'F';
                // dataOUT = Convert.ToString(dateTime) ;
                // serialPort1.WriteLine(dataOUT);
                serialPort1.Write(dateTime, 0, 14);
                progressBar2.Value = 0;
            }
        }

        
    }
}
