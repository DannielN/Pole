using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr04
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
            int[] pole = new int[n];
            Random rnd = new Random();

            for (int k = 0; k < n; k++)
            {
                pole[k] = rnd.Next(1, 21);
                listBox1.Items.Add(pole[k]);
            }
            pole = pole.Distinct().ToArray();
            for (int m = 0; m < pole.Length; m++)
            {
                listBox2.Items.Add(pole[m]);
            }
            int maximum = pole.Max();
            int pozice_max = Array.IndexOf(pole, maximum);

            for (int m = pozice_max; m < pole.Length; m++) /* bez maxima */ 
            {
                pole[m] = pole[m + 1];
            }

            for (int m = 0; m < pole.Length; m++) /* bez maxima */
            {
               
                listBox3.Items.Add(pole[m]);
            }
        }
    }
}
