using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_object
{
    public partial class main_form : Form
    {
        private ControlSystem twoTank;

        public main_form()
        {
            InitializeComponent();
            twoTank = new ControlSystem(1);
         
        }

        private void tmModeling_Tick(object sender, EventArgs e)
        {
            twoTank.Calculate();

            chPlot.Series[0].Points.AddXY(twoTank.Time, twoTank.Out1);
            chPlot.Series[1].Points.AddXY(twoTank.Time, twoTank.Out2);

            waterLevel1.Text = twoTank.Out1.ToString("F2");
            waterLeve2.Text = twoTank.Out2.ToString("F2");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            tmModeling.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            tmModeling.Stop();
        }

        private void scale10_Click(object sender, EventArgs e)
        {
            tmModeling.Interval = 1000;
        }

        private void scale1_Click(object sender, EventArgs e)
        {
            tmModeling.Interval = 100;
        }

        private void scaleDown_Click(object sender, EventArgs e)
        {
            twoTank.ValveOut1--;
            value_xout1.Text = twoTank.ValveOut1.ToString("F2");

        }

        private void scaleUp_Click(object sender, EventArgs e)
        {
            twoTank.ValveOut1++;
            value_xout1.Text = twoTank.ValveOut1.ToString("F2");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmModeling.Stop();
            twoTank.Valve12 = 0;
            twoTank.ValveIn1 = 0;
            twoTank.ValveIn2 = 0;
            twoTank.ValveOut1 = 0;
            twoTank.ValveOut2 = 0;
            foreach(var serie in chPlot.Series)
            {
                serie.Points.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            twoTank.ValveIn1++;
            value_xin1.Text = twoTank.ValveIn1.ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            twoTank.ValveIn1--;
            value_xin1.Text = twoTank.ValveIn1.ToString("F2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            twoTank.ValveIn2++;
            value_xin2.Text = twoTank.ValveIn2.ToString("F2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            twoTank.ValveIn2--;
            value_xin2.Text = twoTank.ValveIn2.ToString("F2");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            twoTank.Valve12++;
            value_x12.Text = twoTank.Valve12.ToString("F2");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            twoTank.Valve12--;
            value_x12.Text = twoTank.Valve12.ToString("F2");

        }

        private void value_xin1_TextChanged(object sender, EventArgs e)
        {
            double v = 0;
            if (Double.TryParse(value_xin1.Text, out v))
            {
                twoTank.ValveIn1 = v;
            }
        }

        private void value_xin2_TextChanged(object sender, EventArgs e)
        {
            double v = 0;
            if (Double.TryParse(value_xin1.Text, out v))
            {
                twoTank.ValveIn1 = v;
            }
        }

        private void value_x12_TextChanged(object sender, EventArgs e)
        {
            double v = 0;
            if (Double.TryParse(value_xin1.Text, out v))
            {
                twoTank.ValveIn1 = v;
            }
        }
        private void value_xout1_TextChanged(object sender, EventArgs e)
        {
            double v = 0;
            if (Double.TryParse(value_xin1.Text, out v))
            {
                twoTank.ValveIn1 = v;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double v = 0;
            if (Double.TryParse(value_xin1.Text, out v))
            {
                twoTank.ValveIn1 = v;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            twoTank.ValveOut2++;
            value_out2.Text = twoTank.ValveOut2.ToString("F2");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            twoTank.ValveOut2--;
            value_out2.Text = twoTank.ValveOut2.ToString("F2");
        }
    }
}
