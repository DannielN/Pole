using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr03
{
    public partial class Form1 : Form
    {
        int[] poleA;
        int[] poleB;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) /* pole A o N nahodnych cislech*/
        {}

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {}

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int N = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();

            poleA = new int[N];

            for (int l = 0; l < N; l++)
            {
                poleA[l] = rnd.Next(3, 11);
                listBox1.Items.Add(poleA[l]);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int M = Convert.ToInt32(textBox2.Text);
            Random rnd = new Random();

            poleB = new int[M];

            for (int k = 0; k < M; k++)
            {
                poleB[k] = rnd.Next(3, 11);
                listBox2.Items.Add(poleB[k]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            int[] poleC = poleA.Concat(poleB).ToArray();

            for (int k = 0; k < poleC.Length; k++)
            {
                listBox3.Items.Add(poleC[k]);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            int[] poleD = poleA.Union(poleB).ToArray();

            for (int k = 0; k < poleD.Length; k++)
            {
                listBox4.Items.Add(poleD[k]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            int[] poleE = poleA.Intersect(poleB).ToArray();

            for (int k = 0; k < poleE.Length; k++)
            {
                listBox5.Items.Add(poleE[k]);
            }
        }
    }
}
