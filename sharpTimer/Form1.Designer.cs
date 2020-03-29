namespace sharpTimer {
	partial class Form1 {
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.currentTime = new System.Windows.Forms.Button();
            this.uitimer = new System.Windows.Forms.Timer(this.components);
            this.pressBtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.stopwatchBtn = new System.Windows.Forms.Button();
            this.countdownBtn = new System.Windows.Forms.Button();
            this.reinitBtn = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.countdown_set = new System.Windows.Forms.Button();
            this.countdown_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentTime
            // 
            this.currentTime.Enabled = false;
            this.currentTime.Font = new System.Drawing.Font("新細明體", 30F);
            this.currentTime.Location = new System.Drawing.Point(136, 39);
            this.currentTime.Margin = new System.Windows.Forms.Padding(2);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(322, 54);
            this.currentTime.TabIndex = 0;
            this.currentTime.UseVisualStyleBackColor = true;
            // 
            // uitimer
            // 
            this.uitimer.Interval = 1000;
            this.uitimer.Tick += new System.EventHandler(this.uitimer_Tick);
            // 
            // pressBtn
            // 
            this.pressBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.pressBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.pressBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pressBtn.Location = new System.Drawing.Point(231, 117);
            this.pressBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pressBtn.Name = "pressBtn";
            this.pressBtn.Size = new System.Drawing.Size(142, 39);
            this.pressBtn.TabIndex = 1;
            this.pressBtn.Text = "start";
            this.pressBtn.UseVisualStyleBackColor = false;
            this.pressBtn.Click += new System.EventHandler(this.pressBtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.Pink;
            this.clearbtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.clearbtn.Location = new System.Drawing.Point(231, 181);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(142, 39);
            this.clearbtn.TabIndex = 2;
            this.clearbtn.Text = "clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // stopwatchBtn
            // 
            this.stopwatchBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.stopwatchBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.stopwatchBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stopwatchBtn.Location = new System.Drawing.Point(149, 265);
            this.stopwatchBtn.Name = "stopwatchBtn";
            this.stopwatchBtn.Size = new System.Drawing.Size(140, 45);
            this.stopwatchBtn.TabIndex = 3;
            this.stopwatchBtn.Text = "stopwatch";
            this.stopwatchBtn.UseVisualStyleBackColor = false;
            this.stopwatchBtn.Click += new System.EventHandler(this.initChoose);
            // 
            // countdownBtn
            // 
            this.countdownBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.countdownBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.countdownBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.countdownBtn.Location = new System.Drawing.Point(307, 265);
            this.countdownBtn.Name = "countdownBtn";
            this.countdownBtn.Size = new System.Drawing.Size(140, 45);
            this.countdownBtn.TabIndex = 4;
            this.countdownBtn.Text = "countdown";
            this.countdownBtn.UseVisualStyleBackColor = false;
            this.countdownBtn.Click += new System.EventHandler(this.initChoose);
            // 
            // reinitBtn
            // 
            this.reinitBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.reinitBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.reinitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reinitBtn.Location = new System.Drawing.Point(231, 316);
            this.reinitBtn.Name = "reinitBtn";
            this.reinitBtn.Size = new System.Drawing.Size(140, 45);
            this.reinitBtn.TabIndex = 5;
            this.reinitBtn.Text = "clear";
            this.reinitBtn.UseVisualStyleBackColor = false;
            this.reinitBtn.Click += new System.EventHandler(this.initChoose);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.Lime;
            this.btn_5.Font = new System.Drawing.Font("新細明體", 20F);
            this.btn_5.Location = new System.Drawing.Point(165, 106);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(50, 50);
            this.btn_5.TabIndex = 6;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.setter_click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.Lime;
            this.btn_6.Font = new System.Drawing.Font("新細明體", 20F);
            this.btn_6.Location = new System.Drawing.Point(221, 106);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(50, 50);
            this.btn_6.TabIndex = 7;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.setter_click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.Lime;
            this.btn_7.Font = new System.Drawing.Font("新細明體", 20F);
            this.btn_7.Location = new System.Drawing.Point(277, 106);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(50, 50);
            this.btn_7.TabIndex = 8;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.setter_click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.Lime;
            this.btn_8.Font = new System.Drawing.Font("新細明體", 20F);
            this.btn_8.Location = new System.Drawing.Point(336, 106);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(50, 50);
            this.btn_8.TabIndex = 9;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.setter_click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.Lime;
            this.btn_9.Font = new System.Drawing.Font("新細明體", 20F);
            this.btn_9.Location = new System.Drawing.Point(392, 106);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(50, 50);
            this.btn_9.TabIndex = 10;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.setter_click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.Lime;
            this.btn_4.Font = new System.Drawing.Font("新細明體", 20F);
            this.btn_4.Location = new System.Drawing.Point(392, 162);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(50, 50);
            this.btn_4.TabIndex = 15;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.setter_click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.Lime;
            this.btn_3.Font = new System.Drawing.Font("新細明體", 20F);
            this.btn_3.Location = new System.Drawing.Point(336, 162);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(50, 50);
            this.btn_3.TabIndex = 14;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.setter_click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Lime;
            this.btn_2.Font = new System.Drawing.Font("新細明體", 20F);
            this.btn_2.Location = new System.Drawing.Point(277, 162);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(50, 50);
            this.btn_2.TabIndex = 13;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.setter_click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Lime;
            this.btn_1.Font = new System.Drawing.Font("新細明體", 20F);
            this.btn_1.Location = new System.Drawing.Point(221, 162);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(50, 50);
            this.btn_1.TabIndex = 12;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.setter_click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.Lime;
            this.btn_0.Font = new System.Drawing.Font("新細明體", 20F);
            this.btn_0.Location = new System.Drawing.Point(165, 162);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(50, 50);
            this.btn_0.TabIndex = 11;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.setter_click);
            // 
            // countdown_set
            // 
            this.countdown_set.BackColor = System.Drawing.Color.Lime;
            this.countdown_set.Font = new System.Drawing.Font("新細明體", 20F);
            this.countdown_set.Location = new System.Drawing.Point(165, 225);
            this.countdown_set.Name = "countdown_set";
            this.countdown_set.Size = new System.Drawing.Size(136, 40);
            this.countdown_set.TabIndex = 16;
            this.countdown_set.Text = "set";
            this.countdown_set.UseVisualStyleBackColor = false;
            this.countdown_set.Click += new System.EventHandler(this.countdown_set_Click);
            // 
            // countdown_clear
            // 
            this.countdown_clear.Font = new System.Drawing.Font("新細明體", 20F);
            this.countdown_clear.Location = new System.Drawing.Point(306, 225);
            this.countdown_clear.Name = "countdown_clear";
            this.countdown_clear.Size = new System.Drawing.Size(136, 40);
            this.countdown_clear.TabIndex = 17;
            this.countdown_clear.Text = "clear";
            this.countdown_clear.UseVisualStyleBackColor = true;
            this.countdown_clear.Click += new System.EventHandler(this.countdown_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.countdown_clear);
            this.Controls.Add(this.countdown_set);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.reinitBtn);
            this.Controls.Add(this.countdownBtn);
            this.Controls.Add(this.stopwatchBtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.pressBtn);
            this.Controls.Add(this.currentTime);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button currentTime;
		private System.Windows.Forms.Timer uitimer;
		private System.Windows.Forms.Button pressBtn;
		private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button stopwatchBtn;
        private System.Windows.Forms.Button countdownBtn;
        private System.Windows.Forms.Button reinitBtn;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button countdown_set;
        private System.Windows.Forms.Button countdown_clear;
    }
}

