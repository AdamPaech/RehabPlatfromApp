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
using System.Runtime.InteropServices;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace First_WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        ///deklaracja zmiennych //
        string dataOUT;
        string sendWith;
        string DataIN;
        string selectedLeg;
        string selectedMode;
        int sizeIN;
        char[] DataINChar = { 'a' };

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                int dataOUTLength_1 = tBoxDataOut.TextLength;
                if (dataOUTLength_1 == 1)
                {
                    dataOUT = "00" + tBoxDataOut.Text + 'P';
                }
                else if (dataOUTLength_1 == 2)
                {
                    dataOUT = '0' + tBoxDataOut.Text + 'P';
                }
                else
                {
                    dataOUT = "090P";
                    tBoxDataOut.Text = "90";
                }
                
                
              


                //dataOUT = "P0" + tBoxDataOut.Text;
                /*dataOUT = 'P' + dataOUT;*/ 
                if (sendWith == "WriteLine")
                {
                    serialPort1.WriteLine(dataOUT);
                }
                else if(sendWith == "Write") 
                { 
                    serialPort1.Write(dataOUT); 
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);

            btnOpen.Enabled = true;
            btnClose.Enabled = false;

            //serial mode groupbox is off at start
            groupBox11.Enabled = false;
            //single mode groupbox is off at start
            groupBox4.Enabled = false;
            // 2nd single mode groupbox is off at start
            groupBox14.Enabled = false;
            //mode selection groupbox is off at start 
            groupBox13.Enabled = false;
            //lege selection is off at start
            groupBox12.Enabled = false;

            chBoxDtrEnable.Checked = false;
            serialPort1.DtrEnable = false;
            chBoxRTSEnable.Checked = false;
            serialPort1.RtsEnable = false;
            btnSendData.Enabled = false;
            chBoxWriteLine.Checked = false;
            chBoxWrite.Checked = true;
            sendWith = "Write";

            chBoxAddToOldData.Checked = true;
            chBoxAlwaysUpdate.Checked = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                //choosing parameters
                //serialPort1.PortName = cBoxCOMPORT.Text;
                //serialPort1.BaudRate = Convert.ToInt32(CBoxBaudRate.Text);
                //serialPort1.DataBits = Convert.ToInt32(CBoxDataBits.Text);
                //serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CBoxStopBits.Text);
                //serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CBoxParityBits.Text);

                //default parameters
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "None");

                serialPort1.Open();
                timer1.Start();
                progressBar1.Value = 100;
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                lblStatusCom.Text = "ON";
                groupBox12.Enabled = true;
            }
            
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "OFF";
                groupBox12.Enabled = false;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                timer1.Stop();
                serialPort1.Close();
                progressBar1.Value = 0;
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "OFF";
                if(groupBox12.Enabled == true)
                {
                    groupBox12.Enabled = false;
                }
                
            }
        }

        private void chBoxDtrEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxDtrEnable.Checked)
            {
                serialPort1.DtrEnable = true;
            }
            else { serialPort1.DtrEnable = false; }
        }

        private void chBoxRTSEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxRTSEnable.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else { serialPort1.RtsEnable = false; }
        }

        private void btnClearDataOut_Click(object sender, EventArgs e)
        {
            if(tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = "";
            }
        }

        private void tBoxDataOut_TextChanged(object sender, EventArgs e)
        {
            int dataOUTLength = tBoxDataOut.TextLength;
            lblDataOutLength.Text = String.Format("{0:00}", dataOUTLength);
            if(chBoxUsingEnter.Checked)
            {
                tBoxDataOut.Text = tBoxDataOut.Text.Replace(Environment.NewLine, "");
            }
        }

        private void chBoxUsingButton_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxUsingButton.Checked)
            {
                btnSendData.Enabled = true;
            }
            else { btnSendData.Enabled = false; }
        }

        private void tBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        {
            if(chBoxUsingEnter.Checked)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    if (serialPort1.IsOpen)
                    {
                        dataOUT = tBoxDataOut.Text;
                        if (sendWith == "WriteLine")
                        {
                            serialPort1.WriteLine(dataOUT);
                        }
                        else if (sendWith == "Write")
                        {
                            serialPort1.Write(dataOUT);
                        }
                    }
                }
            }
        }

        private void chBoxWriteLine_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxWriteLine.Checked)
            {
                sendWith = "WriteLine";
                chBoxWrite.Checked = false;
                chBoxWriteLine.Checked = true;
                //dataOUT = "LD2";
                //serialPort1.Write(dataOUT);

            }

        }

        private void chBoxWrite_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxWrite.Checked)
            {
                sendWith = "Write";
                chBoxWrite.Checked = true;
                chBoxWriteLine.Checked = false;
            }
        }

        private void cBoxCOMPORT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblStatusCom_Click(object sender, EventArgs e)
        {

        }

        private void lblDataOutLength_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            DataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            //int dataINLength = DataIN.Length;
            //lblDataInLength.Text = String.Format("{0:00}", dataINLength);
            //if (chBoxAlwaysUpdate.Checked)
            //{
            //    tBoxDataIN.Text = DataIN;
            //}
            //else if (chBoxAddToOldData.Checked)
            //{
            //    tBoxDataIN.Text += DataIN;
            //}
            if (DataIN != tBoxDataIN.Text)
            {
                tBoxDataIN.Text = DataIN;
            }
            if(DataIN == "PIP")
            {
                lblStatusEngine.Text = "ON";


            }
        }

        private void chBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxAlwaysUpdate.Checked)
            {
                chBoxAlwaysUpdate.Checked = true;
                chBoxAddToOldData.Checked = false;
            }
            else
            {
                chBoxAddToOldData.Checked = true;
            }
        }

        private void chBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxAddToOldData.Checked)
            {
                chBoxAlwaysUpdate.Checked = false;
                chBoxAddToOldData.Checked = true;
            }
            else
            {
                chBoxAlwaysUpdate.Checked = true;
            }
        }

        private void btnClearDataIN_Click(object sender, EventArgs e)
        {
            if(tBoxDataIN.Text != "")
            {
                tBoxDataIN.Text = "";
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Adam Paech", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLD1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                dataOUT = "LD01";
                serialPort1.Write(dataOUT);
            }
        }

        private void btnLD2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                dataOUT = "LD02";
                serialPort1.Write(dataOUT);
            }
        }

        private void btnLD3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                dataOUT = "LD03";
                serialPort1.Write(dataOUT);
            }
        }

        private void tBoxDataIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDataInLength_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //int dataINLength = DataIN.Length;
                //lblDataInLength.Text = String.Format("{0:00}", dataINLength);
                //DataIN = serialPort1.ReadExisting();
                //if(DataIN != tBoxDataIN.Text)
                //{
                //    tBoxDataIN.Text = DataIN;
                //}
            //    if (chBoxAlwaysUpdate.Checked)
            //    {
            //        tBoxDataIN.Text = DataIN;
            //    }
            }
            catch(Exception err)
            {

            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                //dataOUT = tBoxDataOut.Text;
                dataOUT = "000P";
                serialPort1.Write(dataOUT);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "015P";
                serialPort1.Write(dataOUT);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn30_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "030P";
                serialPort1.Write(dataOUT);
            }
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "045P";
                serialPort1.Write(dataOUT);
            }
        }

        private void btn60_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "060P";
                serialPort1.Write(dataOUT);
            }
        }

        private void btn75_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "075P";
                serialPort1.Write(dataOUT);
            }
        }

        private void btn90_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "090P";
                serialPort1.Write(dataOUT);
            }
        }

        //private void btnBASE_Click(object sender, EventArgs e)
        //{
        //    ///what is base
        //}

        private void btnSAFE_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "000P";
                serialPort1.Write(dataOUT);
            }
        }

        private void chboxRightleg_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxRightleg.Checked)
            {
                selectedLeg = "Right";
                dataOUT = "RGHT";
                serialPort1.Write(dataOUT);
                chboxLeftleg.Checked = false;
                chboxRightleg.Checked = true;
                groupBox13.Enabled = true;
            }
            else
            {
                groupBox13.Enabled = false;
                groupBox4.Enabled = false;
                groupBox14.Enabled = false;
                groupBox11.Enabled = false;
                //unchecking mode checkboxes
                if (chBoxserialmotion.Checked == true)
                {
                    chBoxserialmotion.Checked = false;
                }
                if (chBoxsinglemode.Checked == true)
                {
                    chBoxsinglemode.Checked = false;
                }
            }
        }

        private void chboxLeftleg_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxLeftleg.Checked)
            {
                selectedLeg = "Left";
                dataOUT = "LEFT";
                serialPort1.Write(dataOUT);
                chboxRightleg.Checked = false;
                chboxLeftleg.Checked = true;
                groupBox13.Enabled = true;
            }
            else
            {
                groupBox13.Enabled = false;
                groupBox4.Enabled = false;
                groupBox14.Enabled = false;
                groupBox11.Enabled = false;
                //unchecking mode checkboxes
                if(chBoxserialmotion.Checked == true)
                {
                    chBoxserialmotion.Checked = false;
                }
                if (chBoxsinglemode.Checked == true)
                {
                    chBoxsinglemode.Checked = false;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExternalexe_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe"); //you can also give here a file path
        }

        private void chBoxsinglemode_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxsinglemode.Checked)
            {
                selectedMode = "Single";
                dataOUT = "SNGL";
                serialPort1.Write(dataOUT);
                chBoxserialmotion.Checked = false;
                chBoxsinglemode.Checked = true;
                groupBox4.Enabled = true;
                groupBox14.Enabled = true;
            }
            else 
            { 
                groupBox4.Enabled = false;
                groupBox14.Enabled = false;
            }
        }

        private void chBoxserialmotion_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxserialmotion.Checked)
            {
                selectedMode = "Serial";
                dataOUT = "SERL";
                serialPort1.Write(dataOUT);
                chBoxsinglemode.Checked = false;
                chBoxserialmotion.Checked = true;
                groupBox11.Enabled = true;
            }
            else { groupBox11.Enabled = false; }
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "INIT";
                serialPort1.Write(dataOUT);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "STOP";
                serialPort1.Write(dataOUT);
            }
        }

        private void btnSetreps_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int dataOUTLength_2 = tBoxnumberoreps.TextLength;
                if (dataOUTLength_2 == 1)
                {
                    dataOUT = "00" + tBoxnumberoreps.Text + 'N';
                }
                else if (dataOUTLength_2 == 2)
                {
                    int liczba_powt = Int32.Parse(tBoxnumberoreps.Text);
                    //max liczba_powt = 20
                    if (liczba_powt > 20)
                    {
                        tBoxnumberoreps.Text = "20";
                        dataOUT = "020N";
                    }
                    else if (liczba_powt <= 20)
                    {
                        dataOUT = '0' + tBoxnumberoreps.Text + 'N';
                    }
                }

                if (sendWith == "WriteLine")
                {
                    serialPort1.WriteLine(dataOUT);
                }
                else if (sendWith == "Write")
                {
                    serialPort1.Write(dataOUT);
                }
            }
        }

        private void btnSetrange_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int dataOUTLength_3 = tBoxrangeomotion.TextLength;
                if (dataOUTLength_3 == 1)
                {
                    dataOUT = "00" + tBoxrangeomotion.Text + 'R';
                }
                else if (dataOUTLength_3 == 2)
                {
                    int liczba_zakresu = Int32.Parse(tBoxrangeomotion.Text);
                    if (liczba_zakresu > 90)
                    {
                        tBoxrangeomotion.Text = "90";
                        dataOUT = "090R";
                    }
                    else if (liczba_zakresu <= 90)
                    {
                        dataOUT = '0' + tBoxrangeomotion.Text + 'R';
                    }
                }
                else
                {
                    dataOUT = "090R";
                    tBoxrangeomotion.Text = "90";
                }

                if (sendWith == "WriteLine")
                {
                    serialPort1.WriteLine(dataOUT);
                }
                else if (sendWith == "Write")
                {
                    serialPort1.Write(dataOUT);
                }
            }
        }

        private void btnStartserial_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "STSE";
                serialPort1.Write(dataOUT);
            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
    }
}
