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
            int n = Convert.ToInt32(textBox1.Text);
            int[] pole = new int[n];
            Random rnd = new Random();
            int cislo = 0;
            int max = 0;
            int min = 1001;
            int poziceMax = 0;
            int poziceMin = 0;
            for (int i = 0; i <n; i++)
            {
                pole[cislo] = rnd.Next(1, 1000);
                listBox1.Items.Add(pole[cislo]);
                if (pole[cislo] > max)
                {
                    max = pole[cislo];
                    pole[poziceMax] = i;
                }
                else if (pole[cislo] < min)
                {
                    min = pole[cislo];
                    pole[poziceMin] = i;
                }
            }
            label1.Text = ("Maximum je = " + max);
            label2.Text = ("Minimum je = " + min);
            int pomocna = max;
            pole[poziceMax] = min;
            pole[poziceMin] = pomocna;
            for (int i = 0; i < n; i++)
            {
                listBox2.Items.Add(pole[n]);
            }
        }
    }
}
