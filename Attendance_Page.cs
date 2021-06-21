using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
namespace Addis_River_Side_Attendance_System
{
    public partial class Attendance_Page : Form
    {

        public static string arduinoData;
        SerialPort myport,port;
        String[] words;

        SpeechSynthesizer synth;
   
        Admin_Page F;
        int flag = 1;
        public Attendance_Page()
        {
            InitializeComponent();
                 
            this.CenterToScreen();
          
            try {
                myport = new SerialPort();
                myport.PortName = "COM4";
                myport.BaudRate = 9600;
                myport.DtrEnable = true;
                myport.Open();
                myport.DataReceived += myport_DataReceived;
                port = new SerialPort("COM4", 9600);
      
                
            }
            catch
            { 
            }
             F = new Admin_Page();
             synth = new SpeechSynthesizer();
             synth.Rate = 1;
             synth.SelectVoice("Microsoft Hazel Desktop");
        }

        private void OpenPortConnection()
        {
            try
            {
                myport.Open();
                /*
                                if (myport.IsOpen)
                                {
                                    ArduinoON.Show();
                                    ArduinoOff.Hide();
                                }
                            }
                            catch
                            {
                                if (!myport.IsOpen)
                                {
                                    ArduinoON.Hide();
                                    ArduinoOff.Show();
                                    _WaterPage.WaterLeveleroState("0");
                                }*/

            }
            catch { }
        }
        async Task UseDelay()
        {
            await Task.Delay(1000);
        }



        private void myport_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string POT = myport.ReadLine();
            arduinoData = POT;
            this.BeginInvoke(new LineReceivedEvent(LineReceived), POT);
        }
        private delegate void LineReceivedEvent(string POT);


        void printWords(string POT)
        {
            words = POT.Split(new char[] { ' ' });

        }

        private async void LineReceived(string POT)
        {

            printWords(POT);

            try
            {
                var date = DateTime.Now;
                Admin_Page F = new Admin_Page();
              
                F.lblTodayDate.Text = System.DateTime.Now.ToShortDateString();
                F.lblTimeNow.Text = date.Hour + " : " + date.Minute;
                F.lblTodayDay.Text = date.DayOfWeek.ToString();
                DialogResult dialogResult = new DialogResult();

             
                    if (words[0].CompareTo("YES") == 0)
                    {

                    if (flag == 1)
                    {
                        lblFingerPrintVerify.BackColor = Color.Green;


                        if (int.Parse(words[1]) == 0)
                        {
                          //  pb_Display.Image = new Bitmap("C: /Users/Xentos/Documents/Visual Studio 2015/Projects/Addis River - Side Attendance System/Addis River - Side Attendance System/Resources/human-resources.PNG");
                            txtID_Display.Text = "IE9697";
                            txtName_Display.Text = " Dagmawi Mekonnen";

                            txtStarttime_Display.Text = date.TimeOfDay.ToString();//date.Hour + " : " + date.Minute;
                          //  System.Media.SystemSounds.Asterisk.Play();
                            // synth.Speak("Thank You");
                           
                            txtLeaveTime_Display.Text = " -------- ";
                          
                            flag = 0;
                        
                            dialogResult = MessageBox.Show("NAME       : DAGMAWI MEKONNEN  \n" +"Start Time : "+ date.TimeOfDay.ToString() + "\n" + "Leave Time : ", "FINGERPRINT ACCEPTED", MessageBoxButtons.OK);
                         //   Thankyou.Play();
                            if (dialogResult == DialogResult.OK)
                            {
                                flag = 1;

                                lblFingerPrintVerify.BackColor = Color.Transparent;
                               
                                txtID_Display.Text = string.Empty;
                                txtName_Display.Text = string.Empty;

                                txtStarttime_Display.Text = string.Empty;
                                txtLeaveTime_Display.Text = string.Empty; 

                            }

                        }

                        //mami
                        if (int.Parse(words[1]) == 2)
                        {
                            //  pb_Display.Image = new Bitmap("C: /Users/Xentos/Documents/Visual Studio 2015/Projects/Addis River - Side Attendance System/Addis River - Side Attendance System/Resources/human-resources.PNG");
                            txtID_Display.Text = "ID NUMBER";
                            txtName_Display.Text = " Maritu Tekle";

                            txtStarttime_Display.Text = date.TimeOfDay.ToString();//date.Hour + " : " + date.Minute;

                          // synth.Speak("Thank You");
                         
                            txtLeaveTime_Display.Text = " -------- ";
                            flag = 0;
                          
                            dialogResult = MessageBox.Show("NAME       : MARITU TEKLE  \n" + "Start Time : " + date.TimeOfDay.ToString() + "\n" + "Leave Time : ", "FINGERPRINT ACCEPTED", MessageBoxButtons.OK);

                            if (dialogResult == DialogResult.OK)
                            {
                                flag = 1;
                                lblFingerPrintVerify.BackColor = Color.Transparent;
                                txtID_Display.Text = string.Empty;
                                txtName_Display.Text = string.Empty;
                                txtStarttime_Display.Text = string.Empty;
                                txtLeaveTime_Display.Text = string.Empty;

                            }

                        }
                        //mami end

                        /*        if (int.Parse(words[1]) == 2)
                                {
                                    txtID_Display.Text = "IE9697";
                                    txtName_Display.Text = " Maritu Tekle";

                                    txtStarttime_Display.Text = date.Hour + " : " + date.Minute;
                                    txtLeaveTime_Display.Text = " -------- ";

                                }*/

                     
                        //  await Task.Delay(3000);


                    }


                }

                else if (words[0].CompareTo("NO") == 0)
                {
                    lblFingerPrintVerify.BackColor = Color.Red;
                    synth.Volume = 100;
                    //   if (flag==1)
                    //  synth.Speak("Try Again");
                  //  TryAgain.Play();
                    await Task.Delay(1000);

                    lblFingerPrintVerify.BackColor = Color.Transparent;
                    /* txtID_Display.Text = string.Empty;
                     txtName_Display.Text = string.Empty;

                     txtStarttime_Display.Text = string.Empty;
                     txtLeaveTime_Display.Text = string.Empty;*/
                }
                else
                {
               /*     lblFingerPrintVerify.BackColor = Color.Transparent;
                    txtID_Display.Text = string.Empty;
                    txtName_Display.Text = string.Empty;

                    txtStarttime_Display.Text = string.Empty;
                    txtLeaveTime_Display.Text = string.Empty;*/
                }
        }
            catch { }
        
        }
       

        private void label2_Click(object sender, EventArgs e)
        {
      
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SignUpPage signup = new SignUpPage();
          //  this.Hide();
            signup.Show();
        }

        private void txtLeaveTime_Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbEntrance_CheckedChanged(object sender, EventArgs e)
        {
           
            txtLeaveTime_Display.Hide();
            LeaveLabel.Hide();
        }

        private void checkEntrance_CheckedChanged(object sender, EventArgs e)
        {
          //  checkLeave.CheckState = unchecked;
             //   txtName_Display.Text=checkEntrance.CheckState.ToString();
      
        }

        private void rbLeave_CheckedChanged(object sender, EventArgs e)
        {
            txtLeaveTime_Display.Show();
            LeaveLabel.Show(); 
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtStarttime_Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenPortConnection();
        }

        private void pb_Display_Click(object sender, EventArgs e)
        {
            /*open.Filter = "Image Files(*.jpg; *.jpeg *.gif; *.bmp)|*.jpg; *.jpeg *.gif; *.bmp ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);

                txtLocation.Text = open.FileName;
            }*/
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }

}
