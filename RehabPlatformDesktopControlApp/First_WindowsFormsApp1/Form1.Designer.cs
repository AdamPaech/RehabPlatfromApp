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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblStatusCom = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.chBoxserialmotion = new System.Windows.Forms.CheckBox();
            this.chBoxsinglemode = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.chboxLeftleg = new System.Windows.Forms.CheckBox();
            this.chboxRightleg = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn10 = new System.Windows.Forms.Button();
            this.btnContSingle = new System.Windows.Forms.Button();
            this.btnClearDataOut = new System.Windows.Forms.Button();
            this.btnSAFE = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.btn90 = new System.Windows.Forms.Button();
            this.btn75 = new System.Windows.Forms.Button();
            this.btn60 = new System.Windows.Forms.Button();
            this.btn45 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnSetrange = new System.Windows.Forms.Button();
            this.btnSetreps = new System.Windows.Forms.Button();
            this.btnContSerial = new System.Windows.Forms.Button();
            this.btnStartserial = new System.Windows.Forms.Button();
            this.tBoxrangeomotion = new System.Windows.Forms.TextBox();
            this.tBoxnumberoreps = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExternalexe = new System.Windows.Forms.Button();
            this.gBoxengine = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.gBoxenginestate = new System.Windows.Forms.GroupBox();
            this.lblEncoderStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatusEngine = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gBoxVisionApp = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gBoxengine.SuspendLayout();
            this.gBoxenginestate.SuspendLayout();
            this.gBoxVisionApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(5, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 161);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(118, 23);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(115, 21);
            this.cBoxCOMPORT.TabIndex = 6;
            this.cBoxCOMPORT.SelectedIndexChanged += new System.EventHandler(this.cBoxCOMPORT_SelectedIndexChanged);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxDataOut.Location = new System.Drawing.Point(9, 13);
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
            this.groupBox3.Controls.Add(this.groupBox13);
            this.groupBox3.Controls.Add(this.groupBox12);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(311, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 367);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manipulator Control";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.chBoxserialmotion);
            this.groupBox13.Controls.Add(this.chBoxsinglemode);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox13.Location = new System.Drawing.Point(153, 19);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(257, 64);
            this.groupBox13.TabIndex = 19;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Mode selection";
            // 
            // chBoxserialmotion
            // 
            this.chBoxserialmotion.AutoSize = true;
            this.chBoxserialmotion.Location = new System.Drawing.Point(130, 28);
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
            this.chBoxsinglemode.Location = new System.Drawing.Point(11, 28);
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
            this.groupBox12.Location = new System.Drawing.Point(14, 19);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(130, 64);
            this.groupBox12.TabIndex = 18;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Leg selection";
            // 
            // chboxLeftleg
            // 
            this.chboxLeftleg.AutoSize = true;
            this.chboxLeftleg.Location = new System.Drawing.Point(9, 28);
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
            this.chboxRightleg.Location = new System.Drawing.Point(64, 28);
            this.chboxRightleg.Name = "chboxRightleg";
            this.chboxRightleg.Size = new System.Drawing.Size(55, 19);
            this.chboxRightleg.TabIndex = 1;
            this.chboxRightleg.Text = "Right";
            this.chboxRightleg.UseVisualStyleBackColor = true;
            this.chboxRightleg.CheckedChanged += new System.EventHandler(this.chboxRightleg_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn10);
            this.groupBox4.Controls.Add(this.btnContSingle);
            this.groupBox4.Controls.Add(this.btnClearDataOut);
            this.groupBox4.Controls.Add(this.btnSAFE);
            this.groupBox4.Controls.Add(this.btnSendData);
            this.groupBox4.Controls.Add(this.tBoxDataOut);
            this.groupBox4.Controls.Add(this.btn90);
            this.groupBox4.Controls.Add(this.btn75);
            this.groupBox4.Controls.Add(this.btn60);
            this.groupBox4.Controls.Add(this.btn45);
            this.groupBox4.Controls.Add(this.btn30);
            this.groupBox4.Controls.Add(this.btn15);
            this.groupBox4.Controls.Add(this.btn0);
            this.groupBox4.Location = new System.Drawing.Point(14, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(396, 117);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn10.Location = new System.Drawing.Point(174, 13);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(60, 28);
            this.btn10.TabIndex = 24;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btnContSingle
            // 
            this.btnContSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnContSingle.Location = new System.Drawing.Point(98, 80);
            this.btnContSingle.Name = "btnContSingle";
            this.btnContSingle.Size = new System.Drawing.Size(137, 28);
            this.btnContSingle.TabIndex = 23;
            this.btnContSingle.Text = "CONTINUE";
            this.btnContSingle.UseVisualStyleBackColor = true;
            this.btnContSingle.Click += new System.EventHandler(this.btnContSingle_Click);
            // 
            // btnClearDataOut
            // 
            this.btnClearDataOut.Location = new System.Drawing.Point(9, 80);
            this.btnClearDataOut.Name = "btnClearDataOut";
            this.btnClearDataOut.Size = new System.Drawing.Size(75, 28);
            this.btnClearDataOut.TabIndex = 6;
            this.btnClearDataOut.Text = "CLEAR";
            this.btnClearDataOut.UseVisualStyleBackColor = true;
            this.btnClearDataOut.Click += new System.EventHandler(this.btnClearDataOut_Click);
            // 
            // btnSAFE
            // 
            this.btnSAFE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSAFE.Location = new System.Drawing.Point(250, 80);
            this.btnSAFE.Name = "btnSAFE";
            this.btnSAFE.Size = new System.Drawing.Size(136, 28);
            this.btnSAFE.TabIndex = 22;
            this.btnSAFE.Text = "SAFE";
            this.btnSAFE.UseVisualStyleBackColor = true;
            this.btnSAFE.Click += new System.EventHandler(this.btnSAFE_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(9, 47);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 28);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "SEND";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // btn90
            // 
            this.btn90.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn90.Location = new System.Drawing.Point(326, 47);
            this.btn90.Name = "btn90";
            this.btn90.Size = new System.Drawing.Size(60, 28);
            this.btn90.TabIndex = 20;
            this.btn90.Text = "90";
            this.btn90.UseVisualStyleBackColor = true;
            this.btn90.Click += new System.EventHandler(this.btn90_Click);
            // 
            // btn75
            // 
            this.btn75.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn75.Location = new System.Drawing.Point(250, 46);
            this.btn75.Name = "btn75";
            this.btn75.Size = new System.Drawing.Size(60, 28);
            this.btn75.TabIndex = 19;
            this.btn75.Text = "75";
            this.btn75.UseVisualStyleBackColor = true;
            this.btn75.Click += new System.EventHandler(this.btn75_Click);
            // 
            // btn60
            // 
            this.btn60.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn60.Location = new System.Drawing.Point(174, 47);
            this.btn60.Name = "btn60";
            this.btn60.Size = new System.Drawing.Size(60, 28);
            this.btn60.TabIndex = 18;
            this.btn60.Text = "60";
            this.btn60.UseVisualStyleBackColor = true;
            this.btn60.Click += new System.EventHandler(this.btn60_Click);
            // 
            // btn45
            // 
            this.btn45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn45.Location = new System.Drawing.Point(98, 47);
            this.btn45.Name = "btn45";
            this.btn45.Size = new System.Drawing.Size(60, 28);
            this.btn45.TabIndex = 17;
            this.btn45.Text = "45";
            this.btn45.UseVisualStyleBackColor = true;
            this.btn45.Click += new System.EventHandler(this.btn45_Click);
            // 
            // btn30
            // 
            this.btn30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn30.Location = new System.Drawing.Point(326, 13);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(60, 28);
            this.btn30.TabIndex = 16;
            this.btn30.Text = "30";
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.Click += new System.EventHandler(this.btn30_Click);
            // 
            // btn15
            // 
            this.btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn15.Location = new System.Drawing.Point(250, 13);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(60, 28);
            this.btn15.TabIndex = 15;
            this.btn15.Text = "15";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn0.Location = new System.Drawing.Point(98, 13);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 28);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnSetrange);
            this.groupBox11.Controls.Add(this.btnSetreps);
            this.groupBox11.Controls.Add(this.btnContSerial);
            this.groupBox11.Controls.Add(this.btnStartserial);
            this.groupBox11.Controls.Add(this.tBoxrangeomotion);
            this.groupBox11.Controls.Add(this.tBoxnumberoreps);
            this.groupBox11.Controls.Add(this.label10);
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox11.Location = new System.Drawing.Point(14, 228);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(396, 129);
            this.groupBox11.TabIndex = 17;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Serial motion";
            // 
            // btnSetrange
            // 
            this.btnSetrange.Location = new System.Drawing.Point(250, 57);
            this.btnSetrange.Name = "btnSetrange";
            this.btnSetrange.Size = new System.Drawing.Size(99, 28);
            this.btnSetrange.TabIndex = 22;
            this.btnSetrange.Text = "SET RANGE";
            this.btnSetrange.UseVisualStyleBackColor = true;
            this.btnSetrange.Click += new System.EventHandler(this.btnSetrange_Click);
            // 
            // btnSetreps
            // 
            this.btnSetreps.Location = new System.Drawing.Point(250, 22);
            this.btnSetreps.Name = "btnSetreps";
            this.btnSetreps.Size = new System.Drawing.Size(99, 28);
            this.btnSetreps.TabIndex = 21;
            this.btnSetreps.Text = "SET REPS";
            this.btnSetreps.UseVisualStyleBackColor = true;
            this.btnSetreps.Click += new System.EventHandler(this.btnSetreps_Click);
            // 
            // btnContSerial
            // 
            this.btnContSerial.Location = new System.Drawing.Point(218, 95);
            this.btnContSerial.Name = "btnContSerial";
            this.btnContSerial.Size = new System.Drawing.Size(110, 28);
            this.btnContSerial.TabIndex = 20;
            this.btnContSerial.Text = "CONTINUE";
            this.btnContSerial.UseVisualStyleBackColor = true;
            this.btnContSerial.Click += new System.EventHandler(this.btnContSerial_Click);
            // 
            // btnStartserial
            // 
            this.btnStartserial.Location = new System.Drawing.Point(61, 95);
            this.btnStartserial.Name = "btnStartserial";
            this.btnStartserial.Size = new System.Drawing.Size(110, 28);
            this.btnStartserial.TabIndex = 19;
            this.btnStartserial.Text = "START";
            this.btnStartserial.UseVisualStyleBackColor = true;
            this.btnStartserial.Click += new System.EventHandler(this.btnStartserial_Click);
            // 
            // tBoxrangeomotion
            // 
            this.tBoxrangeomotion.Location = new System.Drawing.Point(178, 60);
            this.tBoxrangeomotion.Name = "tBoxrangeomotion";
            this.tBoxrangeomotion.Size = new System.Drawing.Size(41, 21);
            this.tBoxrangeomotion.TabIndex = 3;
            // 
            // tBoxnumberoreps
            // 
            this.tBoxnumberoreps.Location = new System.Drawing.Point(178, 26);
            this.tBoxnumberoreps.Name = "tBoxnumberoreps";
            this.tBoxnumberoreps.Size = new System.Drawing.Size(41, 21);
            this.tBoxnumberoreps.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(38, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Number of repetitions:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(51, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Range of motion [°]:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(11, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Set position [°]";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
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
            // btnExternalexe
            // 
            this.btnExternalexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExternalexe.Location = new System.Drawing.Point(81, 28);
            this.btnExternalexe.Name = "btnExternalexe";
            this.btnExternalexe.Size = new System.Drawing.Size(118, 48);
            this.btnExternalexe.TabIndex = 11;
            this.btnExternalexe.Text = "OPEN";
            this.btnExternalexe.UseVisualStyleBackColor = true;
            this.btnExternalexe.Click += new System.EventHandler(this.btnExternalexe_Click);
            // 
            // gBoxengine
            // 
            this.gBoxengine.Controls.Add(this.btnReset);
            this.gBoxengine.Controls.Add(this.btnStop);
            this.gBoxengine.Controls.Add(this.btnInitialize);
            this.gBoxengine.Location = new System.Drawing.Point(311, 43);
            this.gBoxengine.Name = "gBoxengine";
            this.gBoxengine.Size = new System.Drawing.Size(426, 68);
            this.gBoxengine.TabIndex = 12;
            this.gBoxengine.TabStop = false;
            this.gBoxengine.Text = "Motor control";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(296, 21);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 35);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStop.Location = new System.Drawing.Point(163, 21);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 35);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnInitialize
            // 
            this.btnInitialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInitialize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInitialize.Location = new System.Drawing.Point(29, 21);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(100, 35);
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
            this.gBoxenginestate.Location = new System.Drawing.Point(5, 208);
            this.gBoxenginestate.Name = "gBoxenginestate";
            this.gBoxenginestate.Size = new System.Drawing.Size(300, 173);
            this.gBoxenginestate.TabIndex = 13;
            this.gBoxenginestate.TabStop = false;
            this.gBoxenginestate.Text = "Motor status";
            // 
            // lblEncoderStatus
            // 
            this.lblEncoderStatus.AutoSize = true;
            this.lblEncoderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEncoderStatus.Location = new System.Drawing.Point(96, 87);
            this.lblEncoderStatus.Name = "lblEncoderStatus";
            this.lblEncoderStatus.Size = new System.Drawing.Size(16, 18);
            this.lblEncoderStatus.TabIndex = 3;
            this.lblEncoderStatus.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Encoder: ";
            // 
            // lblStatusEngine
            // 
            this.lblStatusEngine.AutoSize = true;
            this.lblStatusEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatusEngine.Location = new System.Drawing.Point(98, 41);
            this.lblStatusEngine.Name = "lblStatusEngine";
            this.lblStatusEngine.Size = new System.Drawing.Size(38, 18);
            this.lblStatusEngine.TabIndex = 1;
            this.lblStatusEngine.Text = "OFF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status: ";
            // 
            // gBoxVisionApp
            // 
            this.gBoxVisionApp.Controls.Add(this.btnExternalexe);
            this.gBoxVisionApp.Location = new System.Drawing.Point(5, 387);
            this.gBoxVisionApp.Name = "gBoxVisionApp";
            this.gBoxVisionApp.Size = new System.Drawing.Size(300, 92);
            this.gBoxVisionApp.TabIndex = 14;
            this.gBoxVisionApp.TabStop = false;
            this.gBoxVisionApp.Text = "Knee Joint Vision Measurement App ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 587);
            this.Controls.Add(this.gBoxVisionApp);
            this.Controls.Add(this.gBoxenginestate);
            this.Controls.Add(this.gBoxengine);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rehabilitation Platform Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBoxengine.ResumeLayout(false);
            this.gBoxenginestate.ResumeLayout(false);
            this.gBoxenginestate.PerformLayout();
            this.gBoxVisionApp.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblStatusCom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClearDataOut;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn90;
        private System.Windows.Forms.Button btn75;
        private System.Windows.Forms.Button btn60;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox chboxRightleg;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox tBoxrangeomotion;
        private System.Windows.Forms.TextBox tBoxnumberoreps;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSAFE;
        private System.Windows.Forms.Button btnContSerial;
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
        private System.Windows.Forms.GroupBox gBoxenginestate;
        private System.Windows.Forms.Label lblStatusEngine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEncoderStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnContSingle;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.GroupBox gBoxVisionApp;
    }
}

