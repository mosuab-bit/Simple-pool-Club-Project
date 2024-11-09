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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ucPool1.Start(); 
        }

        private void ucPool1_GameEnd(object sender, UCPool.PoolPlayEndEventArgs e)
        {
            string TableResults = "";

            TableResults = "Time Consumed " + e.TimeText;
            TableResults = TableResults + ", Total Seconds= " + e.TimeInSeconds;
            TableResults = TableResults + ", HourlyRate=" + e.RatePerHour.ToString();
            TableResults = TableResults + ", Total Fees=" + e.TotalFees.ToString();

            MessageBox.Show(TableResults);
        }
    }
}
