namespace First_WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBoxRTSEnable = new System.Windows.Forms.CheckBox();
            this.chBoxDtrEnable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblStatusCom = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.btnClearDataOut = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.chBoxserialmotion = new System.Windows.Forms.CheckBox();
            this.chBoxsinglemode = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.chboxLeftleg = new System.Windows.Forms.CheckBox();
            this.chboxRightleg = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnSetrange = new System.Windows.Forms.Button();
            this.btnSetreps = new System.Windows.Forms.Button();
            this.btnStopserial = new System.Windows.Forms.Button();
            this.btnStartserial = new System.Windows.Forms.Button();
            this.tBoxrangeomotion = new System.Windows.Forms.TextBox();
            this.tBoxnumberoreps = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnLD1 = new System.Windows.Forms.Button();
            this.btnLD2 = new System.Windows.Forms.Button();
            this.btnLD3 = new System.Windows.Forms.Button();
            this.lblDataOutLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSAFE = new System.Windows.Forms.Button();
            this.btn90 = new System.Windows.Forms.Button();
            this.btn75 = new System.Windows.Forms.Button();
            this.btn60 = new System.Windows.Forms.Button();
            this.btn45 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chBoxWrite = new System.Windows.Forms.CheckBox();
            this.chBoxWriteLine = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chBoxUsingEnter = new System.Windows.Forms.CheckBox();
            this.chBoxUsingButton = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblDataInLength = new System.Windows.Forms.Label();
            this.LblPotentiometer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chBoxAddToOldData = new System.Windows.Forms.CheckBox();
            this.chBoxAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.btnClearDataIN = new System.Windows.Forms.Button();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnExternalexe = new System.Windows.Forms.Button();
            this.gBoxengine = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.gBoxenginestate = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatusEngine = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEncoderStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.gBoxengine.SuspendLayout();
            this.gBoxenginestate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.chBoxRTSEnable);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.chBoxDtrEnable);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(5, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 216);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chBoxRTSEnable
            // 
            this.chBoxRTSEnable.AutoSize = true;
            this.chBoxRTSEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxRTSEnable.Location = new System.Drawing.Point(131, 177);
            this.chBoxRTSEnable.Name = "chBoxRTSEnable";
            this.chBoxRTSEnable.Size = new System.Drawing.Size(89, 17);
            this.chBoxRTSEnable.TabIndex = 15;
            this.chBoxRTSEnable.Text = "RTS ENABLE";
            this.chBoxRTSEnable.UseVisualStyleBackColor = true;
            this.chBoxRTSEnable.CheckedChanged += new System.EventHandler(this.chBoxRTSEnable_CheckedChanged);
            // 
            // chBoxDtrEnable
            // 
            this.chBoxDtrEnable.AutoSize = true;
            this.chBoxDtrEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxDtrEnable.Location = new System.Drawing.Point(27, 177);
            this.chBoxDtrEnable.Name = "chBoxDtrEnable";
            this.chBoxDtrEnable.Size = new System.Drawing.Size(90, 17);
            this.chBoxDtrEnable.TabIndex = 14;
            this.chBoxDtrEnable.Text = "DTR ENABLE";
            this.chBoxDtrEnable.UseVisualStyleBackColor = true;
            this.chBoxDtrEnable.CheckedChanged += new System.EventHandler(this.chBoxDtrEnable_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "COM PORT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(118, 23);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(115, 21);
            this.cBoxCOMPORT.TabIndex = 6;
            this.cBoxCOMPORT.SelectedIndexChanged += new System.EventHandler(this.cBoxCOMPORT_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblStatusCom);
            this.groupBox7.Location = new System.Drawing.Point(182, 66);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(78, 86);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "COM PORT STATUS";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // lblStatusCom
            // 
            this.lblStatusCom.AutoSize = true;
            this.lblStatusCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatusCom.Location = new System.Drawing.Point(21, 38);
            this.lblStatusCom.Name = "lblStatusCom";
            this.lblStatusCom.Size = new System.Drawing.Size(38, 18);
            this.lblStatusCom.TabIndex = 0;
            this.lblStatusCom.Text = "OFF";
            this.lblStatusCom.Click += new System.EventHandler(this.lblStatusCom_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 124);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(161, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(94, 66);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 47);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(9, 66);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(77, 47);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxDataOut.Location = new System.Drawing.Point(4, 13);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(75, 28);
            this.tBoxDataOut.TabIndex = 5;
            this.tBoxDataOut.TextChanged += new System.EventHandler(this.tBoxDataOut_TextChanged);
            this.tBoxDataOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxDataOut_KeyDown);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox14);
            this.groupBox3.Controls.Add(this.groupBox13);
            this.groupBox3.Controls.Add(this.groupBox12);
            this.groupBox3.Controls.Add(this.groupBox11);
            this.groupBox3.Controls.Add(this.groupBox10);
            this.groupBox3.Controls.Add(this.lblDataOutLength);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(286, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 358);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manipulator Control";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.btnSendData);
            this.groupBox14.Controls.Add(this.tBoxDataOut);
            this.groupBox14.Controls.Add(this.btnClearDataOut);
            this.groupBox14.Location = new System.Drawing.Point(15, 34);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(83, 113);
            this.groupBox14.TabIndex = 20;
            this.groupBox14.TabStop = false;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(4, 48);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 28);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "SEND";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // btnClearDataOut
            // 
            this.btnClearDataOut.Location = new System.Drawing.Point(4, 80);
            this.btnClearDataOut.Name = "btnClearDataOut";
            this.btnClearDataOut.Size = new System.Drawing.Size(75, 28);
            this.btnClearDataOut.TabIndex = 6;
            this.btnClearDataOut.Text = "CLEAR";
            this.btnClearDataOut.UseVisualStyleBackColor = true;
            this.btnClearDataOut.Click += new System.EventHandler(this.btnClearDataOut_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.chBoxserialmotion);
            this.groupBox13.Controls.Add(this.chBoxsinglemode);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox13.Location = new System.Drawing.Point(303, 34);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(117, 113);
            this.groupBox13.TabIndex = 19;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Mode selection";
            // 
            // chBoxserialmotion
            // 
            this.chBoxserialmotion.AutoSize = true;
            this.chBoxserialmotion.Location = new System.Drawing.Point(7, 67);
            this.chBoxserialmotion.Name = "chBoxserialmotion";
            this.chBoxserialmotion.Size = new System.Drawing.Size(99, 19);
            this.chBoxserialmotion.TabIndex = 1;
            this.chBoxserialmotion.Text = "Serial motion";
            this.chBoxserialmotion.UseVisualStyleBackColor = true;
            this.chBoxserialmotion.CheckedChanged += new System.EventHandler(this.chBoxserialmotion_CheckedChanged);
            // 
            // chBoxsinglemode
            // 
            this.chBoxsinglemode.AutoSize = true;
            this.chBoxsinglemode.Location = new System.Drawing.Point(7, 35);
            this.chBoxsinglemode.Name = "chBoxsinglemode";
            this.chBoxsinglemode.Size = new System.Drawing.Size(102, 19);
            this.chBoxsinglemode.TabIndex = 0;
            this.chBoxsinglemode.Text = "Single motion";
            this.chBoxsinglemode.UseVisualStyleBackColor = true;
            this.chBoxsinglemode.CheckedChanged += new System.EventHandler(this.chBoxsinglemode_CheckedChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.chboxLeftleg);
            this.groupBox12.Controls.Add(this.chboxRightleg);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox12.Location = new System.Drawing.Point(303, 153);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(117, 120);
            this.groupBox12.TabIndex = 18;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Leg selection";
            // 
            // chboxLeftleg
            // 
            this.chboxLeftleg.AutoSize = true;
            this.chboxLeftleg.Location = new System.Drawing.Point(9, 39);
            this.chboxLeftleg.Name = "chboxLeftleg";
            this.chboxLeftleg.Size = new System.Drawing.Size(46, 19);
            this.chboxLeftleg.TabIndex = 2;
            this.chboxLeftleg.Text = "Left";
            this.chboxLeftleg.UseVisualStyleBackColor = true;
            this.chboxLeftleg.CheckedChanged += new System.EventHandler(this.chboxLeftleg_CheckedChanged);
            // 
            // chboxRightleg
            // 
            this.chboxRightleg.AutoSize = true;
            this.chboxRightleg.Location = new System.Drawing.Point(9, 74);
            this.chboxRightleg.Name = "chboxRightleg";
            this.chboxRightleg.Size = new System.Drawing.Size(55, 19);
            this.chboxRightleg.TabIndex = 1;
            this.chboxRightleg.Text = "Right";
            this.chboxRightleg.UseVisualStyleBackColor = true;
            this.chboxRightleg.CheckedChanged += new System.EventHandler(this.chboxRightleg_CheckedChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnSetrange);
            this.groupBox11.Controls.Add(this.btnSetreps);
            this.groupBox11.Controls.Add(this.btnStopserial);
            this.groupBox11.Controls.Add(this.btnStartserial);
            this.groupBox11.Controls.Add(this.tBoxrangeomotion);
            this.groupBox11.Controls.Add(this.tBoxnumberoreps);
            this.groupBox11.Controls.Add(this.label10);
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox11.Location = new System.Drawing.Point(15, 153);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(281, 120);
            this.groupBox11.TabIndex = 17;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Serial motion";
            // 
            // btnSetrange
            // 
            this.btnSetrange.Location = new System.Drawing.Point(186, 52);
            this.btnSetrange.Name = "btnSetrange";
            this.btnSetrange.Size = new System.Drawing.Size(89, 23);
            this.btnSetrange.TabIndex = 22;
            this.btnSetrange.Text = "SET RANGE";
            this.btnSetrange.UseVisualStyleBackColor = true;
            this.btnSetrange.Click += new System.EventHandler(this.btnSetrange_Click);
            // 
            // btnSetreps
            // 
            this.btnSetreps.Location = new System.Drawing.Point(186, 25);
            this.btnSetreps.Name = "btnSetreps";
            this.btnSetreps.Size = new System.Drawing.Size(89, 23);
            this.btnSetreps.TabIndex = 21;
            this.btnSetreps.Text = "SET REPS";
            this.btnSetreps.UseVisualStyleBackColor = true;
            this.btnSetreps.Click += new System.EventHandler(this.btnSetreps_Click);
            // 
            // btnStopserial
            // 
            this.btnStopserial.Location = new System.Drawing.Point(163, 85);
            this.btnStopserial.Name = "btnStopserial";
            this.btnStopserial.Size = new System.Drawing.Size(89, 23);
            this.btnStopserial.TabIndex = 20;
            this.btnStopserial.Text = "STOP";
            this.btnStopserial.UseVisualStyleBackColor = true;
            // 
            // btnStartserial
            // 
            this.btnStartserial.Location = new System.Drawing.Point(29, 85);
            this.btnStartserial.Name = "btnStartserial";
            this.btnStartserial.Size = new System.Drawing.Size(89, 23);
            this.btnStartserial.TabIndex = 19;
            this.btnStartserial.Text = "START";
            this.btnStartserial.UseVisualStyleBackColor = true;
            this.btnStartserial.Click += new System.EventHandler(this.btnStartserial_Click);
            // 
            // tBoxrangeomotion
            // 
            this.tBoxrangeomotion.Location = new System.Drawing.Point(139, 53);
            this.tBoxrangeomotion.Name = "tBoxrangeomotion";
            this.tBoxrangeomotion.Size = new System.Drawing.Size(41, 21);
            this.tBoxrangeomotion.TabIndex = 3;
            // 
            // tBoxnumberoreps
            // 
            this.tBoxnumberoreps.Location = new System.Drawing.Point(139, 26);
            this.tBoxnumberoreps.Name = "tBoxnumberoreps";
            this.tBoxnumberoreps.Size = new System.Drawing.Size(41, 21);
            this.tBoxnumberoreps.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Number of repetitions:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(19, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Range of motion [°]:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnLD1);
            this.groupBox10.Controls.Add(this.btnLD2);
            this.groupBox10.Controls.Add(this.btnLD3);
            this.groupBox10.Location = new System.Drawing.Point(15, 295);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(396, 54);
            this.groupBox10.TabIndex = 16;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "LED CONNECTION TEST";
            // 
            // btnLD1
            // 
            this.btnLD1.Location = new System.Drawing.Point(22, 19);
            this.btnLD1.Name = "btnLD1";
            this.btnLD1.Size = new System.Drawing.Size(75, 23);
            this.btnLD1.TabIndex = 9;
            this.btnLD1.Text = "LD1";
            this.btnLD1.UseVisualStyleBackColor = true;
            this.btnLD1.Click += new System.EventHandler(this.btnLD1_Click);
            // 
            // btnLD2
            // 
            this.btnLD2.Location = new System.Drawing.Point(157, 19);
            this.btnLD2.Name = "btnLD2";
            this.btnLD2.Size = new System.Drawing.Size(75, 23);
            this.btnLD2.TabIndex = 10;
            this.btnLD2.Text = "LD2";
            this.btnLD2.UseVisualStyleBackColor = true;
            this.btnLD2.Click += new System.EventHandler(this.btnLD2_Click);
            // 
            // btnLD3
            // 
            this.btnLD3.Location = new System.Drawing.Point(297, 19);
            this.btnLD3.Name = "btnLD3";
            this.btnLD3.Size = new System.Drawing.Size(75, 23);
            this.btnLD3.TabIndex = 11;
            this.btnLD3.Text = "LD3";
            this.btnLD3.UseVisualStyleBackColor = true;
            this.btnLD3.Click += new System.EventHandler(this.btnLD3_Click);
            // 
            // lblDataOutLength
            // 
            this.lblDataOutLength.AutoSize = true;
            this.lblDataOutLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataOutLength.Location = new System.Drawing.Point(232, 16);
            this.lblDataOutLength.Name = "lblDataOutLength";
            this.lblDataOutLength.Size = new System.Drawing.Size(21, 15);
            this.lblDataOutLength.TabIndex = 8;
            this.lblDataOutLength.Text = "00";
            this.lblDataOutLength.Click += new System.EventHandler(this.lblDataOutLength_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(122, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data OUT Length:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(14, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Set position [°]";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSAFE);
            this.groupBox4.Controls.Add(this.btn90);
            this.groupBox4.Controls.Add(this.btn75);
            this.groupBox4.Controls.Add(this.btn60);
            this.groupBox4.Controls.Add(this.btn45);
            this.groupBox4.Controls.Add(this.btn30);
            this.groupBox4.Controls.Add(this.btn15);
            this.groupBox4.Controls.Add(this.btn0);
            this.groupBox4.Location = new System.Drawing.Point(103, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 113);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // btnSAFE
            // 
            this.btnSAFE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSAFE.Location = new System.Drawing.Point(69, 81);
            this.btnSAFE.Name = "btnSAFE";
            this.btnSAFE.Size = new System.Drawing.Size(118, 28);
            this.btnSAFE.TabIndex = 22;
            this.btnSAFE.Text = "SAFE";
            this.btnSAFE.UseVisualStyleBackColor = true;
            this.btnSAFE.Click += new System.EventHandler(this.btnSAFE_Click);
            // 
            // btn90
            // 
            this.btn90.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn90.Location = new System.Drawing.Point(6, 80);
            this.btn90.Name = "btn90";
            this.btn90.Size = new System.Drawing.Size(55, 28);
            this.btn90.TabIndex = 20;
            this.btn90.Text = "90";
            this.btn90.UseVisualStyleBackColor = true;
            this.btn90.Click += new System.EventHandler(this.btn90_Click);
            // 
            // btn75
            // 
            this.btn75.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn75.Location = new System.Drawing.Point(132, 47);
            this.btn75.Name = "btn75";
            this.btn75.Size = new System.Drawing.Size(55, 28);
            this.btn75.TabIndex = 19;
            this.btn75.Text = "75";
            this.btn75.UseVisualStyleBackColor = true;
            this.btn75.Click += new System.EventHandler(this.btn75_Click);
            // 
            // btn60
            // 
            this.btn60.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn60.Location = new System.Drawing.Point(69, 47);
            this.btn60.Name = "btn60";
            this.btn60.Size = new System.Drawing.Size(55, 28);
            this.btn60.TabIndex = 18;
            this.btn60.Text = "60";
            this.btn60.UseVisualStyleBackColor = true;
            this.btn60.Click += new System.EventHandler(this.btn60_Click);
            // 
            // btn45
            // 
            this.btn45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn45.Location = new System.Drawing.Point(6, 47);
            this.btn45.Name = "btn45";
            this.btn45.Size = new System.Drawing.Size(55, 28);
            this.btn45.TabIndex = 17;
            this.btn45.Text = "45";
            this.btn45.UseVisualStyleBackColor = true;
            this.btn45.Click += new System.EventHandler(this.btn45_Click);
            // 
            // btn30
            // 
            this.btn30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn30.Location = new System.Drawing.Point(132, 13);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(55, 28);
            this.btn30.TabIndex = 16;
            this.btn30.Text = "30";
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.Click += new System.EventHandler(this.btn30_Click);
            // 
            // btn15
            // 
            this.btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn15.Location = new System.Drawing.Point(69, 13);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(55, 28);
            this.btn15.TabIndex = 15;
            this.btn15.Text = "15";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn0.Location = new System.Drawing.Point(6, 13);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 28);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chBoxWrite);
            this.groupBox6.Controls.Add(this.chBoxWriteLine);
            this.groupBox6.Location = new System.Drawing.Point(148, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(84, 68);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "todo";
            // 
            // chBoxWrite
            // 
            this.chBoxWrite.AutoSize = true;
            this.chBoxWrite.Location = new System.Drawing.Point(7, 41);
            this.chBoxWrite.Name = "chBoxWrite";
            this.chBoxWrite.Size = new System.Drawing.Size(51, 17);
            this.chBoxWrite.TabIndex = 1;
            this.chBoxWrite.Text = "Write";
            this.chBoxWrite.UseVisualStyleBackColor = true;
            this.chBoxWrite.CheckedChanged += new System.EventHandler(this.chBoxWrite_CheckedChanged);
            // 
            // chBoxWriteLine
            // 
            this.chBoxWriteLine.AutoSize = true;
            this.chBoxWriteLine.Location = new System.Drawing.Point(7, 18);
            this.chBoxWriteLine.Name = "chBoxWriteLine";
            this.chBoxWriteLine.Size = new System.Drawing.Size(71, 17);
            this.chBoxWriteLine.TabIndex = 0;
            this.chBoxWriteLine.Text = "WriteLine";
            this.chBoxWriteLine.UseVisualStyleBackColor = true;
            this.chBoxWriteLine.CheckedChanged += new System.EventHandler(this.chBoxWriteLine_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chBoxUsingEnter);
            this.groupBox5.Controls.Add(this.chBoxUsingButton);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(103, 68);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sending mode";
            // 
            // chBoxUsingEnter
            // 
            this.chBoxUsingEnter.AutoSize = true;
            this.chBoxUsingEnter.Location = new System.Drawing.Point(6, 40);
            this.chBoxUsingEnter.Name = "chBoxUsingEnter";
            this.chBoxUsingEnter.Size = new System.Drawing.Size(81, 17);
            this.chBoxUsingEnter.TabIndex = 1;
            this.chBoxUsingEnter.Text = "Using Enter";
            this.chBoxUsingEnter.UseVisualStyleBackColor = true;
            // 
            // chBoxUsingButton
            // 
            this.chBoxUsingButton.AutoSize = true;
            this.chBoxUsingButton.Location = new System.Drawing.Point(6, 17);
            this.chBoxUsingButton.Name = "chBoxUsingButton";
            this.chBoxUsingButton.Size = new System.Drawing.Size(87, 17);
            this.chBoxUsingButton.TabIndex = 0;
            this.chBoxUsingButton.Text = "Using Button";
            this.chBoxUsingButton.UseVisualStyleBackColor = true;
            this.chBoxUsingButton.CheckedChanged += new System.EventHandler(this.chBoxUsingButton_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblDataInLength);
            this.groupBox8.Controls.Add(this.LblPotentiometer);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.chBoxAddToOldData);
            this.groupBox8.Controls.Add(this.chBoxAlwaysUpdate);
            this.groupBox8.Controls.Add(this.btnClearDataIN);
            this.groupBox8.Controls.Add(this.tBoxDataIN);
            this.groupBox8.Location = new System.Drawing.Point(733, 250);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(281, 256);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Receiver Control";
            // 
            // lblDataInLength
            // 
            this.lblDataInLength.AutoSize = true;
            this.lblDataInLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataInLength.Location = new System.Drawing.Point(169, 189);
            this.lblDataInLength.Name = "lblDataInLength";
            this.lblDataInLength.Size = new System.Drawing.Size(15, 15);
            this.lblDataInLength.TabIndex = 11;
            this.lblDataInLength.Text = "X";
            this.lblDataInLength.Click += new System.EventHandler(this.lblDataInLength_Click);
            // 
            // LblPotentiometer
            // 
            this.LblPotentiometer.AutoSize = true;
            this.LblPotentiometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPotentiometer.Location = new System.Drawing.Point(36, 235);
            this.LblPotentiometer.Name = "LblPotentiometer";
            this.LblPotentiometer.Size = new System.Drawing.Size(148, 15);
            this.LblPotentiometer.TabIndex = 9;
            this.LblPotentiometer.Text = "Potentiometer Value : 000";
            this.LblPotentiometer.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(58, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Data OUT Length:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // chBoxAddToOldData
            // 
            this.chBoxAddToOldData.AutoSize = true;
            this.chBoxAddToOldData.Location = new System.Drawing.Point(124, 163);
            this.chBoxAddToOldData.Name = "chBoxAddToOldData";
            this.chBoxAddToOldData.Size = new System.Drawing.Size(106, 17);
            this.chBoxAddToOldData.TabIndex = 9;
            this.chBoxAddToOldData.Text = "Add To Old Data";
            this.chBoxAddToOldData.UseVisualStyleBackColor = true;
            this.chBoxAddToOldData.CheckedChanged += new System.EventHandler(this.chBoxAddToOldData_CheckedChanged);
            // 
            // chBoxAlwaysUpdate
            // 
            this.chBoxAlwaysUpdate.AutoSize = true;
            this.chBoxAlwaysUpdate.Location = new System.Drawing.Point(124, 135);
            this.chBoxAlwaysUpdate.Name = "chBoxAlwaysUpdate";
            this.chBoxAlwaysUpdate.Size = new System.Drawing.Size(97, 17);
            this.chBoxAlwaysUpdate.TabIndex = 8;
            this.chBoxAlwaysUpdate.Text = "Always Update";
            this.chBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            this.chBoxAlwaysUpdate.CheckedChanged += new System.EventHandler(this.chBoxAlwaysUpdate_CheckedChanged);
            // 
            // btnClearDataIN
            // 
            this.btnClearDataIN.Location = new System.Drawing.Point(15, 138);
            this.btnClearDataIN.Name = "btnClearDataIN";
            this.btnClearDataIN.Size = new System.Drawing.Size(84, 39);
            this.btnClearDataIN.TabIndex = 7;
            this.btnClearDataIN.Text = "Clear Data IN";
            this.btnClearDataIN.UseVisualStyleBackColor = true;
            this.btnClearDataIN.Click += new System.EventHandler(this.btnClearDataIN_Click);
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.Location = new System.Drawing.Point(15, 19);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.Size = new System.Drawing.Size(224, 108);
            this.tBoxDataIN.TabIndex = 6;
            this.tBoxDataIN.TextChanged += new System.EventHandler(this.tBoxDataIN_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox5);
            this.groupBox9.Controls.Add(this.groupBox6);
            this.groupBox9.Location = new System.Drawing.Point(6, 369);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(261, 100);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Sending data settings";
            // 
            // btnExternalexe
            // 
            this.btnExternalexe.Location = new System.Drawing.Point(12, 279);
            this.btnExternalexe.Name = "btnExternalexe";
            this.btnExternalexe.Size = new System.Drawing.Size(142, 79);
            this.btnExternalexe.TabIndex = 11;
            this.btnExternalexe.Text = "START EXTERNAL EXE";
            this.btnExternalexe.UseVisualStyleBackColor = true;
            this.btnExternalexe.Click += new System.EventHandler(this.btnExternalexe_Click);
            // 
            // gBoxengine
            // 
            this.gBoxengine.Controls.Add(this.btnStop);
            this.gBoxengine.Controls.Add(this.btnInitialize);
            this.gBoxengine.Location = new System.Drawing.Point(286, 43);
            this.gBoxengine.Name = "gBoxengine";
            this.gBoxengine.Size = new System.Drawing.Size(426, 68);
            this.gBoxengine.TabIndex = 12;
            this.gBoxengine.TabStop = false;
            this.gBoxengine.Text = "Engine control";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStop.Location = new System.Drawing.Point(247, 21);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(124, 35);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnInitialize
            // 
            this.btnInitialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInitialize.Location = new System.Drawing.Point(52, 21);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(124, 35);
            this.btnInitialize.TabIndex = 0;
            this.btnInitialize.Text = "INITIALIZE";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // gBoxenginestate
            // 
            this.gBoxenginestate.Controls.Add(this.lblEncoderStatus);
            this.gBoxenginestate.Controls.Add(this.label3);
            this.gBoxenginestate.Controls.Add(this.lblStatusEngine);
            this.gBoxenginestate.Controls.Add(this.label2);
            this.gBoxenginestate.Location = new System.Drawing.Point(718, 43);
            this.gBoxenginestate.Name = "gBoxenginestate";
            this.gBoxenginestate.Size = new System.Drawing.Size(306, 183);
            this.gBoxenginestate.TabIndex = 13;
            this.gBoxenginestate.TabStop = false;
            this.gBoxenginestate.Text = "Engine state";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Engine state: ";
            // 
            // lblStatusEngine
            // 
            this.lblStatusEngine.AutoSize = true;
            this.lblStatusEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatusEngine.Location = new System.Drawing.Point(99, 41);
            this.lblStatusEngine.Name = "lblStatusEngine";
            this.lblStatusEngine.Size = new System.Drawing.Size(38, 18);
            this.lblStatusEngine.TabIndex = 1;
            this.lblStatusEngine.Text = "OFF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Encoder: ";
            // 
            // lblEncoderStatus
            // 
            this.lblEncoderStatus.AutoSize = true;
            this.lblEncoderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEncoderStatus.Location = new System.Drawing.Point(98, 88);
            this.lblEncoderStatus.Name = "lblEncoderStatus";
            this.lblEncoderStatus.Size = new System.Drawing.Size(16, 18);
            this.lblEncoderStatus.TabIndex = 3;
            this.lblEncoderStatus.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 518);
            this.Controls.Add(this.gBoxenginestate);
            this.Controls.Add(this.gBoxengine);
            this.Controls.Add(this.btnExternalexe);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "C# COM PORT SERIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.gBoxengine.ResumeLayout(false);
            this.gBoxenginestate.ResumeLayout(false);
            this.gBoxenginestate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chBoxRTSEnable;
        private System.Windows.Forms.CheckBox chBoxDtrEnable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chBoxWrite;
        private System.Windows.Forms.CheckBox chBoxWriteLine;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chBoxUsingEnter;
        private System.Windows.Forms.CheckBox chBoxUsingButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblStatusCom;
        private System.Windows.Forms.Button btnLD3;
        private System.Windows.Forms.Button btnLD2;
        private System.Windows.Forms.Button btnLD1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chBoxAddToOldData;
        private System.Windows.Forms.CheckBox chBoxAlwaysUpdate;
        private System.Windows.Forms.Button btnClearDataIN;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.Label lblDataInLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label LblPotentiometer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClearDataOut;
        private System.Windows.Forms.Label lblDataOutLength;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn90;
        private System.Windows.Forms.Button btn75;
        private System.Windows.Forms.Button btn60;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox chboxRightleg;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox tBoxrangeomotion;
        private System.Windows.Forms.TextBox tBoxnumberoreps;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSAFE;
        private System.Windows.Forms.Button btnStopserial;
        private System.Windows.Forms.Button btnStartserial;
        private System.Windows.Forms.CheckBox chboxLeftleg;
        private System.Windows.Forms.Button btnExternalexe;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.CheckBox chBoxserialmotion;
        private System.Windows.Forms.CheckBox chBoxsinglemode;
        private System.Windows.Forms.GroupBox gBoxengine;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.Button btnSetreps;
        private System.Windows.Forms.Button btnSetrange;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox gBoxenginestate;
        private System.Windows.Forms.Label lblStatusEngine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEncoderStatus;
        private System.Windows.Forms.Label label3;
    }
}

