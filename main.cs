using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace berlinclock
{
    public partial class main : Form
    {
        int previousSecond = 0;
        int litFirstLine = 0;
        int litSecondLine = 0;
        int litThirdLine = 0;
        int litFourthLine = 0;

        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            devPanel dev = new devPanel();
            dev.Show();
        }

        private void Sync_Tick(object sender, EventArgs e)
        {
            string synctimer;
            string synctimerPreFormat;
            long synctimerPostFormat;
            synctimer = DateTime.Now.TimeOfDay.ToString();

            synctimerPreFormat = new String(synctimer.Where(Char.IsDigit).ToArray());
            synctimerPostFormat = Convert.ToInt64(synctimerPreFormat);

            long hourone = (((synctimerPostFormat / 1000000000000) % 10)), hourtwo = ((synctimerPostFormat / 100000000000) % 10);
            long minone = ((synctimerPostFormat / 10000000000) % 10), mintwo = ((synctimerPostFormat / 1000000000) % 10);
            long secondone = ((synctimerPostFormat / 100000000) % 10), secondtwo = ((synctimerPostFormat / 10000000) % 10);

            int currentSecond = Convert.ToInt32(string.Format("{0}{1}", secondone, secondtwo));
            int currentMinute = Convert.ToInt32(string.Format("{0}{1}", minone, mintwo));
            int currentHour = Convert.ToInt32(string.Format("{0}{1}", hourone, hourtwo));

            if (previousSecond != currentSecond)
            {
                previousSecond = currentSecond;
                if (topSeconds.BackColor == Color.Wheat)
                {
                    topSeconds.BackColor = Color.Yellow;
                }
                else
                {
                    topSeconds.BackColor = Color.Wheat;
                }
            }
            
            if (currentHour >= 5)
            {
                line1Light1.BackColor = Color.Red;
            }
            else
            {
                line1Light1.BackColor = Color.LightCoral;
            }
            if (currentHour >= 10)
            {
                line1Light2.BackColor = Color.Red;
            }
            else
            {
                line1Light2.BackColor = Color.LightCoral;
            }
            if (currentHour >= 15)
            {
                line1Light3.BackColor = Color.Red;
            }
            else
            {
                line1Light3.BackColor = Color.LightCoral;
            }
            if (currentHour >= 20)
            {
                line1Light4.BackColor = Color.Red;
            }
            else
            {
                line1Light4.BackColor = Color.LightCoral;
            }

            if ((currentHour >= 1) || (currentHour >= 6) || (currentHour >= 11))
            {
                line2Light1.BackColor = Color.Red;
            }
            else
            {
                line2Light1.BackColor = Color.LightCoral;
            }

            if ((currentHour == 2) || (currentHour == 7) || (currentHour == 12))
            {
                line2Light2.BackColor = Color.Red;
            }
            else
            {
                line2Light2.BackColor = Color.LightCoral;
            }

            if ((currentHour == 3) || (currentHour == 8) || (currentHour == 13))
            {
                line2Light3.BackColor = Color.Red;
            }
            else
            {
                line2Light3.BackColor = Color.LightCoral;
            }

            if ((currentHour == 4) || (currentHour == 9) || (currentHour == 14))
            {
                line2Light4.BackColor = Color.Red;
            }
            else
            {
                line2Light4.BackColor = Color.LightCoral;
            }

            if (currentMinute >= 5)
            {
                line3Light1.BackColor = Color.Yellow;
            }
            else
            {
                line3Light1.BackColor = Color.Wheat;
            }

            if (currentMinute >= 10)
            {
                line3Light2.BackColor = Color.Yellow;
            }
            else
            {
                line3Light2.BackColor = Color.Wheat;
            }

            if (currentMinute >= 15)
            {
                line3Light3.BackColor = Color.Red;
            }
            else
            {
                line3Light3.BackColor = Color.LightCoral;
            }

            if (currentMinute >= 20)
            {
                line3Light4.BackColor = Color.Yellow;
            }
            else
            {
                line3Light4.BackColor = Color.Wheat;
            }

            if (currentMinute >= 25)
            {
                line3Light5.BackColor = Color.Yellow;
            }
            else
            {
                line3Light5.BackColor = Color.Wheat;
            }

            if (currentMinute >= 30)
            {
                line3Light6.BackColor = Color.Red;
            }
            else
            {
                line3Light6.BackColor = Color.LightCoral;
            }

            if (currentMinute >= 35)
            {
                line3Light7.BackColor = Color.Yellow;
            }
            else
            {
                line3Light7.BackColor = Color.Wheat;
            }

            if (currentMinute >= 40)
            {
                line3Light8.BackColor = Color.Yellow;
            }
            else
            {
                line3Light8.BackColor = Color.Wheat;
            }

            if (currentMinute >= 45)
            {
                line3Light9.BackColor = Color.Red;
            }
            else
            {
                line3Light9.BackColor = Color.LightCoral;
            }

            if (currentMinute >= 50)
            {
                line3Light10.BackColor = Color.Yellow;
            }
            else
            {
                line3Light10.BackColor = Color.Wheat;
            }

            if (currentMinute >= 55)
            {
                line3Light11.BackColor = Color.Yellow;
            }
            else
            {
                line3Light11.BackColor = Color.Wheat;
            }
        }
    }
}
