using System;
using System.Windows.Forms;

namespace ClickTest
{
    public partial class Form1 : Form
    {
        private int nbClicks = 0;
        private Timer timer;
        private int startTimerDuration = 10;
        private int timerDuration = 10;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();

            timerDuration = (int)secondsSelector.Value;
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timerDuration >= 0)
            {
                clickTestTimer.Text = timerDuration.ToString() + "s";
                timerDuration--;
            }
            else
            {
                timer.Stop();
                clickTesterButton.Enabled = false;
                secondsSelector.Enabled = true;
                DialogResult msgResult = MessageBox.Show($"{nbClicks} click(s) en {secondsSelector.Value} secondes. Félicitations ! \n\nSouhaitez-vous recommencer ?", "ClickTest - Félicitations !", MessageBoxButtons.YesNo);

                if(msgResult == DialogResult.Yes)
                {
                    nbClicks = 0;
                    clickTesterButton.Enabled = true;
                    secondsSelector.Enabled = false;
                    timer.Start();
                } else
                {
                    Close();
                }
            }
        }

        private void clickTesterButton_Click(object sender, EventArgs e)
        {
            if (nbClicks == 0)
            {
                nbClicks++;
                clickTesterButton.Text = $"{nbClicks} click";
                timer.Start();
                secondsSelector.Enabled = false;
            }
            else
            {
                nbClicks++;
                clickTesterButton.Text = nbClicks > 1 ? $"{nbClicks} clicks" : $"{nbClicks} click";
            }
        }

        private void secondsSelector_ValueChanged(object sender, EventArgs e)
        {
            timerDuration = (int)secondsSelector.Value;
            clickTestTimer.Text = timerDuration.ToString() + "s";
        }
    }
}
