namespace FanQer
{
    partial class FanQie
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FanQie));
            this.timerUtil = new System.Windows.Forms.Timer(this.components);
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.radioClose = new System.Windows.Forms.RadioButton();
            this.radioOpen = new System.Windows.Forms.RadioButton();
            this.timerDing = new System.Windows.Forms.Timer(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.radioGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // timerUtil
            // 
            this.timerUtil.Tick += new System.EventHandler(this.timerUtil_Tick);
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupBox.Controls.Add(this.numCount);
            this.radioGroupBox.Controls.Add(this.radioClose);
            this.radioGroupBox.Controls.Add(this.radioOpen);
            this.radioGroupBox.Location = new System.Drawing.Point(7, 6);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(186, 50);
            this.radioGroupBox.TabIndex = 1;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Text = "开/关";
            // 
            // numCount
            // 
            this.numCount.Increment = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numCount.Location = new System.Drawing.Point(125, 20);
            this.numCount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(41, 21);
            this.numCount.TabIndex = 1;
            this.numCount.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // radioClose
            // 
            this.radioClose.AutoSize = true;
            this.radioClose.Location = new System.Drawing.Point(77, 22);
            this.radioClose.Name = "radioClose";
            this.radioClose.Size = new System.Drawing.Size(35, 16);
            this.radioClose.TabIndex = 1;
            this.radioClose.TabStop = true;
            this.radioClose.Text = "关";
            this.radioClose.UseVisualStyleBackColor = true;
            this.radioClose.CheckedChanged += new System.EventHandler(this.radioClose_CheckedChanged);
            // 
            // radioOpen
            // 
            this.radioOpen.AutoSize = true;
            this.radioOpen.Location = new System.Drawing.Point(23, 22);
            this.radioOpen.Name = "radioOpen";
            this.radioOpen.Size = new System.Drawing.Size(41, 16);
            this.radioOpen.TabIndex = 0;
            this.radioOpen.TabStop = true;
            this.radioOpen.Text = " 开";
            this.radioOpen.UseVisualStyleBackColor = true;
            this.radioOpen.CheckedChanged += new System.EventHandler(this.radioOpen_CheckedChanged);
            // 
            // timerDing
            // 
            this.timerDing.Interval = 180000;
            this.timerDing.Tick += new System.EventHandler(this.timerDing_Tick);
            // 
            // timerClose
            // 
            this.timerClose.Interval = 90000;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // FanQie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(199, 63);
            this.Controls.Add(this.radioGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FanQie";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "番茄定时";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FanQie_Load);
            this.radioGroupBox.ResumeLayout(false);
            this.radioGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerUtil;
        private System.Windows.Forms.GroupBox radioGroupBox;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.RadioButton radioClose;
        private System.Windows.Forms.RadioButton radioOpen;
        private System.Windows.Forms.Timer timerDing;
        private System.Windows.Forms.Timer timerClose;
    }
}

