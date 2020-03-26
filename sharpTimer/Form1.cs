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
		private Button mypressBtn;
		private Button myclearBtn;
		private Timer currentTimer;
		private double systemTimer = 0;
		private double myinterval = 1;


		private enum systemOrder {
			increase, decrease
		}; // indicate timer order

		public Form1() {
			InitializeComponent();
			this.currentTimeBtn = currentTime;
			this.currentTimer = uitimer;
			this.mypressBtn = pressBtn;
			this.myclearBtn = clearbtn;
			this.reinit();
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
			this.systemTimer = 0;
			this.init = true;
			this.currentTimeBtn.Enabled = false;
			this.currentTimeBtn.Text = this.convert();
			this.currentTimer.Interval = Convert.ToInt32(this.myinterval);
			this.pressBtn.Text = "start";
			this.pressBtn.BackColor = Color.LawnGreen;
			this.myclearBtn.Text = "clear";
			this.myclearBtn.BackColor = Color.LightPink;
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
			this.reinit();
		}
	}
}
