using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr02
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
            Random rnd = new Random();
            int[] pole = new int[n];

            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = rnd.Next(1, 11);
                listBox1.Items.Add(pole[i]);
            }

            if (radioButton1.Checked)
            {

            }
            else if (radioButton2.Checked)
            {

            }
        }
    }
}
