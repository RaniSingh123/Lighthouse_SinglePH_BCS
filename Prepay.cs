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
using System.IO;

namespace LH_RnD_New
{
    public partial class panelPrepay : Form
    {
        private static System.Threading.Timer timer;
        string dataOUT;
        string dataIN;
        string dataTimeStr;
        char[] dateTime = new char[20];
        public panelPrepay()
        {
            InitializeComponent();
        }
        private void panelPrepay_Load(object sender, EventArgs e)
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
            //if (serialPort1.IsOpen)
            //{

            //    dataOUT = "nxpunlock}";
            //    serialPort1.WriteLine(dataOUT);
            //    progressBar2.Value = 0;
            //}
          
                if (serialPort1.IsOpen)
                {
                    try
                    {
                        string dataOUT = "nxpunlock}";
                        serialPort1.WriteLine(dataOUT);
                        progressBar2.Value = 0;
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        MessageBox.Show("Access to the port is denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.Message);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show("The specified port is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.Message);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("An I/O error occurred while accessing the port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("The serial port is not open.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        //***********************************start prepay buttons****************************************//
        #region prepay
        private void btnCalPhasePrepay_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpcalp" + "}";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnCalNeutral_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpcaln" + "}";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnSetCalUnlockPrepay_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpscall0" + "}";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnSetDefaultCalPrepay_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpdcal" + "}";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnGetSrNoPrepay_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpgsr" + "}";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnRelayOnPrepay_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxprlyctr0" + "}";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnRelayOffPrepay_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxprlyctr1" + "}";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnSetSrNoPrepay_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpssr" + (Convert.ToString(cBoxSetSrNoPrepay.Text)) + "}";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }



        private void btnMemErasePrepay_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpmer}";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnPrepayReadConfig_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpconfigREAD" + "}";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnSetTime_Click(object sender, EventArgs e)
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
                dateTime[13] = '}';
                // dataOUT = Convert.ToString(dateTime) ;
                // serialPort1.WriteLine(dataOUT);
                serialPort1.Write(dateTime, 0, 14);
                progressBar2.Value = 0;
            }
        }

        //private void btnDailyMaintenance_Click(object sender, EventArgs e)
        //{
        //    if (serialPort1.IsOpen)
        //    {
        //        Double DailyMaintenance;
        //        DailyMaintenance = Convert.ToDouble(cBoxDailyMaintenance.Text);
        //        // cBoxEbRate.Text
        //        if (DailyMaintenance > 99.0)
        //        {
        //            dataOUT = "nxpconfigDM" + (Convert.ToInt32(DailyMaintenance * 100)) + "}";
        //        }
        //        else if (DailyMaintenance <= 99.0 && DailyMaintenance >= 10.0)
        //        {
        //            dataOUT = "nxpconfigDM0" + (Convert.ToInt32(DailyMaintenance * 100)) + "}";
        //        }
        //        else
        //        {
        //            dataOUT = "nxpconfigDM00" + (Convert.ToInt32(DailyMaintenance * 100)) + "}";
        //        }

        //        serialPort1.WriteLine(dataOUT);
        //        progressBar2.Value = 0;
        //    }
        //}
        //testing-----

        private void btnDailyMaintenance_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Double DailyMaintenance;

                DailyMaintenance = Convert.ToDouble(cBoxDailyMaintenance.Text);
                // cBoxEbRate.Text
                if (DailyMaintenance >= 10000.0)
                {
                    dataOUT = "nxpconfigDM" + (Convert.ToInt32(DailyMaintenance)) + "}";
                }
                else if (DailyMaintenance <= 9999.0 && DailyMaintenance >= 1000.0)
                {
                    dataOUT = "nxpconfigDM0" + (Convert.ToInt32(DailyMaintenance)) + "}";
                }
                else if (DailyMaintenance <= 999.0 && DailyMaintenance >= 100.0)
                {
                    dataOUT = "nxpconfigDM00" + (Convert.ToInt32(DailyMaintenance)) + "}";
                }
                else if (DailyMaintenance <= 99.0 && DailyMaintenance >= 10.0)
                {
                    dataOUT = "nxpconfigDM000" + (Convert.ToInt32(DailyMaintenance)) + "}";
                }
                else
                {
                    dataOUT = "nxpconfigDM0000" + (Convert.ToInt32(DailyMaintenance)) + "}";
                }

                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }
        private void btnEraseConfig_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpconfigERS" + "}";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnEraseToken_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpconfigERT" + "}";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnEbRate_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Double EBRate;
                EBRate = Convert.ToDouble(cBoxEbRate.Text);
                //Convert.ToDouble
                // cBoxEbRate.Text
                if (EBRate >= 10.0)
                {
                    dataOUT = "nxpconfigEB" + (Convert.ToInt32(EBRate * 100)) + "}";
                }
                else
                {
                    dataOUT = "nxpconfigEB0" + (Convert.ToInt32(EBRate * 100)) + "}";
                }

                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnDgRate_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Double DGRate;
                DGRate = Convert.ToDouble(cBoxDgRate.Text);
                // cBoxEbRate.Text
                if (DGRate > 9.0)
                {
                    dataOUT = "nxpconfigDG" + (Convert.ToInt32(DGRate * 100)) + "}";
                }
                else
                {
                    dataOUT = "nxpconfigDG0" + (Convert.ToInt32(DGRate * 100)) + "}";
                }

                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Double NegBal;
                NegBal = Convert.ToDouble(txtNegativeBalance.Text);
                // cBoxEbRate.Text
                if (NegBal >= 1000.0)
                {
                    dataOUT = "nxpconfigNEG" + Convert.ToInt32(NegBal) + "}";
                }
                else if(NegBal >= 100.0 && NegBal <= 999.0)
                {
                    dataOUT = "nxpconfigNEG0" + Convert.ToInt32(NegBal) + "}";
                }
                else if(NegBal<=99.0 && NegBal >= 10.0)
                {
                    dataOUT = "nxpconfigNEG00" + Convert.ToInt32(NegBal) + "}";
                }
                else
                {
                    dataOUT = "nxpconfigNEG000" + Convert.ToInt32(NegBal) + "}";
                }

                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

        private void btnMeterRead_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "nxpmtrREAD" + "}";
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

      

  
        private void btnEbLimit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Double EBLmit;
                EBLmit = Convert.ToDouble(txtEbLimit.Text);
                //Convert.ToDouble
                // cBoxEbRate.Text
                if (EBLmit > 9.0)
                {
                    dataOUT = "nxpconfigLOADEB" + (Convert.ToInt32(EBLmit * 100)) + "}";
                }
                else
                {
                    dataOUT = "nxpconfigLOADEB0" + (Convert.ToInt32(EBLmit * 100)) + "}";
                }

                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }



        }

        private void btDgLimit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Double DGLimit;
                DGLimit = Convert.ToDouble(txtDgLimit.Text);
                //Convert.ToDouble
                // cBoxEbRate.Text
                if (DGLimit > 9.0)
                {
                    dataOUT = "nxpconfigLOADDG" + (Convert.ToInt32(DGLimit * 100)) + "}";
                }
                else
                {
                    dataOUT = "nxpconfigLOADDG0" + (Convert.ToInt32(DGLimit * 100)) + "}";
                }
                serialPort1.WriteLine(dataOUT);
                progressBar2.Value = 0;
            }
        }

      














        #endregion prepay
        //***********************************End prepay buttons****************************************//

    }
}
