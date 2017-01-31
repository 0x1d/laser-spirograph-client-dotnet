namespace LaserSpirograph
{
    partial class ControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refreshComportBtn = new System.Windows.Forms.LinkLabel();
            this.motor1TextBox = new System.Windows.Forms.TextBox();
            this.motor2TextBox = new System.Windows.Forms.TextBox();
            this.motor3TextBox = new System.Windows.Forms.TextBox();
            this.testMotor1Btn = new System.Windows.Forms.Button();
            this.testMotor2Btn = new System.Windows.Forms.Button();
            this.testMotor3Btn = new System.Windows.Forms.Button();
            this.motor1TrackBar = new System.Windows.Forms.TrackBar();
            this.motor2TrackBar = new System.Windows.Forms.TrackBar();
            this.motor3TrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.laserTrackBar = new System.Windows.Forms.TrackBar();
            this.laserTextBox = new System.Windows.Forms.TextBox();
            this.laserBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.randomStart = new System.Windows.Forms.Button();
            this.randomStop = new System.Windows.Forms.Button();
            this.timer1Value = new System.Windows.Forms.TextBox();
            this.M1checkBox = new System.Windows.Forms.CheckBox();
            this.M2checkBox = new System.Windows.Forms.CheckBox();
            this.M3checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LasercheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.presetModeTime = new System.Windows.Forms.NumericUpDown();
            this.btnPresetModeStop = new System.Windows.Forms.Button();
            this.btnPresetModeStart = new System.Windows.Forms.Button();
            this.radioRandom = new System.Windows.Forms.RadioButton();
            this.radioCycle = new System.Windows.Forms.RadioButton();
            this.load_preset = new System.Windows.Forms.Button();
            this.presetNr = new System.Windows.Forms.NumericUpDown();
            this.save_preset = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motor1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor2TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor3TrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laserTrackBar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presetModeTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetNr)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Arial", 8.25F);
            this.buttonStart.ForeColor = System.Drawing.Color.Black;
            this.buttonStart.Location = new System.Drawing.Point(6, 54);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(106, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Open Port";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Font = new System.Drawing.Font("Arial", 8.25F);
            this.buttonStop.ForeColor = System.Drawing.Color.Black;
            this.buttonStop.Location = new System.Drawing.Point(118, 54);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(76, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Close Port";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(365, 58);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // cmbPort
            // 
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.Font = new System.Drawing.Font("Arial", 8.25F);
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.IntegralHeight = false;
            this.cmbPort.Location = new System.Drawing.Point(9, 22);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(68, 22);
            this.cmbPort.Sorted = true;
            this.cmbPort.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(346, 179);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Terminal";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(337, 168);
            this.textBox2.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(346, 179);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Load Parameter Sets";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.refreshComportBtn);
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 93);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serialport";
            // 
            // refreshComportBtn
            // 
            this.refreshComportBtn.AutoSize = true;
            this.refreshComportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshComportBtn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.refreshComportBtn.Location = new System.Drawing.Point(90, 25);
            this.refreshComportBtn.Name = "refreshComportBtn";
            this.refreshComportBtn.Size = new System.Drawing.Size(94, 13);
            this.refreshComportBtn.TabIndex = 8;
            this.refreshComportBtn.TabStop = true;
            this.refreshComportBtn.Text = "Refresh Portlist";
            this.refreshComportBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshComportBtn_LinkClicked);
            // 
            // motor1TextBox
            // 
            this.motor1TextBox.Location = new System.Drawing.Point(5, 19);
            this.motor1TextBox.Name = "motor1TextBox";
            this.motor1TextBox.Size = new System.Drawing.Size(42, 20);
            this.motor1TextBox.TabIndex = 9;
            this.motor1TextBox.Text = "0";
            this.motor1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // motor2TextBox
            // 
            this.motor2TextBox.Location = new System.Drawing.Point(53, 19);
            this.motor2TextBox.Name = "motor2TextBox";
            this.motor2TextBox.Size = new System.Drawing.Size(42, 20);
            this.motor2TextBox.TabIndex = 10;
            this.motor2TextBox.Text = "0";
            this.motor2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // motor3TextBox
            // 
            this.motor3TextBox.Location = new System.Drawing.Point(101, 19);
            this.motor3TextBox.Name = "motor3TextBox";
            this.motor3TextBox.Size = new System.Drawing.Size(42, 20);
            this.motor3TextBox.TabIndex = 11;
            this.motor3TextBox.Text = "0";
            this.motor3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // testMotor1Btn
            // 
            this.testMotor1Btn.ForeColor = System.Drawing.Color.Black;
            this.testMotor1Btn.Location = new System.Drawing.Point(5, 45);
            this.testMotor1Btn.Name = "testMotor1Btn";
            this.testMotor1Btn.Size = new System.Drawing.Size(42, 23);
            this.testMotor1Btn.TabIndex = 12;
            this.testMotor1Btn.Text = "M1";
            this.testMotor1Btn.UseVisualStyleBackColor = true;
            this.testMotor1Btn.Click += new System.EventHandler(this.testMotor1Btn_Click);
            // 
            // testMotor2Btn
            // 
            this.testMotor2Btn.ForeColor = System.Drawing.Color.Black;
            this.testMotor2Btn.Location = new System.Drawing.Point(53, 45);
            this.testMotor2Btn.Name = "testMotor2Btn";
            this.testMotor2Btn.Size = new System.Drawing.Size(42, 23);
            this.testMotor2Btn.TabIndex = 13;
            this.testMotor2Btn.Text = "M2";
            this.testMotor2Btn.UseVisualStyleBackColor = true;
            this.testMotor2Btn.Click += new System.EventHandler(this.testMotor2Btn_Click);
            // 
            // testMotor3Btn
            // 
            this.testMotor3Btn.ForeColor = System.Drawing.Color.Black;
            this.testMotor3Btn.Location = new System.Drawing.Point(101, 45);
            this.testMotor3Btn.Name = "testMotor3Btn";
            this.testMotor3Btn.Size = new System.Drawing.Size(42, 23);
            this.testMotor3Btn.TabIndex = 14;
            this.testMotor3Btn.Text = "M3";
            this.testMotor3Btn.UseVisualStyleBackColor = true;
            this.testMotor3Btn.Click += new System.EventHandler(this.testMotor3Btn_Click);
            // 
            // motor1TrackBar
            // 
            this.motor1TrackBar.BackColor = System.Drawing.Color.Black;
            this.motor1TrackBar.Location = new System.Drawing.Point(5, 74);
            this.motor1TrackBar.Maximum = 127;
            this.motor1TrackBar.Name = "motor1TrackBar";
            this.motor1TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.motor1TrackBar.Size = new System.Drawing.Size(45, 154);
            this.motor1TrackBar.TabIndex = 15;
            this.motor1TrackBar.TickFrequency = 5;
            this.motor1TrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // motor2TrackBar
            // 
            this.motor2TrackBar.BackColor = System.Drawing.Color.Black;
            this.motor2TrackBar.Location = new System.Drawing.Point(53, 74);
            this.motor2TrackBar.Maximum = 127;
            this.motor2TrackBar.Name = "motor2TrackBar";
            this.motor2TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.motor2TrackBar.Size = new System.Drawing.Size(45, 154);
            this.motor2TrackBar.TabIndex = 16;
            this.motor2TrackBar.TickFrequency = 5;
            this.motor2TrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // motor3TrackBar
            // 
            this.motor3TrackBar.BackColor = System.Drawing.Color.Black;
            this.motor3TrackBar.Location = new System.Drawing.Point(101, 74);
            this.motor3TrackBar.Maximum = 127;
            this.motor3TrackBar.Name = "motor3TrackBar";
            this.motor3TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.motor3TrackBar.Size = new System.Drawing.Size(45, 154);
            this.motor3TrackBar.TabIndex = 17;
            this.motor3TrackBar.TickFrequency = 5;
            this.motor3TrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.laserTrackBar);
            this.groupBox2.Controls.Add(this.laserTextBox);
            this.groupBox2.Controls.Add(this.laserBtn);
            this.groupBox2.Controls.Add(this.motor1TextBox);
            this.groupBox2.Controls.Add(this.motor3TrackBar);
            this.groupBox2.Controls.Add(this.motor2TextBox);
            this.groupBox2.Controls.Add(this.motor1TrackBar);
            this.groupBox2.Controls.Add(this.motor2TrackBar);
            this.groupBox2.Controls.Add(this.motor3TextBox);
            this.groupBox2.Controls.Add(this.testMotor1Btn);
            this.groupBox2.Controls.Add(this.testMotor3Btn);
            this.groupBox2.Controls.Add(this.testMotor2Btn);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 239);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Values";
            // 
            // laserTrackBar
            // 
            this.laserTrackBar.BackColor = System.Drawing.Color.Black;
            this.laserTrackBar.Location = new System.Drawing.Point(149, 74);
            this.laserTrackBar.Maximum = 127;
            this.laserTrackBar.Name = "laserTrackBar";
            this.laserTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.laserTrackBar.Size = new System.Drawing.Size(45, 154);
            this.laserTrackBar.TabIndex = 20;
            this.laserTrackBar.TickFrequency = 5;
            this.laserTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.laserTrackBar.Value = 1;
            // 
            // laserTextBox
            // 
            this.laserTextBox.Location = new System.Drawing.Point(149, 19);
            this.laserTextBox.Name = "laserTextBox";
            this.laserTextBox.Size = new System.Drawing.Size(46, 20);
            this.laserTextBox.TabIndex = 19;
            this.laserTextBox.Text = "0";
            this.laserTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // laserBtn
            // 
            this.laserBtn.ForeColor = System.Drawing.Color.Black;
            this.laserBtn.Location = new System.Drawing.Point(149, 45);
            this.laserBtn.Name = "laserBtn";
            this.laserBtn.Size = new System.Drawing.Size(46, 23);
            this.laserBtn.TabIndex = 18;
            this.laserBtn.Text = "Laser";
            this.laserBtn.UseVisualStyleBackColor = true;
            this.laserBtn.Click += new System.EventHandler(this.laserBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Enabled = false;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.groupBox4.Location = new System.Drawing.Point(13, 356);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(380, 83);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Terminal";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // randomStart
            // 
            this.randomStart.Font = new System.Drawing.Font("Arial", 8.25F);
            this.randomStart.ForeColor = System.Drawing.Color.Black;
            this.randomStart.Location = new System.Drawing.Point(124, 25);
            this.randomStart.Name = "randomStart";
            this.randomStart.Size = new System.Drawing.Size(40, 23);
            this.randomStart.TabIndex = 22;
            this.randomStart.Text = "Start";
            this.randomStart.UseVisualStyleBackColor = true;
            this.randomStart.Click += new System.EventHandler(this.randomStart_Click);
            // 
            // randomStop
            // 
            this.randomStop.Enabled = false;
            this.randomStop.Font = new System.Drawing.Font("Arial", 8.25F);
            this.randomStop.ForeColor = System.Drawing.Color.Black;
            this.randomStop.Location = new System.Drawing.Point(124, 54);
            this.randomStop.Name = "randomStop";
            this.randomStop.Size = new System.Drawing.Size(40, 23);
            this.randomStop.TabIndex = 23;
            this.randomStop.Text = "Stop";
            this.randomStop.UseVisualStyleBackColor = true;
            this.randomStop.Click += new System.EventHandler(this.randomStop_Click);
            // 
            // timer1Value
            // 
            this.timer1Value.Location = new System.Drawing.Point(64, 21);
            this.timer1Value.Name = "timer1Value";
            this.timer1Value.Size = new System.Drawing.Size(45, 20);
            this.timer1Value.TabIndex = 24;
            this.timer1Value.Text = "1";
            this.timer1Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // M1checkBox
            // 
            this.M1checkBox.AutoSize = true;
            this.M1checkBox.Checked = true;
            this.M1checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.M1checkBox.Location = new System.Drawing.Point(12, 48);
            this.M1checkBox.Name = "M1checkBox";
            this.M1checkBox.Size = new System.Drawing.Size(43, 17);
            this.M1checkBox.TabIndex = 26;
            this.M1checkBox.Text = "M1";
            this.M1checkBox.UseVisualStyleBackColor = true;
            // 
            // M2checkBox
            // 
            this.M2checkBox.AutoSize = true;
            this.M2checkBox.Checked = true;
            this.M2checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.M2checkBox.Location = new System.Drawing.Point(12, 70);
            this.M2checkBox.Name = "M2checkBox";
            this.M2checkBox.Size = new System.Drawing.Size(43, 17);
            this.M2checkBox.TabIndex = 27;
            this.M2checkBox.Text = "M2";
            this.M2checkBox.UseVisualStyleBackColor = true;
            // 
            // M3checkBox
            // 
            this.M3checkBox.AutoSize = true;
            this.M3checkBox.Checked = true;
            this.M3checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.M3checkBox.Location = new System.Drawing.Point(61, 47);
            this.M3checkBox.Name = "M3checkBox";
            this.M3checkBox.Size = new System.Drawing.Size(43, 17);
            this.M3checkBox.TabIndex = 28;
            this.M3checkBox.Text = "M3";
            this.M3checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.linkLabel1);
            this.groupBox5.Controls.Add(this.LasercheckBox);
            this.groupBox5.Controls.Add(this.M3checkBox);
            this.groupBox5.Controls.Add(this.M2checkBox);
            this.groupBox5.Controls.Add(this.M1checkBox);
            this.groupBox5.Controls.Add(this.timer1Value);
            this.groupBox5.Controls.Add(this.randomStop);
            this.groupBox5.Controls.Add(this.randomStart);
            this.groupBox5.Enabled = false;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.groupBox5.Location = new System.Drawing.Point(219, 257);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(174, 93);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Remote Random Mode";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.linkLabel1.Location = new System.Drawing.Point(9, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 13);
            this.linkLabel1.TabIndex = 30;
            this.linkLabel1.Text = "Time(s):";
            // 
            // LasercheckBox
            // 
            this.LasercheckBox.AutoSize = true;
            this.LasercheckBox.Location = new System.Drawing.Point(61, 70);
            this.LasercheckBox.Name = "LasercheckBox";
            this.LasercheckBox.Size = new System.Drawing.Size(57, 17);
            this.LasercheckBox.TabIndex = 29;
            this.LasercheckBox.Text = "Laser";
            this.LasercheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.load_preset);
            this.groupBox3.Controls.Add(this.presetNr);
            this.groupBox3.Controls.Add(this.save_preset);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.groupBox3.Location = new System.Drawing.Point(219, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 239);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Presets";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.presetModeTime);
            this.groupBox6.Controls.Add(this.btnPresetModeStop);
            this.groupBox6.Controls.Add(this.btnPresetModeStart);
            this.groupBox6.Controls.Add(this.radioRandom);
            this.groupBox6.Controls.Add(this.radioCycle);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.groupBox6.Location = new System.Drawing.Point(7, 130);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(157, 101);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Preset Cycle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time:";
            // 
            // presetModeTime
            // 
            this.presetModeTime.Location = new System.Drawing.Point(49, 42);
            this.presetModeTime.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.presetModeTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.presetModeTime.Name = "presetModeTime";
            this.presetModeTime.Size = new System.Drawing.Size(48, 20);
            this.presetModeTime.TabIndex = 7;
            this.presetModeTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPresetModeStop
            // 
            this.btnPresetModeStop.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresetModeStop.ForeColor = System.Drawing.Color.Black;
            this.btnPresetModeStop.Location = new System.Drawing.Point(60, 68);
            this.btnPresetModeStop.Name = "btnPresetModeStop";
            this.btnPresetModeStop.Size = new System.Drawing.Size(42, 23);
            this.btnPresetModeStop.TabIndex = 6;
            this.btnPresetModeStop.Text = "Stop";
            this.btnPresetModeStop.UseVisualStyleBackColor = true;
            this.btnPresetModeStop.Click += new System.EventHandler(this.btnPresetModeStop_Click);
            // 
            // btnPresetModeStart
            // 
            this.btnPresetModeStart.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresetModeStart.ForeColor = System.Drawing.Color.Black;
            this.btnPresetModeStart.Location = new System.Drawing.Point(12, 68);
            this.btnPresetModeStart.Name = "btnPresetModeStart";
            this.btnPresetModeStart.Size = new System.Drawing.Size(42, 23);
            this.btnPresetModeStart.TabIndex = 5;
            this.btnPresetModeStart.Text = "Start";
            this.btnPresetModeStart.UseVisualStyleBackColor = true;
            this.btnPresetModeStart.Click += new System.EventHandler(this.btnPresetModeStart_Click);
            // 
            // radioRandom
            // 
            this.radioRandom.AutoSize = true;
            this.radioRandom.Checked = true;
            this.radioRandom.Location = new System.Drawing.Point(76, 19);
            this.radioRandom.Name = "radioRandom";
            this.radioRandom.Size = new System.Drawing.Size(71, 17);
            this.radioRandom.TabIndex = 4;
            this.radioRandom.TabStop = true;
            this.radioRandom.Text = "Random";
            this.radioRandom.UseVisualStyleBackColor = true;
            // 
            // radioCycle
            // 
            this.radioCycle.AllowDrop = true;
            this.radioCycle.AutoSize = true;
            this.radioCycle.Location = new System.Drawing.Point(14, 19);
            this.radioCycle.Name = "radioCycle";
            this.radioCycle.Size = new System.Drawing.Size(56, 17);
            this.radioCycle.TabIndex = 3;
            this.radioCycle.Text = "Cycle";
            this.radioCycle.UseVisualStyleBackColor = true;
            // 
            // load_preset
            // 
            this.load_preset.Enabled = false;
            this.load_preset.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_preset.ForeColor = System.Drawing.Color.Black;
            this.load_preset.Location = new System.Drawing.Point(115, 20);
            this.load_preset.Name = "load_preset";
            this.load_preset.Size = new System.Drawing.Size(42, 23);
            this.load_preset.TabIndex = 2;
            this.load_preset.Text = "Load";
            this.load_preset.UseVisualStyleBackColor = true;
            // 
            // presetNr
            // 
            this.presetNr.Location = new System.Drawing.Point(12, 20);
            this.presetNr.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.presetNr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.presetNr.Name = "presetNr";
            this.presetNr.Size = new System.Drawing.Size(49, 20);
            this.presetNr.TabIndex = 1;
            this.presetNr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // save_preset
            // 
            this.save_preset.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_preset.ForeColor = System.Drawing.Color.Black;
            this.save_preset.Location = new System.Drawing.Point(67, 19);
            this.save_preset.Name = "save_preset";
            this.save_preset.Size = new System.Drawing.Size(42, 23);
            this.save_preset.TabIndex = 0;
            this.save_preset.Text = "Save";
            this.save_preset.UseVisualStyleBackColor = true;
            this.save_preset.Click += new System.EventHandler(this.save_preset_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(401, 443);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlForm";
            this.Text = "Spirograph Control Center";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motor1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor2TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor3TrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laserTrackBar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presetModeTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetNr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox motor1TextBox;
        private System.Windows.Forms.TextBox motor2TextBox;
        private System.Windows.Forms.TextBox motor3TextBox;
        private System.Windows.Forms.Button testMotor1Btn;
        private System.Windows.Forms.Button testMotor2Btn;
        private System.Windows.Forms.Button testMotor3Btn;
        private System.Windows.Forms.TrackBar motor1TrackBar;
        private System.Windows.Forms.TrackBar motor2TrackBar;
        private System.Windows.Forms.TrackBar motor3TrackBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button laserBtn;
        private System.Windows.Forms.TrackBar laserTrackBar;
        private System.Windows.Forms.TextBox laserTextBox;
        private System.Windows.Forms.LinkLabel refreshComportBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button randomStart;
        private System.Windows.Forms.Button randomStop;
        private System.Windows.Forms.TextBox timer1Value;
        private System.Windows.Forms.CheckBox M1checkBox;
        private System.Windows.Forms.CheckBox M2checkBox;
        private System.Windows.Forms.CheckBox M3checkBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox LasercheckBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown presetNr;
        private System.Windows.Forms.Button save_preset;
        private System.Windows.Forms.Button load_preset;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioCycle;
        private System.Windows.Forms.RadioButton radioRandom;
        private System.Windows.Forms.Button btnPresetModeStop;
        private System.Windows.Forms.Button btnPresetModeStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown presetModeTime;
        private System.Windows.Forms.Label label2;
    }
}

