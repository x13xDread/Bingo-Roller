using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoRoller
{
    public partial class Form1 : Form
    {
        #region Controls
        //variables
        List<string> calledValues = new List<string>();
        Random random = new Random();
        bool autoPlayOn = false;

        //Form Constructor
        public Form1()
        {
            //Intializes Defaults and Configs for form
            InitializeComponent();
        }

        //Runs On Load
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            //start Media Timing
            outputLabel.Visible = false;
            Timer.Enabled = true;
            bingoRollerGif.Enabled = true;

        }
        //begins auto play feature or stops it
        private void AutoPlayButton_Click(object sender, EventArgs e)
        {
            //reset to normal mode if auto play is already on
            if(autoPlayOn)
            {
                autoPlayOn = false;
                autoPlayButton.Text = "Start Auto Play";
                rollButton.Enabled = true;
            }
            else //begin autoplay feature
            {
                autoPlayOn = true;
                autoPlayButton.Text = "Stop Auto Play";
                rollButton.Enabled = false;
                AutoPlay();
            }
        }
        private void GotBingoButton_Click(object sender, EventArgs e)
        {
            //clear the list of values
            calledValues.Clear();
            //clear right hand list
            valuesList.Text = "";
        }
        #endregion
        #region methods and events
        private void Timer_Tick(object sender, EventArgs e)
        {
            //select value and end timer
            pickValue();
            outputLabel.Visible = true;

            Timer.Enabled = false;
            bingoRollerGif.Enabled = false;

            valuesList.Text = "";

            //update list of values rolled            
            for (int i = calledValues.Count(); i > 0; i--)
            {
                valuesList.Text += (calledValues[i-1] + "\n");
            }

            
            Thread.Sleep(2000);
            if (autoPlayOn)
                AutoPlay();
            
        }
        //picks a value when rolling
        public void pickValue()
        {
            //vars
            int num = 0;
            string character = "";
            string value = "";
            bool picked = true;

            //repeat until a value has been chosen that has not yet been chosen
            while(picked)
            {
                picked = false; 

                //selects a Random value
                switch(random.Next(1,6))
                {
                    case 1:
                        character = "B";
                        num = random.Next(1, 16);
                        break;
                    case 2:
                        character = "I";
                        num = random.Next(16, 31);
                        break;
                    case 3:
                        character = "N";
                        num = random.Next(31, 46);
                        break;
                    case 4:
                        character = "G";
                        num = random.Next(46, 61);
                        break;
                    case 5:
                        character = "O";
                        num = random.Next(61, 76);
                        break;

                }

                //create value
                value = String.Concat(character, num.ToString());
                //check that the value was not already selected
                foreach(string item in calledValues)
                {
                    if(item.Equals(value))
                    {
                        picked = true;
                    }
                }
            }
            calledValues.Add(value);
            //once an unpicked value is selected output with label
            outputLabel.Text = value;
            lastValueLabel.Text = $"Last Value: {value}";

            //output with voice
            SpeechSynthesizer tts = new SpeechSynthesizer();
            tts.Speak(value);
            tts.Dispose();
        }

        //auto play feature rolls 
        public void AutoPlay()
        {
            //start Media Timing

            outputLabel.Visible = false;
            Timer.Enabled = true;
            bingoRollerGif.Enabled = true;
        }
        #endregion
    }
}
