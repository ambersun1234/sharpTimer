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
        private const int showTextLen = 6;
        private int set_counter = Form1.showTextLen; // 8 - 1
		private Button currentTimeBtn;
		private Button mypressBtn; // start, pause, continue
		private Button myclearBtn; // clear
        private Button myreinit;   // init btn
		private Timer currentTimer;
		private double systemTimer = 0;
        private double bpSystemTimer = 0;
		private const double myinterval = 100;
        private systemOrder current;
        private int[] indexArr = new int[] { 0, 1, 3, 4, 6, 7 };
        private List<Button> stopwatchList = new List<Button>();
        private List<Button> countdownList = new List<Button>();
        private List<Button> initList = new List<Button>();

        private enum systemOrder
        {
            increase, decrease
        }; // indicate timer order

        public Form1() {
			InitializeComponent();
			this.currentTimeBtn = currentTime;
			this.currentTimer = uitimer;
			this.mypressBtn = pressBtn;
			this.myclearBtn = clearbtn;
            this.myreinit = reinitBtn;

            this.initList.Add(stopwatchBtn);
            this.initList.Add(countdownBtn);

            this.countdownList.Add(btn_0);
            this.countdownList.Add(btn_1);
            this.countdownList.Add(btn_2);
            this.countdownList.Add(btn_3);
            this.countdownList.Add(btn_4);
            this.countdownList.Add(btn_5);
            this.countdownList.Add(btn_6);
            this.countdownList.Add(btn_7);
            this.countdownList.Add(btn_8);
            this.countdownList.Add(btn_9);
            this.countdownList.Add(countdown_clear);
            this.countdownList.Add(countdown_set);

            this.stopwatchList.Add(this.mypressBtn);
            this.stopwatchList.Add(this.myclearBtn);

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

            string stmp = "";
            if (hour > 99)
            {
                stmp = hour.ToString("000");
            } else
            {
                stmp = hour.ToString("00");
            }
			return stmp + ":" + 
				minute.ToString("00") + ":" + 
				second.ToString("00");
		}

		private void tick() {
            if (this.current == Form1.systemOrder.decrease && this.systemTimer == 0)
            {
                return;
            }

            this.systemTimer =
            (this.current == Form1.systemOrder.increase ?
            this.systemTimer + 1 : this.systemTimer - 1);

            this.currentTimeBtn.Text = this.convert();
		}

		private void reinit() {
            this.set_counter = Form1.showTextLen;
            this.currentTimer.Enabled = false;
			this.currentTimer.Stop();
			this.bpSystemTimer= 0;
            this.systemTimer = this.bpSystemTimer;
			this.init = true;
            this.check = false;
			this.currentTimeBtn.Enabled = false;
			this.currentTimeBtn.Text = this.convert();
			this.currentTimer.Interval = Convert.ToInt32(Form1.myinterval);
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

        private void setter_click(object sender, EventArgs e)
        {
            if (this.set_counter > 0)
            {
                char input = char.Parse(((Button)sender).Text);
                char[] tmp = this.currentTimeBtn.Text.ToCharArray();

                for (int i = 1; i < this.indexArr.Length; i++)
                {
                    tmp[this.indexArr[i - 1]] = tmp[this.indexArr[i]];
                }
                tmp[this.indexArr[this.indexArr.Length - 1]] = input;
                this.currentTimeBtn.Text = new string(tmp);
                this.set_counter -= 1;
            }
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
                this.current = Form1.systemOrder.increase;
                this.bpSystemTimer = 0;
                this.setButtonVisible(this.stopwatchList, true);
                this.setButtonVisible(this.initList, false);
            } else if (tmp == "countdown")
            {
                this.current = Form1.systemOrder.decrease;
                this.setButtonVisible(this.countdownList, true);
                this.setButtonVisible(this.initList, false);
            } else
            {
                this.reinit();
            }
        }

        private void countdown_clear_Click(object sender, EventArgs e)
        {
            this.set_counter = Form1.showTextLen;
            this.currentTimeBtn.Text = this.convert();
        }

        private void countdown_set_Click(object sender, EventArgs e)
        {
            char[] tmp = this.currentTimeBtn.Text.ToCharArray();

            int stmp = ((int)Char.GetNumericValue(tmp[7]) + (int)Char.GetNumericValue(tmp[6]) * 10);
            double second = (double)(stmp % 60);

            int mtmp = ((int)Char.GetNumericValue(tmp[4]) + (int)Char.GetNumericValue(tmp[3]) * 10);
            int mmtmp = mtmp + (stmp / 60);
            double minute = (double)(mmtmp % 60);

            int htmp = ((int)Char.GetNumericValue(tmp[1]) + (int)Char.GetNumericValue(tmp[0]) * 10);
            double hour = (double)(htmp) + (double)(mmtmp / 60);

            this.bpSystemTimer = hour * 60 * 60 + minute * 60 + second;
            this.systemTimer = this.bpSystemTimer;
            this.currentTimeBtn.Text = this.convert();

            this.setButtonVisible(this.countdownList, false);
            this.setButtonVisible(this.stopwatchList, true);
            this.setButtonVisible(this.initList, false);
        }
    }
}
