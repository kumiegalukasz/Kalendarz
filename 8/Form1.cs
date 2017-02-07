using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d, m, r;
            d = Int32.Parse(textBox1.Text);
            m = Int32.Parse(textBox2.Text);
            r = Int32.Parse(textBox3.Text);
            //algorytm obliczający numer dnia
            if (m < 3)
            {
                r--;
                m += 12;
            }
            d = r + r / 4 - r / 100 + r / 400 + 3 * m - (2 * m + 1) / 5 + d + 1;
            d += -d / 7 * 7;
            label4.Text = "Dzień tygodnia ";
            //instrukcja swich, wybierająca nazwę dnia tygodnia
            switch (d)
            {
                case 0:
                    {
                        label4.Text += "niedziela";
                        break;
                    }
                case 1:
                    {
                        label4.Text+="poniedziałek";
                        break;
                    }
                case 2:
                    {
                        label4.Text += "wtorek";
                        break;
                    }
                case 3:
                    {
                        label4.Text += "środa";
                        break;
                    }
                case 4:
                    {
                        label4.Text += "czwartek";
                        break;
                    }
                case 5:
                    {
                        label4.Text += "piątek";
                        break;
                    }
                case 6:
                    {
                        label4.Text += "sobota";
                        break;
                    }
            }
        }
    }
}
