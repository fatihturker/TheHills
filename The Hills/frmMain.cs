using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace The_Hills
{
    public partial class frmMain : Form
    {
        private frmMain mfrmMain;
        Process p = null;
        public frmMain()
        {
            InitializeComponent();
            mfrmMain = this;
            uint _savedVolume;
            waveOutGetVolume(IntPtr.Zero, out _savedVolume);

            this.FormClosing += delegate
            {
                // restore the volume upon exit
                waveOutSetVolume(IntPtr.Zero, _savedVolume);
                if (p != null)
                {
                    p.Kill();
                }
            };
        }

        private bool isRun = false;
        System.Timers.Timer mTimer;
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!isRun)
            {
                counter = 0;
                mTimer = new System.Timers.Timer();
                mTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                mTimer.Interval = 60000;
                mTimer.Enabled = true;
                runAway();
                btnRun.Text = "Stop";
                isRun = true;
                if (p != null)
                {
                    p.Kill();
                }
            }
            else
            {
                mTimer.Stop();
                mTimer.Dispose();
                btnRun.Text = "Start";
                isRun = false;
            }      
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            runAway();
        }
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr h, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr h, uint dwVolume);
        static int counter = 0;
        private void runAway()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessViewIncreaser));
                     
       }

        private void ProcessViewIncreaser(object state)
        {
            try
            {
                var t = new Thread(MyThreadStartMethod);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void MyThreadStartMethod()
        {
            waveOutSetVolume(IntPtr.Zero, 0);
            string uri = "http://www.youtube.com/watch?v=" + txtYoutubeID.Text;
            if(p!= null && !p.HasExited)
            {
                p.Kill();
                counter+=4;
            }
            p = new Process(); 
            mfrmMain.BeginInvoke(
                    (Action)(() => { mfrmMain.lblWatchCount.Text = counter.ToString(); })
            );
            for(int i = 0; i < 2; i++)
            {
                uri += " " + uri;
            }

            p.StartInfo = new ProcessStartInfo(txtTorLink.Text, uri);
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            p.Start();
        }
    }
}
