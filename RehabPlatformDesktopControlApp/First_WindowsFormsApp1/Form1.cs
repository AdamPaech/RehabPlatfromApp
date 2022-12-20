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

        //creating data bridge
        public delegate void d1(string indata);
        private static int counter = 0;
        private static string sEncoderValue;
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
            //groupBox14.Enabled = false;
            //mode selection groupbox is off at start 
            groupBox13.Enabled = false;
            //lege selection is off at start
            groupBox12.Enabled = false;
            //stop button is off at start
            btnStop.Enabled = false;
            //reset button is off at start
            btnReset.Enabled = false;
            //button RESET is unable at start
            btnInitialize.Enabled = false;

            serialPort1.DtrEnable = false;
            serialPort1.RtsEnable = false;
            //btnSendData.Enabled = false;
            sendWith = "Write";


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
                //enable INIT button
                btnInitialize.Enabled = true;
                //groupBox12.Enabled = true;
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
                if (chBoxsinglemode.Checked = true)
                {
                    chBoxsinglemode.Checked = false;
                }
                else if (chBoxserialmotion.Checked == true)
                {
                    chBoxserialmotion.Checked = false;
                }
                //
                if (chboxRightleg.Checked = true)
                {
                    chboxRightleg.Checked = false;
                }
                else if (chboxLeftleg.Checked == true)
                {
                    chboxLeftleg.Checked = false;
                }
                //
                if (groupBox12.Enabled == true)
                {
                    groupBox12.Enabled = false;
                }
                if (groupBox13.Enabled = true)
                {
                    groupBox13.Enabled = false;
                }
                //
                timer1.Stop();
                serialPort1.Close();
                progressBar1.Value = 0;
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "OFF";
                btnInitialize.Enabled = false;



            }
        }

        private void chBoxDtrEnable_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chBoxRTSEnable_CheckedChanged(object sender, EventArgs e)
        {
            
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
            tBoxDataOut.Text = tBoxDataOut.Text.Replace(Environment.NewLine, "");
            //lblDataOutLength.Text = String.Format("{0:00}", dataOUTLength);
            //if(chBoxUsingEnter.Checked)
            //{
            //    tBoxDataOut.Text = tBoxDataOut.Text.Replace(Environment.NewLine, "");
            //}
        }

        private void chBoxUsingButton_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void tBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.Enter)
            //{
            //    tBoxDataOut.Text = tBoxDataOut.Text.Replace(Environment.NewLine, "");
            //}
        }

        private void chBoxWriteLine_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBoxWrite_CheckedChanged(object sender, EventArgs e)
        {

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
            //NEW SOLUTION
            string indata = serialPort1.ReadLine();
            d1 writeit = new d1(Write2Form);
            Invoke(writeit, indata);


            //### HINDI SOLUTION
            //DataIN = serialPort1.ReadExisting();
            //this.Invoke(new EventHandler(ShowData));
        }
        
        public void Write2Form(string indata)
        {
            //this function handles data sent from stm32 and writes it to the form
            char firstchar;
            Single numdata;
            Single angle;
            firstchar = indata[0];
            string firstfour = indata.Substring(0, 4);
            Console.Write(firstfour);
            Console.Write(indata);
            switch (firstchar)
            {   
                case 'p':
                    counter++;
                    //tBoxincoming.Text = Convert.ToString(counter);
                    break;
                //ENCODER VALUE
                case 'e':
                    lblEncoderStatus.Text = indata.Substring(1);
                    break;
                //ENGINE STATE
            }

            //ENGINE STATE
            switch (firstfour)
            {
                case "redy":
                    lblStatusEngine.Text = "READY";
                    break;
                case "work":
                    lblStatusEngine.Text = "MOTION IN PROGRESS...";
                    break;
                case "stop":
                    lblStatusEngine.Text = "STOPPED";
                    break;
                case "inig":
                    lblStatusEngine.Text = "INITIALIZING";
                    break;
            }
        }

        private void chBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClearDataIN_Click(object sender, EventArgs e)
        {

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
            Process.Start("D:\\KneeAngleMes_DEMO\\DEMO_V1.exe"); //you can give here a file path
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
                btnStop.Enabled = true;
                btnReset.Enabled = true;
            }
            else 
            { 
                groupBox4.Enabled = false;
                btnReset.Enabled = false;
                btnStop.Enabled = false;
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
                btnStop.Enabled = true;
                btnReset.Enabled = true;
            }
            else 
            { 
                groupBox11.Enabled = false;
                btnStop.Enabled = false;
                btnReset.Enabled = false;
            }
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "INIT";
                serialPort1.Write(dataOUT);
                //lege selection is off at start
                groupBox12.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "HALT";
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

        private void btn10_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "010P";
                serialPort1.Write(dataOUT);
            }
        }

        private void btnContSingle_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "CONT";
                serialPort1.Write(dataOUT);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "RSET";
                serialPort1.Write(dataOUT);
            }
        }

        private void btnContSerial_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "CONT";
                serialPort1.Write(dataOUT);
            }
        }

        private void chBoxUsingEnter_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
