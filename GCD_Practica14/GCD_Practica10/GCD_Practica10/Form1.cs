using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCD_Practica10
{
    public partial class Frm1 : Form
    {
        int minutes, seconds, flag;

        private void btnStart_Click(object sender, EventArgs e)
        {
            flag = 1;
            picTrafficL.Image = Properties.Resources.GREEN;
            serialPortArduino.Write("1");
            minutes = (int)(numUPV1.Value);
            seconds = (int)(numUPV2.Value);
            minutes *= 60;
            tmr1.Start();
            numUPV1.Enabled = false;
            numUPV2.Enabled = false;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            minutes--;
            lblMessage.Text = minutes.ToString();
            if (minutes == 0)
            {
                flag++;
                if (flag == 1)
                {
                    picTrafficL.Image = Properties.Resources.GREEN;
                    serialPortArduino.Write("1");
                    minutes = (int)(numUPV1.Value);
                    minutes *= 60;
                    tmr1.Start();
                }
                if (flag == 2)
                {
                    picTrafficL.Image = Properties.Resources.YELLOW;
                    serialPortArduino.Write("2");
                    tmr2.Start();
                    tmr1.Stop();
                }

            }
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            seconds--;
            lblMessage.Text = seconds.ToString();
            if(seconds==0)
            {
                flag++;
                if (flag == 3)
                {
                    picTrafficL.Image = Properties.Resources.RED;
                    serialPortArduino.Write("3");
                    minutes = (int)(numUPV1.Value);
                    minutes *= 60;
                    flag = 0;
                    tmr1.Start();
                }
                tmr2.Stop();
                seconds = (int)(numUPV2.Value);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmr1.Stop();
            tmr2.Stop();
            picTrafficL.Image = Properties.Resources.OFF;
            serialPortArduino.Write("0");

            lblMessage.Text = "Process stopped";
            numUPV1.Enabled = true;
            numUPV2.Enabled = true;
            btnStop.Enabled = false;
            btnStart.Enabled = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Frm1()
        {
            InitializeComponent();
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            lbl1.Text = lbl2.Text = lbl3.Text = "    ";
            tmr1.Enabled = false;
            tmr2.Enabled = false;
            tmr1.Interval = 1000;
            tmr2.Interval = 1000;
            picTrafficL.Image = Properties.Resources.OFF;
            lblMessage.Text = "TRAFFIC LIGHTS OFF";
            btnStop.Enabled = false;
            serialPortArduino.Open();
            serialPortArduino.Write("0");
        }
    }
}
