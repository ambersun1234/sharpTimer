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
			this.SuspendLayout();
			// 
			// currentTime
			// 
			this.currentTime.Enabled = false;
			this.currentTime.Font = new System.Drawing.Font("新細明體", 30F);
			this.currentTime.Location = new System.Drawing.Point(182, 49);
			this.currentTime.Name = "currentTime";
			this.currentTime.Size = new System.Drawing.Size(429, 67);
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
			this.pressBtn.Location = new System.Drawing.Point(308, 160);
			this.pressBtn.Name = "pressBtn";
			this.pressBtn.Size = new System.Drawing.Size(189, 49);
			this.pressBtn.TabIndex = 1;
			this.pressBtn.Text = "start";
			this.pressBtn.UseVisualStyleBackColor = false;
			this.pressBtn.Click += new System.EventHandler(this.pressBtn_Click);
			// 
			// clearbtn
			// 
			this.clearbtn.BackColor = System.Drawing.Color.Pink;
			this.clearbtn.Font = new System.Drawing.Font("新細明體", 20F);
			this.clearbtn.Location = new System.Drawing.Point(308, 240);
			this.clearbtn.Name = "clearbtn";
			this.clearbtn.Size = new System.Drawing.Size(189, 49);
			this.clearbtn.TabIndex = 2;
			this.clearbtn.Text = "clear";
			this.clearbtn.UseVisualStyleBackColor = false;
			this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.clearbtn);
			this.Controls.Add(this.pressBtn);
			this.Controls.Add(this.currentTime);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button currentTime;
		private System.Windows.Forms.Timer uitimer;
		private System.Windows.Forms.Button pressBtn;
		private System.Windows.Forms.Button clearbtn;
	}
}

