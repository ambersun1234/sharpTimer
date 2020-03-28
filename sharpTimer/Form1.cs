using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharpTimer {
	public partial class Form1: Form {
		private bool init; // indicate first time
		private bool check = false;
		private Button currentTimeBtn;
		private Button mypressBtn; // start, pause, continue
		private Button myclearBtn; // clear
        private Button stopwatch;  // init btn
        private Button countdown;  // init btn
        private Button myreinit;     // init btn
		private Timer currentTimer;
		private double systemTimer = 0;
        private double bpSystemTimer = 0;
		private double myinterval = 1;
        private List<Button> stopwatchList = new List<Button>();
        private List<Button> countdownList = new List<Button>();
        private List<Button> initList = new List<Button>();

		public Form1() {
			InitializeComponent();
			this.currentTimeBtn = currentTime;
			this.currentTimer = uitimer;
			this.mypressBtn = pressBtn;
			this.myclearBtn = clearbtn;
            this.stopwatch = stopwatchBtn;
            this.countdown = countdownBtn;
            this.myreinit = reinitBtn;

            this.initList.Add(this.stopwatch);
            this.initList.Add(this.countdown);

            this.stopwatchList.Add(this.mypressBtn);
            this.stopwatchList.Add(this.myclearBtn);

            // this.countdownList.Add(Button);

			this.reinit();
		}

        private void setButtonVisible(List<Button> mylist, bool setter)
        {
            foreach (Button element in mylist)
            {
                element.Visible = setter;
            }
        }

		private String convert() {
			int tmp = Convert.ToInt32(this.systemTimer);

			int hour = tmp / (60 * 60);
			tmp -= ((60 * 60) * hour);
			int minute = tmp / 60;
			tmp -= (60 * minute);
			int second = tmp;

			return hour.ToString("00") + ":" + 
				minute.ToString("00") + ":" + 
				second.ToString("00");
		}

		private void tick() {
			this.systemTimer += 1;
			// this.systemTimer %= this.myinterval;
			this.currentTimeBtn.Text = this.convert();
		}

		private void reinit() {
			this.currentTimer.Enabled = false;
			this.currentTimer.Stop();
			this.bpSystemTimer= 0;
            this.systemTimer = this.bpSystemTimer;
			this.init = true;
            this.check = false;
			this.currentTimeBtn.Enabled = false;
			this.currentTimeBtn.Text = this.convert();
			this.currentTimer.Interval = Convert.ToInt32(this.myinterval);
			this.pressBtn.Text = "start";
			this.pressBtn.BackColor = Color.LawnGreen;
			this.myclearBtn.Text = "clear";
			this.myclearBtn.BackColor = Color.LightPink;
            
            this.setButtonVisible(this.initList, true);
            this.setButtonVisible(this.stopwatchList, false);
            this.setButtonVisible(this.countdownList, false);
        }

		private void pressBtn_Click(object sender, EventArgs e) {
			Color tmp;
			bool enabler = false;

			if (!this.init) {
				enabler = false;
				this.currentTimer.Stop();
				this.mypressBtn.Text = "start";
				tmp = Color.LawnGreen;
			} else {
				if (this.check) {
					this.currentTimer.Stop();
					this.mypressBtn.Text = "continue";
					tmp = Color.LawnGreen;
					enabler = false;
				}
				else {
					this.mypressBtn.Text = "pause";
					enabler = true;
					tmp = Color.Aqua;
				}
			}
			this.check = !this.check;
			this.currentTimer.Enabled = enabler;
			this.mypressBtn.BackColor = tmp;
		}

		private void uitimer_Tick(object sender, EventArgs e) {
			this.tick();
		}

		private void clearbtn_Click(object sender, EventArgs e) {
            this.currentTimer.Enabled = false;
            this.currentTimer.Stop();
            this.check = false;
            this.systemTimer = this.bpSystemTimer;
            this.currentTimeBtn.Text = this.convert();
            this.mypressBtn.Text = "start";
            this.mypressBtn.BackColor = Color.LawnGreen;
        }

        private void initChoose(object sender, EventArgs e)
        {
            string tmp = ((Button)sender).Text;

            if (tmp == "stopwatch")
            {
                this.bpSystemTimer = 0;
                this.setButtonVisible(this.stopwatchList, true);
                this.setButtonVisible(this.initList, false);
            } else if (tmp == "countdown")
            {
                this.setButtonVisible(this.countdownList, true);
                this.setButtonVisible(this.initList, false);
            } else
            {
                this.reinit();
            }
        }
    }
}
