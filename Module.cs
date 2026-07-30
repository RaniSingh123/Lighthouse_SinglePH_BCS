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
    public partial class panelModule : Form
    {
        string dataOUT;
        string dataIN;
        string dataTimeStr;
        char[] dateTime = new char[20];
        public panelModule()
        {
            InitializeComponent();
        }
        private void Module_Load(object sender, EventArgs e)
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
        private void btnAtChk_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "AT\r";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void brnSimChk_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "AT+CPIN?\r";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnModuleBaudRate_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                 dataOUT = "AT+IPR=" + txtModuleBaudRate.Text + "\r";
               
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "AT&W\r";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnIPV4_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                dataOUT = "AT+QICSGP=1,1,\"" + txtIPV4.Text + "\",\"\",\"\",0\r";

                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnIPV6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "AT+QICSGP=1,2,\"" + txtIPV6.Text + "\",\"\",\"\",0\r";

                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnPdpAct_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "AT+QIACT=1\r";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnCheckIp_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "AT+QIACT?\r";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

      
    }
}
