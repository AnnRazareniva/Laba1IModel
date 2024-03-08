using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double speed, angle, time, Vx, Vy, h, x, y, S, m, beta, cosAng, sinAng, k;

        double dt;
        double maxHeight = 0 , dist = 0;
        const double g = 9.81, C = 0.15, rho = 1.29;

        private void button1_Click(object sender, EventArgs e)
        {

            h = (double)edHigh.Value;

            time = 0;
            x = 0;
            y = h;
            
            speed = (double)edSpeed.Value;
            angle = (double)edAngle.Value;
            dt = (double)edStep.Value;

            beta = 0.5 * C * rho * S;

            S = (double)edSize.Value;
            m = (double)edWeight.Value;
            k = beta / m;

            cosAng = Math.Cos(angle * Math.PI / 180);
            sinAng = Math.Sin(angle * Math.PI / 180);

            Vx = speed * cosAng;
            Vy = speed * sinAng;

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(x, y);
            
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += dt;

            double VxOld = Vx;
            double VyOld = Vy;

            double V = Math.Sqrt(Vx*Vx + Vy*Vy);
            
            Vx = VxOld - k * VxOld * V * dt;
            Vy= VyOld - (g + k * VyOld * V) * dt;

            x = x + Vx * dt;
            y = y + Vy * dt;

            if (maxHeight < y)
            {
                maxHeight = y;
            }            

            chart1.Series[0].Points.AddXY(x, y);

            if(y<=0) 
            {
                double Vend = Math.Sqrt(Vx * Vx + Vy * Vy);

                VVend.Text = Vend.ToString();
                Height.Text = maxHeight.ToString();
                Dist1.Text = x.ToString();

                timer1.Stop();
            }
        }

    }
}
