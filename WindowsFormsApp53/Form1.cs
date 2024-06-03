using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domainUpDown1.SelectedIndex = 0;
            domainUpDown2.SelectedIndex = 0;
            domainUpDown3.SelectedIndex = 0;
            domainUpDown4.SelectedIndex = 0;
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
                Convert.ToInt32(numericUpDown1.Value),
                Convert.ToInt32(numericUpDown2.Value),
                Convert.ToInt32(numericUpDown3.Value));
            Fraction d2 = new Fraction(1,
               Convert.ToInt32(numericUpDown4.Value),
               Convert.ToInt32(numericUpDown5.Value),
               Convert.ToInt32(numericUpDown6.Value));
            Fraction d3 = d1.Addition(d2);
            numericUpDown7.Value = d3.integer;
            numericUpDown8.Value = d3.numerator;
            numericUpDown9.Value = d3.denominator;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
               Convert.ToInt32(numericUpDown7.Value),
               Convert.ToInt32(numericUpDown8.Value),
               Convert.ToInt32(numericUpDown9.Value));
            Fraction d2 = d1.Correct_Fraction();
            numericUpDown7.Value = d2.integer;
            numericUpDown8.Value = d2.numerator;
            numericUpDown9.Value = d2.denominator;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
              Convert.ToInt32(numericUpDown7.Value),
              Convert.ToInt32(numericUpDown8.Value),
              Convert.ToInt32(numericUpDown9.Value));
            Fraction d2 = d1.Shorten_Fraction();
            numericUpDown7.Value = d2.integer;
            numericUpDown8.Value = d2.numerator;
            numericUpDown9.Value = d2.denominator;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
                 Convert.ToInt32(numericUpDown1.Value),
                 Convert.ToInt32(numericUpDown2.Value),
                 Convert.ToInt32(numericUpDown3.Value));
            Fraction d2 = new Fraction(1,
               Convert.ToInt32(numericUpDown4.Value),
               Convert.ToInt32(numericUpDown5.Value),
               Convert.ToInt32(numericUpDown6.Value));
            Fraction d3;
            if (domainUpDown2.Text == "+")
            {
               d3 = d1 + d2;
                numericUpDown7.Value = d3.integer;
                numericUpDown8.Value = d3.numerator;
                numericUpDown9.Value = d3.denominator;
            }
            else if (domainUpDown2.Text == "-")
            {
                d3 = d1 - d2;
                numericUpDown7.Value = d3.integer;
                numericUpDown8.Value = d3.numerator;
                numericUpDown9.Value = d3.denominator;
            }
            else if (domainUpDown2.Text == "*")
            {
                d3 = d1 * d2;
                numericUpDown7.Value = d3.integer;
                numericUpDown8.Value = d3.numerator;
                numericUpDown9.Value = d3.denominator;
            }
            else if (domainUpDown2.Text == "/")
            {
                d3 = d1 / d2;
                numericUpDown7.Value = d3.integer;
                numericUpDown8.Value = d3.numerator;
                numericUpDown9.Value = d3.denominator;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
                 Convert.ToInt32(numericUpDown1.Value),
                 Convert.ToInt32(numericUpDown2.Value),
                 Convert.ToInt32(numericUpDown3.Value));
            Fraction d2 = new Fraction(1,
               Convert.ToInt32(numericUpDown4.Value),
               Convert.ToInt32(numericUpDown5.Value),
               Convert.ToInt32(numericUpDown6.Value));
            if(radioButton1.Checked == true)
            {
                if (d1 > d2)
                {
                    MessageBox.Show("правда");
                }
                else
                {
                    MessageBox.Show("ложь");
                }
            }
            else if(radioButton2.Checked == true)
            {
                if (d1 < d2)
                {
                    MessageBox.Show("правда");
                }
                else
                {
                    MessageBox.Show("ложь");
                }
            }
            else if (radioButton3.Checked == true)
            {
                if (d1 >= d2)
                {
                    MessageBox.Show("правда");
                }
                else
                {
                    MessageBox.Show("ложь");
                }
            }
            else if (radioButton4.Checked == true)
            {   
                if (d1 <= d2)
                {
                    MessageBox.Show("правда");
                }
                else
                {
                    MessageBox.Show("ложь");
                }
            }
            else if (radioButton5.Checked == true)
            {
                if (d1 != d2)
                {
                    MessageBox.Show("правда");
                }
                else
                {
                    MessageBox.Show("ложь");
                }
            }
            else if (radioButton6.Checked == true)
            {
                if (d1 == d2)
                {
                    MessageBox.Show("правда");
                }
                else
                {
                    MessageBox.Show("ложь");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
            Convert.ToInt32(numericUpDown1.Value),
            Convert.ToInt32(numericUpDown2.Value),
            Convert.ToInt32(numericUpDown3.Value));
            label1.Text = d1.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            Fraction fraction = Fraction.Parse(str);
            numericUpDown10.Value = fraction.denominator;
            numericUpDown11.Value = fraction.numerator;
            numericUpDown12.Value = fraction.integer;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Fraction d1 = Fraction.Parse(textBox2.Text);
            Fraction d2 = Fraction.Parse(textBox3.Text);
            Fraction d3 = d1 + d2;
            textBox4.Text = d3.ToString();
        }
    }
}
