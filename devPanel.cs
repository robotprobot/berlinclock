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
    public partial class devPanel : Form
    {
        public devPanel()
        {
            InitializeComponent();
        }

        private void DevPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            string synctimer;
            string synctimerPreFormat;
            long synctimerPostFormat;
            synctimer = DateTime.Now.TimeOfDay.ToString();

            synctimerPreFormat = new String(synctimer.Where(Char.IsDigit).ToArray());
            synctimerPostFormat = Convert.ToInt64(synctimerPreFormat);

            label1.Text = "TIME GATHERED: " + DateTime.Now.TimeOfDay;
            long hourone = (((synctimerPostFormat / 1000000000000) % 10)), hourtwo = ((synctimerPostFormat / 100000000000) % 10);
            long minone = ((synctimerPostFormat / 10000000000) % 10), mintwo = ((synctimerPostFormat / 1000000000) % 10);
            long secondone = ((synctimerPostFormat / 100000000) % 10), secondtwo = ((synctimerPostFormat / 10000000) % 10);
            long millisecond = (synctimerPostFormat % 10000000);
            label2.Text = "HOUR EXTRACTED: " + hourone + hourtwo;
            label3.Text = "MINUTE EXTRACTED: " + minone + mintwo;
            label4.Text = "SECOND EXTRACTED: " + secondone + secondtwo;
            label5.Text = "MILLISECOND EXTRACTED: " + millisecond;
        }
    }
}
