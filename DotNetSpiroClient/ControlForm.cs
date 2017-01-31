using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;



namespace LaserSpirograph
{


    public partial class ControlForm : Form
    {
        string RxString;
        int cmboxlength;



        public ControlForm()
        {
            InitializeComponent();
            AssignEvents();
            refreshPortList();
        }
        private void AssignEvents()
        {
            motor1TrackBar.Scroll += motor1TrackBar_Scroll;
            motor2TrackBar.Scroll += motor2TrackBar_Scroll;
            motor3TrackBar.Scroll += motor3TrackBar_Scroll;
            laserTrackBar.Scroll += laserTrackBar_Scroll;
        }

        private void refreshPortList()
        {
            cmbPort.Items.Clear();
            cmboxlength = 0;
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmbPort.Items.Add(s);
                cmboxlength++;
            }
            cmbPort.SelectedIndex = cmboxlength - 1; 
        }

        private void refreshComportBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refreshPortList();
        }



        private void buttonStart_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = cmbPort.SelectedItem.ToString();
            serialPort1.BaudRate = 9600;

            
            try
            {
               serialPort1.Open();
            }
            catch (System.UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
                //Application.Exit();
            }

            if (serialPort1.IsOpen)
            {
                buttonStart.Enabled = false;
                
                cmbPort.Enabled = false;
                refreshComportBtn.Enabled = false;
                buttonStop.Enabled = true;
                groupBox5.Enabled = true;
                groupBox4.Enabled = true;
                groupBox3.Enabled = true;
                groupBox2.Enabled = true;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                
                cmbPort.Enabled = true;
                refreshComportBtn.Enabled = true;
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
                groupBox5.Enabled = false;
                groupBox4.Enabled = false;
                groupBox3.Enabled = false;
                groupBox2.Enabled = false;
            }

        }

        public void SendComport(string Txstring)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(Txstring);
                    serialPort1.Write("\n\r"); // Return + New Line
                    System.Threading.Thread.Sleep(50);   
                }
                else
                {
                    MessageBox.Show("Comport Geschlossen oder nicht mehr vorhanden");
                    //serialPort1.Close();
                  
                    cmbPort.Enabled = true;
                    refreshComportBtn.Enabled = true;
                    buttonStart.Enabled = true;
                    buttonStop.Enabled = false;
                    textBox1.ReadOnly = true;
                    //this.Close();
                }
            }
            catch (System.UnauthorizedAccessException ex)
            {
                Application.Exit();
                MessageBox.Show(ex.Message);
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (System.ObjectDisposedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the port is closed, don't try to send a character.
            if (!serialPort1.IsOpen) return;

            // If the port is Open, declare a char[] array with one element.
            char[] buff = new char[1];

            // Load element 0 with the key character.
            buff[0] = e.KeyChar;

            // Send the one character buffer.
            serialPort1.Write(buff, 0, 1);

            // Set the KeyPress event as handled so the character won't
            // display locally. If you want it to display, omit the next line.
            //e.Handled = true;


        }

        private void DisplayText(object sender, EventArgs e)
        {

            if (RxString == "")
            {
                
                MessageBox.Show("detected");
            }
            else
            {
                textBox1.AppendText(RxString);
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();//.ReadChar(); //.ReadLine();//ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }

        private void setMotorSpeed(int motor, int speed)
        {
            if (serialPort1.IsOpen)
            {
                SendComport("AT SMS "+motor+" "+ (speed + 1));
            }
        }

        private void setLaserValue(int lValue)
        {
            if (serialPort1.IsOpen)
            {
                SendComport("AT SLV "+ (lValue + 1));
            }
        }

        private void startPresetMode(int presetTime, int presetMode )
        {
            if (serialPort1.IsOpen)
            {
                SendComport("AT RPM " +presetMode+ " " + presetTime);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (M1checkBox.CheckState == CheckState.Checked)
            {
                Random random = new Random();
                motor1TextBox.Text = random.Next(1, 128).ToString();
                motor1TrackBar.Value = Int16.Parse(motor1TextBox.Text);
                setMotorSpeed(1, Int16.Parse(motor1TextBox.Text));
            }
            if (M2checkBox.CheckState == CheckState.Checked)
            {
                Random random = new Random();
                motor2TextBox.Text = random.Next(1, 128).ToString();
                motor2TrackBar.Value = Int16.Parse(motor2TextBox.Text);
                setMotorSpeed(2, Int16.Parse(motor2TextBox.Text));
            }
            if (M3checkBox.CheckState == CheckState.Checked)
            {
                Random random = new Random();
                motor3TextBox.Text = random.Next(1, 128).ToString();
                motor3TrackBar.Value = Int16.Parse(motor3TextBox.Text);
                setMotorSpeed(3, Int16.Parse(motor3TextBox.Text));
            }
            if (LasercheckBox.CheckState == CheckState.Checked)
            {
                Random random = new Random();
                laserTextBox.Text = random.Next(1, 128).ToString();
                laserTrackBar.Value = Int16.Parse(laserTextBox.Text);
                setLaserValue(Int16.Parse(laserTextBox.Text));
            }          
           
        }
                    


        private void randomStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000 * Int32.Parse(timer1Value.Text);
            timer1.Enabled = true;
            timer1Value.Enabled = false;
            randomStart.Enabled = false;
            M1checkBox.Enabled = false;
            M2checkBox.Enabled = false;
            M3checkBox.Enabled = false;
            LasercheckBox.Enabled = false;
            randomStop.Enabled = true;
            if (M1checkBox.CheckState == CheckState.Checked)
            {
                motor1TrackBar.Enabled = false;
            }
            if (M2checkBox.CheckState == CheckState.Checked)
            {
                motor2TrackBar.Enabled = false;
            }
            if (M3checkBox.CheckState == CheckState.Checked)
            {
                motor3TrackBar.Enabled = false;
            }
            if (LasercheckBox.CheckState == CheckState.Checked)
            {
                laserTrackBar.Enabled = false;
            } 
        }


        private void randomStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1Value.Enabled = true;
            randomStart.Enabled = true;
            M1checkBox.Enabled = true;
            M2checkBox.Enabled = true;
            M3checkBox.Enabled = true;
            LasercheckBox.Enabled = true;
            randomStop.Enabled = false;
            motor1TrackBar.Enabled = true;
            motor2TrackBar.Enabled = true;
            motor3TrackBar.Enabled = true;
            laserTrackBar.Enabled = true;
        }


        #region motor 1 
        private void motor1TrackBar_Scroll(object sender, EventArgs args)
        {
            TrackBar1Moved();
        }
        private void motor1TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            TrackBar1Moved();
        }

        private void TrackBar1Moved()
        {
            motor1TextBox.Text = motor1TrackBar.Value.ToString();
            setMotorSpeed(1, motor1TrackBar.Value);
        }
        private void testMotor1Btn_Click(object sender, EventArgs e)
        {
            setMotorSpeed(1, Int16.Parse(motor1TextBox.Text));
            motor1TrackBar.Value = Int16.Parse(motor1TextBox.Text);
        }
        #endregion
        #region motor 2
        private void TrackBar2Moved()
        {
            motor2TextBox.Text = motor2TrackBar.Value.ToString();
            setMotorSpeed(2, motor2TrackBar.Value);
        }
        private void motor2TrackBar_Scroll(object sender, EventArgs args)
        {
            TrackBar2Moved();
        }
        private void testMotor2Btn_Click(object sender, EventArgs e)
        {
            setMotorSpeed(2, Int16.Parse(motor2TextBox.Text));
            motor2TrackBar.Value = Int16.Parse(motor2TextBox.Text);
        }
        #endregion
        #region motor 3
        private void TrackBar3Moved()
        {
            motor3TextBox.Text = motor3TrackBar.Value.ToString();
            setMotorSpeed(3, motor3TrackBar.Value);
        }
        private void motor3TrackBar_Scroll(object sender, EventArgs args)
        {
            TrackBar3Moved();
        }
        private void testMotor3Btn_Click(object sender, EventArgs e)
        {
            setMotorSpeed(3, Int16.Parse(motor3TextBox.Text));
            motor3TrackBar.Value = Int16.Parse(motor3TextBox.Text);
        }
        #endregion
        #region laser
        private void TrackBar4Moved()
        {
            laserTextBox.Text = laserTrackBar.Value.ToString();
            setLaserValue(laserTrackBar.Value);
            // set laser speed
        }
        private void laserTrackBar_Scroll(object sender, EventArgs args)
        {
            TrackBar4Moved();
        }
        private void laserBtn_Click(object sender, EventArgs e)
        {
            setLaserValue(Int16.Parse(laserTextBox.Text));
            laserTrackBar.Value = Int16.Parse(laserTextBox.Text);
        }
        #endregion
        #region presets
        private void save_preset_Click(object sender, EventArgs e)
        {
            if (motor1TextBox.Text != "" && motor2TextBox.Text != "" && motor3TextBox.Text != "" && laserTextBox.Text != "")
            {
                if (serialPort1.IsOpen)
                {
                    SendComport("AT SPV "+ presetNr.Value + " " + (Convert.ToInt32(motor1TextBox.Text)+1) + " " + (Convert.ToInt32(motor2TextBox.Text)+1) + " " + (Convert.ToInt32(motor3TextBox.Text)+1) + " " + (Convert.ToInt32(laserTextBox.Text)+1));
                }
            }

        }
        private void btnPresetModeStart_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            int cycleRandom = 0;
            if (radioCycle.Checked)
            {
                cycleRandom = 1;
            }
            if (radioRandom.Checked)
            {
                cycleRandom = 2;
            }
            if (serialPort1.IsOpen)
            {
                SendComport("AT SPM");
                SendComport("AT RPM " + cycleRandom + " " + presetModeTime.Value);
            }
        }
        private void btnPresetModeStop_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            if (serialPort1.IsOpen)
            {
                SendComport("AT SPM");
            }
        }
        #endregion










    }
}