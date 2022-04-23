using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiornek
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static int ds = 0, ys = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "";
                ys = ys + 1;
                label8.Text = ys.ToString();
            }
            if (radioButton2.Checked == true)
            {
                label8.Text = "";
                ys = ys + 1;
                label8.Text = ys.ToString();
            }
            if (radioButton3.Checked == true)
            {
                label8.Text = "";
                ys = ys + 1;
            }
            if (radioButton4.Checked == true)
            {
                label6.Text = " ";
                ds = ds + 1;
                label6.Text = ds.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                label8.Text = "";
                ys = ys + 1;
                label8.Text = ys.ToString();
            }
            if (radioButton6.Checked == true)
            {
                label8.Text = "";
                ys = ys + 1;
                label8.Text = ys.ToString();
            }
            if (radioButton7.Checked == true)
            {
                label8.Text = "";
                ys = ys + 1;
            }
            if (radioButton8.Checked == true)
            {
                label6.Text = " ";
                ds = ds + 1;
                label6.Text = ds.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                label8.Text = "";
                ys = ys + 1;
                label8.Text = ys.ToString();
            }
            if (radioButton10.Checked == true)
            {
                label8.Text = "";
                ys = ys + 1;
                label8.Text = ys.ToString();
            }
            if (radioButton11.Checked == true)
            {
                label8.Text = "";
                ys = ys + 1;
            }
            if (radioButton12.Checked == true)
            {
                label6.Text = " ";
                ds = ds + 1;
                label6.Text = ds.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                label8.Text = "";
                ys = ys + 1;
                label8.Text = ys.ToString();
            }
            if (radioButton14.Checked == true)
            {
                label8.Text = "";
                ys = ys + 1;
                label8.Text = ys.ToString();
            }
            if (radioButton15.Checked == true)
            {
                label8.Text = "";
                ys = ys + 1;
            }
            if (radioButton16.Checked == true)
            {
                label6.Text = " ";
                ds = ds + 1;
                label6.Text = ds.ToString();
            }
        }
    }
}
