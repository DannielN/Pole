using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr09
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
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            int [] pole = new int[n];

            for (int k = 0; k < n; k++)
            {
                pole[k] = rnd.Next(1, 11);
            }
            Array.Sort(pole);
            for (int k = 0; k < n; k++)
            {
                listBox1.Items.Add(pole[k]);
            }

            if (n % 2 == 0) /* median u sudych */
            {
                int stred_sud = n / 2; /* n = 6 stred_sud = 3 */
                double soucet = (pole[stred_sud]) +(pole[stred_sud-1]);
                double prumer_stredu = soucet / 2;
                label2.Visible = true;
                label2.Text = ("Hodnota mediánu při sudém počtu čísel " + prumer_stredu);
                int firstindex = Array.IndexOf(pole, (int)prumer_stredu);
                int lastindex = Array.LastIndexOf(pole, (int)prumer_stredu);
                label5.Visible = true;
                if (prumer_stredu == (int)prumer_stredu)
                {
                    if (firstindex > 0)
                    {
                        int pocet_median = (lastindex - firstindex) + 1;
                        label5.Text = ("Počet mediánu " + pocet_median);
                    }
                    else
                    {
                        label5.Text = ("Medián se v poli nenachází ");
                    }
                }
                else
                {
                    label5.Text = ("Medián se v poli nenachází ");
                }
                
            }
            else /* median u lichych */
            {
                int stred_lich = n / 2;
                label2.Visible = true;
                label2.Text = ("Hodnota mediánu při lichém počtu čísel je " + pole[stred_lich]);
                int firstindex = Array.IndexOf(pole, pole[stred_lich]);
                int lastindex = Array.LastIndexOf(pole, pole[stred_lich]);
                int pocet_median = (lastindex - firstindex)+1;

                label5.Visible = true;
                label5.Text = ("Počet mediánu " + pocet_median);

            }
        }
    }
}
