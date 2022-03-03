using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            double[] pole = new double[n];
            Random rnd = new Random();
            double max = 0;
            double min = 1001;
            int poziceMax = 0;
            int poziceMin = 0;
            double soucet = 0;
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.NextDouble() * (999) + 1;
                listBox1.Items.Add(pole[i].ToString("F2"));
                if (pole[i] > max)
                {
                    max = pole[i];
                    poziceMax = i;
                }
                if (pole[i] < min)
                {
                    min = pole[i];
                    poziceMin = i;
                }
                soucet += pole[i];
            }
            label1.Text = ("Maximum je = " + max.ToString("F2"));
            label2.Text = ("Minimum je = " + min.ToString("F2"));
            soucet = (soucet - max) - (min);
            double prumer = soucet / (n - 2);
            label3.Text = ("Aritmetický průměr bez maxima a minima je = " + prumer.ToString("F2"));
            pole[poziceMax] = min;
            pole[poziceMin] = max;

            for (int i = 0; i < n; i++)
            {
                listBox2.Items.Add(pole[i].ToString("F2"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            int n = Convert.ToInt32(textBox1.Text);
            double[] pole = new double[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.NextDouble() * (999) + 1;
                listBox1.Items.Add(pole[i].ToString("F2"));
            }

            double max = pole.Max();
            double min = pole.Min();
            double soucet = pole.Sum();
            soucet = (soucet - max) - (min);
            double prumer = soucet / (pole.Length - 2);

            int PoziceMax = Array.IndexOf(pole, max);
            int PoziceMin = Array.IndexOf(pole, min);
            pole[PoziceMax] = min;
            pole[PoziceMin] = max;

            for (int i = 0; i < pole.Length; i++)
            {
                listBox2.Items.Add(pole[i].ToString("F2"));
            }

            label1.Text = ("Maximum je = " + max.ToString("F2"));
            label2.Text = ("Minimum je = " + min.ToString("F2"));
            label3.Text = ("Aritmetický průměr bez maxima a minima je = " + prumer.ToString("F2"));
        }
    }
}
