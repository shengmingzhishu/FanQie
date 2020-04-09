using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FanQer
{
    public partial class FanQie : Form
    {
        public FanQie()
        {
            InitializeComponent();
        }

        System.Media.SoundPlayer sp = new SoundPlayer();
        System.Media.SoundPlayer spDing = new SoundPlayer();

        int timeLong = 0;
        int dingCount = 0;

        String filePath = @"C:/fqsong.wav";
        String fileDingPath = @"C:/fqding.wav";
        String msgNorHasFile = @"请存入结束音乐：C:/fqsong.wav";
        String msgNorHasDingFile = @"请存入警告音乐：C:/fqding.wav";

        private void radioOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioOpen.Checked)
            {
                //判断文件是否存在  
                if (!File.Exists(filePath))
                {
                    MessageBox.Show(msgNorHasFile);
                    this.radioClose.Checked = true;
                    return;
                }
                //判断文件是否存在  
                if (!File.Exists(fileDingPath))
                {
                    MessageBox.Show(msgNorHasDingFile);
                    this.radioClose.Checked = true;
                    return;
                }
                this.timerUtil.Enabled = true;

                timeLong = int.Parse(this.numCount.Value.ToString());

                dingCount = 1;
                // 设置倒计时 3/18
                this.radioGroupBox.Text = dingCount+"/" + timeLong;

                // 设置结束音乐
                // this.timerUtil.Interval = 1000;
                this.timerUtil.Interval = timeLong * 60 * 1000;
                this.timerUtil.Start();

                // 1分钟叮叮一次
                this.timerDing.Interval = 1 * 60 * 1000;
                this.timerDing.Start();
            }
        }

        private void radioClose_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioClose.Checked)
            {
                this.radioGroupBox.Text = "开/关";
                this.timerUtil.Enabled = false;
                this.timerUtil.Stop();
                this.timerDing.Stop();
                sp.Stop();
                spDing.Stop();
            }
        }

        private void timerUtil_Tick(object sender, EventArgs e)
        {
            try
            {
                sp.SoundLocation = filePath;
                sp.PlayLooping();

                // 结束
                this.radioGroupBox.Text = "开/关";

                // 停止叮叮计时
                this.timerDing.Stop();
                // 定时关闭结束音乐
                this.timerClose.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(msgNorHasFile);
            }
        }

        private void timerDing_Tick(object sender, EventArgs e)
        {
            try
            {
                spDing.SoundLocation = fileDingPath;
                spDing.Play();

                // 设置倒计时 3/18
                this.radioGroupBox.Text = (++dingCount) +"/" + timeLong;
            }
            catch (Exception ex)
            {
                MessageBox.Show(msgNorHasDingFile);
            }
        }

        private void FanQie_Load(object sender, EventArgs e)
        {

        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            sp.Stop();
            this.timerClose.Enabled = false;
            this.radioClose.Checked = true;
        }

    }
}
