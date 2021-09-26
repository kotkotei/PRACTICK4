﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = a + b;
                textBox3.Text = c.ToString();
            }
            else
            {
                if (radioButton2.Checked)
                {
                    double a = Convert.ToDouble(textBox1.Text);
                    double b = Convert.ToDouble(textBox2.Text);
                    double c = a - b;
                    textBox3.Text = c.ToString();
                }
                else
                {
                    if (radioButton3.Checked)
                    {
                        double a = Convert.ToDouble(textBox1.Text);
                        double b = Convert.ToDouble(textBox2.Text);
                        double c = a * b;
                        textBox3.Text = c.ToString();
                    }
                    else
                    {
                        if (radioButton4.Checked)
                        {
                            double a = Convert.ToDouble(textBox1.Text);
                            double b = Convert.ToDouble(textBox2.Text);
                            double c = a / b;
                            textBox3.Text = c.ToString();
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;
            textBox4.Text = d.ToString();
            DateTime b = monthCalendar1.TodayDate;
            textBox5.Text = b.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}







