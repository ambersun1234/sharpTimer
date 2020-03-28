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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
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
    }
}

