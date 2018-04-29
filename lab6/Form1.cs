using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KasButCacl_Click(object sender, EventArgs e)
        {
            double x = 0.0, E = 0.0;
            int i = 0;
            
            x = Convert.ToDouble(KasBoxX0.Text);
            E = Convert.ToDouble(KasBoxTo.Text);
            KasDGV.Rows.Clear();

            while (i< Convert.ToInt32(KasBoxItr.Text))
            {
                if (Math.Abs(x) > E)
                {
                    i++;
                    x = x - (Func(x) / Derfunc(x));
                    KasDGV.Rows.Add(i, x);
                }
            }
        }

        double Func(double x)
        {
            return Math.Exp(x) - x * x - 2.0;
        }

        double Derfunc(double x) // производная
        {
            return -2.0 * x * Math.Exp(x);
        }

        private void MpdBatCalc_Click(object sender, EventArgs e)
        {
            double a = 0.0, b = 0.0, x = 0.0, E = 0.0;
            int Itr = 0;

            E = Convert.ToDouble(MpdBoxTo.Text);
            a = Convert.ToDouble(MpdBoxA.Text);
            b = Convert.ToDouble(MpdBoxB.Text);
            MdpDGV.Rows.Clear();

            x = (a + b) / 2;

            while (Math.Abs(b - a) > E)
            {
                if (Mpd(a) * Mpd(x) <= 0) b = x;
                else a = x;
                x = (a + b) / 2;
                Itr++;
                MdpDGV.Rows.Add(Math.Abs(b - a), Itr, x);
            }
            MessageBox.Show("Номер последней итерации:" + Itr +"\n"+ "Корень уравнения: " + x);

            double Mpd(double xm)
            {
                return Math.Exp(x) - x * x - 2.0;
            }
        }
        
    }
}

