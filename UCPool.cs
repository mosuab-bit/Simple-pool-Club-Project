using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Club_Project
{
    public partial class UCPool : UserControl
    {
        private int _seconds;
       

        public UCPool()
        {
            InitializeComponent();
        }

        public class PoolPlayEndEventArgs:EventArgs
        {
            public string TimeText { get; }
            public int TimeInSeconds { get; }
            public float RatePerHour { get; }
            public float TotalFees { get; }

           public PoolPlayEndEventArgs(string timeText, int timeInSeconds, float ratePerHour, float totalFees)
            {
                this.TimeText = timeText;
                this.TimeInSeconds = timeInSeconds;
                this.RatePerHour = ratePerHour;
                this.TotalFees = totalFees;
            }
        }

        private bool _IsStart = true;

        public event EventHandler<PoolPlayEndEventArgs> GameEnd;
        public void RaiseResultGame(string TimeText,int TimeInSeconds,float RatePerHour,float TotalFees)
        {
            RaiseResultGame(new PoolPlayEndEventArgs(TimeText,TimeInSeconds,RatePerHour,TotalFees));
        }
        protected virtual void RaiseResultGame(PoolPlayEndEventArgs e)
        {
            GameEnd?.Invoke(this, e);
        }

        private float _HourlyRate = 10.00F;

        public float HourlyRate
        {
            get { return _HourlyRate; }
            set { _HourlyRate = value; }
        }

        private string _TableTitle = "Table";

        public string TableTitle
        {
            get { return _TableTitle; }
            set
            {
                _TableTitle = value;
                grpTable.Text = value;
                Invalidate();
            } 
        }

        private string _PlayerName = "Player";

        public string PlayerName
        {
            get
            {
                return _PlayerName;
            }
            set
            {
                _PlayerName = value;

                lblPlayerName.Text = value;

                Invalidate();
            }
        }
    private void timer1_Tick(object sender, EventArgs e)
        {
            _seconds++;
            TimeSpan Time = TimeSpan.FromSeconds(_seconds);
            string TimeFormat = Time.ToString(@"hh\:mm\:ss");
            lblTime.Text = TimeFormat;
            lblTime.Refresh();
            Invalidate();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            float TotalFees = (((float)_seconds / 60 / 60) * _HourlyRate);
            RaiseResultGame(lblTime.Text, _seconds, _HourlyRate, TotalFees);
            grpTable.Text = "Table";
            lblPlayerName.Text = "Player";
            lblHourRate.Text = "[???]";
            lblTime.Text = "00:00:00";
            btnStart.Text = "Start";
            _seconds = 0;
        }

        private void _ReadDataPool(object sender,string PlayerName,float HourRate)
        {
            lblHourRate.Text = HourRate.ToString();
            lblPlayerName.Text = PlayerName;
            _HourlyRate = HourRate;
        }
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if(_IsStart)
            {
                ReadPoolInfoForm frm = new ReadPoolInfoForm();
                frm.DataBack += _ReadDataPool;
                frm.ShowDialog();
                _IsStart = false;
            }
            if (btnStart.Text == "Start")
            {
                timer1.Start();
                btnStart.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                btnStart.Text = "Start";
            }
        }
    }
}
